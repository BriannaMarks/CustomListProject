﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> randomList = new GenericList<string>();
            randomList.ToString();
            Console.ReadKey();
        }
    }
}
