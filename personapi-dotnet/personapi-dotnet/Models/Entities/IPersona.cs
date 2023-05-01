namespace personapi_dotnet.Models.Entities
{
    public interface IPersona
    {
        string Apellido { get; set; }
        int Cc { get; set; }
        int? Edad { get; set; }
        ICollection<Estudio> Estudios { get; set; }
        string Genero { get; set; }
        string Nombre { get; set; }
        ICollection<Telefono> Telefonos { get; set; }
    }
}