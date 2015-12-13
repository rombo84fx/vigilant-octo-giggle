﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Calculator : IDisposable
    {
        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }

        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            this.Dispose();
        }

        public int Divide( int first, int second)
        {
            return first / second;
        }

        public void Dispose()
        {
            Console.WriteLine("Calculator being disposed");
        }
    }
}
