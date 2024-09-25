using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_un_Hospital
{
    class Paciente : Persona
    {
        public string NumHistoriaClinica { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaAlta { get; set; }
        public Medico MedicoAsignado { get; set; }

        public Paciente(string nombre, string apellidos, string sexo, string telefono, string direccion, DateTime fechaNacimiento, string numeroHistoriaClinica, string diagnostico, string tratamiento, DateTime fechaIngreso, Medico medicoAsignado)
           : base(nombre, apellidos, sexo, telefono)
        {
            NumHistoriaClinica = numeroHistoriaClinica;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            FechaIngreso = fechaIngreso;
            MedicoAsignado = medicoAsignado;
        }

        public Paciente(string nombre, string apellidos, string sexo, string telefono, string numHistoriaClinica, DateTime fechaIngreso, string diagnostico, string tratamiento, DateTime fechaAlta)
            : base(nombre, apellidos, sexo, telefono)
        {
            NumHistoriaClinica = numHistoriaClinica;
            FechaIngreso = fechaIngreso;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            FechaAlta = fechaAlta;
        }

        public Paciente(string nombre, string apellidos, string sexo, string telefono, string numHistoriaClinica, DateTime fechaIngreso, string diagnostico, string tratamiento, DateTime fechaAlta, Medico medico) : this(nombre, apellidos, sexo, telefono, numHistoriaClinica, fechaIngreso, diagnostico, tratamiento, fechaAlta)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
