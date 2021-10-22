using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class Paciente
    {
        private string iNombre;
        private string iApellido;
        private string iDNI;

        public Paciente(string pNombre, string pApellido, string pDNI)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iDNI = pDNI;
        }

        public string Nombre
        {
            get { return this.iNombre; }
            private set { }
        }

        public string Apellido
        {
            get { return this.iApellido; }
            private set { }
        }

        public string DNI
        {
            get { return this.iDNI; }
            private set { }
        }
    }
}
