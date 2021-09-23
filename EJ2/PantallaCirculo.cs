using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class PantallaCirculo
    {
        public static void PantCirculo()
        {
            Console.Clear();
            Console.Write($"    - Menu Circulo -    \n" +
                $" Ingrese el punto central del circulo: \n" +
                $" Eje X: ");
            double px = Convert.ToDouble(Console.ReadLine());
            Console.Write($" Eje Y: ");
            double py = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Ingrese el radio del circulo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\n    - Resultados -    \n" +
                $" El área es de: {FacadeFiguraGeometrica.DevolverArea(px, py, radio)}");
            Console.Write($" Y su perímetro de: {FacadeFiguraGeometrica.DevolverPerimetro(px, py, radio)}");
            Console.ReadKey();
        }
    }
}
