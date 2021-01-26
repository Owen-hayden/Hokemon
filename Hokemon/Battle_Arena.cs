using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Battle_Arena // The battle arean structure for the Hokemon.
    {

        public Battle_Arena() // CONSTRUCTOR meathord - same as Class
        {

            Console.WriteLine("***Welcome to the Battle Arena***");
        }
        public void RequestAChallanger(hokemon contender)
        {
            Console.WriteLine("{0}: says 'I want to battle...Anyone ready?", contender.Name);
        }
        public void AcceptingTheBattle(hokemon contender01, hokemon contender02)
        {
            Console.WriteLine("{0}: 'I accept the challange to fight {1}' ", contender02.Name, contender01.Name);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{1}: 'Great lets start the battle!!! {0}' ", contender02.Name, contender01.Name); // Names and challanges 
        }

        public void Battle(hokemon Attacker, hokemon Defender) // Health and attack in the fight 
        {

            hokemon tempHoke; // Declaring a temporary Hokemon to switch attacker and defender

            while (Convert.ToInt32(Attacker.Health) >= 0 || Convert.ToInt32(Defender.Health) >= 0)
            {
                for (int i = 0; i < 2; i++)
                { int attackValue = Attacker.attackCalculator();
                    int defenceValue = Defender.defenceCalculator();
                    int round = 0;

                    // Attacking

                    Console.WriteLine("{0}: Attacks with value {1} ", Attacker.Name, attackValue);

                    // Defending

                    Console.WriteLine("{0}: Defends with value {1} ", Defender.Name, defenceValue);

                    Console.WriteLine("{0}: Health = {1} ", Defender.Name, Defender.Health);

                    // Impact on defenders health

                    Defender.Health = (Defender.Health + defenceValue) - attackValue;

                    Console.WriteLine("!!!Change in Battle!!!");
                    System.Threading.Thread.Sleep(1000);
                    

                }
            }

            Console.WriteLine("\n****\nSwitch turns: Deffender becomes Attacker...\n****\n"); // switching sides 
            tempHoke = Attacker;
            Attacker = Defender;
            Defender = tempHoke;

            if (Attacker.Health > Defender.Health)
            {
                Console.WriteLine("{0}: WINS", Attacker.Name);
            }
            else
            {
                Console.WriteLine("{0}: WINS", Defender.Name);
            }
        
        
        
        
        } 

    }
}