﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_un_Hospital
{
    class Program
    {
        static Hospital hospital = new Hospital();
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
                        8. Modificar datos
                        9. Consultar citas 
                        10. Salir
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
                        ModificarDatos();
                        break;
                    case "9":
                        ConsultarCitas();
                        break;
                    case "10":
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
            Console.WriteLine("Apellidos del médico:");
            string apellidos = Console.ReadLine();
            Console.WriteLine("Sexo del médico:");
            string sexo = Console.ReadLine();
            Console.WriteLine("Teléfono del médico:");
            string telefono = Console.ReadLine();
            Console.WriteLine("Especialidad del médico:");
            string especialidad = Console.ReadLine();
            Console.WriteLine("Número de colegiado del médico:");
            int numColegiado = int.Parse(Console.ReadLine());
            Console.WriteLine("Salario del médico:");
            double salario = double.Parse(Console.ReadLine());

            Medico medico = new Medico(nombre, apellidos, sexo, telefono, especialidad, numColegiado, salario);
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
            Console.WriteLine("Apellidos del paciente: ");
            string apellidos = Console.ReadLine();
            Console.WriteLine("Sexo del paciente: ");
            string sexo = Console.ReadLine();
            Console.WriteLine("Teléfono del paciente: ");
            string telefono = Console.ReadLine();
            Console.WriteLine("Número de historia clínica del paciente: ");
            string numHistoriaClinica = Console.ReadLine();
            Console.WriteLine("Diagnóstico del paciente: ");
            string diagnostico = Console.ReadLine();
            Console.WriteLine("Tratamiento del paciente: ");
            string tratamiento = Console.ReadLine();
            Console.WriteLine("Fecha de ingreso del paciente (yyyy-MM-dd): ");
            DateTime fechaIngreso = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Fecha de alta del paciente (yyyy-MM-dd): ");
            DateTime fechaAlta = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre del médico asignado: ");
            string nombreMedico = Console.ReadLine();

            Medico medico = medicos.Find(m => m.Nombre == nombreMedico);
            if (medico != null)
            {
                Paciente paciente = new Paciente(nombre, apellidos, sexo, telefono, numHistoriaClinica, fechaIngreso, diagnostico, tratamiento, fechaAlta, medico);
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
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellidos:");
            string apellidos = Console.ReadLine();
            Console.WriteLine("Sexo:");
            string sexo = Console.ReadLine();
            Console.WriteLine("Teléfono:");
            string telefono = Console.ReadLine();
            Console.WriteLine("Departamento:");
            string departamento = Console.ReadLine();
            Console.WriteLine("Puesto:");
            string puesto = Console.ReadLine();
            Console.WriteLine("Salario:");
            double salario = double.Parse(Console.ReadLine());

            PersonalAdministrativo personaAdm = new PersonalAdministrativo(nombre, apellidos, sexo, telefono, departamento)
            {
                Puesto = puesto,
                SalarioPersonalAdm = salario
            };
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

        /// <summary>
        /// De cada médico listamos sus pacientes
        /// </summary>
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


        /// <summary>
        /// Eliminamos al paciente de la lista,
        /// por lo tanto el médico ya no lo tendrá
        /// </summary>
        static void EliminarPaciente()
        {
            Console.Write("Ingrese el nombre del paciente a eliminar: ");
            string nombrePaciente = Console.ReadLine();

            foreach (Medico medico in medicos)
            {
                Paciente paciente = medico.Pacientes.Find(p => p.Nombre == nombrePaciente);
                if (paciente != null)
                {
                    medico.EliminarPaciente(paciente);
                    personas.Remove(paciente);

                    Console.WriteLine("Paciente eliminado");

                    return;
                }
            }
            Console.WriteLine("Paciente no encontrado");
        }

        /// <summary>
        /// Mostramos la lista de personas del hospital
        /// </summary>
        static void VerListaPersonas()
        {
            Console.WriteLine("Lista de personas del hospital:");
            foreach (Persona persona in personas)
                Console.WriteLine(persona.Nombre);
        }

        /// <summary>
        /// Modificar los datos de las personas
        /// que estan en el hospital
        /// </summary>
        static void ModificarDatos()
        {
            Console.Write(" Introduce tu nombre ");
            string datos = Console.ReadLine();

            foreach (Persona persona in personas)
            {
                if (persona.Nombre == datos)
                {
                    Console.WriteLine("Nombre: ");
                    persona.Nombre = Console.ReadLine();
                    Console.WriteLine("Apellidos: ");
                    persona.Apellidos = Console.ReadLine();
                    Console.WriteLine("Teléfono: ");
                    persona.Telefono = Console.ReadLine();

                    if (persona is Medico)
                    {
                        Console.WriteLine("Especialidad:");
                        ((Medico)persona).Especialidad = Console.ReadLine();
                        Console.WriteLine("Salario:");
                        ((Medico)persona).SalarioMedico = double.Parse(Console.ReadLine());
                    }
                    else if (persona is PersonalAdministrativo)
                    {
                        Console.WriteLine("Departamento:");
                        ((PersonalAdministrativo)persona).Departamento = Console.ReadLine();
                        Console.WriteLine("Puesto:");
                        ((PersonalAdministrativo)persona).Puesto = Console.ReadLine();
                        Console.WriteLine("Salario:");
                        ((PersonalAdministrativo)persona).SalarioPersonalAdm = double.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Datos modificados");
                }
            }
        }

        public static void ConsultarCitas()
        {
            Console.WriteLine("Nombre del médico:");
            string nombreMedico = Console.ReadLine();

            Medico medico = medicos.Find(m => m.Nombre == nombreMedico);

            if (medico != null)
            {
                Console.WriteLine($" Citas del médico {medico.Nombre}:");
                foreach (Cita cita in medico.Citas)
                    Console.WriteLine(cita.ToString());
            }
            else
                Console.WriteLine("Médico no encontrado");

        }
    }
}

