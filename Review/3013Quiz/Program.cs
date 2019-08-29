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
            double val = Add(1, 5.5);
            Concat("Hello ", "World");
            Arrays();
            Lists();
            Console.ReadKey();
        }

        private static void Lists()
        {
            List<String> firstNames = new List<string>();
            firstNames.Add("Adam");
            firstNames.Add("Adam2");
            firstNames.Add("Adam3");
        }

        private static void Arrays()
        {
            int[] nums = new int[5];

            for(int i = nums.Length -1; i >= 2; i--)
            {
                nums[i] = 3;
            }
        }

        static void Concat(string s1, string s2)
        {
            Console.WriteLine(s1 + s2);
        }

        private static double Add(int v1, double v2)
        {
            return v1 + v2;

            double sum = v1 + v2;
            return sum;
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
