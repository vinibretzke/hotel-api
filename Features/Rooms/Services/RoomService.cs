using hotel_api.Data;
using hotel_api.Features.Rooms.Dtos;
using hotel_api.Features.Rooms.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace hotel_api.Features.Rooms.Services;

public class RoomService : IRoomService
{
    private readonly AppDbContext _context;

    public RoomService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<RoomResponse>> GetAllRoomsAsync()
    {
        var rooms = await _context.Rooms.ToListAsync();
        return rooms.Select(r => new RoomResponse
        {
            Id = r.Id,
            Number = r.Number,
            Floor = r.Floor,
            Capacity = r.Capacity,
            DailyRate = r.DailyRate,
            Description = r.Description,
            IsActive = r.IsActive,
            CreatedAt = r.CreatedAt,
            UpdatedAt = r.UpdatedAt
        });
    }

    public async Task<RoomResponse?> GetRoomByIdAsync(int id)
    {
        var r = await _context.Rooms.FindAsync(id);
        if (r is null) return null;
        return new RoomResponse
        {
            Id = r.Id,
            Number = r.Number,
            Floor = r.Floor,
            Capacity = r.Capacity,
            DailyRate = r.DailyRate,
            Description = r.Description,
            IsActive = r.IsActive,
            CreatedAt = r.CreatedAt,
            UpdatedAt = r.UpdatedAt
        };
    }

    public async Task<RoomResponse> CreateRoomAsync(CreateRoomRequest request)
    {
        var room = new Room
        {
            Number = request.Number,
            Floor = request.Floor,
            Capacity = request.Capacity,
            DailyRate = request.DailyRate,
            Description = request.Description,
            IsActive = request.IsActive
        };

        _context.Rooms.Add(room);
        await _context.SaveChangesAsync();

        return new RoomResponse
        {
            Id = room.Id,
            Number = room.Number,
            Floor = room.Floor,
            Capacity = room.Capacity,
            DailyRate = room.DailyRate,
            Description = room.Description,
            IsActive = room.IsActive,
            CreatedAt = room.CreatedAt,
            UpdatedAt = room.UpdatedAt
        };
    }

    public async Task<RoomResponse?> UpdateRoomAsync(int id, UpdateRoomRequest request)
    {
        var room = await _context.Rooms.FindAsync(id);
        if (room is null) return null;

        room.Number = request.Number;
        room.Floor = request.Floor;
        room.Capacity = request.Capacity;
        room.DailyRate = request.DailyRate;
        room.Description = request.Description;
        room.IsActive = request.IsActive;
        room.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();

        return new RoomResponse
        {
            Id = room.Id,
            Number = room.Number,
            Floor = room.Floor,
            Capacity = room.Capacity,
            DailyRate = room.DailyRate,
            Description = room.Description,
            IsActive = room.IsActive,
            CreatedAt = room.CreatedAt,
            UpdatedAt = room.UpdatedAt
        };
    }

    public async Task<bool> DeleteRoomAsync(int id)
    {
        var room = await _context.Rooms.FindAsync(id);
        if (room is null) return false;

        _context.Rooms.Remove(room);
        await _context.SaveChangesAsync();

        return true;
    }
}
