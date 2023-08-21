using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class PersonaRepository : GenericRepository<Persona>, IPersonaRepository
{
    private readonly ApiIncidenciasContext _context;

    public PersonaRepository(ApiIncidenciasContext context) : base(context)
    {
        _context = context;
    }
}
