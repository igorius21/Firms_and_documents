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

namespace TZ
{
    public partial class Documents : Form
    {
        public Documents()
        {
            InitializeComponent();
        }

        string connectionString;
        string commandText;
        Database db = new Database();

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FindAll();
        }

        public void FindAll()
        {
            connectionString = db.SqlRequest7(out commandText);
            
            FillingTable(commandText);
        }

        private void buttonFirms_Click(object sender, EventArgs e)
        {
            FindFirms();
        }

        public void FindFirms()
        {
            db.FirmName = textBoxFirm.Text;
            connectionString = db.SqlRequest8(out commandText);

            FillingTable(commandText);
        }

        public void FillingTable(string commandText)
        {
            try
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(commandText, connectionString);
                adapter.Fill(table);
                dataGridView.DataSource = table;

                if (dataGridView.RowCount == 1)
                    MessageBox.Show("К сожалению, введено некорректное название фирмы", "Ошибка ввода данных");
            }
            catch
            {
                MessageBox.Show("Невозможно установить соединение с базой данных");
            }

        }
    }
}
