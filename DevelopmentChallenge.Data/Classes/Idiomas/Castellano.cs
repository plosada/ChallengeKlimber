using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public class Castellano : Idioma
    {
        public override string ListaVacia()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }
        public override string Titulo()
        {
            return "<h1>Reporte de Formas</h1>";
        }
        public override string Total()
        {
            return "TOTAL:<br/>";
        }
        public override string Formas()
        {
            return "formas";
        }
        public override string Perimetro()
        {
            return "Perimetro";
        }
        public override string Area()
        {
            return "Area";
        }

        public override string Circulo()
        {
            return "Círculo";
        }

        public override string Cuadrado()
        {
            return "Cuadrado";
        }

        public override string Triangulo()
        {
            return "Triángulo";
        }

        public override string Trapecio()
        {
            return "Trapecio";
        }

        public override string CuadradoPlural()
        {
            return "Cuadrados";
        }

        public override string CirculoPlural()
        {
            return "Círculos";
        }

        public override string TrianguloPlural()
        {
            return "Triángulos";
        }

        public override string TrapecioPlural()
        {
            return "Trapecios";
        }
        //public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string nombreForma)
        //{
        //    return $"{cantidad} {nombreForma} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
        //}
    }
}
