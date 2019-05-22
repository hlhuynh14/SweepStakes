using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            SweepstakesFactoryDesign sweepstakesFactoryDesign = new SweepstakesFactoryDesign();
            string answer = UserInterface.AskQueueOrStack();
            ISweepstakesManager sweepstakesManager = sweepstakesFactoryDesign.DetermineManager(answer);
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakesManager);
            marketingFirm.StartSweepstakes();
            marketingFirm.EndSweepstakes();
            
            Console.ReadLine();

            

        }
    }
}
