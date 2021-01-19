using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Halor : hokemon
    {

        private string team = "Halor";
    
    }
    public void about()
    {
        Console.WriteLine("I am {0} and a part of team {1}\n\n", Name, team);
    }
}
