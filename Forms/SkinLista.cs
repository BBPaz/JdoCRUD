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
    public partial class SkinLista : Form
    {
        public SkinLista()
        {
            InitializeComponent();
        }

        private void skinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.skinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jdoDataSet);

        }

        private void SkinLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jdoDataSet.skin' table. You can move, or remove it, as needed.
            try
            {
                atualizar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                string erro = ex.Message;
                MessageBox.Show("Sem credenciais para conectar ao banco.\nCrie um arquivo de nome \"senha.txt\" com a senha do banco no diretório do arquivo.","Falha ao autenticar");
                this.Close();
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DetalhesSkin();
        }

        private void DetalhesSkin()
        {
            DataGridViewRow row = skinDataGridView.CurrentCell.OwningRow;
            int indice = int.Parse(skinDataGridView.CurrentCell.OwningRow.Cells[0].Value.ToString());
            SkinDetalhes skinDetalhes = new SkinDetalhes(indice);
            skinDetalhes.ShowDialog();
            atualizar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            SkinDetalhes skinDetalhes = new SkinDetalhes();
            skinDetalhes.ShowDialog();
            atualizar();
        }

        private void skinDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DetalhesSkin();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void atualizar()
        {
            this.skinTableAdapter.Fill(this.jdoDataSet.skin);
            popularColunas();
        }

        private void skinDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void popularColunas()
        {
            foreach (DataGridViewRow row in skinDataGridView.Rows)
            {
                //cor
                string hexCor = row.Cells[corTematica.Index].Value.ToString();
                try
                {
                    row.Cells[Cor.Index].Style.BackColor = ColorTranslator.FromHtml(hexCor);
                }
                catch (Exception) { } //Não foi possível exibir alguma das cores na coluna de cor
                //tipo
                row.Cells[Tipo.Index].Value = row.Cells[tipoPeca.Index].Value.ToString() == "0"? "Onça":"Cachorro";
                //permanente
                row.Cells[Permanente.Index].Value = row.Cells[ehPermanente.Index].Value.ToString() == "False"? "Não":"Sim";

            }
            //skinDataGridView.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.Red;
        }
    }
}
