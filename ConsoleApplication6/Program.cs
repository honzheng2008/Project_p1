﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Amicablenumbers 
            //int j = Amicablenumbers(10000); //31626  20190921



        }
        /*
         Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

Evaluate the sum of all the amicable numbers under 10000.
             // 31626
             */
        static int Amicablenumbers(int max)
        {
            int sum = 0;

            for(int i = 1; i < max; i++)
            {
                int j = sumOfDivisor(i);

                if (j != i && sumOfDivisor(j) == i)
                {
                    sum += i;  //
                }
            }
              
            return sum ;
        }

       static  int sumOfDivisor(int n)
        {
            int sum = 0;
            for(int i =1; i < n; i++)
            {

                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum;


        }



        void Capitals_Countries_Question()
        {
            Dictionary<string, string> Data = new Dictionary<string, string>();
            string input = "";
            string countryName = "";
            string countryCapital = "";
            Data.Add("CANADA", "OTTAWA");
            Data.Add("CHINA", "BEIJING");
            Data.Add("ECUADOR", "QUITO");
            Data.Add("ERITREA", "ASMARA");
            Data.Add("FIJI", "SUVA");

            Dictionary<string, string> temp = Data;
            int number = Data.Count;


            while (true)
            {
                number = temp.Count;
                Random random = new Random();
                int randomNumber = random.Next(0, number);
                countryName = temp.ElementAt(randomNumber).Key;
                countryCapital = temp.ElementAt(randomNumber).Value;

                Console.WriteLine("What is capital for " + countryName);
                input = Console.ReadLine();

                if (countryCapital.Equals(input))
                {
                    temp.Remove(countryName);
                    Console.WriteLine("Right!");

                    if (temp.Count == 0)
                    {
                        break;
                    }

                }



            }


            Console.WriteLine("Done");
            Console.ReadLine();


        }
    }
}
