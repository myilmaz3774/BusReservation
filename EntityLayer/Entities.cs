using System;

namespace EntityLayer
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class BusTrip
    {
        public int TripId { get; set; }
        public string Route { get; set; }
        public DateTime DepartureTime { get; set; }
        public decimal Price { get; set; }
    }

    public class Ticket
    {
        public int TicketId { get; set; }
        public int CustomerId { get; set; }
        public int TripId { get; set; }
        public int SeatNumber { get; set; }
    }
}
