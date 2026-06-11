using hotel_api.Features.Guests.Dtos;

namespace hotel_api.Features.Guests.Services;

public interface IGuestService
{
    Task<IEnumerable<GuestResponse>> GetAllGuestsAsync();
    Task<GuestResponse> CreateGuestAsync(CreateGuestRequest request);
    Task<GuestResponse?> GetGuestByIdAsync(int id);
    Task<GuestResponse?> UpdateGuestAsync(int id, UpdateGuestRequest request);
    Task<bool> DeleteGuestAsync(int id);
}