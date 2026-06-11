using hotel_api.Data;
using hotel_api.Features.Guests.Dtos;
using hotel_api.Features.Guests.Models;
using Microsoft.EntityFrameworkCore;

namespace hotel_api.Features.Guests.Services;

public class GuestService : IGuestService
{
    private readonly AppDbContext _context;

    public GuestService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<GuestResponse>> GetAllGuestsAsync()
    {
        var guests = await _context.Guests.ToListAsync();
        return guests.Select(MapToResponse);
    }

    public async Task<GuestResponse> CreateGuestAsync(CreateGuestRequest request)
    {
        var guest = MapToEntity(request);

        _context.Guests.Add(guest);
        await _context.SaveChangesAsync();

        return MapToResponse(guest);
    }

    public async Task<GuestResponse?> GetGuestByIdAsync(Guid id)
    {
        var guest = await _context.Guests.FindAsync(id);
        return guest is null ? null : MapToResponse(guest);
    }

    public async Task<GuestResponse?> UpdateGuestAsync(Guid id, UpdateGuestRequest request)
    {
        var guest = await _context.Guests.FindAsync(id);
        if (guest is null)
            return null;

        ApplyUpdate(guest, request);
        guest.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();

        return MapToResponse(guest);
    }

    public async Task<bool> DeleteGuestAsync(Guid id)
    {
        var guest = await _context.Guests.FindAsync(id);
        if (guest is null)
            return false;

        _context.Guests.Remove(guest);
        await _context.SaveChangesAsync();

        return true;
    }

    private static Guest MapToEntity(CreateGuestRequest request) => new()
    {
        Name = request.Name,
        Email = request.Email,
        Phone = request.Phone,
        BirthDate = request.BirthDate,
        Nationality = request.Nationality,
        BirthCountry = request.BirthCountry,
        BirthCity = request.BirthCity,
        BirthState = request.BirthState,
        Street = request.Street,
        Number = request.Number,
        Neighborhood = request.Neighborhood,
        ZipCode = request.ZipCode,
        City = request.City,
        State = request.State,
        Country = request.Country,
        Complement = request.Complement,
        Reference = request.Reference,
        DocumentType = request.DocumentType,
        DocumentNumber = request.DocumentNumber,
    };

    private static void ApplyUpdate(Guest guest, UpdateGuestRequest request)
    {
        guest.Name = request.Name;
        guest.Email = request.Email;
        guest.Phone = request.Phone;
        guest.BirthDate = request.BirthDate;
        guest.Nationality = request.Nationality;
        guest.BirthCountry = request.BirthCountry;
        guest.BirthCity = request.BirthCity;
        guest.BirthState = request.BirthState;
        guest.Street = request.Street;
        guest.Number = request.Number;
        guest.Neighborhood = request.Neighborhood;
        guest.ZipCode = request.ZipCode;
        guest.City = request.City;
        guest.State = request.State;
        guest.Country = request.Country;
        guest.Complement = request.Complement;
        guest.Reference = request.Reference;
        guest.DocumentType = request.DocumentType;
        guest.DocumentNumber = request.DocumentNumber;
    }

    private static GuestResponse MapToResponse(Guest guest) => new()
    {
        Id = guest.Id,
        Name = guest.Name,
        Email = guest.Email,
        Phone = guest.Phone,
        BirthDate = guest.BirthDate,
        Nationality = guest.Nationality,
        BirthCountry = guest.BirthCountry,
        BirthCity = guest.BirthCity,
        BirthState = guest.BirthState,
        Street = guest.Street,
        Number = guest.Number,
        Neighborhood = guest.Neighborhood,
        ZipCode = guest.ZipCode,
        City = guest.City,
        State = guest.State,
        Country = guest.Country,
        Complement = guest.Complement,
        Reference = guest.Reference,
        DocumentType = guest.DocumentType,
        DocumentNumber = guest.DocumentNumber,
        CreatedAt = guest.CreatedAt,
        UpdatedAt = guest.UpdatedAt,
    };
}
