namespace Dominio;

public class Departamento
{
    public string IdDep { get; set; }
    public string NombreDep { get; set; }
    public string IdPaisFk { get; set; }
    public Pais Pais { get; set; }
    public ICollection<Ciudad> Ciudades { get; set; }

}
