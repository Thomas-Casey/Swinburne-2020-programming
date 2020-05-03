using System;
using System.Collections.Generic;

namespace C__Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter task number");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    Console.WriteLine("Enter your name: ");
                    string usersname = Console.ReadLine();
                    task2(usersname);
                    break;
                case 3:
                    Console.WriteLine("Enter a number: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter another number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    task3(number1, number2);
                    break;
                case 4:
                    Console.WriteLine("Please imput a string:");
                    string imput = Console.ReadLine();
                    task4(imput);
                    break;
                case 5:
                    Console.WriteLine("Enter imput-1:");
                    int element1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter imput-2:");
                    int element2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter imput-3:");
                    int element3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter imput-4:");
                    int element4 = Convert.ToInt32(Console.ReadLine());
                    task5(element1, element2, element3, element4);
                    break;
                case 6:
                    Console.WriteLine("Enter 1st number:");
                    int stno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd number:");
                    int ndno = Convert.ToInt32(Console.ReadLine());
                    task6(stno, ndno);
                    break;
                case 7:
                    Console.WriteLine("Input Base number:");
                    int baseno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input the Exponent:");
                    int exponent = Convert.ToInt32(Console.ReadLine());
                    task7(baseno, exponent);
                    break;
                case 8:
                    Console.WriteLine("Enter the number of elements: ");
                    int fibnum = Convert.ToInt32(Console.ReadLine());
                    task8(fibnum);
                    break;
                case 9:
                    Console.WriteLine("Imput a number:");
                    int chprime = Convert.ToInt32(Console.ReadLine());
                    task9(chprime);
                    break;
                case 10:
                    Console.WriteLine("Enter a number:");
                    int sumnum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The sum of the digits of the given number is:" + task10(sumnum));
                    break;

                default:
                    break;

            }






        }
        static void task1()
        {
            Console.WriteLine(@"
Welcome Friends! 
Have a nice day!");
        }
        static void task2(string usersname)
        {
            Console.WriteLine("Welcome friend {0} Have a nice day!", usersname);
        }
        static void task3(int number1, int number2)
        {
            int sum = number1 + number2;
            Console.WriteLine("The sum of the two numbers is: {0}", sum);
        }
        static void task4(string imput)
        {

            int nospaces = 0;
            foreach (char letter in imput)
            {
                if (letter == ' ')
                {
                    nospaces += 1;
                }
            }
            Console.WriteLine("{0} contains {1} spaces", imput, nospaces);


        }
        static void task5(int element1, int element2, int element3, int element4)
        {
            int sum = element1 + element2 + element3 + element4;
            Console.WriteLine("the sum of the elements in the array is: {0}", sum);

        }
        static void task6(int stno, int ndno)
        {
            Console.WriteLine("Now the 1st number is: {0} , and the 2nd number is: {1} ", ndno, stno);
        }
        static void task7(int baseno, int exponent)
        {
            var res1 = Math.Pow(baseno, exponent);
            Console.WriteLine("So, the number {0} to the power of {1} = {2}", baseno, exponent, res1);
        }
        static void task8(int fibnum)
        {
            int n1 = 0, n2 = 1, n3, i;
            Console.WriteLine("The Fibonacci series of {0} numbers is :", fibnum);
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < fibnum; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
        static void task9(int chprime)
        {

            if (IsPrime(chprime))
            {
                Console.WriteLine("{0} is a prime number", chprime);
            }
            else
            {
                Console.WriteLine("{0} is not prime number", chprime);
            }

            static bool IsPrime(int chprime)
            {
                if (chprime <= 1) return false;
                if (chprime == 2) return true;
                if (chprime % 2 == 0) return false;

                var boundary = (int)Math.Floor(Math.Sqrt(chprime));

                for (int i = 3; i <= boundary; i += 2)
                {
                    if (chprime % i == 0) return false;
                }

                return true;
            }
        }
        static int task10(int sumnum)
        {
            int sum = 0;

            while (sumnum != 0)
            {
                sum = sum + sumnum % 10;
                sumnum = sumnum / 10;
            }

            return sum;
        }
    }
}



