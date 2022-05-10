using JdoCRUD.DAO;
using JdoCRUD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JdoCRUD.Forms
{
    public partial class SkinDetalhes : Form
    {
        private JdoDAO dao;
        Skin skin;
        Color cor;
        int idSkinInicial = 0;

        public SkinDetalhes()
        {
            InitializeComponent();
        }

        public SkinDetalhes(int idSkin)
        {
            InitializeComponent();
            idSkinInicial = idSkin;
        }

        private void SkinDetalhes_Load(object sender, EventArgs e)
        {
            Carregar(idSkinInicial);
        }

        private void Carregar(int idSkin)
        {
            dao = new JdoDAO();
            if (idSkinInicial == 0)
                ExibicaoNovo();
            else
                ExibicaoExistente(idSkin);
        }

        private void Salvar(int idSkin)
        {
            if(ValidarCampos())
            if (idSkinInicial == 0)
            {
                //inserir skin
                skin = ConsolidarObjeto();
                dao.InserirSkin(skin);
                ExibicaoExistente(idSkin);
            }
            else
            {
                //atualizar skin
                skin = ConsolidarObjeto();
                dao.AtualizarSkin(skin);
                ExibicaoExistente(idSkin);
            }
        }

        private Skin ConsolidarObjeto()//Cria objeto usando os dados do formulário
        {
            Skin tempSkin = new Skin
            {
                Id = int.Parse(txtId.Text),
                NomeSkin = txtNomeSkin.Text,
                ImagemSkin = rtxtImagemSkin.Text,
                TipoPeca = rdbTipoO.Checked ? 0 : 1,
                CorTematica = txtCorTematica.Text
            };

            return tempSkin;
        }

        private void ExibirDados(Skin skin)//Exibe os dados de uma skin no formulário
        {
            txtId.Text = skin.Id.ToString();
            txtNomeSkin.Text = skin.NomeSkin;
            rtxtImagemSkin.Text = skin.ImagemSkin;
            txtCorTematica.Text = skin.CorTematica;


            if (skin.TipoPeca == 0)
                rdbTipoO.Checked = true;
            else
                rdbTipoC.Checked = true;

            ExibirImagem(skin.ImagemSkin);

            ExibirCor(skin.CorTematica);
        }

        private void SetEditavel(bool estado)
        {
            if (estado)
            {
                txtNomeSkin.Enabled = true;
                rtxtImagemSkin.Enabled = true;
                txtCorTematica.Enabled = true;

                rdbTipoO.Enabled = true;
                rdbTipoC.Enabled = true;

                btnColorDialog.Enabled = true;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
            }
            else
            {
                txtNomeSkin.Enabled = false;
                rtxtImagemSkin.Enabled = false;
                txtCorTematica.Enabled = false;

                rdbTipoO.Enabled = false;
                rdbTipoC.Enabled = false;

                btnColorDialog.Enabled = false;
                btnEditar.Enabled = true;
                btnSalvar.Enabled = false;
            }
        }

        private void ExibicaoNovo()
        {
            btnEditar.Enabled = false;
            btnEditar.Visible = false;
            btnRemover.Enabled = false;
            btnRemover.Visible = false;

            int autoIncrement = dao.ConsultarAutoIncrementSkin();
            txtId.Text = autoIncrement.ToString();
        }

        private void ExibicaoExistente(int idSkin)
        {
            btnEditar.Enabled = true;
            btnEditar.Visible = true;
            btnRemover.Enabled = true;
            btnRemover.Visible = true;

            skin = dao.ConsultarSkin(idSkin);

            ExibirDados(skin);

            SetEditavel(false);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar(int.Parse(txtId.Text));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            SetEditavel(true);
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblCor.BackColor = colorDialog1.Color;
            txtCorTematica.Text = ConverterColorParaHex(colorDialog1.Color);//ColorTranslator.ToHtml(colorDialog1.Color).ToString();
        }

        private void picImagemSkin_Click(object sender, EventArgs e)
        {
            //TODO: Exibir imagem aumentada
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Remover();
        }

        private void txtCorTematica_TextChanged(object sender, EventArgs e)
        {
            if(txtCorTematica.Text.Length == 7)
            {
                try
                {
                    ExibirCor(txtCorTematica.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Cor inválida", "Falha");
                }
            }
        }

        private void rtxtImagemSkin_Leave(object sender, EventArgs e)
        {
            ExibirImagem(rtxtImagemSkin.Text);
        }

        private void ExibirCor(string corHex)
        {
            try
            {
                cor = ColorTranslator.FromHtml(corHex);
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

        private string ConverterColorParaHex(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        public void Remover()
        {
            skin = ConsolidarObjeto();
            if (dao.IsRemovivelSkin(skin.Id))
            {
                DialogResult resposta = MessageBox.Show("Deseja remover a skin? Esta ação não pode ser revertida.", "Atenção", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    dao.RemoverSkin(skin.Id);
                    MessageBox.Show("Skin removida", "Alerta");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Não é possível remover a skin, pois ela está associada a uma ou mais vendas.", "Aviso");
            }
        }

        private void ExibirImagem(string url)
        {
            try
            {
                picImagemSkin.Load(url);
            }
            catch (System.IO.FileNotFoundException)
            {
                //Imagem não pôde ser exibida/URL inválida
                picImagemSkin.Image = picImagemSkin.ErrorImage;
            }
            catch(InvalidOperationException)
            {
                //Url vazia
                picImagemSkin.Image = picImagemSkin.ErrorImage;
            }
        }

        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtNomeSkin.Text.Length < 1)
            {
                MessageBox.Show("Preencha o nome");
                ok = false;
            }

            if (rtxtImagemSkin.Text.Length < 1)
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string result = fileDialog.FileName;
                rtxtImagemSkin.Text = Upload(result);
                ExibirImagem(rtxtImagemSkin.Text);
            }
            else
            {
                MessageBox.Show("Seleção inválida");
                return;
            }
        }

        private string Upload(string caminho)
        {
            byte[] imagem = (byte[])new ImageConverter().ConvertTo(new Bitmap(caminho), typeof(byte[]));

            HttpClient client = new HttpClient();

            MultipartFormDataContent conteudoRequest = new MultipartFormDataContent();

            ByteArrayContent conteudoImagem = new ByteArrayContent(imagem);

            conteudoImagem.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");

            conteudoRequest.Add(conteudoImagem, "arquivo", caminho.Split('\\')[caminho.Split('\\').Count()-1]);

            var result = client.PostAsync(helper.Instancia.GetImageStoreUrl(), conteudoRequest).Result;

            return result.Content.ReadAsStringAsync().Result;

        }
    }
}
