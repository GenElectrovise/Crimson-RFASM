﻿using System.Collections;

namespace RedFoxVM
{
    /// <summary>
    /// Static utility methods for RF_ASM
    /// </summary>
    internal class Utils
    {

        /// <summary>
        /// Takes a file containing binary data, and writes it into a buffer.
        /// </summary>
        public static byte[] GetDataFromFile(string path)
        {
            // Open a handle to the file
            BinaryReader reader = new BinaryReader(File.Open(path, FileMode.OpenOrCreate));
            
            // Read data from file into buffer
            byte[] data = new byte[reader.BaseStream.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = reader.ReadByte();
            }
            
            reader.Close();
            return data;
        }

        /// <summary>
        /// Takes an array of bytes and writes them out to the console as hex values.
        /// </summary>
        public static void DisplayHexDump(byte[] data)
        {
            // Get number of lines to display in dump
            int lines = (data.Length + 15) / 16;
            string linesHex = (lines - 1).ToString("X");
            Console.WriteLine(new string(' ', linesHex.Length) + " 00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F");
            
            // For each line of 
            for (int i = 0; i < lines; i++)
            {
                // Write the current line number
                Console.Write(i.ToString("X" + linesHex.Length.ToString()));
                
                // Write each byte on the line
                for (int j = 0; j < 16; j++)
                {
                    if (i * 16 + j < data.Length)
                    {
                        Console.Write(" " + data[i * 16 + j].ToString("X2"));
                    }
                }
                Console.WriteLine();
            }
        }

        public static byte[] SetBitInByte(byte b, int bitIndex, bool bitValue)
        {
            BitArray bitArr = new BitArray(new byte[] {b});
            bitArr.Set(bitIndex, bitValue);
            byte[] o = new byte[bitArr.Length];
            bitArr.CopyTo(o, 0);
            return o;
        }

        /*public static Value IntToValue(int num, int width)
        {
            Value value = new Value(width);
            for (int i = 0; i < width; i++)
            {
                value.data[i] = (byte)(num % 256);
                num /= 256;
            }
            return value;
        }*/
    }
}
