using Microsoft.EntityFrameworkCore;
using REST_API.Models;
using System.Security.Cryptography.X509Certificates;

namespace REST_API.Data {

    public class ApiContext : DbContext {

        public DbSet<HotelBooking> Bookings { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) {  }
    }
}
