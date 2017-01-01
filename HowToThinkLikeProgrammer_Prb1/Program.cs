using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToThinkLikeProgrammer_Prb1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Cont = true;
            do
            {
                int number = 0;
                int sum = 0;
                try
                {
                    Console.WriteLine("Please Insert a Valid natural number and Press Enter:");
                    number = Convert.ToInt16(Console.ReadLine());
                    for (int i = 1; i < number; i++)
                    {
                        //multiples of 3 , 5 
                        if (i % 3 == 0 || i % 5 == 0)
                        {
                            sum += i; //sum = sum+i;
                        }
                    }
                    Console.WriteLine("Sum of multiples is :" + sum);
                }
                catch
                {
                    Console.WriteLine("Inser a valid number !");
                }
                Console.WriteLine("Enter 0 to Exist or any number to continue , and press Enter:");
                Cont = Convert.ToInt16(Console.ReadLine()) != 0;
            } while (Cont);
        }
    }
}
