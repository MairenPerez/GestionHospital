using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_un_Hospital
{
    class PersonalAdministrativo : Persona
    {
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public double SalarioPersonalAdm { get; set; }

        public PersonalAdministrativo(string nombre, string apellidos, string sexo, string telefono, string direccion)
            : base(nombre, apellidos, sexo, telefono) { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
