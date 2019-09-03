using System;
using System.Collections.Generic;

namespace _3013Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzz();
            //WhileLoop();
            //ForLoop();
            //Arrays();
            //Lists();
            //int myFavoriteNumber = 11;
            //double result = Add(myFavoriteNumber, 5.5);
            //string strWorld = " World";
            //Concat("Hello", strWorld);
            string variableName = "";
            Computer myComputer = new Computer();
            myComputer.Brand = "Dell";
            myComputer.CPUCores = 2;
            Computer katiesComputer = new Computer();
            katiesComputer.CPUCores = 16;
            Console.WriteLine(myComputer.Brand);
            Console.WriteLine(katiesComputer.Brand);
            Console.ReadKey();
        }

        static double Add(int param1, double param2)
        {
            return param1 + param2;
        }

        static void Concat(string param1, string param2)
        {
            string variable3 = param1 + param2;
            Console.WriteLine(variable3);
        }

        private static void Lists()
        {
            List<String> firstNames = new List<string>();
            firstNames.Add("Adam");
            firstNames.Add("Adam2");
            firstNames.Add("Adam3");

            //for (int i = 0; i < firstNames.Count; i++)
            //{
            //    string tempName = firstNames[i];

            //    Console.WriteLine(tempName);
            //}

            //foreach (var tempName in firstNames)
            //{
            //    Console.WriteLine(tempName);
            //}

        }

        private static void Arrays()
        {
            int[] nums = new int[5];

            for(int i = nums.Length -1; i >= 2; i--)
            {
                nums[i] = 3;
            }
        }


        private static void ForLoop()
        {
            string word = "Adam";
            word = word.ToUpper();
            for (int i = word.Length-1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine("!");
        }

        private static void WhileLoop()
        {
            string word = "Adam";
            int index = 0;
            string newWord = string.Empty;

            while (index < word.Length)
            {
                if (word.Length - 1 == index)
                {
                    Console.Write(word[index]);
                    newWord += word[index];
                }
                else
                {
                    Console.Write(word[index] + "-");
                    newWord += word[index] + "-";
                }
                //newWord = newWord + word[index] + "-";
                index++;
            }

            Console.WriteLine($"\n{newWord}");
            //"\n" + newWord

        }

        private static void FizzBuzz()
        {
            string firstName = "123456789123456";

            if (firstName.Length % 3 == 0 && firstName.Length % 5 == 0)
            {
                Console.WriteLine("Fizzbuzz");
            }
            else if (firstName.Length % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (firstName.Length % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }

        }
    }
}
