using JdoCRUD.DAO;
using JdoCRUD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JdoCRUD.Forms
{
    public partial class TabuleiroDetalhes : Form
    {
        TabuleiroDetalhesController controller;
        bool novo;

        public TabuleiroDetalhes()
        {
            InitializeComponent();
            controller = new TabuleiroDetalhesController();
            ExibicaoNovo();
        }

        public TabuleiroDetalhes(int idTabuleiro)
        {
            InitializeComponent();
            controller = new TabuleiroDetalhesController();
            ExibicaoExistente(idTabuleiro);
        }

        private void ExibicaoExistente(int idTabuleiro)
        {
            btnEditar.Enabled = true;
            btnEditar.Visible = true;
            btnRemover.Enabled = true;
            btnRemover.Visible = true;

            novo = false;
            ExibirDados(idTabuleiro);
            SetEditavel(false);
        }

        private void ExibicaoNovo()
        {
            btnEditar.Enabled = false;
            btnEditar.Visible = false;
            btnRemover.Enabled = false;
            btnRemover.Visible = false;

            novo = true;
            int autoIncrement = controller.ConsultarAutoIncrementTabuleiro();//dao.ConsultarAutoIncrementSkin();
            txtId.Text = autoIncrement.ToString();
        }

        private void ExibirDados(int idTabuleiro)
        {
            Tabuleiro tabuleiro = controller.ConsultarTabuleiro(idTabuleiro);

            txtId.Text = tabuleiro.Id.ToString();
            txtNomeTabuleiro.Text = tabuleiro.NomeTabuleiro;
            rtxtImagemTabuleiro.Text = tabuleiro.ImagemTabuleiro;
            txtCorTematica.Text = tabuleiro.CorTematica;
            txtDtCriacao.Text = tabuleiro.DtCriacao.ToString("dd/MM/yyyy");

            ExibirImagem(tabuleiro.ImagemTabuleiro);

            ExibirCor(tabuleiro.CorTematica);
        }

        private void ExibirImagem(string url)
        {
            try
            {
                picImagemTabuleiro.Load(url);
            }
            catch (System.IO.FileNotFoundException)
            {
                //Imagem não pôde ser exibida/URL inválida
                picImagemTabuleiro.Image = picImagemTabuleiro.ErrorImage;
            }
            catch (InvalidOperationException)
            {
                //Url vazia
                picImagemTabuleiro.Image = picImagemTabuleiro.ErrorImage;
            }
        }

        private void SetEditavel(bool estado)
        {
            if (estado)
            {
                txtNomeTabuleiro.Enabled = true;
                rtxtImagemTabuleiro.Enabled = true;
                txtCorTematica.Enabled = true;

                btnColorDialog.Enabled = true;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
            }
            else
            {
                txtNomeTabuleiro.Enabled = false;
                rtxtImagemTabuleiro.Enabled = false;
                txtCorTematica.Enabled = false;

                btnColorDialog.Enabled = false;
                btnEditar.Enabled = true;
                btnSalvar.Enabled = false;
            }
        }

        private void ExibirCor(string corHex)
        {
            try
            {
                Color cor = ColorTranslator.FromHtml(corHex);
                lblCor.BackColor = cor;
                colorDialog1.Color = ColorTranslator.FromHtml(corHex);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Cor inválida", "Falha");
                txtCorTematica.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Cor inválida", "Falha");
                txtCorTematica.Text = "";
            }
        }

        private Tabuleiro ConsolidarObjeto()
        {
            Tabuleiro tempTabuleiro = new Tabuleiro();
            tempTabuleiro.Id = int.Parse(txtId.Text);
            tempTabuleiro.NomeTabuleiro = txtNomeTabuleiro.Text;
            tempTabuleiro.ImagemTabuleiro = rtxtImagemTabuleiro.Text;
            tempTabuleiro.CorTematica = txtCorTematica.Text;
            return tempTabuleiro;
        }

        public bool ValidarCampos()
        {
            bool ok = true;

            if (txtNomeTabuleiro.Text.Length < 1)
            {
                MessageBox.Show("Preencha o nome");
                ok = false;
            }

            if (rtxtImagemTabuleiro.Text.Length < 1)
            {
                MessageBox.Show("Defina uma imagem");
                ok = false;
            }

            if (txtCorTematica.Text.Length < 1)
            {
                MessageBox.Show("Defina uma cor temática");
                ok = false;
            }

            return ok;
        }

        private void TabuleiroDetalhes_Load(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Tabuleiro tabuleiro = ConsolidarObjeto();

            if (controller.VerificarRemovivel(tabuleiro.Id))
            {
                DialogResult resposta = MessageBox.Show("Deseja remover o tabuleiro? Esta ação não pode ser revertida.", "Atenção", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                    if (controller.Remover(tabuleiro.Id))
                    {
                        MessageBox.Show("Tabuleiro removido", "Aviso");
                        Close();
                    }
            }
            else
            {
                MessageBox.Show("Não é possível remover o tabuleiro, pois ele está sendo utilizado em uma ou mais seasons.", "Aviso");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            SetEditavel(true);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (novo)
                    controller.Inserir(ConsolidarObjeto());
                else
                    controller.Atualizar(ConsolidarObjeto());

                ExibicaoExistente(ConsolidarObjeto().Id);
            }

        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblCor.BackColor = colorDialog1.Color;
            txtCorTematica.Text = controller.ConverterColorParaHex(colorDialog1.Color);
        }

        private void picImagemTabuleiro_Click(object sender, EventArgs e)
        {

        }

        private void rtxtImagemTabuleiro_Leave(object sender, EventArgs e)
        {
            ExibirImagem(rtxtImagemTabuleiro.Text);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string result = fileDialog.FileName;
                rtxtImagemTabuleiro.Text = controller.Upload(result);
                ExibirImagem(rtxtImagemTabuleiro.Text);
            }
            else
            {
                MessageBox.Show("Seleção inválida");
                return;
            }
        }
    }

    public class TabuleiroDetalhesController
    {
        JdoDAO dao;

        public TabuleiroDetalhesController()
        {
            dao = new JdoDAO();
        }

        public bool Remover(int idTabuleiro)
        {
            try
            {
                dao.RemoverTabuleiro(idTabuleiro);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void Inserir(Tabuleiro tabuleiro)
        {
            dao.InserirTabuleiro(tabuleiro);
        }

        public void Atualizar(Tabuleiro tabuleiro)
        {
            dao.AtualizarTabuleiro(tabuleiro);
        }

        public string ConverterColorParaHex(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        public int ConsultarAutoIncrementTabuleiro()
        {
            return dao.ConsultarAutoIncrementTabuleiro();
        }

        public Tabuleiro ConsultarTabuleiro(int idTabuleiro)
        {
            return dao.ConsultarTabuleiro(idTabuleiro);
        }

        public string Upload(string caminho)
        {
            byte[] imagem = (byte[])new ImageConverter().ConvertTo(new Bitmap(caminho), typeof(byte[]));

            HttpClient client = new HttpClient();

            MultipartFormDataContent conteudoRequest = new MultipartFormDataContent();

            ByteArrayContent conteudoImagem = new ByteArrayContent(imagem);

            conteudoImagem.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");

            conteudoRequest.Add(conteudoImagem, "arquivo", caminho.Split('\\')[caminho.Split('\\').Count() - 1]);

            var result = client.PostAsync(helper.Instancia.GetImageStoreUrl(), conteudoRequest).Result;

            return result.Content.ReadAsStringAsync().Result;

        }

        internal bool VerificarRemovivel(int idTabuleiro)
        {
           return dao.IsRemovivelTabuleiro(idTabuleiro);
        }
    }
}
