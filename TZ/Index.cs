using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TZ
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void buttonFirms_Click(object sender, EventArgs e)
        {
            Firms firms = new Firms();
            firms.ShowDialog();
        }

        private void buttonDocument_Click(object sender, EventArgs e)
        {
            Documents doc = new Documents();
            doc.ShowDialog();
        }
    }
}
