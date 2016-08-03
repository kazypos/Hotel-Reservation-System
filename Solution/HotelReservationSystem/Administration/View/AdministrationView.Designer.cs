namespace HotelReservationSystem.Administration.View
{
    partial class AdministrationView
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
            this.btnPrintSummnary = new System.Windows.Forms.Button();
            this.btnUpdateRoomPrice = new System.Windows.Forms.Button();
            this.btnAddNewStaff = new System.Windows.Forms.Button();
            this.AddNewRoom = new System.Windows.Forms.Button();
            this.btnAddNewHotel = new System.Windows.Forms.Button();
            this.btnAddNewRoomType = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrintSummnary);
            this.panel1.Controls.Add(this.btnUpdateRoomPrice);
            this.panel1.Controls.Add(this.btnAddNewStaff);
            this.panel1.Controls.Add(this.AddNewRoom);
            this.panel1.Controls.Add(this.btnAddNewHotel);
            this.panel1.Controls.Add(this.btnAddNewRoomType);
            this.panel1.Location = new System.Drawing.Point(103, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 222);
            this.panel1.TabIndex = 0;
            // 
            // btnPrintSummnary
            // 
            this.btnPrintSummnary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSummnary.Location = new System.Drawing.Point(400, 135);
            this.btnPrintSummnary.Name = "btnPrintSummnary";
            this.btnPrintSummnary.Size = new System.Drawing.Size(155, 67);
            this.btnPrintSummnary.TabIndex = 5;
            this.btnPrintSummnary.Text = "Print summary";
            this.btnPrintSummnary.UseVisualStyleBackColor = true;
            this.btnPrintSummnary.Click += new System.EventHandler(this.btnPrintSummnary_Click);
            // 
            // btnUpdateRoomPrice
            // 
            this.btnUpdateRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoomPrice.Location = new System.Drawing.Point(212, 137);
            this.btnUpdateRoomPrice.Name = "btnUpdateRoomPrice";
            this.btnUpdateRoomPrice.Size = new System.Drawing.Size(155, 67);
            this.btnUpdateRoomPrice.TabIndex = 4;
            this.btnUpdateRoomPrice.Text = "Update room price";
            this.btnUpdateRoomPrice.UseVisualStyleBackColor = true;
            this.btnUpdateRoomPrice.Click += new System.EventHandler(this.btnUpdateRoomPrice_Click);
            // 
            // btnAddNewStaff
            // 
            this.btnAddNewStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStaff.Location = new System.Drawing.Point(400, 20);
            this.btnAddNewStaff.Name = "btnAddNewStaff";
            this.btnAddNewStaff.Size = new System.Drawing.Size(155, 67);
            this.btnAddNewStaff.TabIndex = 2;
            this.btnAddNewStaff.Text = "Add a new staff";
            this.btnAddNewStaff.UseVisualStyleBackColor = true;
            // 
            // AddNewRoom
            // 
            this.AddNewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewRoom.Location = new System.Drawing.Point(23, 135);
            this.AddNewRoom.Name = "AddNewRoom";
            this.AddNewRoom.Size = new System.Drawing.Size(155, 67);
            this.AddNewRoom.TabIndex = 3;
            this.AddNewRoom.Text = "Add a new room";
            this.AddNewRoom.UseVisualStyleBackColor = true;
            // 
            // btnAddNewHotel
            // 
            this.btnAddNewHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewHotel.Location = new System.Drawing.Point(212, 20);
            this.btnAddNewHotel.Name = "btnAddNewHotel";
            this.btnAddNewHotel.Size = new System.Drawing.Size(155, 67);
            this.btnAddNewHotel.TabIndex = 1;
            this.btnAddNewHotel.Text = "Add a new hotel";
            this.btnAddNewHotel.UseVisualStyleBackColor = true;
            this.btnAddNewHotel.Click += new System.EventHandler(this.btnAddNewHotel_Click);
            // 
            // btnAddNewRoomType
            // 
            this.btnAddNewRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewRoomType.Location = new System.Drawing.Point(23, 20);
            this.btnAddNewRoomType.Name = "btnAddNewRoomType";
            this.btnAddNewRoomType.Size = new System.Drawing.Size(155, 67);
            this.btnAddNewRoomType.TabIndex = 0;
            this.btnAddNewRoomType.Text = "Add a new room type";
            this.btnAddNewRoomType.UseVisualStyleBackColor = true;
            this.btnAddNewRoomType.Click += new System.EventHandler(this.btnAddNewRoomType_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(713, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(79, 28);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(356, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(351, 28);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "asdfasdfasdjfjaskdhfkjhaskdjhfjkhasjkdfh";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AdministrationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 303);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Name = "AdministrationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrintSummnary;
        private System.Windows.Forms.Button btnUpdateRoomPrice;
        private System.Windows.Forms.Button btnAddNewStaff;
        private System.Windows.Forms.Button AddNewRoom;
        private System.Windows.Forms.Button btnAddNewHotel;
        private System.Windows.Forms.Button btnAddNewRoomType;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUsername;
    }
}