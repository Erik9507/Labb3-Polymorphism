using System;               //Erik Norell Sut21
using System.Collections.Generic;
using System.Text;

namespace Labb3_Polymorphism
{
    public class Fyrkant : Teckning    //child class
    {
        public double Sida { set; get; }

        public Fyrkant()
        {
            Sida = 20;
            
        }
        public override double Area()
        {
            return Sida * Sida;
        }


    }
}
