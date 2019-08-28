using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0701A2ImperialDistance
{
    class Program
    {
        static int MetricToIdiotic(int metric)
        {
            return ((int)((float)metric / 1.609344));
        }

        static void Main(string[] args)
        {
            int metricdistance;

            Console.Write("Bitte geben Sie eine Entfernung in vernünftigen Einheiten an: ");
            if (int.TryParse(Console.ReadLine(), out metricdistance))
                Console.WriteLine("Das entspricht etwa {0} komischen Einheiten!", MetricToIdiotic(metricdistance));
            Console.WriteLine();
        }
    }
}
