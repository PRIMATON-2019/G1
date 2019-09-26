namespace G1.Clases.Modelos
{
    public class DetalleEventos
    {
        public int Id { get; set; }
        public int TipoEvento { get; set; }
        public string Observaciones { get; set; }
        public Informacion informacion { get; set; }
        public double Cantidad { get; set; }

    }
}