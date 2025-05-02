namespace IndoorFootballReservation
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDeleteReservation = new Button();
            btnAddReservation = new Button();
            label5 = new Label();
            dtpEndTime = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            dtpReservationDate = new DateTimePicker();
            txtPhoneNumber = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtCustomerName = new TextBox();
            label1 = new Label();
            btnViewAll = new Button();
            dgvReservations = new DataGridView();
            btnBackToUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteReservation
            // 
            btnDeleteReservation.Location = new Point(142, 197);
            btnDeleteReservation.Name = "btnDeleteReservation";
            btnDeleteReservation.Size = new Size(109, 23);
            btnDeleteReservation.TabIndex = 24;
            btnDeleteReservation.Text = "Delete Selected";
            btnDeleteReservation.UseVisualStyleBackColor = true;
            // 
            // btnAddReservation
            // 
            btnAddReservation.Location = new Point(29, 197);
            btnAddReservation.Name = "btnAddReservation";
            btnAddReservation.Size = new Size(109, 23);
            btnAddReservation.TabIndex = 23;
            btnAddReservation.Text = "Add Reservation";
            btnAddReservation.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 148);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 22;
            label5.Text = "End Time";
            // 
            // dtpEndTime
            // 
            dtpEndTime.CustomFormat = "HH:mm";
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.Location = new Point(151, 140);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(200, 23);
            dtpEndTime.TabIndex = 21;
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "HH:mm";
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(151, 111);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(200, 23);
            dtpStartTime.TabIndex = 20;
            // 
            // dtpReservationDate
            // 
            dtpReservationDate.CustomFormat = "";
            dtpReservationDate.Location = new Point(151, 82);
            dtpReservationDate.Name = "dtpReservationDate";
            dtpReservationDate.Size = new Size(200, 23);
            dtpReservationDate.TabIndex = 19;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(151, 53);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 90);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 17;
            label4.Text = "Reservation Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 119);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 16;
            label3.Text = "Start Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 61);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 15;
            label2.Text = "Phone Number";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(151, 24);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(100, 23);
            txtCustomerName.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 32);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 13;
            label1.Text = "Customer Name";
            // 
            // btnViewAll
            // 
            btnViewAll.Location = new Point(257, 197);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(103, 23);
            btnViewAll.TabIndex = 26;
            btnViewAll.Text = "View All";
            btnViewAll.UseVisualStyleBackColor = true;
            // 
            // dgvReservations
            // 
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Location = new Point(50, 237);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.Size = new Size(301, 179);
            dgvReservations.TabIndex = 25;
            dgvReservations.CellContentClick += dgvReservations_CellContentClick;
            // 
            // btnBackToUser
            // 
            btnBackToUser.Location = new Point(3, 6);
            btnBackToUser.Name = "btnBackToUser";
            btnBackToUser.Size = new Size(83, 23);
            btnBackToUser.TabIndex = 27;
            btnBackToUser.Text = "Back to User";
            btnBackToUser.UseVisualStyleBackColor = true;
            btnBackToUser.Click += btnBackToUser_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 428);
            Controls.Add(btnBackToUser);
            Controls.Add(btnViewAll);
            Controls.Add(dgvReservations);
            Controls.Add(btnDeleteReservation);
            Controls.Add(btnAddReservation);
            Controls.Add(label5);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpStartTime);
            Controls.Add(dtpReservationDate);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Admin Control Panel";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDeleteReservation;
        private Button btnAddReservation;
        private Label label5;
        private DateTimePicker dtpEndTime;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpReservationDate;
        private TextBox txtPhoneNumber;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCustomerName;
        private Label label1;
        private Button btnViewAll;
        private DataGridView dgvReservations;
        private Button btnBackToUser;
    }
}