namespace Dominio;

public class Ciudad
{
    public string IdCiudad { get; set; }
    public string NombreCiudad { get; set; }
    public string IdDepFk { get; set; }
    public Departamento Departamento { get; set; }
    public ICollection<Persona> Personas { get; set; }
}
