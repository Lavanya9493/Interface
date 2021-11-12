﻿using System;

namespace Intface
{
    interface IMath
    {
        int add(int x,int y);
        int sub(int x,int y);
    }
    class Math:IMath
    {
        public int add(int x,int y)
        {
                return x+y;
        }
        public int sub(int x,int y)
        {
            return x-y;
        }
        
    }
    class Program
    {
        static void Main()
        {
            IMath math=new Math();
            Console.WriteLine(math.add(10,15));
            Console.WriteLine(math.sub(25,5));
        }
    }
}
