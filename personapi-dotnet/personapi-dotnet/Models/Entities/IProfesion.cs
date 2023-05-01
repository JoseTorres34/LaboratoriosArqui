namespace personapi_dotnet.Models.Entities
{
    public interface IProfesion
    {
        string? Des { get; set; }
        ICollection<Estudio> Estudios { get; set; }
        int Id { get; set; }
        string Nom { get; set; }
    }
}