using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JdoCRUD.Forms;

namespace JdoCRUD
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void skinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkinLista skinLista = new SkinLista();
            skinLista.ShowDialog();
            /*try
            {
                skinLista.ShowDialog();
            }
            catch(Exception ex)
            {
                string text = ex.Message;
            }*/
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            test test = new test();
            test.ShowDialog();
        }

        private void tabuleirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabuleiroLista tabuleiroLista = new TabuleiroLista();
            tabuleiroLista.ShowDialog();
        }

        private void seasonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeasonLista seasonLista = new SeasonLista();
            seasonLista.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendaLista vendaLista = new VendaLista();
            vendaLista.ShowDialog();
        }
    }
}
