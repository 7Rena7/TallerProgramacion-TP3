using System;
using System.IO;
using System.Security.Cryptography;

namespace EJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n Ingrese el encriptador que desee utilizar (Cesar, AES, Base64, Simple): ");
            string nombreEncriptador = Console.ReadLine();
            Console.Write("\n Ingrese la cadena a encriptar: ");
            string cadenaAEncriptar = Console.ReadLine();
            string cadenaEncriptada = Facade.EncriptarFrase(nombreEncriptador, cadenaAEncriptar);
            Console.Write($"\n Cadena Encriptada: {cadenaEncriptada} \n Pulse cualquier letra para continuar");
            Console.ReadKey();
            Console.WriteLine("\n ¿Desea desencriptar la cadena? 1 por Si");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                string cadenaDesencriptada = Facade.DesencriptarFrase(nombreEncriptador, cadenaEncriptada);
                Console.WriteLine($"\n Cadena Desencriptada: {cadenaDesencriptada} \n Pulse cualquier letra para finalizar");
            }
            Console.ReadKey();
        }
    }
}
