using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter  number:");
        int number = Convert.ToInt32(Console.ReadLine());
        string fesil = number switch
        {
            1 or 12 or 2 => "Qis",
            3 or 4 or 5 => "yaz",
            6 or 7 or 8 => "yay",
            9 or 10 or 11 => "payiz",
            _ => "Bele ay yoxdu"
        };

        Console.WriteLine(fesil);

    }
}