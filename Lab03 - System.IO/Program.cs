using System;
using System.IO;

namespace Lab03___System.IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Challenge1();
            Challenge2();
            Challenge3();
            int[] array2 = { 1, 1, 2, 3, 3,3, 3, 1 };
            Challenge4(array2);
            int[] array = { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
            Challenge5(array);
            Challenge6();
            Challenge7();
            Challenge8();
            Challenge9();
        }

        static void Challenge1()
        {
            Console.WriteLine("Please enter three numbers:");
            Console.WriteLine("Please enter the first number:");
                string numberone = (Console.ReadLine());
                int number1;
            if (!string.IsNullOrEmpty(numberone))
            {
                try
                {
                    number1 = Convert.ToInt32(numberone);
                }
                catch(System.FormatException e)
                {
                    Console.WriteLine("You didn't enter a number, it will be set to one....");
                    number1 = 1;
                }
            }
            else
            {
                Console.WriteLine("You didn't enter a value, it will be set to Zero....");
                number1 = 0;
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Please enter the second number:");
            string numbertwo = (Console.ReadLine());
            int number2;
            if (!string.IsNullOrEmpty(numbertwo))
            {
                try
                {
                    number2 = Convert.ToInt32(numbertwo);
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("You didn't enter a number, it will be set to one....");
                    number2 = 1;
                }
            }
            else
            {
                Console.WriteLine("You didn't enter a value, it will be set to Zero....");
                number2 = 0;
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Please enter the third number:");
            string numberthree = (Console.ReadLine());
            int number3;
            if (!string.IsNullOrEmpty(numberthree))
            {
                try
                {
                    number3 = Convert.ToInt32(numberthree);
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("You didn't enter a number, it will be set to one....");
                    number3 = 1;
                }
            }
            else
            {
                Console.WriteLine("You didn't enter a value, it will be set to Zero....");
                number3 = 0;
            }

            int Multiply = number1 * number2 * number3;
            Console.WriteLine($"The product of these numbers are: {number1} * {number2} * {number3} = {Multiply}");
        }

        static void Challenge2()
        {
            Console.WriteLine("Please enter a number between 2-10: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] newArray = new int[number];
           
            

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine("Please enter a number: {0} of {1}", i + 1, number);
                int input = Convert.ToInt32(Console.ReadLine());
                while ((input < 0))
                {
                    Console.WriteLine("Please enter a positive number");
                    Console.WriteLine("Please enter a number: {0} of {1}", i + 1, number);
                    input = Convert.ToInt32(Console.ReadLine());
                    newArray[i] = input;
                    if(input >= 0)
                    {
                        break;
                    }
                }
                if (input >= 0)
                {
                    newArray[i] = input;
                    
                }
            }

            int sum = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                sum += newArray[i];
            }
            int avg = sum / number;
            Console.WriteLine($"The average of these numbers: {sum} / {number} = {avg}.");
        }

        static void Challenge3()
        {
            int i, j, count = 1, number;
            Console.Write("Enter number of rows:");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (j = 1; j <= number - 1; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - j) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void Challenge4(int[] arr)
        {
            Array.Sort(arr);
            int max_count = 1, res = arr[0];
            int curr_count = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                    curr_count++;
                else
                {
                    if (curr_count > max_count)
                    {
                        max_count = curr_count;
                        res = arr[i - 1];
                    }
                    curr_count = 1;
                }
            }

            // If last element is most frequent
            if (curr_count > max_count)
            {
                max_count = curr_count;
                res = arr[arr.Length - 1];
            }
            Console.WriteLine("The most frequesnt number in this array is: " + res);
        }
        
        static void Challenge5(int[] arr)
        {
           
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }

        static void Challenge6()
        {
            Console.Write("Please enter what you want to add the text file: ");
            string Path = "../../../Challenges6&7&8.txt";
            string Input = Console.ReadLine();

            File.WriteAllText(Path, Input);
        }

        static void Challenge7()
        {
            string Path = "../../../Challenges6&7&8.txt";
            string Result = File.ReadAllText(Path);
            Console.WriteLine(Result);
        }

        static void Challenge8()
        {
            string Path = "../../../Challenges6&7&8.txt";
            string Text = File.ReadAllText(Path);
            string FirstWord = Text.Substring(0, Text.IndexOf(" "));
            string NewWord = Text.Remove(0, FirstWord.Length + 1);
            Console.WriteLine(NewWord);
        }

        static void Challenge9()
        {
            Console.WriteLine("Please enter a sentence to find how many letters are in each word: ");
            string Input = Console.ReadLine();
            string[] Splitted = Input.Split(" ");
            for (int i = 0; i < Splitted.Length; i++)
            {
                Console.WriteLine($"{Splitted[i]}: {Splitted[i].Length}");
            }
        }
    }
}
