using AutoMapper;
using FilmeAPI.Data.Dtos.Filme;
using FilmeAPI.Models;

namespace FilmeAPI.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<UpdateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
        }
    }
}