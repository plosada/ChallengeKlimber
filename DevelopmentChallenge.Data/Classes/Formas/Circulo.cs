using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal _radio;
        public Circulo(decimal radio) 
        {
            _radio = radio;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * _radio * _radio;
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _radio * 2;
        }

        public override string Nombre(Idioma idioma)
        {
            return idioma.Circulo();
        }

        public override string NombrePlural(Idioma idioma)
        {
            return idioma.CirculoPlural();
        }
    }
}
