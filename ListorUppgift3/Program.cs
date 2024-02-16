using System;
using System.Collections.Generic;
namespace ListorUppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> länder = new Dictionary<string, int>();

            länder["Sverige"] = 450000;
            länder["Norge"] = 385000;
            länder["Danmark"] = 43000;
            länder["Finland"] = 338000;

            Console.WriteLine("Skriv in Sverige, Norge, Danmark eller Finland så får du veta dess yta.");
            string svar = Console.ReadLine();
            Console.WriteLine(svar + "s area är " + länder[svar] + " kvkm");
        }
    }
}