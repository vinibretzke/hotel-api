using hotel_api.Data;
using hotel_api.Features.Reservations.Dtos;
using hotel_api.Features.Reservations.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace hotel_api.Features.Reservations.Services;

public class ReservationService : IReservationService
{
    private readonly AppDbContext _context;

    public ReservationService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ReservationResponse>> GetAllAsync()
    {
        var items = await _context.Reservations.ToListAsync();
        return items.Select(r => new ReservationResponse
        {
            Id = r.Id,
            GuestId = r.GuestId,
            RoomId = r.RoomId,
            ReservationStatusId = r.ReservationStatusId,
            CheckInDate = r.CheckInDate,
            CheckOutDate = r.CheckOutDate,
            DailyRate = r.DailyRate,
            TotalAmount = r.TotalAmount,
            Notes = r.Notes,
            CreatedAt = r.CreatedAt,
            UpdatedAt = r.UpdatedAt
        });
    }

    public async Task<ReservationResponse?> GetByIdAsync(int id)
    {
        var r = await _context.Reservations.FindAsync(id);
        if (r is null) return null;
        return new ReservationResponse
        {
            Id = r.Id,
            GuestId = r.GuestId,
            RoomId = r.RoomId,
            ReservationStatusId = r.ReservationStatusId,
            CheckInDate = r.CheckInDate,
            CheckOutDate = r.CheckOutDate,
            DailyRate = r.DailyRate,
            TotalAmount = r.TotalAmount,
            Notes = r.Notes,
            CreatedAt = r.CreatedAt,
            UpdatedAt = r.UpdatedAt
        };
    }

    public async Task<ReservationResponse> CreateAsync(CreateReservationRequest request)
    {
        var r = new Reservation
        {
            GuestId = request.GuestId,
            RoomId = request.RoomId,
            ReservationStatusId = request.ReservationStatusId,
            CheckInDate = request.CheckInDate,
            CheckOutDate = request.CheckOutDate,
            DailyRate = request.DailyRate,
            TotalAmount = request.TotalAmount,
            Notes = request.Notes
        };

        _context.Reservations.Add(r);
        await _context.SaveChangesAsync();

        return new ReservationResponse
        {
            Id = r.Id,
            GuestId = r.GuestId,
            RoomId = r.RoomId,
            ReservationStatusId = r.ReservationStatusId,
            CheckInDate = r.CheckInDate,
            CheckOutDate = r.CheckOutDate,
            DailyRate = r.DailyRate,
            TotalAmount = r.TotalAmount,
            Notes = r.Notes,
            CreatedAt = r.CreatedAt,
            UpdatedAt = r.UpdatedAt
        };
    }

    public async Task<ReservationResponse?> UpdateAsync(int id, UpdateReservationRequest request)
    {
        var r = await _context.Reservations.FindAsync(id);
        if (r is null) return null;

        r.GuestId = request.GuestId;
        r.RoomId = request.RoomId;
        r.ReservationStatusId = request.ReservationStatusId;
        r.CheckInDate = request.CheckInDate;
        r.CheckOutDate = request.CheckOutDate;
        r.DailyRate = request.DailyRate;
        r.TotalAmount = request.TotalAmount;
        r.Notes = request.Notes;
        r.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();

        return new ReservationResponse
        {
            Id = r.Id,
            GuestId = r.GuestId,
            RoomId = r.RoomId,
            ReservationStatusId = r.ReservationStatusId,
            CheckInDate = r.CheckInDate,
            CheckOutDate = r.CheckOutDate,
            DailyRate = r.DailyRate,
            TotalAmount = r.TotalAmount,
            Notes = r.Notes,
            CreatedAt = r.CreatedAt,
            UpdatedAt = r.UpdatedAt
        };
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var r = await _context.Reservations.FindAsync(id);
        if (r is null) return false;

        _context.Reservations.Remove(r);
        await _context.SaveChangesAsync();

        return true;
    }
}
