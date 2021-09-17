using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Airport_KURS.Forms
{
    public partial class Ticket : Form
    {
        #region Fileds
        private string name;
        private string surname;
        private string flight;
        private string gate;
        private string seat;
        private string from;
        private string to;
        private string date;
        private string time;
        #endregion

        #region Constructors
        public Ticket()
        {
            InitializeComponent();
        }

        public Ticket(string name, string surname, string flight, string gate, string seat, string from, string to, string date,string time)
        {
            this.name = name;
            this.surname = surname;
            this.flight = flight;
            this.gate = gate;
            this.seat = seat;
            this.from = from;
            this.to = to;
            this.date = date;
            this.time = time;
            InitializeComponent();
        }
        #endregion

        #region Button Close
        private void btnCloseTicket_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Load Event
        private void Ticket_Load(object sender, EventArgs e)
        {
            lblSurname.Text = surname;
            lblName.Text = name;
            lblFrom.Text = from;
            lblTo.Text = to;
            lblFlight.Text = flight;
            lblGate.Text = gate;
            lblSeat.Text = seat;
            lblDate.Text = date.Remove(10,9);
            lblTime.Text = time.Remove(5,3);
        }
        #endregion

        #region For Move
        bool move;
        int mouse_x;
        int mouse_y;
        private void Ticket_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Ticket_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Ticket_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        #endregion
    }
}
