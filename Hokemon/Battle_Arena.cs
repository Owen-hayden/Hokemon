using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Battle_Arena
    {

        public Battle_Arena() // CONSTRUCTOR meathord - same as Class
        {

            Console.WriteLine("***Welcome to the Battle Arena***")
        }
        public void RequestAChallanger(hokemon contender);
        {
         Console.Writeline("{0}: says 'I want to battle...Anyone ready?", contender.name);
        }

    }   
}
