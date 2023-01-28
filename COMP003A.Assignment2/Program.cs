/*
* Author: Lionel Villanueva
* Coursee: COMP=003A-L01
* Purpose: To demonstrate the use of various date types and string interpolation of C#
*/

namespace COMP003A.Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Consolee Section
            
                                    

            Console.Title = " COMP-003A- Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;


            // String Section
            
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your middle name");
            string middleName = Console.ReadLine();
            Console.WriteLine("Please enter your last namee");
            string lastName = Console.ReadLine();
            Console.WriteLine("Pleas enter your age in 2023:");
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");


            // Math Section
            Console.WriteLine("Please enter an integer:");
            int integer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another integer:");
            int integer2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{integer1}+{integer2}={integer1 + integer2}");
            Console.WriteLine($"{integer1}-{integer2}={integer1 - integer2}");
            Console.WriteLine($"{integer1}*{integer2}= {integer1 * integer2}");
            Console.WriteLine($"{integer1}/ {integer2}= {integer1 / integer2}");
            Console.WriteLine($"{integer1}% {integer2}= {integer1 % integer2}");

            // Circle Area & Circumference Calculator Section
            Console.WriteLine("Please entr the radius of a circle");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"Th area of thee circle is {area}.");
            Console.WriteLine($"The circumfrence of the circle is {circumference}");

        }
    }
}










