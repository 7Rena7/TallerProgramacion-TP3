using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    abstract class Encriptador : IEncriptador
    {
        private string iNombre;

        public Encriptador(string pNombre)
        {
            this.iNombre = pNombre;
        }

        public string Nombre
        {
            get { return this.iNombre; }
            private set { }
        }

        public abstract string Encriptar(string pCadena);

        public abstract string Desencriptar(string pCadena);
    }
}
