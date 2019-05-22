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
        // constructor
        public MarketingFirm(ISweepstakesManager manager)
        {

        }
        // member methods (CAND DO)
        Contestant contestant = new Contestant()
        {
            firstName = UserInterface.AskFirstName(),
            lastName = UserInterface.AskLastName(),
            email = UserInterface.AskEmail(),
            registrationNumber = 0
        };
    }
}

