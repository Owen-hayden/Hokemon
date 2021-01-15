using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Battle_Arena
    {

        public Battle_Arena() // CONSTRUCTOR meathord - same as Class
        {

            Console.WriteLine("***Welcome to the Battle Arena***");
        }
        public void RequestAChallanger(hokemon contender)
        {
         Console.WriteLine("{0}: says 'I want to battle...Anyone ready?", contender.Name);
        }
        public void AcceptingTheBattle(hokemon contender01, hokemon contender02 )
        {
            Console.WriteLine("{0}: 'I accept the challange to fight {1}' ", contender02.Name, contender01.Name);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{1}: 'Great lets start the battle!!! {0}' ", contender02.Name, contender01.Name);
        }
    }   
}
