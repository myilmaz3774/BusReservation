using System;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;

namespace UILayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket newTicket = new Ticket
                {
                    CustomerId = Convert.ToInt32(txtCustomerId.Text),
                    TripId = Convert.ToInt32(txtTripId.Text),
                    SeatNumber = Convert.ToInt32(txtSeatNumber.Text)
                };

                TicketManager manager = new TicketManager();
                bool isSuccess = manager.ReserveSeat(newTicket);

                if (isSuccess)
                {
                    MessageBox.Show("Bilet başarıyla rezerve edildi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistem Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
