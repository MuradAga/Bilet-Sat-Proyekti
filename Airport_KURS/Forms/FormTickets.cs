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
    public partial class FormTickets : Form
    {
        #region Constructor
        public FormTickets()
        {
            InitializeComponent();
        }
        #endregion

        #region FormTickets Load
        private void FormTickets_Load(object sender, EventArgs e)
        {
            LoadTheme();
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
        }
        #endregion

        #region CheckBox One Way
        private void chkOneWay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOneWay.Checked)
            {
                dtDateOfReturn.Enabled = false;
            }
            else
            {
                dtDateOfReturn.Enabled = true;
            }
        }
        #endregion

        #region Button Find
        private void btnFind_Click(object sender, EventArgs e)
        {
            string Query = "update Ticket set Ticket_DateFlight = @dateFlight, Ticket_ReturnDate = @returnDate";
            FormLogin.connection.Open();
            SqlCommand command = new SqlCommand(Query, FormLogin.connection);
            command.Parameters.AddWithValue("@dateFlight", dtDepartureDate.Value);
            if (dtDateOfReturn.Enabled )
            {
                command.Parameters.AddWithValue("@returnDate", dtDateOfReturn.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@returnDate", Convert.ToDateTime("01.01.1753"));
            }
            command.ExecuteNonQuery();


            string Query2 = "select Ticket_Id, Passenger_Id, Ticket_FromWhere, Ticket_ToWhere, Ticket_DateFlight, Ticket_FlightTime, Ticket_ReturnDate, Ticket_Price, Ticket_FlightNumber, Ticket_Gate, Ticket_Seat, Ticket_Carrier from Ticket where Ticket_IsSold = 'false' and Ticket_FromWhere = @from and Ticket_ToWhere = @to";
            SqlCommand command2 = new SqlCommand(Query2, FormLogin.connection);
            command2.Parameters.AddWithValue("@from",cmbWhereFrom.SelectedItem.ToString());
            command2.Parameters.AddWithValue("@to",cmbToWhere.SelectedItem.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter(command2);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            grdTickets.AutoGenerateColumns = false;
            grdTickets.DataSource = dt;

            FormLogin.connection.Close();
        }
        #endregion

        #region Button Buy
        DialogResult rs;

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (grdTickets.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bu bileti almaq istədiyinizə əminsiniz ?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int index = grdTickets.SelectedRows[0].Index;
                    string ticket_id = grdTickets.Rows[index].Cells["TicketId"].Value.ToString();
                    string Query = "update Ticket set Ticket_IsSold = 'true', Passenger_Id = @Passenger_Id where Ticket_Id = @Ticket_Id";
                    SqlCommand command = new SqlCommand(Query, FormLogin.connection);
                    command.Parameters.AddWithValue("@Passenger_Id", FormLogin.Passenger_Id);
                    command.Parameters.AddWithValue("@Ticket_Id", ticket_id);
                    FormLogin.connection.Open();
                    command.ExecuteNonQuery();
                    FormLogin.connection.Close();
                    rs = MessageBox.Show("Bilet alındı !", "Program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (rs == DialogResult.OK)
                    {
                        string Query2 = "update Ticket set Ticket_DateFlight = @dateFlight, Ticket_ReturnDate = @returnDate";
                        FormLogin.connection.Open();
                        SqlCommand command2 = new SqlCommand(Query2, FormLogin.connection);
                        command2.Parameters.AddWithValue("@dateFlight", dtDepartureDate.Value);
                        if (dtDateOfReturn.Enabled)
                        {

                            command2.Parameters.AddWithValue("@returnDate", dtDateOfReturn.Value);
                        }
                        else
                        {
                            command2.Parameters.AddWithValue("@returnDate", Convert.ToDateTime(""));
                        }
                        command2.ExecuteNonQuery();


                        string Query3 = "select Ticket_Id, Passenger_Id, Ticket_FromWhere, Ticket_ToWhere, Ticket_DateFlight, Ticket_FlightTime, Ticket_ReturnDate, Ticket_Price, Ticket_FlightNumber, Ticket_Gate, Ticket_Seat, Ticket_Carrier from Ticket where Ticket_IsSold = 'false' and Ticket_FromWhere = @from and Ticket_ToWhere = @to";
                        SqlCommand command3 = new SqlCommand(Query3, FormLogin.connection);
                        command3.Parameters.AddWithValue("@from", cmbWhereFrom.SelectedItem.ToString());
                        command3.Parameters.AddWithValue("@to", cmbToWhere.SelectedItem.ToString());
                        SqlDataAdapter adapter = new SqlDataAdapter(command3);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        grdTickets.AutoGenerateColumns = false;
                        grdTickets.DataSource = dt;

                        FormLogin.connection.Close();
                    }
                }
            }

            else
            {
                MessageBox.Show("Zəhmət olmasa bilet seçin !", "Program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion
    }
}
