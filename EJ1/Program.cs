using System;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veterinaria unaVet = new Veterinaria();
            Perro unPerro = new Perro();
            Gato unGato = new Gato();
            Vaca unaVaca = new Vaca();
            Grillo unGrillo = new Grillo();
            Animal[] arrayAnimales = { unPerro, unGato, unaVaca, unGrillo };
            unaVet.AceptarAnimales(arrayAnimales);
            Console.ReadKey();
        }
    }
}
