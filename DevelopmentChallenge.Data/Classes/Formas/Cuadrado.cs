using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal _lado;
        public Cuadrado(decimal lado) 
        {
            _lado = lado;
        }
        public override string Nombre(Idioma idioma)
        {
            return idioma.Cuadrado();
        }
        public override string NombrePlural(Idioma idioma)
        {
            return idioma.CuadradoPlural();
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

    }
}
