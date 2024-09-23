using Gestión_de_un_Hospital;
using System.Collections.Generic;

class Medico : Persona
{
    public List<Paciente> Pacientes { get; set; }

    public Medico(string nombre) : base(nombre)
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
