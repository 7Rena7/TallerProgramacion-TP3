using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class Turno
    {
        private DateTime iFechaHoraGenerado;
        private DateTime? iFechaHoraFinalizado;
        private int iPrioridad;
        private Paciente iPaciente;

        public Turno (DateTime pFechaHoraGenerado, int pPrioridad, Paciente pPaciente)
        {
            this.iFechaHoraGenerado = pFechaHoraGenerado;
            this.iFechaHoraFinalizado = null;
            this.iPrioridad = pPrioridad;
            this.iPaciente = pPaciente;
        }

        public DateTime FechaHoraGenerado
        {
            get { return this.iFechaHoraGenerado; }
            private set { }
        }

        public DateTime? FechaHoraFinalizado
        {
            get { return this.iFechaHoraFinalizado; }
            set { this.iFechaHoraFinalizado = value; }
        }

        public int Prioridad
        {
            get { return this.iPrioridad; }
            private set { }
        }

        public Paciente Paciente
        {
            get { return this.iPaciente; }
            private set { }
        }
    }
}
