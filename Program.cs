using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Number_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome To My Arm Strong Number Program");
            Console.Write("Enter Your number to check its armstrong or not : ");
            long userNumber = Convert.ToInt64(Console.ReadLine());

            long rem;
            long cube;
            long result = 0;
            long temp = userNumber;

            while (userNumber!=0)
            {
                rem = userNumber % 10;
                cube = rem* rem* rem;
                result = result + cube;
                userNumber = userNumber/ 10;

            }

            userNumber = temp;

            if (result == userNumber) 
            {
                Console.WriteLine("Armstrong Number");
            }
            else 
            {
                Console.WriteLine("Not a Armstrong Number");
            }
            Console.ReadLine();
        }
    }
}
