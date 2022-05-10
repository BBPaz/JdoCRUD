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
    public partial class VendaLista : Form
    {
        public VendaLista()
        {
            InitializeComponent();
        }

        private void VendaLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jdoDataSet.venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.jdoDataSet.venda);

        }

        private void NovaVenda()
        {
            VendaDetalhes VendaDetalhes = new VendaDetalhes();
            VendaDetalhes.ShowDialog();
            Atualizar();
        }

        private void DetalhesVenda(int id)
        {
            VendaDetalhes VendaDetalhes = new VendaDetalhes(id);
            VendaDetalhes.ShowDialog();
            Atualizar();
        }
        private void Atualizar()
        {
            this.vendaTableAdapter.Fill(this.jdoDataSet.venda);
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = vendaDataGridView.CurrentCell.OwningRow;
            int id = int.Parse(vendaDataGridView.CurrentCell.OwningRow.Cells[0].Value.ToString());
            DetalhesVenda(id);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovaVenda();
        }

        private void vendaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = vendaDataGridView.CurrentCell.OwningRow;
            int id = int.Parse(vendaDataGridView.CurrentCell.OwningRow.Cells[0].Value.ToString());
            DetalhesVenda(id);
        }
    }

}
