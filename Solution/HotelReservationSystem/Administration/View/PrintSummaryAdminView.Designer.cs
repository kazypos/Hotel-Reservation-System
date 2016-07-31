namespace HotelReservationSystem.Administration.View
{
    partial class PrintSummaryAdminView
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datePickerOut = new System.Windows.Forms.DateTimePicker();
            this.datePickerIn = new System.Windows.Forms.DateTimePicker();
            this.btnViewRevenue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboRoomType = new System.Windows.Forms.ComboBox();
            this.comboHotel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.dataGridViewStatistic = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Admin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datePickerOut);
            this.groupBox1.Controls.Add(this.datePickerIn);
            this.groupBox1.Controls.Add(this.btnViewRevenue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboRoomType);
            this.groupBox1.Controls.Add(this.comboHotel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select room";
            // 
            // datePickerOut
            // 
            this.datePickerOut.CustomFormat = "MM/dd/yyyy";
            this.datePickerOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerOut.Location = new System.Drawing.Point(412, 73);
            this.datePickerOut.Name = "datePickerOut";
            this.datePickerOut.Size = new System.Drawing.Size(95, 20);
            this.datePickerOut.TabIndex = 8;
            this.datePickerOut.Value = new System.DateTime(2015, 11, 20, 0, 0, 0, 0);
            this.datePickerOut.ValueChanged += new System.EventHandler(this.datePickerOut_ValueChanged);
            // 
            // datePickerIn
            // 
            this.datePickerIn.CustomFormat = "MM/dd/yyyy";
            this.datePickerIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerIn.Location = new System.Drawing.Point(412, 31);
            this.datePickerIn.Name = "datePickerIn";
            this.datePickerIn.Size = new System.Drawing.Size(95, 20);
            this.datePickerIn.TabIndex = 7;
            this.datePickerIn.Value = new System.DateTime(2015, 11, 1, 0, 0, 0, 0);
            this.datePickerIn.ValueChanged += new System.EventHandler(this.datePickerIn_ValueChanged);
            // 
            // btnViewRevenue
            // 
            this.btnViewRevenue.Location = new System.Drawing.Point(21, 119);
            this.btnViewRevenue.Name = "btnViewRevenue";
            this.btnViewRevenue.Size = new System.Drawing.Size(127, 23);
            this.btnViewRevenue.TabIndex = 6;
            this.btnViewRevenue.Text = "View revenue";
            this.btnViewRevenue.UseVisualStyleBackColor = true;
            this.btnViewRevenue.Click += new System.EventHandler(this.btnViewRevenue_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Check out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Check in";
            // 
            // comboRoomType
            // 
            this.comboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRoomType.FormattingEnabled = true;
            this.comboRoomType.Location = new System.Drawing.Point(117, 73);
            this.comboRoomType.Name = "comboRoomType";
            this.comboRoomType.Size = new System.Drawing.Size(172, 21);
            this.comboRoomType.TabIndex = 3;
            this.comboRoomType.SelectedIndexChanged += new System.EventHandler(this.comboRoomType_SelectedIndexChanged);
            // 
            // comboHotel
            // 
            this.comboHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHotel.FormattingEnabled = true;
            this.comboHotel.Location = new System.Drawing.Point(117, 31);
            this.comboHotel.Name = "comboHotel";
            this.comboHotel.Size = new System.Drawing.Size(172, 21);
            this.comboHotel.TabIndex = 2;
            this.comboHotel.SelectedIndexChanged += new System.EventHandler(this.comboHotel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select room type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select hotel";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(16, 505);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(204, 22);
            this.lblTotalRevenue.TabIndex = 2;
            this.lblTotalRevenue.Text = "Total revenue: 130($)";
            // 
            // dataGridViewStatistic
            // 
            this.dataGridViewStatistic.AllowUserToAddRows = false;
            this.dataGridViewStatistic.AllowUserToDeleteRows = false;
            this.dataGridViewStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistic.Location = new System.Drawing.Point(20, 239);
            this.dataGridViewStatistic.Name = "dataGridViewStatistic";
            this.dataGridViewStatistic.ReadOnly = true;
            this.dataGridViewStatistic.Size = new System.Drawing.Size(842, 263);
            this.dataGridViewStatistic.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(20, 539);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PrintSummaryAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 574);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewStatistic);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "PrintSummaryAdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print summary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboRoomType;
        private System.Windows.Forms.ComboBox comboHotel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnViewRevenue;
        private System.Windows.Forms.DateTimePicker datePickerIn;
        private System.Windows.Forms.DateTimePicker datePickerOut;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.DataGridView dataGridViewStatistic;
        private System.Windows.Forms.Button btnClose;
    }
}