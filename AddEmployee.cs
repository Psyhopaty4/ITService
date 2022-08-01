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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=DESKTOP-G26Q8FF;Initial Catalog=ProAuto;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection();

        public string typeQuery = "";
        string[] data = new string[4];

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
        private void add()
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxLastName.Text) && !string.IsNullOrWhiteSpace(textBoxLastName.Text) &&
                    !string.IsNullOrEmpty(textBoxFirstName.Text) && !string.IsNullOrWhiteSpace(textBoxFirstName.Text) &&
                    !string.IsNullOrEmpty(comboBoxGender.Text) && !string.IsNullOrWhiteSpace(comboBoxGender.Text) &&
                    !string.IsNullOrEmpty(comboBoxPosition.Text) && !string.IsNullOrWhiteSpace(comboBoxPosition.Text))
                {
                    sqlConnection = new SqlConnection(@connectionString);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Employee (LastName, FirstName, id_gender, id_position)" +
                        " VALUES (@LName, @Name, @Gender, @Position)", sqlConnection);

                    sqlCommand.Parameters.AddWithValue("LName", textBoxLastName.Text);
                    sqlCommand.Parameters.AddWithValue("Name", textBoxFirstName.Text);
                    if (comboBoxGender.SelectedIndex == 0)
                    {
                        sqlCommand.Parameters.AddWithValue("Gender", 1);
                    }
                    else if (comboBoxGender.SelectedIndex == 1)
                    {
                        sqlCommand.Parameters.AddWithValue("Gender", 2);
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("Gender", 3);
                    }
                    sqlCommand.Parameters.AddWithValue("Position", /*запрос на получение id*/1);
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
                    !string.IsNullOrEmpty(textBoxFirstName.Text) && !string.IsNullOrWhiteSpace(textBoxFirstName.Text) &&
                    !string.IsNullOrEmpty(comboBoxGender.Text) && !string.IsNullOrWhiteSpace(comboBoxGender.Text) &&
                    !string.IsNullOrEmpty(comboBoxPosition.Text) && !string.IsNullOrWhiteSpace(comboBoxPosition.Text))
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
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Employee SET " +
                        $"LastName = '{textBoxLastName.Text}'," +
                        $"FirstName = '{textBoxFirstName.Text}'," +
                        $"id_gender = '{idGender}'," +
                        $"id_position = '{idGender}', WHERE id = {data[0]}", sqlConnection);

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
        private void button1_Click(object sender, EventArgs e)
        {
            if (typeQuery.Equals("add"))
                add();
            else if (typeQuery.Equals("update"))
                update();
        }

        private void AddSupplies_Load(object sender, EventArgs e)
        {
            if (typeQuery.Equals("update"))
            {
                this.Text = "Редактирование работника";
                textBoxLastName.Text = data[1];
                textBoxFirstName.Text = data[2];
                comboBoxGender.SelectedIndex = 0;
                comboBoxPosition.SelectedIndex = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
