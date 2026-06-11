using Microsoft.EntityFrameworkCore;
using hotel_api.Features.Guests.Models;
using hotel_api.Features.Rooms.Models;
using hotel_api.Features.Reservations.Models;
using hotel_api.Features.ReservationStatus.Models;

namespace hotel_api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(
        DbContextOptions<AppDbContext> options
    ) : base(options)
    {
    }

    public DbSet<Guest> Guests { get; set; } = null!;
    public DbSet<Room> Rooms { get; set; } = null!;
    public DbSet<Reservation> Reservations { get; set; } = null!;
    public DbSet<ReservationStatus> ReservationStatuses { get; set; } = null!;

}