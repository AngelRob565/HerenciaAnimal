using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAnimal
{
    internal class Animal

    {
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        private int _intEdad;
        public int Edad
        {
            get { return _intEdad; }
            set { _intEdad = value; }
        }
        public virtual string HacerSonido()
            { return  "Sonido propio del animal"; }
    }
}
