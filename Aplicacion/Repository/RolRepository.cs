using Dominio;
using Dominio.Interfaces;
using Persistencia;

namespace Aplicacion.Repository;

public class RolRepository : GenericRepositoryB<Rol>, IRolRepository
{
    private readonly ApiIncidenciasContext _context;

    public RolRepository(ApiIncidenciasContext context) : base(context)
    {
        _context = context;
    }
}
