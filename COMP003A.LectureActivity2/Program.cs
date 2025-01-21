/*
*Author: [Zaid Rojas]
*Course: [COMP-003A-L01]
*Faculty: Jonathan Cruz
*Purpose: A program demonstrating statements, variables, and operators.
*/

using System;

namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 3.1 Declaration
            string userName;
            int userAge;
            double productPrice;
            bool isStudent;

            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            Console.Write("Enter your age: ");
            userAge = int.Parse(Console.ReadLine());

            Console.Write("Enter the price of a product: ");
            productPrice = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false): ");
            isStudent = bool.Parse(Console.ReadLine());

            // Step 3.2 Calculation
            int futureAge = userAge + 5;
            bool isAdult = futureAge >= 18;
            bool isAdultStudent = isStudent && isAdult;

            // Step 3.3 Results
            Console.WriteLine($"Hello, {userName}!");
            Console.WriteLine($"You are currently {userAge} years old. In 5 years, you will be {futureAge}.");
            Console.WriteLine($"Are you 18 or older?: {isAdult}.");
            Console.WriteLine($"Are you both a sudent and 18 or older? {isAdultStudent}");

        }
    }
}
