using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace ClassesExercise_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();

            myCar.Make = "Chevy";
            myCar.Model = "Malibu";
            myCar.Year = 2017;

            myCar.MyCar();

        }
    }
}