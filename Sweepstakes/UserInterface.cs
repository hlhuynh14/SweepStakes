using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {// member variables (HAS A)
     // constructor
     // member methods (CAND DO)
     public static string AskFirstName()
     {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine().ToString();
            return firstName;
     }
     public static string AskLastName()
     {
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine().ToString();
            return lastName;
     }
        public static string AskEmail()
        {
            Console.WriteLine("What is your email?");
            string email = Console.ReadLine().ToString();
            return email;
        }
        public static void DisplayConstestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: " + contestant.firstName);
            Console.WriteLine($"Last Name: " + contestant.lastName);
            Console.WriteLine($"Email: " + contestant.email);
        }
    }
}
