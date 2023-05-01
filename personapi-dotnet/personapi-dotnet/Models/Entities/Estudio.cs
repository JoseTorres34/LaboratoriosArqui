namespace personapi_dotnet.Models.Entities;

public partial class Estudio : IEstudio
{
    public int IdProf { get; set; }

    public int CcPer { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Univer { get; set; }

    public virtual Persona CcPerNavigation { get; set; } = null!;

    public virtual Profesion IdProfNavigation { get; set; } = null!;
}


public static class EstudioEndpoints
{
    public static void MapEstudioEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Estudio", () =>
        {
            return new[] { new Estudio() };
        })
        .WithName("GetAllEstudios")
        .Produces<Estudio[]>(StatusCodes.Status200OK);

        routes.MapGet("/api/Estudio/{id}", (int id) =>
        {
            //return new Estudio { ID = id };
        })
        .WithName("GetEstudioById")
        .Produces<Estudio>(StatusCodes.Status200OK);

        routes.MapPut("/api/Estudio/{id}", (int id, Estudio input) =>
        {
            return Results.NoContent();
        })
        .WithName("UpdateEstudio")
        .Produces(StatusCodes.Status204NoContent);

        routes.MapPost("/api/Estudio/", (Estudio model) =>
        {
            //return Results.Created($"/Estudios/{model.ID}", model);
        })
        .WithName("CreateEstudio")
        .Produces<Estudio>(StatusCodes.Status201Created);

        routes.MapDelete("/api/Estudio/{id}", (int id) =>
        {
            //return Results.Ok(new Estudio { ID = id });
        })
        .WithName("DeleteEstudio")
        .Produces<Estudio>(StatusCodes.Status200OK);
    }
}