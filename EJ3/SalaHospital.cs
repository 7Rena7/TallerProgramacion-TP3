using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class SalaHospital
    {
        private AlgoritmoBusqueda iAlgoritmo;

        public SalaHospital()
        {
            
        }

        public void setAlgoritmoBusqueda(AlgoritmoBusqueda pAlgoritmo)
        {
            this.iAlgoritmo = pAlgoritmo;
        }

        public Paciente performAlgoritmoBusqueda()
        {
            this.iAlgoritmo.EjecutarAlgoritmo();
        }

    }
}
