using Gestión_de_un_Hospital;
using System.Collections.Generic;

class Medico : Persona
{
    public int NumColegiado { get; set; }
    public string Especialidad { get; set; }
    public double SalarioMedico { get; set; }

    public List<Paciente> Pacientes { get; set; }

    public Medico(string nombre, string apellidos, string sexo, string telefono, string direccion, int numColegiado, string especialidad, double salarioMedico)
        : base(nombre, apellidos, sexo, telefono)
    {
        NumColegiado = numColegiado;
        Especialidad = especialidad;
        SalarioMedico = 0;
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
        return base.ToString();
    }
}
