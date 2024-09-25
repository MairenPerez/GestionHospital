using Gestión_de_un_Hospital;
using System.Collections.Generic;

class Medico : Persona
{
    public int NumColegiado { get; set; }
    public string Especialidad { get; set; }
    public double SalarioMedico { get; set; }

    public List<Paciente> Pacientes { get; set; }
    public List<Cita> Citas { get; set; }

    public Medico(string nombre, string apellidos, string sexo, string telefono, string especialidad, int numColegiado, double salario)
    : base(nombre, apellidos, sexo, telefono)
    {
        NumColegiado = numColegiado;
        Especialidad = especialidad;
        SalarioMedico = salario;
        Pacientes = new List<Paciente>();
        Citas = new List<Cita>();
    }

    public void AgregarPaciente(Paciente paciente)
    {
        Pacientes.Add(paciente);
    }

    public void EliminarPaciente(Paciente paciente)
    {
        Pacientes.Remove(paciente);
    }

    public void AgregarCita(Cita cita)
    {
        Citas.Add(cita);
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
