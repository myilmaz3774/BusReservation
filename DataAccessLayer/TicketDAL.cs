using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class TicketDAL
    {
        private string connString = "Server=localhost;Database=BusReservationDB;Integrated Security=True;";

        public bool InsertTicket(Ticket ticket)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "INSERT INTO Tickets (CustomerId, TripId, SeatNumber) VALUES (@CustomerId, @TripId, @SeatNumber)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerId", ticket.CustomerId);
                cmd.Parameters.AddWithValue("@TripId", ticket.TripId);
                cmd.Parameters.AddWithValue("@SeatNumber", ticket.SeatNumber);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
