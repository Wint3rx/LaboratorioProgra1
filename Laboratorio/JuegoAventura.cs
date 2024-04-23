using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    internal class JuegoAventura : VideoJuego
    {
        public string TipoDeAventura { get; set; }
        public bool MundoAbierto { get; set; }
        public string TiposdeAventura()
        {
            List<string> aventuras = new List<string>();

            aventuras.Add("Mundo abierto");
            aventuras.Add("Lineal");
            aventuras.Add("Plataformero");
            aventuras.Add("Medieval (Dark Souls)");

            Console.WriteLine("Tipos de aventura disponibles:");
            for (int i = 0; i < aventuras.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {aventuras[i]}");
            }

            Console.Write("\nIngrese el número del tipo de aventura que desea elegir: ");
            int indiceElegido = int.Parse(Console.ReadLine());

            if (indiceElegido >= 1 && indiceElegido <= aventuras.Count)
            {
                string aventuraElegida = aventuras[indiceElegido - 1];
                Console.WriteLine($"\nHa elegido el tipo de aventura: {aventuraElegida}");
                return aventuraElegida;
            }
            else
            {
                Console.WriteLine("\nOpción no válida. Por favor, ingrese un número válido.");
                return string.Empty;
            }
        }
        public string mostrardetallesAventura()
        {
            return ($"Que tipo de aventura es: {TipoDeAventura} es mundo abierto: {MundoAbierto}");
        }
    }
}
