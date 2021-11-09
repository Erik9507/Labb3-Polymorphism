using System;               //Erik Norell Sut21
using System.Collections.Generic;
using System.Text;

namespace Labb3_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Teckning cirkel = new Cirkel();
            Teckning rektangel = new Rektangel();
            Teckning fyrkant = new Fyrkant();

            Console.WriteLine("Area cirkel = " + cirkel.Area());
            Console.WriteLine("Area rektangel = " + rektangel.Area());
            Console.WriteLine("Area fyrkant = " + fyrkant.Area());

            

        }
    }
}
