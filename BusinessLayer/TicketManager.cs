using System;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLayer
{
    public class TicketManager
    {
        private TicketDAL _ticketDal;

        public TicketManager()
        {
            _ticketDal = new TicketDAL();
        }

        public bool ReserveSeat(Ticket ticket)
        {
            if (ticket.SeatNumber <= 0 || ticket.SeatNumber > 40)
            {
                throw new Exception("Hata: Geçersiz koltuk numarası! Lütfen 1-40 arası bir koltuk seçin.");
            }

            if (ticket.CustomerId <= 0 || ticket.TripId <= 0)
            {
                throw new Exception("Hata: Müşteri ve Sefer bilgileri eksiksiz doldurulmalıdır!");
            }

            return _ticketDal.InsertTicket(ticket);
        }
    }
}
