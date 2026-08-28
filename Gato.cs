using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAnimal
{
    internal class Gato : Animal
    {
        private string _strColor;
        public string Color
        {
            get { return _strColor; }
            set { _strColor = value; }
        }
        private bool _blnEstaDomesticado;

        public bool EstaDomesticado
        {
            get { return _blnEstaDomesticado; }
            set => _blnEstaDomesticado = value;
        }
        public Gato(string strNombre, int intEdad, string strColor, bool blnEstaDomesticado) : base(strNombre, intEdad)
        {
           Color = strColor;
            EstaDomesticado = blnEstaDomesticado;
        }

    
        public override string HacerSonido()
        {
            return base.HacerSonido() + ", Meow";
        }

        public override string ToString()
        {
            return $@"
Gato:
Nombre:{Nombre}
Edad:{Edad}
Color: {Color}
Doméstico: {(EstaDomesticado == true ? "si" : "no")}
Sonido:{HacerSonido()}";
        }

    }
}
