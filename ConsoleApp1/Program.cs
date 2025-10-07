using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n :");
        int n = Convert.ToInt32(Console.ReadLine());
        int big = 0;

        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
                big = i;


        }

        Console.WriteLine("Big data: " + big);
    }









}
