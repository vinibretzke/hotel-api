using hotel_api.Features.Guests.Dtos;

namespace hotel_api.Features.Guests.Services;

public interface IGuestService
{
    Task<IEnumerable<GuestResponse>> GetAllGuestsAsync();
    Task<GuestResponse> CreateGuestAsync(CreateGuestRequest request);
    Task<GuestResponse?> GetGuestByIdAsync(Guid id);
    Task<GuestResponse?> UpdateGuestAsync(Guid id, UpdateGuestRequest request);
    Task<bool> DeleteGuestAsync(Guid id);
}