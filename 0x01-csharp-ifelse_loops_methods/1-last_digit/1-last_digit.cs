﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastDigit = number % 10;
        string msg = "";
        if (lastDigit > 5) {
            msg = "and is greater than 5";
        } else if (lastDigit == 0) {
            msg = "and is 0";
        } else {
            msg = "and is less than 6 and not 0";
        }
	    Console.WriteLine("The last digit of {0} is {1} {2}", number, lastDigit, msg);
    }
}
