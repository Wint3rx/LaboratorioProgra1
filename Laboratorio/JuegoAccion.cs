using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    internal class JuegoAccion : VideoJuego
    {
        public string clasificacion {  get; set; }
        public bool shooter { get; set; }
        public string Detalleshooter()
        {
            return ($"es shooter: {shooter}");
        }
        public string Clasificacion()
        {
            List<string> clasificaciones = new List<string>();

            clasificaciones.Add("E - Para todos");
            clasificaciones.Add("T - Adolescente");
            clasificaciones.Add("M - Maduro");
            clasificaciones.Add("AO - Solo adultos");

            Console.WriteLine("Clasificaciones disponibles:");
            for (int i = 0; i < clasificaciones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {clasificaciones[i]}");
            }

            Console.Write("\nIngrese el número de la clasificación que desea elegir: ");
            int indiceElegido = int.Parse(Console.ReadLine());

            if (indiceElegido >= 1 && indiceElegido <= clasificaciones.Count)
            {
                string clasificacionElegida = clasificaciones[indiceElegido - 1];
                Console.WriteLine($"\nHa elegido la clasificación: {clasificacionElegida}");
                return clasificacionElegida;
            }
            else
            {
                Console.WriteLine("\nOpción no válida. Por favor, ingrese un número válido.");
                return string.Empty;
            }
        }
    }
}
