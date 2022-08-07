using AutoMapper;
using FilmeAPI.Data.Dtos.Enderecos;
using FilmeAPI.Models;

namespace FilmeAPI.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<UpdateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
        }        
    }
}