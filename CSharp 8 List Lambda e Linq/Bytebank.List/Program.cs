using System;
using System.Collections.Generic;

namespace Bytebank.List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            idades.Add(12);
            idades.Add(53);
            idades.Add(3);
            idades.Remove(3);

            ListExtensions.AddSome(idades, 43, 64, 15, 43, 20);
            idades.AddSome(7, 99, 32, 55);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }
    }
}
