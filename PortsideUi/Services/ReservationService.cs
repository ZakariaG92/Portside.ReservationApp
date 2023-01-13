using Microsoft.EntityFrameworkCore;
using Portside.Persistance.DbContext;
using Portside.Persistance.Model;
using PortsideUi.Services.Interfaces;

namespace PortsideUi.Services;

public class ReservationService: IReservationService
{
    private readonly DataBaseContext _context;

    public ReservationService(DataBaseContext context)
    {
        _context = context;
    }

    public async Task<List<Reservation>> GetReservationsByCustomerIdAsync(string customerId)
    {
        return await _context.Reservations.Where(r => r.CustomerId == customerId).ToListAsync();
    }

    public async Task<Reservation?> GetReservationByIdAsync(string reservationId)
    {
        return await _context.Reservations.FindAsync(reservationId);
    }

    public async Task AddReservationAsync(Reservation reservation)
    {
        _context.Reservations.Add(reservation);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateReservationAsync(Reservation reservation)
    {
        _context.Reservations.Update(reservation);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteReservationAsync(string reservationId)
    {
        var reservation = await _context.Reservations.FindAsync(reservationId);
        _context.Reservations.Remove(reservation);
        await _context.SaveChangesAsync();
    }
}