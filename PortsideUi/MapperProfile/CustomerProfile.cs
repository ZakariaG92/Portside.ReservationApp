using AutoMapper;
using Portside.Entities.Model;
using Portside.Persistance.Model;

namespace PortsideUi.MapperProfile;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<Customer, CustomerDto>();
        CreateMap<CustomerDto, Customer>();
    }
}