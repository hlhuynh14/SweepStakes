using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
        public static string AskQueueOrStack()
        {
            Console.WriteLine("Would you like to use a stack or queue for your sweepstakes?");
            string answer = Console.ReadLine().ToString();

            return answer;
        }
        public static void DisplayWrongInput()
        {
            Console.WriteLine(" You have given a wrong input.");
        }
        public static string AskSweepstakesName()
        {
            Console.WriteLine("Please enter a name or number to identify this sweepstakes.");
            string answer = Console.ReadLine().ToString();
            return answer;
        }
        public static int AskHowManySweepstakes()
        {
            int number;
            Console.WriteLine("How many sweepstakes will there be, please give a number!");
           bool answer = Int32.TryParse(Console.ReadLine(), out number);

            if (answer == false)
            {
                number = UserInterface.AskHowManySweepstakes();
            }
            else
            {
                return number;
            }
            return number;
        }
        public static int AskHowManyContestants()
        {
            int number;
            Console.WriteLine("How many contestant will there be, please give a number!");
            bool answer = Int32.TryParse(Console.ReadLine(), out number);

            if (answer == false)
            {
                number = UserInterface.AskHowManySweepstakes();
            }
            else
            {
                return number;
            }
            return number;
        }
        public static void DisplayWinners(string sweepstakesName, string winner)
        {
            Console.WriteLine($"The winner of {sweepstakesName} is {winner}!");
            Console.ReadLine();
        }
        public static void NotifyWinner(Contestant contestant)
        {
            SmtpClient s = new SmtpClient();
             s.Send("MarketingFirm", contestant.email,"Congratulations", $"Congratulations {contestant.firstName}, you are the father.");
            
        }
        public static void NotifyLoser(Contestant contestant)
        {
            SmtpClient s = new SmtpClient();
            s.Send("MarketingFirm", contestant.email, "Sorry", $"Sorry{contestant.firstName}, you are not the father.");
        }


    }
}

