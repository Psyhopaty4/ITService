using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProAuto
{
    public partial class MainForm : Form
    {

        BindingSource bind = new BindingSource();
        DataSet dataSet = new DataSet();
        SqlDataAdapter sqlData = new SqlDataAdapter();
        
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\ProjectsCS\ITService\Project\ITService.mdf;Integrated Security=True;Connect Timeout=30";
        string query = "";
        public string typeQuery = ""; // инкапсулировать потом на основной форме
        string action = "";
        bool f = true;

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            action = "Client";
            toolStripButton6.Visible = false;
            query = "SELECT * FROM Client";
            connect();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                action = "Client";
                bind.RemoveFilter();
                toolStripButton6.Visible = false;
                toolStripButton5.Enabled = true;
                query = "SELECT * FROM Client";
                connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void connect ()
        {
            SqlConnection sqlConnection = new SqlConnection(@connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = query;
            sqlData = new SqlDataAdapter(sqlCommand);
            dataSet.Tables.Clear();
            sqlData.Fill(dataSet);
            bind.DataSource = dataSet.Tables[0];
            dataGridView1.DataSource = bind;
            sqlConnection.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                bind.RemoveFilter();
                action = "Employee";
                toolStripButton6.Visible = false;
                toolStripButton5.Enabled = true;
                query = "SELECT * FROM Employee";
                /*query = "SELECT Orders.id, Clients.Фамилия AS Клиент, " +
                    "Managers.Фамилия AS Менеджер, Cars.Марка, " +
                    "Cars.Модель, Cars.[Год выпуска], Orders.Цена, Orders.[Статус заказа], " +
                    "Supplies.[Наименование поставщика] AS Поставщик " +
                    "FROM Orders JOIN Clients ON Orders.[id_клиента] = Clients.id JOIN Managers ON " +
                    "Orders.[id_менеджера] = Managers.id JOIN Cars ON Orders.[id_авто] = Cars.id " +
                    "JOIN Supplies ON Orders.[id_поставки] = Supplies.id";*/
                connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                bind.RemoveFilter();
                action = "ServiceContract";
                toolStripButton5.Enabled = false;
                toolStripButton6.Visible = false;
                query = "SELECT * FROM ServiceContract";
                connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                bind.RemoveFilter();
                action = "Organization";
                toolStripButton6.Visible = false;
                toolStripButton5.Enabled = true;
                query = "SELECT * FROM Organization";
                connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                bind.RemoveFilter();
                action = "Service";
                toolStripButton6.Visible = true;
                toolStripButton5.Enabled = true;
                query = "SELECT * FROM Service";
                connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            /*switch (action)
            {
                case "Supplies":
                    if (!string.IsNullOrEmpty(toolStripTextBox1.Text) && !string.IsNullOrWhiteSpace(toolStripTextBox1.Text))
                        bind.Filter = $"[имя] LIKE '{toolStripTextBox1.Text}%' OR [фамилия] LIKE '{toolStripTextBox1.Text}%' OR [отчество] LIKE '{toolStripTextBox1.Text}%'";
                    else
                        bind.RemoveFilter();
                    break;
                case "Clients":
                    if (!string.IsNullOrEmpty(toolStripTextBox1.Text) && !string.IsNullOrWhiteSpace(toolStripTextBox1.Text))
                        bind.Filter = $"[имя] LIKE '{toolStripTextBox1.Text}%' OR [фамилия] LIKE '{toolStripTextBox1.Text}%' OR [отчество] LIKE '{toolStripTextBox1.Text}%'";
                    else
                        bind.RemoveFilter();
                    break;
                case "Orders":
                    if (!string.IsNullOrEmpty(toolStripTextBox1.Text) && !string.IsNullOrWhiteSpace(toolStripTextBox1.Text))
                        bind.Filter = $"[имя] LIKE '{toolStripTextBox1.Text}%' OR [фамилия] LIKE '{toolStripTextBox1.Text}%' OR [отчество] LIKE '{toolStripTextBox1.Text}%'";
                    else
                        bind.RemoveFilter();
                    break;
                case "Managers":
                    if (!string.IsNullOrEmpty(toolStripTextBox1.Text) && !string.IsNullOrWhiteSpace(toolStripTextBox1.Text))
                        bind.Filter = $"[имя] LIKE '{toolStripTextBox1.Text}%' OR [фамилия] LIKE '{toolStripTextBox1.Text}%' OR [отчество] LIKE '{toolStripTextBox1.Text}%'";
                    else
                        bind.RemoveFilter();
                    break;
                case "Cars":
                    if (!string.IsNullOrEmpty(toolStripTextBox1.Text) && !string.IsNullOrWhiteSpace(toolStripTextBox1.Text))
                        bind.Filter = $"[имя] LIKE '{toolStripTextBox1.Text}%' OR [фамилия] LIKE '{toolStripTextBox1.Text}%' OR [отчество] LIKE '{toolStripTextBox1.Text}%'";
                    else
                        bind.RemoveFilter();
                    break;
            }*/
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case "Employee":
                    AddEmployee addEmployee = new AddEmployee();
                    addEmployee.typeQuery = "add";
                    addEmployee.Show();
                    break;
                case "Client":
                    AddClient addClient = new AddClient();
                    addClient.typeQuery = "add";
                    addClient.Show();
                    break;
                case "Organization":
                    AddOrganization addOrganization = new AddOrganization();
                    addOrganization.typeQuery = "add";
                    addOrganization.Show();    
                    break;
                case "ServiceContract":
                    AddContract addContract = new AddContract();
                    addContract.typeQuery = "add";
                    addContract.Show();
                    break;
                case "Service":
                    AddService addService = new AddService();
                    addService.typeQuery = "add";
                    addService.Show();
                    break;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы действительно хотите удалить?");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = new SqlConnection(@connectionString);
                sqlConnection.Open();
                string queryDelete = "";
                if (dataGridView1.Rows.Count > 0 && dataGridView1.Rows != null)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                    switch (action)
                    {
                        case "Employee":
                            queryDelete = $"DELETE FROM Employee WHERE id = {dataGridView1.Rows[selectedrowindex].Cells[0].Value}";
                            break;
                        case "Client":
                            queryDelete = $"DELETE FROM Client WHERE id = {dataGridView1.Rows[selectedrowindex].Cells[0].Value}";
                            break;
                        case "Organization":
                            queryDelete = $"DELETE FROM Organization WHERE id = {dataGridView1.Rows[selectedrowindex].Cells[0].Value}";
                            break;
                        case "Contract":
                            queryDelete = $"DELETE FROM Contract WHERE id = {dataGridView1.Rows[selectedrowindex].Cells[0].Value}";
                            break;
                        case "Service":
                            queryDelete = $"DELETE FROM Service WHERE id = {dataGridView1.Rows[selectedrowindex].Cells[0].Value}";
                            break;
                    }
                    SqlCommand sqlCommand = new SqlCommand(queryDelete, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
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

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            connect();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.Rows != null)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                switch (action)
                {
                    case "Employee":
                        AddEmployee addEmployee = new AddEmployee();
                        addEmployee.typeQuery = "update";
                        /*for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            addEmployee.Data[i] = dataGridView1.Rows[selectedrowindex].Cells[i].Value.ToString();*/
                        addEmployee.Show();
                        break;
                    case "Client":
                        AddClient addClient = new AddClient();
                        addClient.typeQuery = "update";
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            addClient.Data[i] = dataGridView1.Rows[selectedrowindex].Cells[i].Value.ToString();
                        addClient.Show();
                        break;
                    case "Organization":
                        AddOrganization addOrganization = new AddOrganization();
                        addOrganization.typeQuery = "update";
                        /*for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            addOrganization.Data[i] = dataGridView1.Rows[selectedrowindex].Cells[i].Value.ToString();*/
                        addOrganization.Show();
                        break;
                    case "Contract":
                        AddContract addContract = new AddContract();
                        addContract.typeQuery = "update";
                        /*for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            addContract.Data[i] = dataGridView1.Rows[selectedrowindex].Cells[i].Value.ToString();*/
                        addContract.Show();
                        break;
                    case "Service":
                        AddService addService = new AddService();
                        /*for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            addService.Data[i] = dataGridView1.Rows[selectedrowindex].Cells[i].Value.ToString();*/
                        addService.typeQuery = "update";
                        addService.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Клиент не выбран!");
            }
        }

    }
}
