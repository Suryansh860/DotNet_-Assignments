﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concession;   // using namespace

namespace Test
{
    internal class Program_Test
    {
        const int TotalFare = 1000;
        public string name;
        public int age;
        static void Main(string[] args)
        {

            //Taking input from the user like Name and Age
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());

            //Creating an instance of TicketConcession Class
            TicketConcession ticket = new TicketConcession();

            //Calling the CalculateConcession Method
            ticket.CalculateConcession(age, name);
            Console.ReadLine();
        }
    }
}
