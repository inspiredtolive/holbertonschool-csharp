using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sep = "";
            int first = 0, second = 0; 
            for (int i = 0; i < 100; i++) {
                first = i / 10 % 10;
                second = i % 10;
                if (first < second) {
                    Console.Write("{0}{1:D2}", sep, i);
                    sep = ", ";
                }
            }
            Console.Write("\n");
        }
    }
}
