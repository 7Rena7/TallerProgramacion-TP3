using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class EncriptadorCesar : Encriptador
    {
        private int iDesplazamiento;

        public EncriptadorCesar(int pDesplazamiento)
            : base ("Cesar")
        {
            this.iDesplazamiento = pDesplazamiento;
        }

        public override string Encriptar(string pCadena)
        {
            string output = string.Empty;

            foreach (char caracter in pCadena)
                output += Cipher(caracter, this.iDesplazamiento);

            return output;
        }

        public override string Desencriptar(string pCadena)
        {
            string output = string.Empty;

            foreach (char caracter in pCadena)
                output += Cipher(caracter, 26 - this.iDesplazamiento);

            return output;
        }

        private char Cipher(char caracter, int pDesplazamiento)
        {
            if (!char.IsLetter(caracter))
            {
                return caracter;
            }

            char d;

            if (char.IsUpper(caracter))
            {
                d = 'A';
            }
            else
            {
                d = 'a';
            }

            return (char) ((((caracter + pDesplazamiento) - d) % 26) + d);
        }
    }
}
