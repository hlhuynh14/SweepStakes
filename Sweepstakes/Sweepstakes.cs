using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
   public class Sweepstakes
    {   // member variables (HAS A)
        
        Dictionary<int, Contestant> contestantDictionary;
        Random random;
        int winner;
       public string name;
       public int givenID;
        
        // constructor
        public Sweepstakes(string name)
        {
            
            random = new Random();
            this.name = name;
            contestantDictionary = new Dictionary<int, Contestant>();
            
        }
        // member methods (CAND DO)
        public void RegisterContestant(Contestant contestant)
        {
            contestantDictionary.Add(contestant.registrationNumber, contestant);
            givenID++;
        }
        public string PickWinner()
        {
            string winnerName = "";
           int winnerRegistrationNumber = random.Next(givenID + 1);
            foreach(KeyValuePair<int, Contestant> entry in contestantDictionary)
            {
                if (winnerRegistrationNumber == entry.Key)
                {
                     winnerName += entry.Value.firstName + " " + entry.Value.lastName;
                    winner = entry.Key;
                }
            }
            return winnerName;

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayConstestantInfo(contestant);   
        }
        public void NotifyEachPerson()
        {
            foreach (KeyValuePair<int, Contestant> entry in contestantDictionary)
            {
                if (winner == entry.Key)
                {
                    UserInterface.NotifyWinner(entry.Value);
                }
                else
                {
                    UserInterface.NotifyLoser( entry.Value);
                }
            }
        }
    }
   
}
