using System;
using algoexpert_tv.Algorithms.AlgoExpert;
using algoexpert_tv.Workers;

namespace algoexpert_tv
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Hostess greets with something like hello
            var hostess = new Hostess("C# Bitches");
            hostess.OpenGreeting();

            var x = new TwoNumberSum();

            x.readFile();
           
            // It shows a list of filenames in the algoexpert folder in a list number format

            // It asks you to choose a number(algo) to display

            // It prints the algorithm to the console or err

            // It asks if you want to reset
        }
    }
}
