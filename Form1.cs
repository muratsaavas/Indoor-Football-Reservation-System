using System;
using System.Windows.Forms;
using IndoorFootballReservation.Business;
using IndoorFootballReservation.Data;
using Microsoft.VisualBasic;

namespace IndoorFootballReservation
{
    public partial class Form1 : Form
    {
        private readonly ReservationService _reservationService = new ReservationService();

        public Form1()
        {
            InitializeComponent();

           
            this.btnAddReservation.Click += btnAddReservation_Click;
            this.btnDeleteReservation.Click += btnDeleteReservation_Click;
            this.dtpStartTime.ValueChanged += dtpStartTime_ValueChanged;
            this.dtpEndTime.ValueChanged += dtpEndTime_ValueChanged;
            this.btnGoToAdmin.Click += btnGoToAdmin_Click; // Þifreli admin geçiþi
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpStartTime.Value.TimeOfDay >= dtpEndTime.Value.TimeOfDay)
            {
                MessageBox.Show("Start Time must be earlier than End Time!", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var reservation = new Reservation
            {
                CustomerName = txtCustomerName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                ReservationDate = dtpReservationDate.Value.Date,
                StartTime = dtpStartTime.Value.TimeOfDay,
                EndTime = dtpEndTime.Value.TimeOfDay
            };

            _reservationService.AddReservation(reservation);
            MessageBox.Show("Reservation added successfully!");
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Only admins can delete reservations from the system. Please contact an admin.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpStartTime.Value;
            int minutes = dt.Minute;
            int mod = minutes % 30;
            if (mod != 0)
            {
                dtpStartTime.Value = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, minutes - mod, 0);
            }
        }

        private void dtpEndTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpEndTime.Value;
            int minutes = dt.Minute;
            int mod = minutes % 30;
            if (mod != 0)
            {
                dtpEndTime.Value = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, minutes - mod, 0);
            }
        }
        private void btnGoToAdmin_Click(object sender, EventArgs e)
        {
            string username = Interaction.InputBox("Enter Admin Username:", "Admin Login", "");
            string password = Interaction.InputBox("Enter Admin Password:", "Admin Login", "");

            if (username == "murat" && password == "pru2025")
            {
                Form2 adminPanel = new Form2();
                adminPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void txtCustomerName_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void dtpReservationDate_ValueChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void dtpStartTime_ValueChanged_1(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void dtpEndTime_ValueChanged_1(object sender, EventArgs e) { }
        private void btnAddReservation_Click_1(object sender, EventArgs e) { }
        private void btnDeleteReservation_Click_1(object sender, EventArgs e) { }
        private void dgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnGoToAdmin_Click_1(object sender, EventArgs e)
        {

        }
    }
}
