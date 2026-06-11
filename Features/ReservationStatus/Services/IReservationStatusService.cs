using hotel_api.Features.ReservationStatus.Dtos;

namespace hotel_api.Features.ReservationStatus.Services;

public interface IReservationStatusService
{
    Task<IEnumerable<ReservationStatusResponse>> GetAllAsync();
    Task<ReservationStatusResponse?> GetByIdAsync(int id);
}
