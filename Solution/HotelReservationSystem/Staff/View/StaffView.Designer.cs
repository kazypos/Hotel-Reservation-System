namespace HotelReservationSystem.Staff.View
{
    partial class StaffView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrintSummary = new System.Windows.Forms.Button();
            this.btnMakeNewBooking = new System.Windows.Forms.Button();
            this.btnUpdateInforStaff = new System.Windows.Forms.Button();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrintSummary);
            this.panel1.Controls.Add(this.btnMakeNewBooking);
            this.panel1.Controls.Add(this.btnUpdateInforStaff);
            this.panel1.Controls.Add(this.btnAddNewCustomer);
            this.panel1.Location = new System.Drawing.Point(72, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 312);
            this.panel1.TabIndex = 0;
            // 
            // btnPrintSummary
            // 
            this.btnPrintSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSummary.Location = new System.Drawing.Point(263, 180);
            this.btnPrintSummary.Name = "btnPrintSummary";
            this.btnPrintSummary.Size = new System.Drawing.Size(181, 100);
            this.btnPrintSummary.TabIndex = 3;
            this.btnPrintSummary.Text = "Print summary";
            this.btnPrintSummary.UseVisualStyleBackColor = true;
            this.btnPrintSummary.Click += new System.EventHandler(this.btnPrintSummary_Click);
            // 
            // btnMakeNewBooking
            // 
            this.btnMakeNewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeNewBooking.Location = new System.Drawing.Point(30, 180);
            this.btnMakeNewBooking.Name = "btnMakeNewBooking";
            this.btnMakeNewBooking.Size = new System.Drawing.Size(181, 100);
            this.btnMakeNewBooking.TabIndex = 2;
            this.btnMakeNewBooking.Text = "Make a new booking";
            this.btnMakeNewBooking.UseVisualStyleBackColor = true;
            this.btnMakeNewBooking.Click += new System.EventHandler(this.btnMakeNewBooking_Click);
            // 
            // btnUpdateInforStaff
            // 
            this.btnUpdateInforStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInforStaff.Location = new System.Drawing.Point(263, 33);
            this.btnUpdateInforStaff.Name = "btnUpdateInforStaff";
            this.btnUpdateInforStaff.Size = new System.Drawing.Size(181, 100);
            this.btnUpdateInforStaff.TabIndex = 1;
            this.btnUpdateInforStaff.Text = "Update information of staff";
            this.btnUpdateInforStaff.UseVisualStyleBackColor = true;
            this.btnUpdateInforStaff.Click += new System.EventHandler(this.btnUpdateInforStaff_Click);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.Location = new System.Drawing.Point(30, 33);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(181, 100);
            this.btnAddNewCustomer.TabIndex = 0;
            this.btnAddNewCustomer.Text = "Add new customer";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(539, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 27);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(182, 7);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(351, 28);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "asdfasdfasdjfjaskdhfkjhaskdjhfjkhasjkdfh";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 368);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Name = "StaffView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrintSummary;
        private System.Windows.Forms.Button btnMakeNewBooking;
        private System.Windows.Forms.Button btnUpdateInforStaff;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUsername;
    }
}