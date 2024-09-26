namespace Gestión_de_un_Hospital
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }

        public Persona(string nombre, string apellidos, string sexo, string telefono)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Sexo = sexo;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Apellidos: {Apellidos}, Sexo: {Sexo}, Teléfono: {Telefono}";
        }
    }
}


