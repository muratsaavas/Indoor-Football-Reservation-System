using System;
using System.Windows.Forms;
using IndoorFootballReservation.Business;
using IndoorFootballReservation.Data;

namespace IndoorFootballReservation
{
    public partial class Form2 : Form
    {
        private readonly ReservationService _reservationService = new ReservationService();

        public Form2()
        {
            InitializeComponent();

            btnAddReservation.Click += btnAddReservation_Click;
            btnDeleteReservation.Click += btnDeleteReservation_Click;
            btnViewAll.Click += btnViewAll_Click;
            btnBackToUser.Click += btnBackToUser_Click;
            Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void LoadReservations()
        {
            dgvReservations.DataSource = null;
            dgvReservations.DataSource = _reservationService.GetAllReservations();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (dtpStartTime.Value.TimeOfDay >= dtpEndTime.Value.TimeOfDay)
            {
                MessageBox.Show("Start time must be before end time.");
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
            MessageBox.Show("Reservation added successfully.");
            LoadReservations();
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["Id"].Value);
                _reservationService.DeleteReservation(id);
                MessageBox.Show("Reservation deleted.");
                LoadReservations();
            }
            else
            {
                MessageBox.Show("Please select a reservation.");
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void btnBackToUser_Click(object sender, EventArgs e)
        {
            Form1 userForm = new Form1();
            userForm.Show();
            this.Hide();
        }

        private void dgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
