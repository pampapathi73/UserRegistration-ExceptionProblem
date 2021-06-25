﻿using System;

namespace UserRegistrationExceptionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Exception Problem!");
            Patterns patternsMatch = new Patterns();
            Console.WriteLine("Enter FirstName:");
            string firstName = Console.ReadLine();
            Console.WriteLine("FirstName:" + patternsMatch.ValidateFirstName(firstName));
            Console.WriteLine("Enter LastName:");
            string lastName = Console.ReadLine();
            Console.WriteLine("LastName:" + patternsMatch.ValidateLastName(lastName));
            Console.WriteLine("Enter EmailID:");
            string emailId = Console.ReadLine();
            Console.WriteLine("EmailID:" + patternsMatch.ValidateEmailId(emailId));
        }
    }
}
