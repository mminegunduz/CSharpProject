using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int question = 1;
            string answer;
            if(question==1)
            {
                Console.WriteLine("Where is the capital of Turkey?");
                Console.WriteLine();
                Console.WriteLine("A) Istanbul");
                Console.WriteLine("B) Ankara");
                Console.WriteLine("C) Bursa");
                Console.WriteLine("D) Sinop");
                Console.WriteLine();
                Console.Write("Your Answer: ");
                answer = Console.ReadLine();

                if(answer== "B" || answer=="b")
                {
                    question = question + 1;
                }
                else
                {
                    Console.WriteLine("Your answer is false. Your total point is zero.");
                }

                if (question == 2)
                {
                    Console.WriteLine("In what year was the Republic declared?");
                    Console.WriteLine();
                    Console.WriteLine("A) 1920");
                    Console.WriteLine("B) 1921");
                    Console.WriteLine("C) 1922");
                    Console.WriteLine("D) 1923");
                    Console.WriteLine();
                    Console.Write("Your Answer: ");
                    answer = Console.ReadLine();

                    if(answer=="d" || answer=="D")
                    {
                        question = question + 1;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is false. The competition is over. Your point is 1. ");
                    }
                }
                if (question == 3)
                {
                    Console.WriteLine("Sinop is a district of which country?");
                    Console.WriteLine();
                    Console.WriteLine("A) Switzerland");
                    Console.WriteLine("B) Canada");
                    Console.WriteLine("C) Turkey");
                    Console.WriteLine("D) Russia");
                    Console.WriteLine();
                    Console.Write("Your Answer: ");
                    answer = Console.ReadLine();

                    if (answer == "c" || answer == "C")
                    {
                        Console.WriteLine("Congrats... You answered all the questions correctly");
                    }
                    else
                    {
                        Console.WriteLine("Your answer is false. The competition is over. Your point is 2. ");
                    }
                }
            }
            Console.Read();


        }
            
    }
}
