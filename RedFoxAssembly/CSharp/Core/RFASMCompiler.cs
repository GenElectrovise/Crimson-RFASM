﻿using System.Text.RegularExpressions;
using Antlr4.Runtime;
using RedFoxAssembly.AntlrBuild;
using RedFoxAssembly.CSharp.Statements;

namespace RedFoxAssembly.CSharp.Core
{
    /// <summary>
    /// Compiler for converting a list of RF ASM instructions into binary for interpretation. 
    /// Each instruction (for example, "LDA 0xaf") should be on a new line, and arguments are seperated by a space.
    /// </summary>
    class RFASMCompiler
    {
        public const int DATA_WIDTH = 2;


        internal Dictionary<string, LabelCommand> Labels { get; set; }
        internal Dictionary<string, IData> Constants { get; set; }

        public RFASMCompilerMetadata? meta;

        static Task<int> Main(string[] args)
        {
            return Task.Run(() =>
            {
                RFASMCompiler compiler = new RFASMCompiler();
                return compiler.Start(args);
            });
        }

        public RFASMCompiler()
        {
            Labels = new Dictionary<string, LabelCommand>();
            Constants = new Dictionary<string, IData>();
        }

        private int Start(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine(" <==> RFASM Compiler, by GenElectrovise for Gamesmaster3000X");
            Console.WriteLine(" <==> https://github.com/gamesmaster3000x/RF_ASM");

            // <==> Preparing
            Console.WriteLine("");
            Console.WriteLine(" <==> Preparing");

            bool USE_AUTOWIRED_ARGUMENTS = true;
            if (USE_AUTOWIRED_ARGUMENTS)
            {
                Console.WriteLine("Using autowired program arguments (ignoring " + args.Length + " input arguments)");
                string testProgramsPath = "../../../Documentation/TestPrograms/"; // Escape bin, Debug, and net6.0
                args = new string[] { 
                    "-INPUT_PATH", testProgramsPath + "TestAll.txt", //
                    "-DATA_WIDTH", "1", //
                    "-RANDOM_ARG", //
                    "-OTHER_RANDOM_ARG", " ", //
                    "CONFUSION", "-" //
                };
            }

            Console.WriteLine("Parsing arguments");
            meta = new RFASMCompilerMetadata(args);

            if (meta.InputPath == null || meta.InputPath.Equals(""))
            {
                meta.InputPath = GetInputFilePath();
            }
            else
            {
                Console.WriteLine("Found input path " + meta.InputPath + " via program arguments");
            }

            // <==> Parsing
            Console.WriteLine("");
            Console.WriteLine(" <==> Parsing");

            string[] rawLinesArr = File.ReadAllLines(meta.InputPath);
            List<string> rawLines = rawLinesArr.ToList();
            Console.WriteLine("Found " + rawLinesArr.Length + " lines");

            //ITokenGenerator generator = new RFASMTokenGenerator(meta);
            //TokenParser.TokenParser parser = new TokenParser.TokenParser(RFASMTokenGenerator.GOOD_TOKEN, RFASMTokenGenerator.IGNORE_TOKEN, RFASMTokenGenerator.BAD_TOKEN, meta, generator);
            //List<IToken> tokens = parser.Parse(rawLines);
            //string tokenHash = ComputeTokenListHash(tokens);
            //Console.WriteLine("Hash of token raw values: " + tokenHash);

            // Get Antlr context
            RFASMProgram program;
            {
                AntlrInputStream a4is = new AntlrInputStream(string.Join(Environment.NewLine, rawLinesArr));
                RedFoxAssemblyLexer lexer = new RedFoxAssemblyLexer(a4is);
                // lexer.AddErrorListener(new LexerErrorListener(meta.InputPath));

                CommonTokenStream cts = new CommonTokenStream(lexer);
                RedFoxAssemblyParser parser = new RedFoxAssemblyParser(cts);
                // parser.ErrorHandler = new BailErrorStrategy();
                parser.AddErrorListener(new ParserErrorListener(meta.InputPath));

                RedFoxAssemblyParser.ProgramContext cuCtx = parser.program();
                RFASMProgramVisitor visitor = new RFASMProgramVisitor();
                program = visitor.VisitProgram(cuCtx);
            }

            // <==> Compiling
            Console.WriteLine("");
            Console.WriteLine(" <==> Compiling");

            Console.WriteLine("Doing pre-compilation pass");
            PreCompilationPass(program);
            Console.WriteLine("Bytifying");
            List<byte> compiledBytes = CompileTokens(program);

            Console.WriteLine("Generated bytes:");
            CompilerUtils.DisplayHexDump(compiledBytes.ToArray());

            // <==> Writing
            Console.WriteLine("");
            Console.WriteLine(" <==> Writing");
            WriteCompilation(meta.InputPath, compiledBytes.ToArray());

            Console.WriteLine("");
            Console.WriteLine(" <==> Done");
            Console.WriteLine(" <==> https://github.com/gamesmaster3000x/RF_ASM");
            Console.WriteLine(" <==> RFASM Compiler, by GenElectrovise for Gamesmaster3000X");
            Console.WriteLine("");

            return 0;
        }

        private void PreCompilationPass(RFASMProgram program)
        {

            // Resolve configuration (i.e. data widths and values)
            foreach (var c in program.Configuations)
            {
                c.Resolve(this);
            }

            int programLength = 0;
            // Resolve labels
            foreach (var c in program.Commands)
            {
                if (c is LabelCommand)
                {
                    ((LabelCommand)c).DeclareLabel(this, programLength);
                }
                else
                {
                    programLength += c.GetPredictedLength(this);
                }
            }
        }

        private List<byte> CompileTokens(RFASMProgram program)
        {
            List<byte> compiledBytes = new List<byte>();

            foreach (var c in program.Commands)
            {
                if (c is not LabelCommand)
                {
                    compiledBytes.AddRange(c.GetBytes(this));
                }
            }

            return compiledBytes;
        }

        private void WriteCompilation(string inputPath, byte[] bytes)
        {
            string outputPath = GetOutputFileName(inputPath);
            FileInfo outputFileInfo = new FileInfo(outputPath);
            Console.WriteLine("Storing compilation to " + outputFileInfo.FullName);
            if (File.Exists(outputPath)) File.Delete(outputPath);
            BinaryWriter writer = new BinaryWriter(File.Open(outputPath, FileMode.OpenOrCreate));
            writer.Write(bytes);
            writer.Flush();
            writer.Close();
        }

        private string GetInputFilePath()
        {
            Console.Write("Enter the name of the file to be compiled (including the file extension): ");
            string inputPath = Console.ReadLine();
            FileInfo inputFileInfo = new FileInfo(inputPath);
            if (!inputFileInfo.Exists)
            {
                throw new FileNotFoundException("Cannot file the file " + inputFileInfo.FullName);
            }

            return inputPath;
        }

        /// <summary>
        /// Generates the name of the output file based on the input file. For example Program.rfx will become Program.rfbin.
        /// </summary>
        /// <param name="inputFileName"></param>
        /// <returns></returns>
        public string GetOutputFileName(string inputFileName)
        {
            // The input file extension and output file extension
            string RF_BIN_FileEnding = "rfb";

            // Fancy regular expression stuff to replace the .input with the .output
            // () are a class
            // Searches for the final . , then takes everything after it and replaces with the new file ending
            return Regex.Replace(inputFileName, "([^.]+$)", RF_BIN_FileEnding);
        }
    }
}
