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
    public partial class SeasonLista : Form
    {
        public SeasonLista()
        {
            InitializeComponent();
        }

        private void SeasonLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jdoDataSet.season' table. You can move, or remove it, as needed.
            this.seasonTableAdapter.Fill(this.jdoDataSet.season);

        }

        private void NovaSeason()
        {
            SeasonDetalhes seasonDetalhes = new SeasonDetalhes();
            seasonDetalhes.ShowDialog();
            Atualizar();
        }

        private void DetalhesSeason(int id)
        {
            SeasonDetalhes seasonDetalhes = new SeasonDetalhes(id);
            seasonDetalhes.ShowDialog();
            Atualizar();
        }
        private void Atualizar()
        {
            this.seasonTableAdapter.Fill(this.jdoDataSet.season);
            PopularColunas();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = seasonDataGridView.CurrentCell.OwningRow;
            int id = int.Parse(seasonDataGridView.CurrentCell.OwningRow.Cells[0].Value.ToString());
            DetalhesSeason(id);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovaSeason();
        }

        private void seasonDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = seasonDataGridView.CurrentCell.OwningRow;
            int id = int.Parse(seasonDataGridView.CurrentCell.OwningRow.Cells[0].Value.ToString());
            DetalhesSeason(id);
        }

        private void PopularColunas()
        {

        }
    }
}
