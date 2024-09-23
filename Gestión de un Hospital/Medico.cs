using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_un_Hospital
{
    class Medico : Persona
    {
        private List <Paciente> Pacientes { get; set; }

        public Medico (string nombre) : base(nombre)
        {
            Pacientes = new List<Paciente>();
        }

        public void AgregarPaciente(Paciente paciente)
        {
            Pacientes.Add(paciente);
        }

        public void EliminarPaciente(Paciente paciente)
        {
            Pacientes.Remove(paciente);
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
