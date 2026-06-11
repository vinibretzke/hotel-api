using System.ComponentModel.DataAnnotations;

namespace hotel_api.Features.Reservations.Dtos;

public class CreateReservationRequest
{
    [Required]
    public int GuestId { get; set; }

    [Required]
    public int RoomId { get; set; }

    [Required]
    public int ReservationStatusId { get; set; }

    [Required]
    public DateTime CheckInDate { get; set; }

    [Required]
    public DateTime CheckOutDate { get; set; }

    [Required]
    public decimal DailyRate { get; set; }

    public decimal TotalAmount { get; set; }

    public string Notes { get; set; } = string.Empty;
}
