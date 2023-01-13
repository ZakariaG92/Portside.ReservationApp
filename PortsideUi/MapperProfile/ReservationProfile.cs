using AutoMapper;
using Portside.Entities.Model;
using Portside.Persistance.Model;

namespace PortsideUi.MapperProfile;

public class ReservationProfile : Profile
{
    public ReservationProfile()
    {
        CreateMap<Reservation, ReservationDto>();
        CreateMap<ReservationDto, Reservation>();
    }
}