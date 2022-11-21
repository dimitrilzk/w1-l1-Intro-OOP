using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta a1 = new Atleta();
            a1.Nome = "Mario";
            a1.Cognome = "Rossi";
            a1.Eta = 25;
            a1.InfoAtleta();
            //Console.Write(a1.InfoAtleta());
            Dipendente d1 = new Dipendente();
            d1.Stipendio = 2300;
            //Console.Write(d1.AumentoStipendio(500));
            Console.ReadLine();
        }
    }
}
