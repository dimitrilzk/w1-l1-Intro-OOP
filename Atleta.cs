using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP
{
    public class Atleta
    {
        private string _nome;
        private string _cognome;
        private int _eta;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }
        public int Eta
        {
            get { return _eta; }
            set { _eta = value; }
        }
        public string InfoAtleta()
        {
            return "Nome: " + _nome +" " + "Cognome: " + _cognome + " " + "Anni: " + _eta;
        }
    }
}
