using System;
using System.Windows.Forms;
using IndoorFootballReservation.Business;

namespace IndoorFootballReservation
{
    public partial class Form3 : Form
    {
        private readonly ReservationService _reservationService = new ReservationService();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadAllReservations();
        }

        private void LoadAllReservations()
        {
            dgvAllReservations.DataSource = null;
            dgvAllReservations.DataSource = _reservationService.GetAllReservations();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

    }
}
