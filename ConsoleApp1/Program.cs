using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int fibonachi = Convert.ToInt32(Console.ReadLine());

        int firstNumber = 0;
        int secondNumber = 1;
        int sum;

        Console.WriteLine("Fibonacci sequence:");

        for (int i = 0; i < fibonachi; i++)
        {
            Console.WriteLine(firstNumber);
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
        }









    }
}