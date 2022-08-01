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

namespace ProAuto
{
    public partial class AddClient : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ProjectsCS\ITService\Project\ITService.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection sqlConnection = new SqlConnection();

        public string typeQuery = "";
        string[] data = new string[5];

        public AddClient()
        {
            InitializeComponent();
        }
        public string[] Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            if (typeQuery.Equals("add"))
                add();
            else if (typeQuery.Equals("update"))
                update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            if (typeQuery.Equals("update"))
            {
                this.Text = "Редактирование клиента";
                textBoxLastName.Text = data[1];
                textBoxFirstName.Text = data[2];
                comboBoxGender.Text = data[3];
                textBoxEmail.Text = data[4];
            }    
        }

        private void add ()
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxLastName.Text) && !string.IsNullOrWhiteSpace(textBoxLastName.Text) &&
                    !string.IsNullOrEmpty(textBoxFirstName.Text) && !string.IsNullOrWhiteSpace(textBoxFirstName.Text) &&
                    !string.IsNullOrEmpty(comboBoxGender.Text) && !string.IsNullOrWhiteSpace(comboBoxGender.Text) &&
                    !string.IsNullOrEmpty(textBoxEmail.Text) && !string.IsNullOrWhiteSpace(textBoxEmail.Text))
                {
                    sqlConnection = new SqlConnection(@connectionString);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Client (LastName, FirstName, id_gender, Email)" +
                        " VALUES (@LastName, @FirstName, @Gender @Email)", sqlConnection);

                    sqlCommand.Parameters.AddWithValue("LastName", textBoxLastName.Text);
                    sqlCommand.Parameters.AddWithValue("FirstName", textBoxFirstName.Text);
                    if (comboBoxGender.SelectedIndex == 0)
                    {
                        sqlCommand.Parameters.AddWithValue("Gender", 1);
                    } else if (comboBoxGender.SelectedIndex == 1)
                    {
                        sqlCommand.Parameters.AddWithValue("Gender", 2);
                    } else
                    {
                        sqlCommand.Parameters.AddWithValue("Gender", 3);
                    }
                        sqlCommand.Parameters.AddWithValue("Email", textBoxEmail.Text);

                    sqlCommand.ExecuteNonQuery();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Все поля обязательны к заполнению!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void update()
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxLastName.Text) && !string.IsNullOrWhiteSpace(textBoxLastName.Text) &&
                    !string.IsNullOrEmpty(comboBoxGender.Text) && !string.IsNullOrWhiteSpace(comboBoxGender.Text) &&
                    !string.IsNullOrEmpty(textBoxFirstName.Text) && !string.IsNullOrWhiteSpace(textBoxFirstName.Text) &&
                    !string.IsNullOrEmpty(textBoxEmail.Text) && !string.IsNullOrWhiteSpace(textBoxEmail.Text))
                {
                    int idGender = 0;
                    if (comboBoxGender.SelectedIndex == 0)
                    {
                        idGender = 1;
                    }
                    else if (comboBoxGender.SelectedIndex == 1)
                    {
                        idGender = 2;
                    }
                    else
                    {
                        idGender = 3;
                    }
                    sqlConnection = new SqlConnection(@connectionString);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Client SET " +
                        $"LastName = '{textBoxLastName.Text}'," +
                        $"FirstName = '{textBoxFirstName.Text}'," +
                        $"id_gender = '{idGender}'," +
                        $"Email = '{textBoxEmail.Text}',", sqlConnection);

                    sqlCommand.ExecuteNonQuery();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Все поля обязательны к заполнению!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
