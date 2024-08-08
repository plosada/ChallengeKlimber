using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public class Italiano : Idioma
    {
        public override string ListaVacia()
        {
            return "<h1>Lista vacaia de formas!</h1>";
        }
        public override string Titulo()
        {
            return "<h1>Rapporto sulle forme</h1>";
        }
        public override string Circulo()
        {
            return "Cerchio";
        }

        public override string Cuadrado()
        {
            return "Piazza";
        }

        public override string Triangulo()
        {
            return "Triangolo";
        }

        public override string Trapecio()
        {
            return "Trapezio";
        }

        public override string CuadradoPlural()
        {
            return "Piazze";
        }

        public override string CirculoPlural()
        {
            return "Cerchi";
        }

        public override string TrianguloPlural()
        {
            return "Triangoli";
        }

        public override string TrapecioPlural()
        {
            return "Trapezi";
        }

        public override string Total()
        {
            return "TOTALE:<br/>";
        }

        public override string Formas()
        {
            return "Forme";
        }

        public override string Perimetro()
        {
            return "Perimetro";
        }

        public override string Area()
        {
            return "Zona";
        }
    }
}
