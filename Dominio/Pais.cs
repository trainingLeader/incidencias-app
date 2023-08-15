namespace Dominio;

public class Pais
{
    public string IdPais { get; set; } 
    public string NombrePais { get; set; }
    public ICollection<Departamento> Departamentos { get; set; }
}
