﻿using System;
using System.Runtime.CompilerServices;

namespace Deliverable__3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
           
            while (true)
            {
                Console.Write("Enter an integer number between 1 and 100: ");
                input = int.Parse(Console.ReadLine());

                if (input >= 1 && input <= 100)
                {
                    break;
                }
            }

            Console.Write("Specify the series type: Even or Odd ");
            string series = Console.ReadLine();

            if (series == "Odd")
            {
                Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                for (int i = 1; i < input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            if (series == "Even")
            {
                Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are:");
                for (int i = 0; i < input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}