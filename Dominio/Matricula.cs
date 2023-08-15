namespace Dominio;

public class Matricula
{
    public int IdMatricula { get; set; }
    public string IdPersonaFk { get; set; }
    public Persona Persona { get; set; }
    public int IdSalonFk { get; set; }
    public Salon Salon { get; set; }
}
