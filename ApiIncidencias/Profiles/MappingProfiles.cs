using ApiIncidencias.Dtos;
using Dominio;
using AutoMapper;
namespace ApiIncidencias.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles(){
        CreateMap<Pais,PaisDto>()
        .ReverseMap()
        .ForMember(o => o.Departamentos,d => d.Ignore());

        CreateMap<Departamento,DepartamentoDto>().ReverseMap();

        CreateMap<Pais,PaisxDepDto>().ReverseMap();

        /*CreateMap<Estado,EstadoDto>()
        .ForMember(dest => dest.IdEstado, opt => opt.MapFrom(src => src.IdCod))
        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.nombreEstado))
        .ReverseMap();*/
    }  
}
