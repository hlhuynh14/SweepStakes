using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesFactoryDesign
    {// member variables (HAS A)
     // constructor
     // member methods (CAND DO)
     public ISweepstakesManager DetermineManager(string answer)
     {
            ISweepstakesManager sweepstakesManager;
            switch (answer)
            {
                case "stack":
                    SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();
                    sweepstakesManager = sweepstakesStackManager;
                    break;


                case "queue":

                    SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
                    sweepstakesManager = sweepstakesQueueManager;
                    break;


                default:

                        UserInterface.DisplayWrongInput();
                    string tryagain = UserInterface.AskQueueOrStack();
                    sweepstakesManager = DetermineManager(tryagain);
                    break;
            }

            return sweepstakesManager;
     }
    }
}
