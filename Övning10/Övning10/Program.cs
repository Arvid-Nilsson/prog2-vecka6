using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Övning10
{
    public class person
    {
        public string förnamn;
        public string efternamn;
        public int ålder;
        public string intresse;

        public string sammanfattning()
        {
            return $"Hej mitt namn är {förnamn} {efternamn}. Jag är {ålder} år gammal och gillar att {intresse}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person Person1 = new person();
            Person1.förnamn = "Arvid";
            Person1.efternamn = "Nilsson";
            Person1.ålder = 18;
            Person1.intresse = "vandra";

            person Person2 = new person();
            Person2.förnamn = "Daniel";
            Person2.efternamn = "Nilsson";
            Person2.ålder = 49;
            Person2.intresse = "åka skidor";

            Console.WriteLine(Person1.sammanfattning());
            Console.WriteLine(Person2.sammanfattning());

        }
    }
}
