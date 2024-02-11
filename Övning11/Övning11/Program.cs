using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Övning11
{
    public class Bil
    {
        public double TankStorlek;
        public double KvarvarandeBränsle;
        public double Bränsleförbrukning;

        public double HurMycketKanManTanka()
        {
            return TankStorlek - KvarvarandeBränsle;
        }
        public double Räckvidd()
        {
            return KvarvarandeBränsle * Bränsleförbrukning;
        }
        public string Sammanfattning()
        {
            return $"Bilen har {KvarvarandeBränsle} Liter kvar i tanken. Om du vill tanka kan du max tanka {HurMycketKanManTanka()} Liter, annars kan du köra {Räckvidd()} km till tanken är tom.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating object car
            Bil bil = new Bil();
            bil.TankStorlek = 100;
            bil.KvarvarandeBränsle = 42;
            bil.Bränsleförbrukning = 2;
            //Writing summary for car
            Console.WriteLine(bil.Sammanfattning());    
        }
    }
}
