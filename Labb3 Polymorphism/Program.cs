using System;               //Erik Norell Sut21
using System.Collections.Generic;
using System.Text;

namespace Labb3_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Cirkel cirkel = new Cirkel();
            Rektangel rektangel = new Rektangel();
            Fyrkant fyrkant = new Fyrkant();

            Console.WriteLine("Cirkel med en radie på "+ cirkel.Radie + " har en area som är " + cirkel.Area());
            Console.WriteLine("Rektangel med en bas som är " + rektangel.Bas + " och en höjd som är " + rektangel.Höjd + " har en area som är " + rektangel.Area());
            Console.WriteLine("Fyrkant med en sida som är " + fyrkant.Sida + " har en area som är " + fyrkant.Area());


            

            

        }
    }
    

}
