using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Airport_KURS.Forms
{
    public partial class FormBalance : Form
    {
        #region Constructor
        public FormBalance()
        {
            InitializeComponent();
        }
        #endregion

        #region FormBalance Load
        private void FormBalance_Load(object sender, EventArgs e)
        {
            LoadTheme();
            string Query = "select Ticket_Id, Passenger_Id, Ticket_FromWhere, Ticket_ToWhere, Ticket_DateFlight, Ticket_FlightTime, Ticket_ReturnDate, Ticket_Price, Ticket_FlightNumber, Ticket_Gate, Ticket_Seat, Ticket_Carrier from Ticket where Ticket_IsSold = 'true' and Passenger_Id = @Id";
            SqlCommand command = new SqlCommand(Query, FormLogin.connection);
            command.Parameters.AddWithValue("@Id", FormLogin.Passenger_Id);
            FormLogin.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            grdHistory.AutoGenerateColumns = false;
            grdHistory.DataSource = dt;

            FormLogin.connection.Close();
        }
        #endregion

        #region Method Load Theme
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            lblBalance.ForeColor = ThemeColor.SecondaryColor;
        }
        #endregion

        #region Button Show
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (grdHistory.SelectedRows.Count > 0)
            {

                string query = "select Passenger_Name from Passenger where Passenger_Id = @idName";
                string query2 = "select Passenger_Surname from Passenger where Passenger_Id = @idSurname";

                SqlCommand command = new SqlCommand(query, FormLogin.connection);
                command.Parameters.AddWithValue("@idName", FormLogin.Passenger_Id);
                SqlCommand command2 = new SqlCommand(query2, FormLogin.connection);
                command2.Parameters.AddWithValue("@idSurname", FormLogin.Passenger_Id);
                FormLogin.connection.Open();
                string name = command.ExecuteScalar().ToString();
                string surname = command2.ExecuteScalar().ToString();
                FormLogin.connection.Close();

                int index = grdHistory.SelectedRows[0].Index;
                string flight = grdHistory.Rows[index].Cells["Flight"].Value.ToString();
                string gate = grdHistory.Rows[index].Cells["Gate"].Value.ToString();
                string seat = grdHistory.Rows[index].Cells["Seat"].Value.ToString();
                string from = grdHistory.Rows[index].Cells["FromWhere"].Value.ToString();
                string to = grdHistory.Rows[index].Cells["ToWhere"].Value.ToString();
                string date = grdHistory.Rows[index].Cells["DateFlight"].Value.ToString();
                string time = grdHistory.Rows[index].Cells["FlightTime"].Value.ToString();

                Ticket ticket = new Ticket(name, surname, flight, gate, seat, from, to, date, time);
                ticket.Show();
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa bilet seçin !", "Program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion
    }
}
