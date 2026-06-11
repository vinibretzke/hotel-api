using System.ComponentModel.DataAnnotations;

namespace hotel_api.Features.Rooms.Dtos;

public class CreateRoomRequest
{
    [Required]
    public string Number { get; set; } = string.Empty;

    [Required]
    public string Floor { get; set; } = string.Empty;

    [Required]
    public int Capacity { get; set; }

    [Required]
    public decimal DailyRate { get; set; }

    public string Description { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;
}
