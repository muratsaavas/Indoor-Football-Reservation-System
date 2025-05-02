using Microsoft.EntityFrameworkCore;

namespace IndoorFootballReservation.Data
{
    public class ReservationContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=reservation_db;user=root;password=;",
                new MySqlServerVersion(new Version(8, 0, 36))
            );
        }
    }
}
