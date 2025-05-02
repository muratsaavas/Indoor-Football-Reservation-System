namespace IndoorFootballReservation
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvAllReservations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAllReservations).BeginInit();
            SuspendLayout();
            // 
            // dgvAllReservations
            // 
            dgvAllReservations.AllowUserToAddRows = false;
            dgvAllReservations.AllowUserToDeleteRows = false;
            dgvAllReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllReservations.Dock = DockStyle.Fill;
            dgvAllReservations.Location = new Point(0, 0);
            dgvAllReservations.Name = "dgvAllReservations";
            dgvAllReservations.ReadOnly = true;
            dgvAllReservations.Size = new Size(600, 400);
            dgvAllReservations.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(dgvAllReservations);
            Name = "Form3";
            Text = "All Reservations Overview";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllReservations;
    }
}
