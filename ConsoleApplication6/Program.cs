using System;
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
           
            


        }

        void Amicablenumbers()
        {



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
