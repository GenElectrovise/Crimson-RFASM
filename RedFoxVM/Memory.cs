﻿using RedFoxVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace RedFoxVM
{
    internal class Memory
    {
        byte[] data;
        public Memory(int capacity, byte[] input = null)
        {
            if (input == null)
            {
                input = new byte[] {0};
            }

            data = new byte[capacity];

            for (int i = 0; i < capacity; i++)
            {
                if (i < input.Length)
                {
                    data[i] = input[i];
                }
                else
                {
                    data[i] = 0;
                }
            }
        }

        public byte GetByte(int addr)
        {
            return data[addr];
        }
        
        public void SetByte(int addr, byte data)
        {
            this.data[addr] = data;
        }
    }
}
