using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Airport_KURS
{
    public partial class FormSignUp : Form
    {
        #region Constructor
        public FormSignUp()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Move
        bool move;
        int mouse_x;
        int mouse_y;

        private void FormSignUp_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void FormSignUp_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void FormSignUp_MouseMove(object sender, MouseEventArgs e)
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
            txtUsername.Clear();
            pnlUsername.BackColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);

            pnlPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;

            pnlConfirmPassword.BackColor = Color.WhiteSmoke;
            txtConfirmPassword.ForeColor = Color.WhiteSmoke;

            pnlEmail.BackColor = Color.WhiteSmoke;
            txtEmail.ForeColor = Color.WhiteSmoke;

            pnlName.BackColor = Color.WhiteSmoke;
            txtName.ForeColor = Color.WhiteSmoke;

            pnlSurname.BackColor = Color.WhiteSmoke;
            txtSurname.ForeColor = Color.WhiteSmoke;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.PasswordChar = '*';
            pnlPassword.BackColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);

            pnlUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;

            pnlConfirmPassword.BackColor = Color.WhiteSmoke;
            txtConfirmPassword.ForeColor = Color.WhiteSmoke;

            pnlEmail.BackColor = Color.WhiteSmoke;
            txtEmail.ForeColor = Color.WhiteSmoke;

            pnlName.BackColor = Color.WhiteSmoke;
            txtName.ForeColor = Color.WhiteSmoke;

            pnlSurname.BackColor = Color.WhiteSmoke;
            txtSurname.ForeColor = Color.WhiteSmoke;
        }

        private void txtConfirmPassword_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.Clear();
            txtConfirmPassword.PasswordChar = '*';
            pnlConfirmPassword.BackColor = Color.FromArgb(78, 184, 206);
            txtConfirmPassword.ForeColor = Color.FromArgb(78, 184, 206);

            pnlUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;

            pnlPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;

            pnlEmail.BackColor = Color.WhiteSmoke;
            txtEmail.ForeColor = Color.WhiteSmoke;

            pnlName.BackColor = Color.WhiteSmoke;
            txtName.ForeColor = Color.WhiteSmoke;

            pnlSurname.BackColor = Color.WhiteSmoke;
            txtSurname.ForeColor = Color.WhiteSmoke;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            pnlEmail.BackColor = Color.FromArgb(78, 184, 206);
            txtEmail.ForeColor = Color.FromArgb(78, 184, 206);

            pnlUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;

            pnlPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;

            pnlConfirmPassword.BackColor = Color.WhiteSmoke;
            txtConfirmPassword.ForeColor = Color.WhiteSmoke;

            pnlName.BackColor = Color.WhiteSmoke;
            txtName.ForeColor = Color.WhiteSmoke;

            pnlSurname.BackColor = Color.WhiteSmoke;
            txtSurname.ForeColor = Color.WhiteSmoke;
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            pnlName.BackColor = Color.FromArgb(78, 184, 206);
            txtName.ForeColor = Color.FromArgb(78, 184, 206);

            pnlUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;

            pnlPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;

            pnlConfirmPassword.BackColor = Color.WhiteSmoke;
            txtConfirmPassword.ForeColor = Color.WhiteSmoke;

            pnlEmail.BackColor = Color.WhiteSmoke;
            txtEmail.ForeColor = Color.WhiteSmoke;

            pnlSurname.BackColor = Color.WhiteSmoke;
            txtSurname.ForeColor = Color.WhiteSmoke;
        }

        private void txtSurname_Click(object sender, EventArgs e)
        {
            txtSurname.Clear();
            pnlSurname.BackColor = Color.FromArgb(78, 184, 206);
            txtSurname.ForeColor = Color.FromArgb(78, 184, 206);

            pnlUsername.BackColor = Color.WhiteSmoke;
            txtUsername.ForeColor = Color.WhiteSmoke;

            pnlPassword.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;

            pnlConfirmPassword.BackColor = Color.WhiteSmoke;
            txtConfirmPassword.ForeColor = Color.WhiteSmoke;

            pnlEmail.BackColor = Color.WhiteSmoke;
            txtEmail.ForeColor = Color.WhiteSmoke;

            pnlName.BackColor = Color.WhiteSmoke;
            txtName.ForeColor = Color.WhiteSmoke;
        }
        #endregion

        #region CheckBox Show Password
        int n = 3;
        char? none = null;
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (n % 2 == 1)
            {
                txtPassword.PasswordChar = Convert.ToChar(none);
                txtConfirmPassword.PasswordChar = Convert.ToChar(none);
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
            n++;
        }
        #endregion

        #region Label Login
        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            FormLogin lg = new FormLogin();
            lg.ShowDialog();
        }
        #endregion

        #region Button Sign Up
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtSurname.Text == "")
                {
                    MessageBox.Show("Məlumatlar tam deyil !", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Parollar eyni deyil !", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FormLogin.Query = $"insert into Passenger (Passenger_UserName,Passenger_Password,Passenger_Name,Passenger_Surname,Passenger_Email,Passenger_CreatedAt) values (@Username,@Password,@Name,@Surname,@Email,@CreatedAt)";
                    SqlCommand command = new SqlCommand(FormLogin.Query,FormLogin.connection);
                    command.Parameters.AddWithValue("@Username",txtUsername.Text.ToString().TrimEnd());
                    command.Parameters.AddWithValue("@Password",txtPassword.Text.ToString().TrimEnd());
                    command.Parameters.AddWithValue("@Name",txtName.Text.ToString().TrimEnd());
                    command.Parameters.AddWithValue("@Surname",txtSurname.Text.ToString().TrimEnd());
                    command.Parameters.AddWithValue("@Email",txtEmail.Text.ToString().TrimEnd());
                    command.Parameters.AddWithValue("@CreatedAt", DateTime.Now.ToString("MM/dd/yyyy"));
                    FormLogin.connection.Open();
                    command.ExecuteNonQuery();
                    FormLogin.connection.Close();
                    DialogResult dialog = MessageBox.Show("Hesab yaradıldı. Daxil olmaq istəyirsiniz ?", "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        this.Hide();
                        FormLogin login = new FormLogin();
                        login.ShowDialog();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi !", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
