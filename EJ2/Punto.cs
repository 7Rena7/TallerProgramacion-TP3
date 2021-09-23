using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Punto
    {
        private double iX, iY;

        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }

        public double X
        {
            get { return iX; }
            private set { }
        }

        public double Y
        {
            get { return iY; }
            private set { }
        }

        public double CalcularDistanciaDesde(Punto pPunto)
        {
            double xDif = this.iX - pPunto.iX;
            double yDif = this.iY - pPunto.iY;
            return Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
        }
    }
}
