using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_un_Hospital
{
    class Cita 
    {
        public int IdCita { get; set; }
        public DateTime FechaHora { get; set; }
        public string Paciente { get; set; }
        public string Medico { get; set; }
        public string Motivo { get; set; }
        public enum EstadoCita { Pendiente, Realizada, Cancelada }

        public Cita (int idCita, DateTime fechaHora, string paciente, string medico, string motivo)
        {
            IdCita = idCita;
            FechaHora = fechaHora;
            Paciente = paciente;
            Medico = medico;
            Motivo = motivo;
        }

        public override string ToString()
        {
            return "IdCita: " + IdCita + " FechaHora: " + FechaHora + " Paciente: " + Paciente + " Medico: " + Medico + " Motivo: " + Motivo;
        }
    }
}
