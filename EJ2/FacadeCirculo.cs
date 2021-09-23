using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class FacadeCirculo
    {
        public static double DevolverAreaCirculo(double px, double py, double radio)
        {
            Circulo circ = new Circulo(px, py, radio);

            return Math.Round(circ.CalcularArea(), 2);
        }

        public static double DevolverPerimetroCirculo(double px, double py, double radio)
        {
            Circulo circ = new Circulo(px, py, radio);

            return Math.Round(circ.CalcularPerimetro(), 2);
        }
    }
}
