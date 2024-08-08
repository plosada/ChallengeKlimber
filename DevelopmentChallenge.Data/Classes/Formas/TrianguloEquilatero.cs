using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly decimal _lado;
        public TrianguloEquilatero(decimal lado) 
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }

        public override string Nombre(Idioma idioma)
        {
            return idioma.Triangulo();
        }

        public override string NombrePlural(Idioma idioma)
        {
            return idioma.TrianguloPlural();
        }
    }
}
