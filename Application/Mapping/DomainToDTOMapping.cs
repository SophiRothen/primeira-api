using AutoMapper;
using PrimeiraAPI.Domain.DTOs;
using PrimeiraAPI.Domain.Model;

namespace PrimeiraAPI.Application.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping()
        {
            CreateMap<Employee, EmployeeDTO>()  // se fossem iguais só isso bastaria para mapear, entidade para dto
                .ForMember(dest => dest.NameEmployee, m => m.MapFrom(orig => orig.name));  //necessario pq os nomes do atributo "name" sao diferentes nas classes de origem e destino
        }

    }
}
