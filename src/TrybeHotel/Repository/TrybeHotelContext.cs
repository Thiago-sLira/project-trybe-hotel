using Microsoft.EntityFrameworkCore;
using TrybeHotel.Models;

namespace TrybeHotel.Repository;
public class TrybeHotelContext : DbContext, ITrybeHotelContext
{
    public DbSet<City> Cities { get; set; }

    public DbSet<Hotel> Hotels { get; set; }

    public DbSet<Room> Rooms { get; set; }
    
    public TrybeHotelContext(DbContextOptions<TrybeHotelContext> options) : base(options) { }
    public TrybeHotelContext() { }

}