using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        string sign = "";
	    if (number > 0) {
            sign = "positive";
        } else if (number == 0) {
            sign = "zero";
        } else {
            sign = "negative";
        }
        Console.WriteLine("{0} is {1}", number, sign);
    }
}
