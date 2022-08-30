using AutoMapper;
using GeekBrainsCardStorageService.Models.Dto.Card.Request;
using GeekBrainsCardStorageService.Models.Dto.Card.Response;
using GeekBrainsCardStorageService.Repository.Data;

namespace GeekBrainsCardStorageService.AutoMapperProfiles
{
    public class AutoMapperCardProfile : Profile
    {
        public AutoMapperCardProfile()
        {
            CreateMap<DtoCardRequestCreate, Card>();

            CreateMap<Card, DtoCardResponse>();
        }
    }
}
