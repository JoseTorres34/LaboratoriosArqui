namespace personapi_dotnet.Models.Entities
{
    public interface ITelefono
    {
        int Duenio { get; set; }
        Persona DuenioNavigation { get; set; }
        string Num { get; set; }
        string Oper { get; set; }
    }
}