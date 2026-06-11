using hotel_api.Features.Reservations.Dtos;

namespace hotel_api.Features.Reservations.Services;

public interface IReservationService
{
    Task<IEnumerable<ReservationResponse>> GetAllAsync();
    Task<ReservationResponse?> GetByIdAsync(int id);
    Task<ReservationResponse> CreateAsync(CreateReservationRequest request);
    Task<ReservationResponse?> UpdateAsync(int id, UpdateReservationRequest request);
    Task<bool> DeleteAsync(int id);
}
