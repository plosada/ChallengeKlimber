﻿using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using Enums = DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Formas;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), (int)Enums.Idioma.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), (int)Enums.Idioma.Ingles));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Lista vacaia de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), (int)Enums.Idioma.Italiano));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, (int)Enums.Idioma.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, (int)Enums.Idioma.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new Trapecio(5,2,3,3.2m,3.2m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, (int)Enums.Idioma.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Circles | Area 52.03 | Perimeter 36.13 <br/>1 Trapeze | Area 10.5 | Perimeter 13.4 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>2 Squares | Area 29 | Perimeter 28 <br/>TOTAL:<br/>8 shapes Perimeter 129.13 Area 141.17",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new Trapecio(5,2,3,3.2m,3.2m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, (int)Enums.Idioma.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Círculos | Area 52.03 | Perimetro 36.13 <br/>1 Trapecio | Area 10.5 | Perimetro 13.4 <br/>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>2 Cuadrados | Area 29 | Perimetro 28 <br/>TOTAL:<br/>8 formas Perimetro 129.13 Area 141.17",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new Trapecio(5,2,3,3.2m,3.2m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, (int)Enums.Idioma.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto sulle forme</h1>2 Cerchi | Zona 52.03 | Perimetro 36.13 <br/>1 Trapezio | Zona 10.5 | Perimetro 13.4 <br/>3 Triangoli | Zona 49.64 | Perimetro 51.6 <br/>2 Piazze | Zona 29 | Perimetro 28 <br/>TOTALE:<br/>8 Forme Perimetro 129.13 Zona 141.17",
                resumen);
        }
    }
}
