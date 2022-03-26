using System;
using System.IO;

namespace Lab03___System.IO
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Challenge1(InputChall01());
            Challenge2(InputChall02());
            //Challenge3();
            //int[] array2 = { 1, 1, 2, 3, 3, 3, 3, 1 };
            //Challenge4(array2);
            //int[] array = { 5, 25, 99, 123, 78, 96, 555, 108, 4 };
            //Challenge5(array);
            //Challenge6();
            //Challenge7();
            //Challenge8();
            //Challenge9();
        }


        public static string InputChall01()
        {
            Console.WriteLine("Please enter three numbers:");
            string UserInput = Console.ReadLine();
            
            return UserInput;
        }
        public static int Challenge1(string UserInput)
        {
            string[] NumbersArray = UserInput.Split(" ");

            if (NumbersArray.Length < 3)
            {
                Console.WriteLine("0");
                return 0;
            }
            else
            {
                try
                {
                    int product = 1;
                    for (int i = 0; i < 3; i++)
                    {
                        int ConvertedArray = Convert.ToInt32(NumbersArray[i]);
                        product *= ConvertedArray;
                    }
                    Console.WriteLine("The product of these numbers is: "+product);
                    
                    return product;
                }
                catch (FormatException)
                {
                    Console.WriteLine("1");
                    return 1;

                }
            }
        }

        public static int[] InputChall02()
        {
            Console.WriteLine("Please enter a number between 2-10: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 2 && number <= 10)
            {
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
                        if (input >= 0)
                        {
                            break;
                        }
                    }
                    if (input >= 0)
                    {
                        newArray[i] = input;
                    }


                }

            return newArray;
            }
            else
            {
                Console.WriteLine("You didn't a number between 2-10...");
                Console.WriteLine("");

                return InputChall02();
            }

        }

        public static int Challenge2(int[] newArray)
            {
                    int sum = 0;
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        sum += newArray[i];
                    }
                    int avg = sum / newArray.Length;
                    Console.WriteLine($"The average of these numbers: {sum} / {newArray.Length} = {avg}.");


            return avg;

            }

        public static void Challenge3()
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

        public static int Challenge4(int[] arr)
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
                return res;
            }

        public static int Challenge5(int[] arr)
            {

                int max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= max)
                    {
                        max = arr[i];
                    }
                }
                Console.WriteLine(max);
            return max;
            }

        public static void Challenge6()
            {
                Console.Write("Please enter what you want to add the text file: ");
                string Path = "../../../Challenges6&7&8.txt";
                string Input = Console.ReadLine();

                File.WriteAllText(Path, Input);
            }

        public static void Challenge7()
            {
                string Path = "../../../Challenges6&7&8.txt";
                string Result = File.ReadAllText(Path);
                Console.WriteLine(Result);
            }

         public static void Challenge8()
            {
                string Path = "../../../Challenges6&7&8.txt";
            
                String[] FileData = File.ReadAllLines(Path);
                for (int i = 0; i < FileData.Length; i++)
                {
                    Console.WriteLine(FileData[i]);
                }
                Console.WriteLine("Enter the index of the word you want to delete:  ");
                int UserInput = Convert.ToInt32(Console.ReadLine());
                String holder = FileData[UserInput];
                FileData[UserInput] = "";
                String str = String.Concat(FileData);
                File.WriteAllText(Path, str);

                File.AppendAllText(Path, holder);
             }

         public static void Challenge9()
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

