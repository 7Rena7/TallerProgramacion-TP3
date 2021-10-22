using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class EncriptadorBase64 : Encriptador
    {
        //private int iClave;

        public EncriptadorBase64()
            : base("Cesar")
        {
            //this.iClave = pClave;
        }

        public override string Encriptar(string pCadena)
        {
            byte[] byt = System.Text.Encoding.UTF8.GetBytes(pCadena);
            return Convert.ToBase64String(byt);
        }

        public override string Desencriptar(string pCadena)
        {
            byte[] b = Convert.FromBase64String(pCadena);
            return System.Text.Encoding.UTF8.GetString(b);
        }


    }
}
