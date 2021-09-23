using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class FacadeFiguraGeometrica
    {
        public static double DevolverArea(double pX, double pY, double pRadio)
        {
            Circulo circ = new Circulo(pX, pY, pRadio);
            return Math.Round(circ.CalcularArea(), 2);
        }

        public static double DevolverArea(double px1, double py1, double px2, double py2, double px3, double py3)
        {
            Punto p1 = new Punto(px1, py2);
            Punto p2 = new Punto(px2, py2);
            Punto p3 = new Punto(px3, py3);
            Triangulo tri = new Triangulo(p1, p2, p3);
            return Math.Round(tri.CalcularArea(), 2);
        }

        public static double DevolverPerimetro(double px, double py, double radio)
        {
            Circulo circ = new Circulo(px, py, radio);
            return Math.Round(circ.CalcularPerimetro(), 2);
        }

        public static double DevolverPerimetro(double px1, double py1, double px2, double py2, double px3, double py3)
        {
            Punto p1 = new Punto(px1, py2);
            Punto p2 = new Punto(px2, py2);
            Punto p3 = new Punto(px3, py3);
            Triangulo tri = new Triangulo(p1, p2, p3);
            return Math.Round(tri.CalcularPerimetro(), 2);
        }
    }
}
