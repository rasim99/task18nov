﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task18nov
{
    public class Calculator
    {
        
       
        public void Calculation()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a * b);
            Console.WriteLine(a/b);
        }
    }
}
