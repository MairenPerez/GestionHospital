using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_un_Hospital
{
    class PersonalAdministrativo : Persona
    {
        public PersonalAdministrativo(string nombre) : base(nombre) { }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
