using System;
using System.IO;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            int najdlhsie = 0;
            for (int l = 0; l < strings.Length; l++)
            {
                if (strings[l].Length > najdlhsie)
                {
                    najdlhsie = strings[l].Length;
                }
            }
            for (int i = 1; i < najdlhsie + 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write("* ");
                Console.Write(strings[i]);
                for (int s = 0; s < najdlhsie - strings[i].Length; s++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" *");
            }
            for (int i = 1; i < najdlhsie + 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
        }
    }
}