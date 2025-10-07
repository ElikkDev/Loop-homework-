using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter x :");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (y > x) Console.WriteLine("Wrong data");
        else
        {
            int big = 0;

            for (int i = 0; i < x; i++)
            {
                if (i % y == 0)
                    big = i;


            }

            Console.WriteLine("big dividor :" + big);
        }
    }









}
