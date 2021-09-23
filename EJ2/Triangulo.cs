using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Triangulo : FiguraGeometrica
    {
        private Punto iPunto1, iPunto2, iPunto3;

        public Triangulo (Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;
        }

        public Punto Punto1
        {
            get { return iPunto1; }
            private set { }
        }
        public Punto Punto2
        {
            get { return iPunto2; }
            private set { }
        }

        public Punto Punto3
        {
            get { return iPunto3; }
            private set { }
        }

        public override double CalcularPerimetro()
        {
            return (this.iPunto1.CalcularDistanciaDesde(this.iPunto2)) + (this.iPunto2.CalcularDistanciaDesde(this.iPunto3))
                + (this.iPunto3.CalcularDistanciaDesde(this.iPunto1));
        }

        public override double CalcularArea()
        {
            //La fórmula de Herón halla el área de un triángulo del cual se conocen todos sus lados.
            //El área se calcula a partir del semiperímetro del triángulo s y de la longitud de los lados (a, b y c).
            double semiperim = (this.CalcularPerimetro()) / 2;
            double a = this.iPunto1.CalcularDistanciaDesde(this.iPunto2);
            double b = this.iPunto2.CalcularDistanciaDesde(this.iPunto3);
            double c = this.iPunto3.CalcularDistanciaDesde(this.iPunto1);
            return Math.Sqrt(semiperim * (semiperim - a) * (semiperim - b) * (semiperim - c));
        }
    }
}
