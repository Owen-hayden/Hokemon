using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Hinstinct : hokemon // Second team, Hinstinct. 
    {
        
       private string team = "Hinstinct ";

     
       public void about() // POLYMORPHISM  changing the method form from Hokemon about.
        {
            Console.WriteLine("I am {0} and a part of team {1}\n\n", Name, team);
       }
    }
}
