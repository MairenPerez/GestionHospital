using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_un_Hospital
{
    class Paciente : Persona
    {
        public Paciente(string nombre) : base(nombre) { }

        public override string ToString()
        {
            return Nombre;
        }
    }
}