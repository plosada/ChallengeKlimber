/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using Enums = DevelopmentChallenge.Data.Classes.Enums;
using DevelopmentChallenge.Data.Classes.Idiomas;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            Idioma idiomaObj;

            switch (idioma)
            { 
                case (int)Enums.Idioma.Castellano:
                    idiomaObj = new Castellano(); break;
                case (int)Enums.Idioma.Ingles:
                    idiomaObj = new Ingles(); break;
                case (int)Enums.Idioma.Italiano:
                    idiomaObj = new Italiano(); break;
                default:
                    idiomaObj = new Ingles(); break;
            }

            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(idiomaObj.ListaVacia());
            }
            else
            {
                int cantidadTotal = 0;
                decimal areaTotal = 0, perimetroTotal = 0;

                // HEADER
                sb.Append(idiomaObj.Titulo());

                var tiposFormasGeometricas = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(FormaGeometrica)));

                foreach (var tipo in tiposFormasGeometricas)
                {
                    int cantidad = formas.Count(x => x.GetType() == tipo);
                    decimal area = formas.Where(x => x.GetType() == tipo).Sum(x => x.CalcularArea());
                    decimal perimetro = formas.Where(x => x.GetType() == tipo).Sum(x => x.CalcularPerimetro());

                    if (cantidad > 0)
                    {
                        var forma = formas.First(x => x.GetType() == tipo);
                        cantidadTotal += cantidad;
                        areaTotal += area;
                        perimetroTotal += perimetro;

                        var nombreForma = cantidad > 1 ? forma.NombrePlural(idiomaObj) : forma.Nombre(idiomaObj);
                        sb.Append($"{cantidad} {nombreForma} | {idiomaObj.Area()} {area:#.##} | {idiomaObj.Perimetro()} {perimetro:#.##} <br/>");
                    }
                }

                // FOOTER
                sb.Append(idiomaObj.Total());
                sb.Append(cantidadTotal + " " + idiomaObj.Formas() + " ");
                sb.Append($"{idiomaObj.Perimetro()} {perimetroTotal.ToString("#.##")} ");
                sb.Append($"{idiomaObj.Area()} {areaTotal.ToString("#.##")}");
            }

            return sb.ToString();
        }

        public abstract string Nombre(Idioma idioma);
        public abstract string NombrePlural(Idioma idioma);
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }
}
