using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fn = Fn−1 + Fn−2, where F1 = 1, F2 = 1, F3 = 2, .... and F12 = 144.F12 is the first term to contain three digits.

//What is the index of the first term in the Fibonacci sequence to contain 10 digits?


namespace TenDigitFibonnaci
{
    class TenDigit
    {
        static void Main(string[] args)
        {

            int fib1 = 1; //variable for first number
            int fib2 = 2; //variable for second number
            int fib3 = 0; //stores addition

            //int fib4 = 0; NO LONGER NEEDED
            do
            {
                //string to make the output of addition stored in new variable
                fib3 = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib3;
                //fib4 += fib3; //NO LONGER NEEDED


                //if (fib2 % 2 == 0) //find numbers divisible by 2 (even)
                //{
                //    fib4 += fib2; //fib2 turns into fib3 so that is why we need to store it in fib4
                //}


            } while (fib3 < 1000000000); //variable goes until 1 bill (10 digits)
            Console.WriteLine(fib3);
        }
    }
}
