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
    public partial class AddService : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ProjectsCS\ITService\Project\ITService.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection sqlConnection = new SqlConnection();

        public string typeQuery = "";

        string[] data = new string[9];
        public AddService()
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
        private void AddCar_Load(object sender, EventArgs e)
        {
            if (typeQuery.Equals("update"))
            {
                this.Text = "Редактирование сервиса";
                textBoxMark.Text = data[1];
                textBoxModel.Text = data[2];
            }
        }

        private void add()
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxMark.Text) && !string.IsNullOrWhiteSpace(textBoxMark.Text) &&
                    !string.IsNullOrEmpty(textBoxModel.Text) && !string.IsNullOrWhiteSpace(textBoxModel.Text))
                {
                    sqlConnection = new SqlConnection(@connectionString);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Cars ([Марка],[Модель],[Год выпуска],[Цвет],[Тип коробки],[Комплектация], [Цена], [Наличие])" +
                        " VALUES (@LName, @Name, @Otche, @Phone, @Mail, @Pas, @Price, @Nahod)", sqlConnection);

                    sqlCommand.Parameters.AddWithValue("LName", textBoxMark.Text);
                    sqlCommand.Parameters.AddWithValue("Name", textBoxModel.Text);


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
                if (!string.IsNullOrEmpty(textBoxMark.Text) && !string.IsNullOrWhiteSpace(textBoxMark.Text) &&
                    !string.IsNullOrEmpty(textBoxModel.Text) && !string.IsNullOrWhiteSpace(textBoxModel.Text))
                {
                    sqlConnection = new SqlConnection(@connectionString);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Cars SET " +
                        $"[Марка] = '{textBoxMark.Text}'," +
                        $"[Модель] = '{textBoxModel.Text}' WHERE id = {data[0]}", sqlConnection);

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
