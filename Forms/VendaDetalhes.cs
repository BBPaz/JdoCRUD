using JdoCRUD.DAO;
using JdoCRUD.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JdoCRUD.Forms
{
    public partial class VendaDetalhes : Form
    {
        bool novo;
        VendaDetalhesController controller;

        public VendaDetalhes()
        {
            InitializeComponent();
            controller = new VendaDetalhesController();
            ExibicaoNovo();
        }

        public VendaDetalhes(int id)
        {
            InitializeComponent();
            controller = new VendaDetalhesController();
            ExibicaoExistente(id);
        }

        private void ExibicaoExistente(int idSeason)
        {
            btnEditar.Enabled = true;
            btnEditar.Visible = true;
            btnRemover.Enabled = true;
            btnRemover.Visible = true;

            novo = false;
            ExibirDados(idSeason);
            SetEditavel(false);
        }

        private void ExibicaoNovo()
        {
            btnEditar.Enabled = false;
            btnEditar.Visible = false;
            btnRemover.Enabled = false;
            btnRemover.Visible = false;

            novo = true;
            int autoIncrement = controller.ConsultarAutoIncrementSeason();//dao.ConsultarAutoIncrementSkin();
            txtId.Text = autoIncrement.ToString();

            CarregarSkins();
            CarregarSeasons();
        }

        private void ExibirDados(int idVenda)
        {
            Venda venda = controller.ConsultarVenda(idVenda);

            txtId.Text = venda.Id.ToString();
            numValor.Text = venda.Valor.ToString();
            CarregarSkins();
            ExibirDadosSkin(venda.IdSkin);

            CarregarSeasons();
            ExibirDadosSeason(venda.IdSeason);
        }

        private void CarregarSkins()
        {
            cbbSkins.Items.Clear();
            List<Skin> skins = controller.ConsultarSkins();
            foreach (Skin skin in skins)
                cbbSkins.Items.Add(new ItemComboBox(skin.Id, skin.NomeSkin));
        }

        private void CarregarSeasons()
        {
            cbbSeasons.Items.Clear();
            List<Season> seasons = controller.ConsultarSeasons();
            foreach (Season season in seasons)
                cbbSeasons.Items.Add(new ItemComboBox(season.Id, season.NomeSeason));
        }

        private void ExibirDadosSkin(int idSkin)
        {
            Skin skin = controller.ConsultarSkin(idSkin);

            foreach (ItemComboBox item in cbbSkins.Items)
                if (item.Value == idSkin)
                {
                    cbbSkins.SelectedItem = item;
                    break;
                }

            txtCorTematicaSkin.Text = skin.CorTematica;

            ExibirImagemSkin(skin.ImagemSkin);

            ExibirCorSkin(skin.CorTematica);
        }

        private void ExibirDadosSeason(int idSeason)
        {
            Season season = controller.ConsultarSeason(idSeason);

            foreach (ItemComboBox item in cbbSeasons.Items)
                if (item.Value == idSeason)
                {
                    cbbSeasons.SelectedItem = item;
                    break;
                }

            txtIdSeason.Text = season.Id.ToString();
            txtNomeSeason.Text = season.NomeSeason;

            ExibirDadosTabuleiro(season.IdTabuleiro);
        }

        private void ExibirImagemSkin(string url)
        {
            try
            {
                picImagemSkin.Load(url);
            }
            catch (System.IO.FileNotFoundException)
            {
                //Imagem não pôde ser exibida/URL inválida
                picImagemSkin.Image = picImagemTabuleiro.ErrorImage;
            }
            catch (InvalidOperationException)
            {
                //Url vazia
                picImagemSkin.Image = picImagemTabuleiro.ErrorImage;
            }
        }

        private void ExibirCorSkin(string corHex)
        {
            Color cor = ColorTranslator.FromHtml(corHex);
            pnlCorTematicaSkin.BackColor = cor;
        }

        private void ExibirDadosTabuleiro(int idTabuleiro)
        {
            Tabuleiro tab = controller.ConsultarTabuleiro(idTabuleiro);

            txtCorTematicaTabuleiro.Text = tab.CorTematica;

            ExibirImagemTabuleiro(tab.ImagemTabuleiro);

            ExibirCorTabuleiro(tab.CorTematica);
        }

        private void ExibirImagemTabuleiro(string url)
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

        private void ExibirCorTabuleiro(string corHex)
        {
            Color cor = ColorTranslator.FromHtml(corHex);
            pnlCorTematicaTabuleiro.BackColor = cor;
        }

        private void SetEditavel(bool estado)
        {
            if (estado)
            {
                numValor.Enabled = true;
                cbbSeasons.Enabled = true;
                cbbSkins.Enabled = true;

                btnDetalhesSeason.Enabled = true;
                btnDetalhesSkin.Enabled = true;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
            }
            else
            {
                numValor.Enabled = false;
                cbbSeasons.Enabled = false;
                cbbSkins.Enabled = false;

                btnDetalhesSeason.Enabled = false;
                btnDetalhesSkin.Enabled = false;
                btnEditar.Enabled = true;
                btnSalvar.Enabled = false;
            }
        }

        private Venda ConsolidarObjeto()
        {
            Venda tempVenda = new Venda();
            tempVenda.Id = int.Parse(txtId.Text);
            tempVenda.IdSkin = (cbbSkins.SelectedItem as ItemComboBox).Value;
            tempVenda.IdSeason = (cbbSeasons.SelectedItem as ItemComboBox).Value;
            tempVenda.Valor = ((int)numValor.Value);
            return tempVenda;
        }

        public class ItemComboBox
        {
            public string Text { get { return Value + " - " + Nome; } }
            public int Value { get; set; }
            public string Nome { get; set; }

            public ItemComboBox(int value, string nome)
            {
                Nome = nome;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        public bool ValidarCampos()
        {
            bool ok = true;
            //valor
            if (numValor.Text.Length < 1)
            {
                MessageBox.Show("Defina o valor", "Atenção");
                ok = false;
            }
            //skin
            if (cbbSkins.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma skin", "Atenção");
                ok = false;
            }
            //season
            if (cbbSeasons.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma season", "Atenção");
                ok = false;
            }

            return ok;
        }

        private void VendaDetalhes_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            SetEditavel(true);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Venda venda = ConsolidarObjeto();

            DialogResult resposta = MessageBox.Show("Deseja remover a venda? Esta ação não pode ser revertida.", "Atenção", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
                if (controller.Remover(venda.Id))
                {
                    MessageBox.Show("Venda removida", "Aviso");
                    Close();
                }
        }

        private void btnDetalhesSkin_Click(object sender, EventArgs e)
        {
            new SkinDetalhes((cbbSkins.SelectedItem as ItemComboBox).Value);
        }

        private void btnDetalhesSeason_Click(object sender, EventArgs e)
        {
            new SkinDetalhes((cbbSeasons.SelectedItem as ItemComboBox).Value);
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

        private void cbbSkins_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExibirDadosSkin((cbbSkins.SelectedItem as ItemComboBox).Value);
        }

        private void cbbSeasons_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExibirDadosSeason((cbbSeasons.SelectedItem as ItemComboBox).Value);
        }
    }


    public partial class VendaDetalhesController{
        JdoDAO dao;

        public VendaDetalhesController()
        {
            dao = new JdoDAO();
        }

        public bool Remover(int idVenda)
        {
            try
            {
                dao.RemoverVenda(idVenda);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void Inserir(Venda venda)
        {
            dao.InserirVenda(venda);
        }

        public void Atualizar(Venda venda)
        {
            dao.AtualizarVenda(venda);
        }

        public string ConverterColorParaHex(Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        public int ConsultarAutoIncrementSeason()
        {
            return dao.ConsultarAutoIncrementSeason();
        }

        public Season ConsultarSeason(int idSeason)
        {
            return dao.ConsultarSeason(idSeason);
        }

        internal List<Season> ConsultarSeasons()
        {
            return dao.ConsultarSeasons();
        }

        public Tabuleiro ConsultarTabuleiro(int idTabuleiro)
        {
            return dao.ConsultarTabuleiro(idTabuleiro);
        }

        public Skin ConsultarSkin(int idSkin)
        {
            return dao.ConsultarSkin(idSkin);
        }

        internal List<Skin> ConsultarSkins()
        {
            return dao.ConsultarSkins();
        }

        internal Venda ConsultarVenda(int idVenda)
        {
            return dao.ConsultarVenda(idVenda);
        }
    }

}
