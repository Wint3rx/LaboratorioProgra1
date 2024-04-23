using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Deportes
{
    internal class futbol : JuegoDeportes
    {
        public override void MedidasCancha()
        {
            Console.WriteLine("La medida de la cancha es 45m x 90m");
        }
    }
}
