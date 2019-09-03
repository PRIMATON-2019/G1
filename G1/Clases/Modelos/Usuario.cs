namespace G1.Clases
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public Persona Persona { get; set; }
        public int Rol { get; set; }
    }
}