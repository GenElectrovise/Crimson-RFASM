﻿using CommandLine;
using Crimson.Statements;
using NLog;
using NLog.Fluent;
using NLog.Layouts;
using Crimson.ANTLR.Crimson;

namespace Crimson.Core
{
    internal class CrimsonCompiler
    {
        public CrimsonCmdArguments Options { get; }

        private static NLog.Logger Logger;

        public CrimsonCompiler(CrimsonCmdArguments options)
        {
            Options = options;
        }

        static Task<int> Main(string[] args)
        {
            bool useAutowiredArgs = true;
            if (useAutowiredArgs)
            {
                string testProgramsPath = "../../../Documentation/Examples/"; // Escape bin, Debug, and net6.0
                args = new string[] { "-s", testProgramsPath + "Main_Utils/main.crm", "-t", "out", "-n", "nope"};
            }

            // Start
            Console.WriteLine("");
            Console.WriteLine(" ~C~ "); 
            Console.WriteLine("Crimson Language Compiler, by GenElectrovise, for GamesMaster3000X");
            Console.WriteLine("https://github.com/gamesmaster3000x/RF_ASM");
            Console.WriteLine(" ~C~ ");
            Console.WriteLine("");

            Console.WriteLine("Parsing program arguments");
            return Parser.Default.ParseArguments<CrimsonCmdArguments>(args).MapResult((CrimsonCmdArguments options) =>
            {
                Console.WriteLine("CompilationSourcePath: " + options.CompilationSourcePath);
                Console.WriteLine("CompilationTargetPath: " + options.CompilationTargetPath);
                Console.WriteLine("NativeLibraryPath: " + options.NativeLibraryPath);
                CrimsonCompiler compiler = new CrimsonCompiler(options);
                return Task.FromResult(compiler.Start(options));
            },
            (error) => {
                Console.Error.WriteLine("An issue occurred while parsing the program arguments (invalid arguments)");
                return Task.FromResult(-1);
            });
        }

        private int Start(CrimsonCmdArguments options)
        {
            // Prepare
            ConfigureNLog();

            CrimsonBaseVisitor<bool> visitor = new CrimsonBaseVisitor<bool>(); // TODO: Extend visitor from here

            // Pre-compilation
            LazySourceFile compilation = new LazySourceFile(options.CompilationSourcePath, options);

            if (options.CleanFiles)
            {
                Cleaner.CleanFiles();
            }
            return 0;
        }

        private void ConfigureNLog()
        {
            Console.WriteLine("Configuring NLog...");
            NLog.Config.LoggingConfiguration config = new NLog.Config.LoggingConfiguration();
            var fileTarget = new NLog.Targets.FileTarget("CrimsonFileLogTarget")
            {
                FileName = "Crimson_${shortdate}.log",
                Layout = "${level} | ${time} | ${logger} > ${message:withexception=true}",
                DeleteOldFileOnStartup = true
            };
            var consoleTarget = new NLog.Targets.ConsoleTarget("CrimsonConsoleLogTarget")
            {
                Layout = "${level} | ${time} | ${logger} > ${message:withexception=true}"
            };
            config.AddRule(LogLevel.Trace, LogLevel.Fatal, fileTarget);
            config.AddRule(LogLevel.Trace, LogLevel.Fatal, consoleTarget);
            NLog.LogManager.Configuration = config;
            Console.WriteLine("NLog configured!");

            Logger = NLog.LogManager.GetCurrentClassLogger();
            Logger.Trace("Testing trace level logging...");
            Logger.Fatal("Testing fatal level logging...");
            Console.WriteLine("Did you see *both* of the *two* test messages? If not, you should report this to the developer!");
        }
    }
}