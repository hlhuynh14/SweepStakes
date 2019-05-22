using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        // member variables (HAS A)
        ISweepstakesManager sweepstakesManager;
        
        int howManySweepstakes;
        // constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            sweepstakesManager = manager;
        }

        // member methods (CAND DO)
        public void StartSweepstakes()
        {
            AddSweepstakes(); 
            
        }
        public void EndSweepstakes()
        {
            PickWinners();
        }
        public void AddSweepstakes()
        {
             howManySweepstakes = UserInterface.AskHowManySweepstakes();
            for (int i = 0; i < howManySweepstakes; i++)
            {
                AddContestants();
            }
        }
        
        public Sweepstakes CreateSweepstakes()
        {
            string name = UserInterface.AskSweepstakesName();
            Sweepstakes sweepstakes = new Sweepstakes(name);
            
            return sweepstakes;
        }
        public Contestant CreateContestant()
        {
            Contestant contestant = new Contestant()
            {
                firstName = UserInterface.AskFirstName(),
                lastName = UserInterface.AskLastName(),
                email = UserInterface.AskEmail()
                
            };
            
            return contestant;
        }
        public void AddContestants()
        {
            Sweepstakes sweepstakes = CreateSweepstakes();
            int howManyContestant = UserInterface.AskHowManyContestants();
            for (int j = 0; j < howManyContestant; j++)
            {
                Contestant newContestant = CreateContestant();
                newContestant.registrationNumber = sweepstakes.givenID;
                sweepstakes.givenID++;
                sweepstakes.RegisterContestant(newContestant);
            }

            sweepstakesManager.InsertSweepstakes(sweepstakes);
        }
        public void PickWinners()
        {
            for (int i = 0; i < howManySweepstakes; i++)
            {
                Sweepstakes sweepstakes = sweepstakesManager.GetSweepstakes();
                string winner = sweepstakes.PickWinner();
                UserInterface.DisplayWinners(sweepstakes.name, winner);
                
            }
            
        }
        public void NotifyContestants()
        {
            for (int i = 0; i < howManySweepstakes; i++)
            {
                Sweepstakes sweepstakes = sweepstakesManager.GetSweepstakes();
                sweepstakes.NotifyEachPerson();

            }
        }
    }
}

