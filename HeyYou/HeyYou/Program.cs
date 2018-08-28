using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyYou
{
    class HeyYou
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;

            System.Console.WriteLine("Hey you!");

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine(
                "Your full name is {0} {1}.", firstName, lastName);
        }
    }
}
