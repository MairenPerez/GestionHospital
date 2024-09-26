using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_un_Hospital
{
    class Hospital
    {
        public List<Medico> Medicos { get; set; }
        public List<Paciente> Pacientes { get; set; }
        public List<PersonalAdministrativo> PersonalAdministrativos { get; set; }
        public List<Cita> Citas { get; set; }

        public Hospital()
        {
            Medicos = new List<Medico>();
            Pacientes = new List<Paciente>();
            PersonalAdministrativos = new List<PersonalAdministrativo>();
            Citas = new List<Cita>();   
        }

        public void AgregarMedico (Medico medico)
        {
            Medicos.Add(medico);
        }

        public void AgregarPaciente(Paciente paciente)
        {
            Pacientes.Add(paciente);
        }

        public void AgregarPersonalAdministrativo (PersonalAdministrativo personalAdministrativo)
        {
            PersonalAdministrativos.Add(personalAdministrativo);
        }

        public void ListarMedicos ()
        {
            Medicos.ForEach(medico => Console.WriteLine(medico.ToString()));
        }

        public void ListarPacientes()
        {
            Pacientes.ForEach(paciente => Console.WriteLine(paciente.ToString()));
        }

        public void ListarPersonalAdministrativo()
        {
            PersonalAdministrativos.ForEach(personalAdministrativo => Console.WriteLine(personalAdministrativo.ToString()));
        }

        public void CancelarCita(int idCita)
        {
            Cita cita = Citas.Find(c => c.IdCita == idCita);
            if (cita != null)
            {
                cita.CancelarCita();
                Medico medico = Medicos.Find(m => m.Nombre == cita.Medico);
                medico?.Citas.Remove(cita);
            }
            else
                Console.WriteLine("No se ha encontrado ninguna cita");
        }

        public void ModificarCita(int idCita, DateTime nuevaFechaHora, string motivoNuevo)
        {
            Cita cita = Citas.Find(c => c.IdCita == idCita);
            if (cita != null)
                cita.ModificarCita(nuevaFechaHora, motivoNuevo);
            else
                Console.WriteLine("Cita no encontrada.");
        }

        public void ListarCitas()
        {
            Citas.ForEach(cita => Console.WriteLine(cita.ToString()));
        }
    }
}
