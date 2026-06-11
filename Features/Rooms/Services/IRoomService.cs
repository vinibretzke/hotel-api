using hotel_api.Features.Rooms.Dtos;

namespace hotel_api.Features.Rooms.Services;

public interface IRoomService
{
    Task<IEnumerable<RoomResponse>> GetAllRoomsAsync();
    Task<RoomResponse?> GetRoomByIdAsync(int id);
    Task<RoomResponse> CreateRoomAsync(CreateRoomRequest request);
    Task<RoomResponse?> UpdateRoomAsync(int id, UpdateRoomRequest request);
    Task<bool> DeleteRoomAsync(int id);
}
