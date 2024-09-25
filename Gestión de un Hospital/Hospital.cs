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

        public void AgregarCita (Cita cita)
        {
            Citas.Add(cita);
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

        public void ListarCitas()
        {
            // Por implementar 
        }
    }
}
