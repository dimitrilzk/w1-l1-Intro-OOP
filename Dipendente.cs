using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP
{
    internal class Dipendente
    {
        private string _nome;
        private string _cognome;
        private int _stipendio;
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
        public int Stipendio
        {
            get { return _stipendio; }
            set { _stipendio = value; }
        }
        public int AumentoStipendio(int bonus)
        {
            return bonus += _stipendio;
        }
    }
}
