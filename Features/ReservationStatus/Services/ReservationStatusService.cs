using hotel_api.Data;
using hotel_api.Features.ReservationStatus.Dtos;
using Microsoft.EntityFrameworkCore;

namespace hotel_api.Features.ReservationStatus.Services;

public class ReservationStatusService : IReservationStatusService
{
    private readonly AppDbContext _context;

    public ReservationStatusService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ReservationStatusResponse>> GetAllAsync()
    {
        var items = await _context.ReservationStatuses.ToListAsync();
        return items.Select(i => new ReservationStatusResponse
        {
            Id = i.Id,
            Name = i.Name,
            Description = i.Description,
            IsActive = i.IsActive,
            CreatedAt = i.CreatedAt,
            UpdatedAt = i.UpdatedAt
        });
    }

    public async Task<ReservationStatusResponse?> GetByIdAsync(int id)
    {
        var i = await _context.ReservationStatuses.FindAsync(id);
        if (i is null) return null;
        return new ReservationStatusResponse
        {
            Id = i.Id,
            Name = i.Name,
            Description = i.Description,
            IsActive = i.IsActive,
            CreatedAt = i.CreatedAt,
            UpdatedAt = i.UpdatedAt
        };
    }
}
