﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    
    class Program
    {
        static void PrintName(string str)
        {
            Console.WriteLine("Hello, {0}!",str);
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintName(name);


        }
    }
}
