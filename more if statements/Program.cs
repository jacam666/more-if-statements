using System;

namespace more_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there, what is your bill total");
            int bill = Convert.ToInt32(Console.ReadLine());
            
            double discount = (0.15 * bill);
            if (bill > 1500)
            {
                Console.WriteLine("Your total discount is: ");
                Console.WriteLine(discount);
            }
            else
            {
                Console.WriteLine("Sorry you have no discount!!!");
            }
        }
    }
}
