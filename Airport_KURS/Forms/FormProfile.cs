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
    public partial class FormProfile : Form
    {
        #region Constructor
        public FormProfile()
        {
            InitializeComponent();
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
            lblProfile.ForeColor = ThemeColor.SecondaryColor;
        }
        #endregion

        #region Method Gender
        private string Gender()
        {
            if (radiobtnMale.Checked)
            {
                return "Male";
            }
            else
            {
                return "Female";
            }
        }
        private void Gender2(string gender)
        {
            if (gender == "Male")
            {
                radiobtnMale.Checked = true;
            }
            else
            {
                radiobtnFemale.Checked = true;
            }
        }
        #endregion

        #region Button Choose
        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Fayl seçin !";

            if (f.ShowDialog() == DialogResult.OK)
            {
                picPhoto.ImageLocation = f.FileName;
            }
        }
        #endregion

        #region Button Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            picPhoto.Image = null;
            string Query = "update Passenger set Passenger_Image = null where Passenger_Id = @Id";
            FormLogin.connection.Open();
            SqlCommand command = new SqlCommand(Query, FormLogin.connection);
            command.Parameters.AddWithValue("@Id", FormLogin.Passenger_Id);
            command.ExecuteNonQuery();
            FormLogin.connection.Close();
        }
        #endregion

        #region FormProfile Load
        private void FormProfile_Load(object sender, EventArgs e)
        {
            radiobtnMale.Checked = true;
            picPhoto.SizeMode = PictureBoxSizeMode.StretchImage;

            string Query = "select Passenger_Name,Passenger_Surname,Passenger_Email,Passenger_Phone,Passenger_Gender,Passenger_Birth,Passenger_Image from Passenger where Passenger_Id = @Id";
            FormLogin.connection.Open();
            SqlCommand command = new SqlCommand(Query, FormLogin.connection);
            command.Parameters.AddWithValue("@Id", FormLogin.Passenger_Id);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                txtName.Text = reader["Passenger_Name"].ToString().TrimEnd();
                txtSurname.Text = reader["Passenger_Surname"].ToString().TrimEnd();
                txtEmail.Text = reader["Passenger_Email"].ToString().TrimEnd();
                txtPhone.Text = reader["Passenger_Phone"].ToString().TrimEnd();
                string image = reader["Passenger_Image"].ToString().TrimEnd();
                Gender2(reader["Passenger_Gender"].ToString().TrimEnd());
                string dtBirth = reader["Passenger_Birth"].ToString();

                if (string.IsNullOrEmpty(dtBirth))
                {
                    dtDateOfBirth.Value = DateTime.Now;
                }
                else
                {
                    dtDateOfBirth.Value = Convert.ToDateTime(reader["Passenger_Birth"]);
                }

                if (string.IsNullOrEmpty(image))
                {
                    picPhoto.Image = null;
                }
                else
                {
                    picPhoto.ImageLocation = image;
                }


            }
            FormLogin.connection.Close();
        }
        #endregion

        #region Button Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            string Query = "update Passenger set Passenger_Name = @Name,Passenger_Surname = @Surname,Passenger_Email = @Email,Passenger_Phone = @Phone,Passenger_Gender = @Gender,Passenger_Birth = @Birth, Passenger_Image = @Path where Passenger_Id = @Id";

            FormLogin.connection.Open();
            SqlCommand command = new SqlCommand(Query,FormLogin.connection);
            command.Parameters.AddWithValue("@Name", txtName.Text.ToString().TrimEnd());
            command.Parameters.AddWithValue("@Surname", txtSurname.Text.ToString().TrimEnd());
            command.Parameters.AddWithValue("@Email", txtEmail.Text.ToString().TrimEnd());
            command.Parameters.AddWithValue("@Phone", txtPhone.Text.ToString().TrimEnd());
            command.Parameters.AddWithValue("@Gender", Gender().ToString());
            command.Parameters.AddWithValue("@Birth", dtDateOfBirth.Value.ToString("MM/dd/yyyy"));
            command.Parameters.AddWithValue("@Path", picPhoto.ImageLocation);
            command.Parameters.AddWithValue("@Id", FormLogin.Passenger_Id);
            command.ExecuteNonQuery();
            MessageBox.Show("Yadda saxlanıldı !","Program",MessageBoxButtons.OK,MessageBoxIcon.Information);
            FormLogin.connection.Close();
        }
        #endregion
    }
}
