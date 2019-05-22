using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
   public class Sweepstakes
    {   // member variables (HAS A)
        
        Dictionary<int, Contestant> sweepstakesDict;
        Random rand;
        Contestant winner1;
        string name;
        // constructor
        public Sweepstakes(string name)
        {
            
            rand = new Random();
            this.name = name;
            sweepstakesDict = new Dictionary<int, Contestant>();
            
        }
        // member methods (CAND DO)
        public void RegisterContestant(Contestant contestant)
        {
            sweepstakesDict.Add(contestant.registrationNumber, contestant);          
        }
        public string PickWinner()
        {
            string winnerName = "";
           int winner = rand.Next(sweepstakesDict.Count);
            foreach(KeyValuePair<int, Contestant> entry in sweepstakesDict)
            {
                if (winner == entry.Key)
                {
                     winnerName += entry.Value.firstName + " " + entry.Value.lastName;
                    winner1 = entry.Value;
                }
            }
            return winnerName;

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.DisplayConstestantInfo(contestant);   
        }
    }
   
}
