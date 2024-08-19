using AutoMapper;
using DAL.ENTITIES;
using Matrix.VM;

namespace Matrix.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductVM>().ReverseMap();
        }
    }
}
