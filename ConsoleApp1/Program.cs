using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        #region 4.1 task
        Console.WriteLine("Enter number:");
        int num = Convert.ToInt32(Console.ReadLine());

        while (num > 10)
        {
            num /= 10;
        }
        Console.WriteLine(num);

        #endregion



        #region third task
        Console.WriteLine("Enter n :");
        int n = Convert.ToInt32(Console.ReadLine());


        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
                Console.WriteLine(i);


        }
        #endregion

        #region Second task
        Console.WriteLine("Enter x :");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (y > x) Console.WriteLine("-1");
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
        #endregion


        #region Fibonachi
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
        #endregion



        #region 4.2
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

        #endregion
    }
}