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
            while (true)
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

                switch (opcion)
                {
                    case "1":
                        DarAltaMedico();
                        break;
                    case "2":
                        DarAltaPaciente();
                        break;
                    case "3":
                        DarAltaPersAdm();
                        break;
                    case "4":
                        ListarMedicos();
                        break;
                    case "5":
                        ListarPacientesMedico();
                        break;
                    case "6":
                        EliminarPaciente();
                        break;
                    case "7":
                        VerListaPersonas();
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        /// <summary>
        /// Damos de alta un médico
        /// 
        /// Lo añadimos a la lista de médicos y a la lista de personas
        /// </summary>
        static void DarAltaMedico()
        {
            Console.WriteLine("Nombre del médico:");
            string nombre = Console.ReadLine();

            Medico medico = new Medico(nombre);
            medicos.Add(medico);
            personas.Add(medico);

            Console.WriteLine("Médico dado de alta");
        }

        /// <summary>
        /// Damos de alta un paciente
        /// 
        /// Si el nombre del médico existe en la lista  
        /// le asignamos  el paciente
        /// </summary>
        static void DarAltaPaciente()
        {
            Console.WriteLine("Nombre del paciente: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el nombre del médico asignado: ");
            string nombreMedico = Console.ReadLine();

            Medico medico = medicos.Find(m => m.Nombre == nombreMedico);
            if (medico != null)
            {
                Paciente paciente = new Paciente(nombre);
                medico.AgregarPaciente(paciente);
                personas.Add(paciente);

                Console.WriteLine("Paciente dado de alta");
            }
            else
                Console.WriteLine("Médico no encontrado");
        }

        /// <summary>
        /// Dar de alta a los personales Adm
        /// </summary>
        static void DarAltaPersAdm()
        {
            Console.WriteLine("Nombre del personal administrativo:");
            string nombre = Console.ReadLine();
            
            PersonalAdministrativo personaAdm = new PersonalAdministrativo(nombre);
            personas.Add(personaAdm);

            Console.WriteLine("Personal administrativo dado de alta");
        }

        /// <summary>
        /// Listamos todos los médicos de la 
        /// lista.
        /// </summary>
        static void ListarMedicos()
        {
            foreach (Medico medico in medicos)
                Console.WriteLine(medico.Nombre);
        }

        static void ListarPacientesMedico()
        {
            Console.WriteLine("Nombre del médico: ");
            string nombreMedico = Console.ReadLine();
            
            Medico medico = medicos.Find(m => m.Nombre == nombreMedico);

            // Comprobamos si el médico existe
            if (medico != null)
            {
                Console.WriteLine($"Pacientes del médico {medico.Nombre}:");
                foreach (Paciente paciente in medico.Pacientes)
                    Console.WriteLine(paciente.Nombre);
            }
            else 
                Console.WriteLine("Médico no encontrado");
        }
    }


}
