using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Circulo : FiguraGeometrica
    {
        private double iRadio;
        private Punto iCentro;

        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }

        public Circulo(double pX, double pY, double pRadio)
        {
            this.iCentro = new Punto(pX, pY);
            this.iRadio = pRadio;
        }

        public Punto Centro
        {
            get { return iCentro; }
            private set { }
        }

        public double Radio
        {
            get { return iRadio; }
            private set { }
        }

        public override double CalcularArea()
        {
            return Math.PI * (Math.Pow(this.iRadio, 2));
        }

        public override double CalcularPerimetro()
        {
            return Math.PI * 2 * this.iRadio;
        }
    }
}
