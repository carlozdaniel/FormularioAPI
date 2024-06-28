namespace FormularioAPI.Models
{
    // Modelo de usuario que representa la estructura de datos en la base de datos
    public class User
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
    }
}
