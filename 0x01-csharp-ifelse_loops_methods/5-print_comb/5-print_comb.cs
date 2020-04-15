using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            string sep = "";
            for (int i = 0; i < 100; i++) {
                Console.Write("{0}{1:D2}", sep, i);
                sep = ", ";
            }
            Console.Write("\n");
        }
    }
}
