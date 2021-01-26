using System;

namespace Hokemon
{
    class Program // Main program for the running of the Hokemon. 
    {
        static void Main(string[] args) // New hokemon 
        {
            Console.WriteLine("Hello welcome to the world of Hokemon");

            hokemon HokeObject01 = new hokemon();

            HokeObject01.details();

            System.Threading.Thread.Sleep(1000); // Sleep for 1 second.

            hokemon HokeObject02 = new hokemon(); // New HokeObject.

            HokeObject02.details(); // HokeObject02 details/stats.

            HokeObject01.about();
            HokeObject02.about();

            Halor halorhoke01 = new Halor(); // New Halor Hoke.
            halorhoke01.details();


            hokemon hokeobject03 = new hokemon();

            Halor halorhoke02 = new Halor();

            hokeobject03.about();
            halorhoke02.about();

            Battle_Arena firstArena = new Battle_Arena(); // creating the first Object Battle Arena 

            firstArena.RequestAChallanger(HokeObject01);

            firstArena.AcceptingTheBattle(HokeObject01, HokeObject02);

        }
    }
}
