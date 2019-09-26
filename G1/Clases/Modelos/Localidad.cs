namespace G1.Clases.Modelos
{
    public class Localidad
    {
        public int Id { get; set; }
        public string NombreLocalidad { get; set; }
        public Provincia Provincias { get; set; }
    }
}