using System;

namespace Gestión_de_un_Hospital
{
    class Cita
    {
        public int IdCita { get; set; }
        public DateTime FechaHora { get; set; }
        public string Paciente { get; set; }
        public string Medico { get; set; }
        public string Motivo { get; set; }
        public EstadoCita Estado { get; set; }

        public enum EstadoCita { Pendiente, Realizada, Cancelada }

        public Cita(int idCita, DateTime fechaHora, string paciente, string medico, string motivo)
        {
            IdCita = idCita;
            FechaHora = fechaHora;
            Paciente = paciente;
            Medico = medico;
            Motivo = motivo;
            Estado = EstadoCita.Pendiente;
        }

        /// <summary>
        /// Cambia el estado de la cita a Cancelada.
        /// </summary>
        public void CancelarCita()
        {
            Estado = EstadoCita.Cancelada;
        }

        /// <summary>
        /// Modificamos la fecha y el motivo de la cita.
        /// </summary>
        /// <param name="nuevaFechaHora"></param>
        /// <param name="motivoNuevo"></param>
        public void ModificarCita(DateTime nuevaFechaHora, string motivoNuevo)
        {
            if (Estado != EstadoCita.Cancelada)
            {
                FechaHora = nuevaFechaHora;
                Motivo = motivoNuevo;
            }
            else
                Console.WriteLine("No es posible modificar una cita cancelada.");
        }

        public override string ToString()
        {
            return $"IdCita: {IdCita}, FechaHora: {FechaHora}, Paciente: {Paciente}, Medico: {Medico}, Motivo: {Motivo}, Estado: {Estado}";
        }
    }
}
