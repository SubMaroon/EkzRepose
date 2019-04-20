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

namespace ekzamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sql_connection;
        string conn_string = @" Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\maksm\Documents\ekz\ekzamen\database.mdf; Integrated Security = True; Connect Timeout = 30";

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Human". При необходимости она может быть перемещена или удалена.
            this.humanTableAdapter.Fill(this.databaseDataSet.Human);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.databaseDataSet.Company);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [HUMAN]";
            try
            {
                sql_connection = new SqlConnection(conn_string);
                sql_connection.Open();
            }
            catch
            {
                MessageBox.Show("нет подключения", "Сообщение", MessageBoxButtons.OK);
            }


        }
    }
}
