namespace personapi_dotnet.Models.Entities
{
    public interface IEstudio
    {
        int CcPer { get; set; }
        Persona CcPerNavigation { get; set; }
        DateTime? Fecha { get; set; }
        int IdProf { get; set; }
        Profesion IdProfNavigation { get; set; }
        string? Univer { get; set; }
    }
}