using System.Collections.Generic;
using System.Linq;
using IndoorFootballReservation.Data;

namespace IndoorFootballReservation.Business
{
    public class ReservationService
    {
        private readonly ReservationContext _context;

        public ReservationService()
        {
            _context = new ReservationContext();
        }

        public void AddReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
        }

        public List<Reservation> GetAllReservations()
        {
            return _context.Reservations.ToList();
        }

        public void DeleteReservation(int id)
        {
            var reservation = _context.Reservations.FirstOrDefault(r => r.Id == id);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
                _context.SaveChanges();
            }
        }
    }
}
