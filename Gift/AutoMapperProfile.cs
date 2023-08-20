using AutoMapper;
using Gift.Models.DTOs;

namespace Gift;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<Era, EraDto>();
        CreateMap<Models.Gift, GiftDto>();
    }
}