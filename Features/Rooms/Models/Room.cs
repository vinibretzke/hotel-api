namespace hotel_api.Features.Rooms.Models;

public class Room
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Number { get; set; } = string.Empty;

    public string Floor { get; set; } = string.Empty;

    public int Capacity { get; set; }

    public decimal DailyRate { get; set; }

    public string Description { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}