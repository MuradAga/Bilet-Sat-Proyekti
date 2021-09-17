using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_KURS
{
    public partial class FormLogin : Form
    {
        #region Fields
        public static string Query;
        public static string Query2;
        public static int Passenger_Id;
        public static SqlConnection connection = new SqlConnection("Data Source=WIN-4PT45T6MS0U; Initial Catalog=Airport; Integrated Security=TRUE");
        #endregion

        #region Constructor
        public FormLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Move
        bool move;
        int mouse_x;
        int mouse_y;

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void FormLogin_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        #endregion

        #region TextBoxes
        private void txtUsername_Click(object sender, EventArgs e)
        {
            lblIncorrectUserNameAndOrPassword.Text = "";
            txtUsername.Clear();
            pnlUsername.BackColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            pnlPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            lblIncorrectUserNameAndOrPassword.Text = "";
            txtPassword.Clear();
            txtPassword.PasswordChar = '*';
            pnlPassword.BackColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            pnlUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;
        }
        #endregion

        #region Button Exit FormLogin
        private void btnExitFormLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Button Sign Up
        private void btnSingUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp signUp = new FormSignUp();
            signUp.ShowDialog();
        }

        #endregion

        #region PictureBox Show Password
        int n = 3;
        char? none = null;
        private void picShowPassword_Click(object sender, EventArgs e)
        {
            if (n % 2 == 1)
            {
                picShowPassword.BorderStyle = BorderStyle.Fixed3D;
                txtPassword.PasswordChar = Convert.ToChar(none);
            }
            else
            {
                picShowPassword.BorderStyle = BorderStyle.None;
                txtPassword.PasswordChar = '*';
            }
            n++;
        }
        #endregion

        #region Button Login

        bool isThere;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Query = "select * from Passenger";
            connection.Open();

            SqlCommand command = new SqlCommand(Query,connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
               if (txtUsername.Text == reader["Passenger_UserName"].ToString().TrimEnd() && txtPassword.Text == reader["Passenger_Password"].ToString().TrimEnd())
               {
                    Passenger_Id = Convert.ToInt32(reader["Passenger_Id"]);
                 isThere = true;
                 break;
               }
               else
               {
                   isThere = false;
               }
            }
            connection.Close();

            if (isThere)
            {
                this.Hide();
                FormMenu menu = new FormMenu();
                menu.ShowDialog();
            }
            else
            {
                lblIncorrectUserNameAndOrPassword.Text = "İstifadəçi adı və ya şifrə yanlışdır !";
                pnlUsername.BackColor = Color.FromArgb(255, 44, 41);
                pnlPassword.BackColor = Color.FromArgb(255, 44, 41);
            }
        }
        #endregion

    }
}
