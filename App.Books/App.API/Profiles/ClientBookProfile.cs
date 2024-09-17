using App.API.Models;
using App.DA.Entities;
using AutoMapper;

namespace App.API.Profiles
{
    public class ClientBookProfile : Profile
    {
        public ClientBookProfile()
        {
            CreateMap<CreateBookRequest, BookDTO>();
        }
    }
}
