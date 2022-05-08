using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
                Atualizar();
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
            DataGridViewRow row = skinDataGridView.CurrentCell.OwningRow;
            int id = int.Parse(skinDataGridView.CurrentCell.OwningRow.Cells[0].Value.ToString());
            DetalhesSkin(id);
        }

        private void DetalhesSkin(int id)
        {
            
            SkinDetalhes skinDetalhes = new SkinDetalhes(id);
            skinDetalhes.ShowDialog();
            Atualizar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            SkinDetalhes skinDetalhes = new SkinDetalhes();
            skinDetalhes.ShowDialog();
            Atualizar();
        }

        private void skinDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = skinDataGridView.CurrentCell.OwningRow;
            int indice = int.Parse(skinDataGridView.CurrentCell.OwningRow.Cells[0].Value.ToString());
            DetalhesSkin(indice);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            this.skinTableAdapter.Fill(this.jdoDataSet.skin);
            PopularColunas();
        }

        private void skinDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PopularColunas()
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
                //imagens
                try
                {
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(row.Cells[imagemSkin.Index].Value.ToString());
                    myRequest.Method = "GET";
                    HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                    Bitmap bmp = new Bitmap(myResponse.GetResponseStream());
                    row.Cells[imgExibicao.Index].Value = bmp;
                }
                catch (System.UriFormatException)
                {
                    //Imagem não pôde ser exibida/URL inválida
                }
                catch (InvalidOperationException)
                {
                    //Url vazia
                }
            }
            //skinDataGridView.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.Red;
        }
    }
}
