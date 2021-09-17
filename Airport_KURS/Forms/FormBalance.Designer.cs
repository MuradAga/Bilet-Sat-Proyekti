
namespace Airport_KURS.Forms
{
    partial class FormBalance
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
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.grdHistory = new System.Windows.Forms.DataGridView();
            this.TicketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassengerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromWhere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToWhere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBalance.ForeColor = System.Drawing.Color.Black;
            this.lblBalance.Location = new System.Drawing.Point(4, 14);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(128, 26);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "TARIX";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Location = new System.Drawing.Point(466, 334);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(86, 25);
            this.btnShow.TabIndex = 19;
            this.btnShow.Text = "Göstər";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // grdHistory
            // 
            this.grdHistory.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.grdHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketId,
            this.Gate,
            this.Seat,
            this.Flight,
            this.PassengerId,
            this.FromWhere,
            this.ToWhere,
            this.DateFlight,
            this.FlightTime,
            this.ReturnDate,
            this.Price,
            this.Carrier});
            this.grdHistory.GridColor = System.Drawing.Color.DimGray;
            this.grdHistory.Location = new System.Drawing.Point(1, 54);
            this.grdHistory.Name = "grdHistory";
            this.grdHistory.RowTemplate.Height = 25;
            this.grdHistory.Size = new System.Drawing.Size(567, 248);
            this.grdHistory.TabIndex = 21;
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
            // FlightTime
            // 
            this.FlightTime.DataPropertyName = "Ticket_FlightTime";
            this.FlightTime.HeaderText = "Saat";
            this.FlightTime.Name = "FlightTime";
            this.FlightTime.Width = 70;
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "Ticket_ReturnDate";
            this.ReturnDate.HeaderText = "Dönüş tarixi";
            this.ReturnDate.Name = "ReturnDate";
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
            // FormBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(564, 381);
            this.Controls.Add(this.grdHistory);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblBalance);
            this.Name = "FormBalance";
            this.Text = "FormBalance";
            this.Load += new System.EventHandler(this.FormBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNameForm;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView grdHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flight;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassengerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromWhere;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToWhere;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrier;
    }
}