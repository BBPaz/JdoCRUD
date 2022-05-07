using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JdoCRUD.Forms
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jdoDataSet.tabuleiro' table. You can move, or remove it, as needed.
            this.tabuleiroTableAdapter.Fill(this.jdoDataSet.tabuleiro);

        }
    }
}
