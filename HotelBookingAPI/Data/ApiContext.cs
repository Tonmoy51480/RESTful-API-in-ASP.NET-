using Microsoft.EntityFrameworkCore;
using HotelBookingAPI.Models;
using Microsoft.Extensions.Options;

namespace HotelBookingAPI.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<HotelBooking> Bookings { get; set; } = null!;
    }
}
