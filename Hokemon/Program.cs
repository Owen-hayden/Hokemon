using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to the world of Hokemon");

            hokemon HokeObject01 = new hokemon();

            HokeOject01.details();

            System.Threading.Thread.Sleep(1000); // sleep for 1 second 

            hokemon HokeObject02 = new hokemon();

            HokeOject02.details();


            Battle_Arena firstArena = new Battle_Arena(); // creating the first Object Battle Arena 

        }
    }
}
