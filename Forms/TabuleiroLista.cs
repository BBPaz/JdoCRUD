using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JdoCRUD.Forms
{
    public partial class TabuleiroLista : Form
    {
        public TabuleiroLista()
        {
            InitializeComponent();
        }

        private void TabuleiroLista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jdoDataSet.tabuleiro' table. You can move, or remove it, as needed.
            this.tabuleiroTableAdapter.Fill(this.jdoDataSet.tabuleiro);
            try
            {
                Atualizar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                string erro = ex.Message;
                MessageBox.Show("Sem credenciais para conectar ao banco.\nCrie um arquivo de nome \"senha.txt\" com a senha do banco no diretório do arquivo.", "Falha ao autenticar");
                this.Close();
            }
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = tabuleiroDataGridView.CurrentCell.OwningRow;
            int id = int.Parse(tabuleiroDataGridView.CurrentCell.OwningRow.Cells[0].Value.ToString());
            DetalhesTabuleiro(id);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            NovoTabuleiro();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void NovoTabuleiro()
        {
            TabuleiroDetalhes tabuleiroDetalhes = new TabuleiroDetalhes();
            tabuleiroDetalhes.ShowDialog();
            Atualizar();
        }

        private void DetalhesTabuleiro(int id)
        {
            TabuleiroDetalhes tabuleiroDetalhes = new TabuleiroDetalhes(id);
            tabuleiroDetalhes.ShowDialog();
            Atualizar();
        }

        private void PopularColunas()
        {
            foreach(DataGridViewRow row in tabuleiroDataGridView.Rows)
            {
                //cor
                string hexcor = row.Cells[corTematica.Index].Value.ToString();
                try
                {
                    row.Cells[Cor.Index].Style.BackColor = ColorTranslator.FromHtml(hexcor);
                }
                catch (Exception) { } //Não foi possível exibir cor na coluna

                //imagem
                try
                {
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(row.Cells[imagemTabuleiro.Index].Value.ToString());
                    myRequest.Method = "GET";
                    HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                    Bitmap bmp = new Bitmap(myResponse.GetResponseStream());
                    row.Cells[Imagem.Index].Value = bmp;
                }
                catch(UriFormatException)
                {
                    //Imagem não pôde ser exibida/URL Inválida
                }
                catch (InvalidOperationException)
                {
                    //Url vazia
                }
            }
        }

        private void Atualizar()
        {
            this.tabuleiroTableAdapter.Fill(this.jdoDataSet.tabuleiro);
            PopularColunas();
        }

        private void tabuleiroDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = tabuleiroDataGridView.CurrentCell.OwningRow;
            int id = int.Parse(tabuleiroDataGridView.CurrentCell.OwningRow.Cells[0].Value.ToString());
            DetalhesTabuleiro(id);
        }
    }
}
