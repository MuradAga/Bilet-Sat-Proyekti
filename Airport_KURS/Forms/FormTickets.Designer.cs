
namespace Airport_KURS.Forms
{
    partial class FormTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTickets));
            this.grdTickets = new System.Windows.Forms.DataGridView();
            this.lblWhereFrom = new System.Windows.Forms.Label();
            this.lblToWhere = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblDateOfReturn = new System.Windows.Forms.Label();
            this.chkOneWay = new System.Windows.Forms.CheckBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.dtDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dtDateOfReturn = new System.Windows.Forms.DateTimePicker();
            this.picCalendar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.picLocation = new System.Windows.Forms.PictureBox();
            this.cmbWhereFrom = new System.Windows.Forms.ComboBox();
            this.cmbToWhere = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TicketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassengerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromWhere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToWhere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTickets
            // 
            this.grdTickets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(58)))), ((int)(((byte)(186)))));
            this.grdTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketId,
            this.Gate,
            this.Seat,
            this.Flight,
            this.PassengerId,
            this.FromWhere,
            this.ToWhere,
            this.DateFlight,
            this.ReturnDate,
            this.FlightTime,
            this.Price,
            this.Carrier});
            this.grdTickets.GridColor = System.Drawing.Color.DimGray;
            this.grdTickets.Location = new System.Drawing.Point(2, 125);
            this.grdTickets.Name = "grdTickets";
            this.grdTickets.RowTemplate.Height = 25;
            this.grdTickets.Size = new System.Drawing.Size(553, 248);
            this.grdTickets.TabIndex = 19;
            // 
            // lblWhereFrom
            // 
            this.lblWhereFrom.AutoSize = true;
            this.lblWhereFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWhereFrom.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWhereFrom.ForeColor = System.Drawing.Color.Black;
            this.lblWhereFrom.Location = new System.Drawing.Point(8, 10);
            this.lblWhereFrom.Name = "lblWhereFrom";
            this.lblWhereFrom.Size = new System.Drawing.Size(51, 13);
            this.lblWhereFrom.TabIndex = 21;
            this.lblWhereFrom.Text = "Haradan";
            // 
            // lblToWhere
            // 
            this.lblToWhere.AutoSize = true;
            this.lblToWhere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblToWhere.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToWhere.ForeColor = System.Drawing.Color.Black;
            this.lblToWhere.Location = new System.Drawing.Point(166, 10);
            this.lblToWhere.Name = "lblToWhere";
            this.lblToWhere.Size = new System.Drawing.Size(42, 13);
            this.lblToWhere.TabIndex = 23;
            this.lblToWhere.Text = "Haraya";
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDepartureDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepartureDate.ForeColor = System.Drawing.Color.Black;
            this.lblDepartureDate.Location = new System.Drawing.Point(301, 15);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(64, 13);
            this.lblDepartureDate.TabIndex = 26;
            this.lblDepartureDate.Text = "Gediş tarixi";
            // 
            // lblDateOfReturn
            // 
            this.lblDateOfReturn.AutoSize = true;
            this.lblDateOfReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDateOfReturn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfReturn.ForeColor = System.Drawing.Color.Black;
            this.lblDateOfReturn.Location = new System.Drawing.Point(424, 15);
            this.lblDateOfReturn.Name = "lblDateOfReturn";
            this.lblDateOfReturn.Size = new System.Drawing.Size(69, 13);
            this.lblDateOfReturn.TabIndex = 27;
            this.lblDateOfReturn.Text = "Dönüş tarixi";
            // 
            // chkOneWay
            // 
            this.chkOneWay.AutoSize = true;
            this.chkOneWay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOneWay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkOneWay.ForeColor = System.Drawing.Color.Black;
            this.chkOneWay.Location = new System.Drawing.Point(405, 66);
            this.chkOneWay.Name = "chkOneWay";
            this.chkOneWay.Size = new System.Drawing.Size(76, 18);
            this.chkOneWay.TabIndex = 28;
            this.chkOneWay.Text = "Tək gedişli";
            this.chkOneWay.UseVisualStyleBackColor = true;
            this.chkOneWay.CheckedChanged += new System.EventHandler(this.chkOneWay_CheckedChanged);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.Location = new System.Drawing.Point(482, 66);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(66, 30);
            this.btnFind.TabIndex = 29;
            this.btnFind.Text = "Axtar";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dtDepartureDate
            // 
            this.dtDepartureDate.CalendarForeColor = System.Drawing.Color.Black;
            this.dtDepartureDate.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDepartureDate.Location = new System.Drawing.Point(301, 31);
            this.dtDepartureDate.Name = "dtDepartureDate";
            this.dtDepartureDate.Size = new System.Drawing.Size(97, 22);
            this.dtDepartureDate.TabIndex = 30;
            // 
            // dtDateOfReturn
            // 
            this.dtDateOfReturn.CalendarForeColor = System.Drawing.Color.Black;
            this.dtDateOfReturn.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtDateOfReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOfReturn.Location = new System.Drawing.Point(424, 31);
            this.dtDateOfReturn.Name = "dtDateOfReturn";
            this.dtDateOfReturn.Size = new System.Drawing.Size(97, 22);
            this.dtDateOfReturn.TabIndex = 31;
            // 
            // picCalendar
            // 
            this.picCalendar.Image = ((System.Drawing.Image)(resources.GetObject("picCalendar.Image")));
            this.picCalendar.Location = new System.Drawing.Point(401, 33);
            this.picCalendar.Name = "picCalendar";
            this.picCalendar.Size = new System.Drawing.Size(20, 20);
            this.picCalendar.TabIndex = 32;
            this.picCalendar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(524, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuy.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuy.ForeColor = System.Drawing.Color.Black;
            this.btnBuy.Location = new System.Drawing.Point(8, 87);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(86, 25);
            this.btnBuy.TabIndex = 34;
            this.btnBuy.Text = "Bileti al";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // picLocation
            // 
            this.picLocation.Image = ((System.Drawing.Image)(resources.GetObject("picLocation.Image")));
            this.picLocation.Location = new System.Drawing.Point(135, 26);
            this.picLocation.Name = "picLocation";
            this.picLocation.Size = new System.Drawing.Size(25, 25);
            this.picLocation.TabIndex = 35;
            this.picLocation.TabStop = false;
            // 
            // cmbWhereFrom
            // 
            this.cmbWhereFrom.BackColor = System.Drawing.Color.LightBlue;
            this.cmbWhereFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbWhereFrom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbWhereFrom.FormattingEnabled = true;
            this.cmbWhereFrom.Items.AddRange(new object[] {
            "Baku",
            "Istanbul"});
            this.cmbWhereFrom.Location = new System.Drawing.Point(8, 28);
            this.cmbWhereFrom.Name = "cmbWhereFrom";
            this.cmbWhereFrom.Size = new System.Drawing.Size(121, 25);
            this.cmbWhereFrom.TabIndex = 36;
            // 
            // cmbToWhere
            // 
            this.cmbToWhere.BackColor = System.Drawing.Color.LightBlue;
            this.cmbToWhere.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbToWhere.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbToWhere.FormattingEnabled = true;
            this.cmbToWhere.Items.AddRange(new object[] {
            "Baku",
            "Istanbul"});
            this.cmbToWhere.Location = new System.Drawing.Point(166, 28);
            this.cmbToWhere.Name = "cmbToWhere";
            this.cmbToWhere.Size = new System.Drawing.Size(121, 25);
            this.cmbToWhere.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(8, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 3);
            this.panel1.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(109, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 35);
            this.panel3.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(109, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(443, 3);
            this.panel5.TabIndex = 41;
            // 
            // TicketId
            // 
            this.TicketId.DataPropertyName = "Ticket_Id";
            this.TicketId.HeaderText = "TicketId";
            this.TicketId.Name = "TicketId";
            this.TicketId.Visible = false;
            // 
            // Gate
            // 
            this.Gate.DataPropertyName = "Ticket_Gate";
            this.Gate.HeaderText = "Keçid";
            this.Gate.Name = "Gate";
            this.Gate.Visible = false;
            // 
            // Seat
            // 
            this.Seat.DataPropertyName = "Ticket_Seat";
            this.Seat.HeaderText = "Oturacaq";
            this.Seat.Name = "Seat";
            this.Seat.Visible = false;
            // 
            // Flight
            // 
            this.Flight.DataPropertyName = "Ticket_FlightNumber";
            this.Flight.HeaderText = "Uçuş";
            this.Flight.Name = "Flight";
            this.Flight.Visible = false;
            // 
            // PassengerId
            // 
            this.PassengerId.DataPropertyName = "Passenger_Id";
            this.PassengerId.HeaderText = "PassengerId";
            this.PassengerId.Name = "PassengerId";
            this.PassengerId.Visible = false;
            // 
            // FromWhere
            // 
            this.FromWhere.DataPropertyName = "Ticket_FromWhere";
            this.FromWhere.HeaderText = "Haradan";
            this.FromWhere.Name = "FromWhere";
            // 
            // ToWhere
            // 
            this.ToWhere.DataPropertyName = "Ticket_ToWhere";
            this.ToWhere.HeaderText = "Haraya";
            this.ToWhere.Name = "ToWhere";
            // 
            // DateFlight
            // 
            this.DateFlight.DataPropertyName = "Ticket_DateFlight";
            this.DateFlight.HeaderText = "Gediş tarixi";
            this.DateFlight.Name = "DateFlight";
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "Ticket_ReturnDate";
            this.ReturnDate.HeaderText = "Dönüş tarixi";
            this.ReturnDate.Name = "ReturnDate";
            // 
            // FlightTime
            // 
            this.FlightTime.DataPropertyName = "Ticket_FlightTime";
            this.FlightTime.HeaderText = "Saat";
            this.FlightTime.Name = "FlightTime";
            this.FlightTime.Width = 70;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Ticket_Price";
            this.Price.HeaderText = "Qiymət";
            this.Price.Name = "Price";
            this.Price.Width = 50;
            // 
            // Carrier
            // 
            this.Carrier.DataPropertyName = "Ticket_Carrier";
            this.Carrier.HeaderText = "Şirkət";
            this.Carrier.Name = "Carrier";
            // 
            // FormTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(58)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(557, 377);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbToWhere);
            this.Controls.Add(this.cmbWhereFrom);
            this.Controls.Add(this.picLocation);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picCalendar);
            this.Controls.Add(this.dtDateOfReturn);
            this.Controls.Add(this.dtDepartureDate);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.chkOneWay);
            this.Controls.Add(this.lblDateOfReturn);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.lblToWhere);
            this.Controls.Add(this.lblWhereFrom);
            this.Controls.Add(this.grdTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTickets";
            this.Text = "FormTickets";
            this.Load += new System.EventHandler(this.FormTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameForm;
        private System.Windows.Forms.DataGridView grdTickets;
        private System.Windows.Forms.Label lblWhereFrom;
        private System.Windows.Forms.Label lblToWhere;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblDateOfReturn;
        private System.Windows.Forms.CheckBox chkOneWay;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DateTimePicker dtDepartureDate;
        private System.Windows.Forms.DateTimePicker dtDateOfReturn;
        private System.Windows.Forms.PictureBox picCalendar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.PictureBox picLocation;
        private System.Windows.Forms.ComboBox cmbWhereFrom;
        private System.Windows.Forms.ComboBox cmbToWhere;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flight;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassengerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromWhere;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToWhere;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrier;
    }
}