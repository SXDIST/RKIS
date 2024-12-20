﻿namespace C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MiddleOf(5, 0, 100));  
            Console.WriteLine(MiddleOf(12, 12, 11)); 
            Console.WriteLine(MiddleOf(1, 1, 1));   
            Console.WriteLine(MiddleOf(2, 3, 2));  
            Console.WriteLine(MiddleOf(8, 8, 8));
            Console.WriteLine(MiddleOf(5, 0, 1)); 
        }

        public static int MiddleOf(int a, int b, int c)
        {
            int min = Math.Min(a, Math.Min(b, c));
            int max = Math.Max(a, Math.Max(b, c));
            return a + b + c - min - max; 
        }
    }
}