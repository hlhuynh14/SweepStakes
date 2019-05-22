using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {// member variables (HAS A)
        Stack<Sweepstakes> stack;
        // constructor
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }
        // member methods (CAND DO)
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = stack.Pop();
            return sweepstakes;
        }
    }
}
