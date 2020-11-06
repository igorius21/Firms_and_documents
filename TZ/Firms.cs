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
    public partial class Firms : System.Windows.Forms.Form
    {
        public Firms()
        {
            InitializeComponent();
        }

        Database db = new Database();
        string connectionString;
        string commandText;

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FindFirm();
        }

        public void FindFirm()
        {
            if (enterNameFirms.Text != "" && enterJurCity.Text == "" && enterPostCity.Text == "")
            {
                db.FirmName = enterNameFirms.Text;

                connectionString = db.SqlRequest1(out commandText);
                FillingTable(commandText);
            }

            if (enterNameFirms.Text == "" && enterJurCity.Text != "" && enterPostCity.Text == "")
            {
                db.CityJurName = enterJurCity.Text;

                connectionString = db.SqlRequest2(out commandText);
                FillingTable(commandText);
            }

            if (enterNameFirms.Text == "" && enterJurCity.Text == "" && enterPostCity.Text != "")
            {
                db.CityPostName = enterPostCity.Text;

                connectionString = db.SqlRequest3(out commandText);
                FillingTable(commandText);
            }

            if (enterNameFirms.Text != "" && enterJurCity.Text != "" && enterPostCity.Text == "")
            {
                db.FirmName = enterNameFirms.Text;
                db.CityJurName = enterJurCity.Text;

                connectionString = db.SqlRequest4(out commandText);
                FillingTable(commandText);
            }

            if (enterNameFirms.Text != "" && enterJurCity.Text == "" && enterPostCity.Text != "")
            {
                db.FirmName = enterNameFirms.Text;
                db.CityPostName = enterPostCity.Text;

                connectionString = db.SqlRequest4(out commandText);
                FillingTable(commandText);
            }

            if (enterJurPost.Text != "")
            {
                db.CityPostName = enterJurPost.Text;

                connectionString = db.SqlRequest5(out commandText);
                FillingTable(commandText);
            }

            if (enterJurPost.Text != "" && enterNameFirms.Text != "")
            {
                db.CityPostName = enterJurPost.Text;
                db.FirmName = enterNameFirms.Text;

                connectionString = db.SqlRequest6(out commandText);
                FillingTable(commandText);
            }

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
                    MessageBox.Show("К сожалению, введено некорректное название фирмы, либо введенный город не " +
                        "соответствует указанному в поле для ввода адресу фирмы", "Ошибка ввода данных");
            }
            catch
            {
                MessageBox.Show("Невозможно установить соединение с базой данных");
            }

        }

        private void enterPostCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (enterJurCity.Text != "" || enterJurPost.Text != "")
            {
                e.Handled = true;
            } 
        }

        private void enterJurCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (enterPostCity.Text != "" || enterJurPost.Text != "")
            {
                e.Handled = true;
            }
        }

        private void enterJurPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (enterJurCity.Text != "" || enterPostCity.Text != "")
            {
                e.Handled = true;
            }
        }
    }
}
