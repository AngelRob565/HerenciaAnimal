using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAnimal
{
    internal class Perro : Animal
    {
        
        private string _strRaza;
        private bool _blnEstaVacunado;
        #region propiedades
        public string Raza
        {
            get { return _strRaza; }
            set { _strRaza = value; }
        }
       

        public bool EstaVacunado
        {
            get { return _blnEstaVacunado; }
            set => _blnEstaVacunado = value;
        }
        #endregion

        #region constructor
        public Perro(string strNombre, int intEdad, string strRaza, bool blnEstaVacunado) : base(strNombre, intEdad)
        {
            Raza = strRaza;
            EstaVacunado = blnEstaVacunado;
        }
        #endregion

        #region funciones
        public override string HacerSonido()
        {
            return base.HacerSonido() + ", Woof";
        }
        #endregion
        public override string ToString()
        {
            return $@"
Perro: 
Nombre: {Nombre}
Edad:{Edad}
Raza:{Raza}
Vacunado: {(EstaVacunado == true ? "si" : "no")}
Sonido:
{HacerSonido()}";
        }
    }
}
