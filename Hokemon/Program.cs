using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to the world of Hokemon");

            hokemon HokeObject01 = new hokemon();

            HokeObject01.details();

            System.Threading.Thread.Sleep(1000); // sleep for 1 second 

            hokemon HokeObject02 = new hokemon();

            HokeObject02.details();

            HokeObject01.About();
            HokeObject02.About();

            Halor halorhoke01 = new Halor();
            halorhoke01.details;


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
