using AutoMapper;
using GeekBrainsCardStorageService.Models.Dto.Client.Request;
using GeekBrainsCardStorageService.Models.Dto.Client.Response;
using GeekBrainsCardStorageService.Repository.Data;

namespace GeekBrainsCardStorageService.AutoMapperProfiles
{
    public class AutoMapperClientProfile : Profile
    {
        public AutoMapperClientProfile()
        {
            CreateMap<DtoClientRequestCreate, Client>();

            CreateMap<Client, DtoClientResponse>();
        }
    }
}
