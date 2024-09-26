namespace Gestión_de_un_Hospital
{
    class PersonalAdministrativo : Persona
    {
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public double SalarioPersonalAdm { get; set; }

        public PersonalAdministrativo(string nombre, string apellidos, string sexo, string telefono, string direccion)
            : base(nombre, apellidos, sexo, telefono) 
        {
            Departamento = string.Empty;
            Puesto = string.Empty;
            SalarioPersonalAdm = 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Departamento: {Departamento}, Puesto: {Puesto}, Salario: {SalarioPersonalAdm}";
        }
    }
}
