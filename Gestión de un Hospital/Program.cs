using Gestión_de_un_Hospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_un_Hospital
{
    internal class Program
    {
        static List<Medico> medicos = new List<Medico>();
        static List<Persona> personas = new List<Persona>();

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine(@"
                    Gestión del Hospital
                    1. Dar de alta un médico
                    2. Dar de alta un paciente
                    3. Dar de alta un personal administrativo
                    4. Listar todos los médicos
                    5. Listar los pacientes de un médico
                    6. Eliminar a un paciente
                    7. Ver la lista de personas del hospital
                    8. Salir
                    ");
                string opcion = Console.ReadLine();

                switch(opcion)
                {
                    case 1:
                        DarAltaMedico();
                        break;
                    case 2:
                        DarAltaPaciente();
                        break;
                    case 3:
                        DarAltaPersAdm();
                        break;
                    case 4:
                        ListarMedicos();
                        break;
                    case 5:
                        ListarPacientesMedico();
                        break;
                    case 6:
                        EliminarPaciente();
                        break;
                    case 7:
                        VerListaPersonas();
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
           
        }
    }
}
