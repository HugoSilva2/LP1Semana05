using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            //define both cronos
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            //Start crono1
            crono1.Start();
            
            //Stop crono1 after 0.6 seconds
            Thread.Sleep(600);

            //Start crono2
            crono2.Start();

            //Stop crono2 after 0.2 seconds
            Thread.Sleep(200);

            //Stop Both cronos
            crono1.Stop();
            crono2.Stop();

            //Get the both times in seconds
            float time1 = crono1.ElapsedMilliseconds/1000f;
            float time2 = crono2.ElapsedMilliseconds/1000f;

            //Print
            Console.WriteLine($"Crono1: {time1}; Crono2: {time2}.");
        }
    }
}

