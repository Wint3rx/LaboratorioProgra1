using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Deportes
{
    internal class baloncesto : JuegoDeportes
    {
        public override void MedidasCancha()
        {
            Console.WriteLine("La medida de la cancha es 28m x 15m");
        }
    }
}
