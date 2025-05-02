namespace IndoorFootballReservation
{
    partial class Form1
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCustomerName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPhoneNumber = new TextBox();
            dtpReservationDate = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            dtpEndTime = new DateTimePicker();
            label5 = new Label();
            btnAddReservation = new Button();
            btnDeleteReservation = new Button();
            btnGoToAdmin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            label1.Click += label1_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(112, 6);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(100, 23);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 43);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Phone Number";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 101);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 3;
            label3.Text = "Start Time";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 72);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 4;
            label4.Text = "Reservation Date";
            label4.Click += label4_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(112, 35);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 5;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            // 
            // dtpReservationDate
            // 
            dtpReservationDate.CustomFormat = "";
            dtpReservationDate.Location = new Point(112, 64);
            dtpReservationDate.Name = "dtpReservationDate";
            dtpReservationDate.Size = new Size(200, 23);
            dtpReservationDate.TabIndex = 6;
            dtpReservationDate.ValueChanged += dtpReservationDate_ValueChanged;
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "HH:mm";
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(112, 93);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(200, 23);
            dtpStartTime.TabIndex = 7;
            dtpStartTime.ValueChanged += dtpStartTime_ValueChanged_1;
            // 
            // dtpEndTime
            // 
            dtpEndTime.CustomFormat = "HH:mm";
            dtpEndTime.Format = DateTimePickerFormat.Custom;
            dtpEndTime.Location = new Point(112, 122);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(200, 23);
            dtpEndTime.TabIndex = 8;
            dtpEndTime.ValueChanged += dtpEndTime_ValueChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 130);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 9;
            label5.Text = "End Time";
            label5.Click += label5_Click;
            // 
            // btnAddReservation
            // 
            btnAddReservation.Location = new Point(6, 179);
            btnAddReservation.Name = "btnAddReservation";
            btnAddReservation.Size = new Size(109, 23);
            btnAddReservation.TabIndex = 10;
            btnAddReservation.Text = "Add Reservation";
            btnAddReservation.UseVisualStyleBackColor = true;
            btnAddReservation.Click += btnAddReservation_Click_1;
            // 
            // btnDeleteReservation
            // 
            btnDeleteReservation.Location = new Point(121, 179);
            btnDeleteReservation.Name = "btnDeleteReservation";
            btnDeleteReservation.Size = new Size(113, 23);
            btnDeleteReservation.TabIndex = 11;
            btnDeleteReservation.Text = "Delete Reservation";
            btnDeleteReservation.UseVisualStyleBackColor = true;
            btnDeleteReservation.Click += btnDeleteReservation_Click_1;
            // 
            // btnGoToAdmin
            // 
            btnGoToAdmin.Location = new Point(240, 179);
            btnGoToAdmin.Name = "btnGoToAdmin";
            btnGoToAdmin.Size = new Size(113, 23);
            btnGoToAdmin.TabIndex = 12;
            btnGoToAdmin.Text = "Admin Panel";
            btnGoToAdmin.UseVisualStyleBackColor = true;
            btnGoToAdmin.Click += btnGoToAdmin_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 268);
            Controls.Add(btnGoToAdmin);
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
            Name = "Form1";
            Text = "User Reservation Panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPhoneNumber;
        private DateTimePicker dtpReservationDate;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndTime;
        private Label label5;
        private Button btnAddReservation;
        private Button btnDeleteReservation;
        private Button btnGoToAdmin;
    }
}
