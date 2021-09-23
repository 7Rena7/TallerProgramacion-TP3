using System;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            PantallaPrincipal();
        }
        static void PantallaPrincipal()
        {
            string op;
            Boolean exit = true;
            while (exit)
            {
                Console.Clear();
                Console.Write($"    - Menú Principal -    \n" +
                $" 1- Distancia entre dos puntos \n" +
                $" 2- Área y perímetro de un círculo \n" +
                $" 3- Área y perímetro de un triángulo \n" +
                $" 0- Salir \n" +
                $"\n" +
                $" Ingrese un valor: ");
                op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        PantallaPunto.PantPunto(); 
                        break;

                    case "2":
                        PantallaCirculo.PantCirculo();
                        break; 

                    case "3":
                        PantallaTriangulo.PantTriangulo();
                        break;  

                    case "0":
                        return; 

                    default:
                        Console.WriteLine("Valor ingresado no valido.");
                        Console.ReadKey();
                        break; 
                }

            }
        }
    }
}
