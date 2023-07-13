using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //4th Assignment


            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());


            //if (number > 0)
            //{
            //    Console.WriteLine("The number is positive.");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("The number is negative.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is zero.");
            //}


            //string parity = (number % 2 == 0) ? "even" : "odd";
            //Console.WriteLine("The number is " + parity + ".");



            //5th Assignment


            string correctUsername = "john";
            string correctPassword = "pass123";
            int attemptsRemaining = 3;

            while (attemptsRemaining > 0)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (username == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("Login successful.");
                    return;
                }
                else if (username == correctUsername)
                {
                    Console.WriteLine("Invalid password.");
                }
                else
                {
                    Console.WriteLine("Invalid username.");
                }

                attemptsRemaining--;
            }

            Console.WriteLine("Login failed.");





        }
    }
}
