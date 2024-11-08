using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_232410101065_utspbo.Views
{
    public partial class HalamanBuku : Form
    {
        public HalamanBuku()
        {
            InitializeComponent();
            bukuContext = new Models.BukuContext();

            bukuContext.Read();
            dataGridView1_CellContentClick().DataSource = bukuContext.listBuku;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
