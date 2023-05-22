using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise_
{
    public class Car
   {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void MyCar()
        {
            Console.WriteLine($"My car is a {Make} {Model} and the year is {Year}.");
        }
    }
    
}
