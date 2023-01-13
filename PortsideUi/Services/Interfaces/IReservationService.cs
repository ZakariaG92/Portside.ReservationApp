using Portside.Persistance.Model;

namespace PortsideUi.Services.Interfaces;

public interface IReservationService
{
    Task<List<Reservation>> GetReservationsByCustomerIdAsync(string customerId);
    Task<Reservation?> GetReservationByIdAsync(string reservationId);
    Task AddReservationAsync(Reservation reservation);
    Task UpdateReservationAsync(Reservation reservation);
    Task DeleteReservationAsync(string reservationId);
}