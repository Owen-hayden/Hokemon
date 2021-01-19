using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Halor : hokemon // First team, Halor.
    {

        private string team = "Halor";


        public void about() // POLYMORPHISM  changing the method form from Hokemon about.
        {
            Console.WriteLine("I am {0} and a part of team {1}\n\n", Name, team);
        }
    }
}
