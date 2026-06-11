namespace hotel_api.Features.Rooms.Dtos;

public class RoomResponse
{
    public int Id { get; set; }
    public string Number { get; set; } = string.Empty;
    public string Floor { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public decimal DailyRate { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
