using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome in simply calculator");
            
            Calculate.InputMethod();

            bool turnOn = true;
            while (turnOn)
            {
                turnOn = Calculate.InputMethod();
            }
        }
    }
}
