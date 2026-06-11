namespace hotel_api.Features.Reservations.Models;

using hotel_api.Features.Guests.Models;
using hotel_api.Features.Rooms.Models;
using hotel_api.Features.ReservationStatus.Models;

public class Reservation
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid GuestId { get; set; }

    public Guid RoomId { get; set; }

    public Guid ReservationStatusId { get; set; }

    public DateTime CheckInDate { get; set; }

    public DateTime CheckOutDate { get; set; }

    public decimal DailyRate { get; set; }

    public decimal TotalAmount { get; set; }

    public string Notes { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public Guest Guest { get; set; } = null!;

    public Room Room { get; set; } = null!;

    public ReservationStatus ReservationStatus { get; set; } = null!;
}