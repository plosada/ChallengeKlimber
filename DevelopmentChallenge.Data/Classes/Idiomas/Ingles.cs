using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public class Ingles : Idioma
    {
        public override string ListaVacia()
        {
            return "<h1>Empty list of shapes!</h1>";
        }
        public override string Titulo()
        {
            return "<h1>Shapes report</h1>";
        }
        public override string Total()
        {
            return "TOTAL:<br/>";
        }
        public override string Formas()
        {
            return "shapes";
        }
        public override string Perimetro()
        {
            return "Perimeter";
        }
        public override string Area()
        {
            return "Area";
        }
        public override string Circulo()
        {
            return "Circle";
        }

        public override string Cuadrado()
        {
            return "Square";
        }

        public override string Triangulo()
        {
            return "Triangle";
        }

        public override string Trapecio()
        {
            return "Trapeze";
        }

        public override string CuadradoPlural()
        {
            return "Squares";
        }

        public override string CirculoPlural()
        {
            return "Circles";
        }

        public override string TrianguloPlural()
        {
            return "Triangles";
        }

        public override string TrapecioPlural()
        {
            return "Trapezoids";
        }
    }
}
