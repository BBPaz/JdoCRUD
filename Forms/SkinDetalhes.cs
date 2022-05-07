using JdoCRUD.DAO;
using JdoCRUD.Model;
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
    public partial class SkinDetalhes : Form
    {

        private bool novoRegistro;
        private JdoDAO dao;
        Skin skin;
        Color cor;
        int idSkinInicial = 0;

        public SkinDetalhes()
        {
            InitializeComponent();
            novoRegistro = true;
        }

        public SkinDetalhes(int idSkin)
        {
            InitializeComponent();
            novoRegistro = false;
            idSkinInicial = idSkin;
        }

        private void SkinDetalhes_Load(object sender, EventArgs e)
        {
            Carregar(idSkinInicial);
        }

        private void Carregar(int idSkin)
        {
            dao = new JdoDAO();
            if (novoRegistro)
                exibicaoNovo();
            else
                exibicaoExistente(idSkin);
        }

        private void salvar(int idSkin)
        {
            if(validarCampos())
            if (novoRegistro)
            {
                //inserir skin
                skin = consolidarObjeto();
                dao.InserirSkin(skin);
                exibicaoExistente(idSkin);
            }
            else
            {
                //atualizar skin
                skin = consolidarObjeto();
                dao.AtualizarSkin(skin);
                exibicaoExistente(idSkin);
            }
        }

        private Skin consolidarObjeto()//Cria objeto usando os dados do formulário
        {
            Skin tempSkin = new Skin
            {
                Id = int.Parse(txtId.Text),
                NomeSkin = txtNomeSkin.Text,
                ImagemSkin = rtxtImagemSkin.Text,
                TipoPeca = rdbTipoO.Checked ? 0 : 1,
                EhPermanente = rdbPermanenteSim.Checked,
                CorTematica = txtCorTematica.Text
            };

            return tempSkin;
        }

        private void exibirDados(Skin skin)//Exibe os dados de uma skin no formulário
        {
            txtId.Text = skin.Id.ToString();
            txtNomeSkin.Text = skin.NomeSkin;
            rtxtImagemSkin.Text = skin.ImagemSkin;
            txtTipoPeca.Text = skin.TipoPeca.ToString();
            txtEhPermanente.Text = skin.EhPermanente.ToString();
            txtCorTematica.Text = skin.CorTematica;
            if (skin.EhPermanente)
                rdbPermanenteSim.Checked = true;
            else
                rdbPermanenteNao.Checked = true;

            if (skin.TipoPeca == 0)
                rdbTipoO.Checked = true;
            else
                rdbTipoC.Checked = true;

            exibirImagem(skin.ImagemSkin);

            exibirCor(skin.CorTematica);
        }

        private void exibicaoNovo()
        {
            btnEditar.Enabled = false;
            btnEditar.Visible = false;
            btnRemover.Enabled = false;
            btnRemover.Visible = false;

            int autoIncrement = dao.ConsultarAutoIncrementSkin();
            txtId.Text = autoIncrement.ToString();
        }

        private void exibicaoExistente(int idSkin)
        {
            btnEditar.Enabled = true;
            btnEditar.Visible = true;
            btnRemover.Enabled = true;
            btnRemover.Visible = true;

            skin = dao.ConsultarSkin(idSkin);

            exibirDados(skin);

            setEditavel(false);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar(int.Parse(txtId.Text));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            setEditavel(true);
        }

        private void setEditavel(bool estado)
        {
            if (estado)
            {
                txtNomeSkin.Enabled = true;
                rtxtImagemSkin.Enabled = true;
                txtTipoPeca.Enabled = true;
                txtEhPermanente.Enabled = true;
                txtCorTematica.Enabled = true;

                rdbTipoO.Enabled = true;
                rdbTipoC.Enabled = true;
                rdbPermanenteNao.Enabled = true;
                rdbPermanenteSim.Enabled = true;

                btnColorDialog.Enabled = true;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
            }
            else
            {
                txtNomeSkin.Enabled = false;
                rtxtImagemSkin.Enabled = false;
                txtTipoPeca.Enabled = false;
                txtEhPermanente.Enabled = false;
                txtCorTematica.Enabled = false;

                rdbTipoO.Enabled = false;
                rdbTipoC.Enabled = false;
                rdbPermanenteNao.Enabled = false;
                rdbPermanenteSim.Enabled = false;

                btnColorDialog.Enabled = false;
                btnEditar.Enabled = true;
                btnSalvar.Enabled = false;
            }
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblCor.BackColor = colorDialog1.Color;
            txtCorTematica.Text = converterColorParaHex(colorDialog1.Color);//ColorTranslator.ToHtml(colorDialog1.Color).ToString();
        }

        private void exibirCor(string corHex)
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
            /*try
            {
            }
            catch(System.FormatException e)
            {
                string message = e.Message;
            }*/
        }

        private string converterColorParaHex(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private void picImagemSkin_Click(object sender, EventArgs e)
        {
            //TODO: Exibir imagem aumentada
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            remover();
        }

        public void remover()
        {
            skin = consolidarObjeto();
            DialogResult resposta = MessageBox.Show("Deseja remover a skin? Esta ação não pode ser revertida.", "Atenção", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                dao.RemoverSkin(skin.Id);
                MessageBox.Show("Skin removida", "Alerta");
                Close();
            }
        }

        private void txtCorTematica_TextChanged(object sender, EventArgs e)
        {
            if(txtCorTematica.Text.Length == 7)
            {
                try
                {
                    exibirCor(txtCorTematica.Text);
                }
                catch (System.FormatException formatE)
                {
                    MessageBox.Show("Cor inválida", "Falha");
                }
            }
        }

        private void rtxtImagemSkin_Leave(object sender, EventArgs e)
        {
            exibirImagem(rtxtImagemSkin.Text);
        }

        private void exibirImagem(string url)
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

        private bool validarCampos()
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
    }
}
