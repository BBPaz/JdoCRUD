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
    public partial class SeasonDetalhes : Form
    {
        SeasonDetalhesController controller;
        bool novo;

        public SeasonDetalhes()
        {
            InitializeComponent();
            controller = new SeasonDetalhesController();
            ExibicaoNovo();
        }

        public SeasonDetalhes(int idSeason)
        {
            InitializeComponent();
            controller = new SeasonDetalhesController();
            ExibicaoExistente(idSeason);
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

            CarregarTabuleiros();
        }

        private void ExibirDados(int idSeason)
        {
            Season season = controller.ConsultarSeason(idSeason);

            txtId.Text = season.Id.ToString();
            txtNomeSeason.Text = season.NomeSeason;
            dtpDtInicio.Value = season.InicioVigencia;
            dtpDtFim.Value = season.FimVigencia;
            numPrioridade.Text = season.Prioridade.ToString();
            CarregarTabuleiros();
            ExibirDadosTabuleiro(season.IdTabuleiro);
        }

        private void ExibirDadosTabuleiro(int idTabuleiro)
        {
            Tabuleiro tab = controller.ConsultarTabuleiro(idTabuleiro);

            foreach(ItemTabuleiro item in cbbTabuleiros.Items)
                if(item.Value == idTabuleiro)
                {
                    cbbTabuleiros.SelectedItem = item;
                    break;
                }

            txtCorTematica.Text = tab.CorTematica;

            ExibirImagemTabuleiro(tab.ImagemTabuleiro);

            ExibirCorTabuleiro(tab.CorTematica);
        }

        private void SetEditavel(bool estado)
        {
            if (estado)
            {
                txtNomeSeason.Enabled = true;
                dtpDtInicio.Enabled = true;
                dtpDtFim.Enabled = true;
                numPrioridade.Enabled = true;
                cbbTabuleiros.Enabled = true;

                btnDetalhes.Enabled = true;
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
            }
            else
            {
                txtNomeSeason.Enabled = false;
                dtpDtInicio.Enabled = false;
                dtpDtFim.Enabled = false;
                numPrioridade.Enabled = false;
                cbbTabuleiros.Enabled = false;

                btnDetalhes.Enabled = false;
                btnEditar.Enabled = true;
                btnSalvar.Enabled = false;
            }
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
            lblCor.BackColor = cor;
        }

        private Season ConsolidarObjeto()
        {
            Season tempSeason = new Season();
            tempSeason.Id = int.Parse(txtId.Text);
            tempSeason.NomeSeason = txtNomeSeason.Text;
            tempSeason.InicioVigencia = dtpDtInicio.Value;
            tempSeason.FimVigencia = dtpDtFim.Value;
            tempSeason.Prioridade = ((int)numPrioridade.Value);
            tempSeason.IdTabuleiro = (cbbTabuleiros.SelectedItem as ItemTabuleiro).Value;
            return tempSeason;
        }

        public class ItemTabuleiro
        {
            public string Text { get { return Value + " - " + Nome; } }
            public int Value { get; set; }
            public string Nome { get; set; }

            public ItemTabuleiro(int value, string nome)
            {
                Nome = nome;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void CarregarTabuleiros()
        {
            cbbTabuleiros.Items.Clear();
            List<Tabuleiro> tabuleiros = controller.ConsultarTabuleiros();
            foreach (Tabuleiro tab in tabuleiros)
                cbbTabuleiros.Items.Add(new ItemTabuleiro(tab.Id, tab.NomeTabuleiro));
        }

        public bool ValidarCampos()
        {
            bool ok = true;
            //nome
            if (txtNomeSeason.Text.Length < 1)
            {
                MessageBox.Show("Preencha o nome");
                ok = false;
            }
            //datas
            if(dtpDtInicio.Value < dtpDtFim.Value)
            {
                MessageBox.Show("Data de início da vigência deve ocorrer antes da de final");
                ok = false;
            }
            //
            //prioridade
            if (numPrioridade.Text.Length < 1)
            {
                MessageBox.Show("Defina o nivel de prioridade");
                ok = false;
            }
            //tabuleiro
            if (cbbTabuleiros.SelectedItem == null)
            {
                MessageBox.Show("Selecione um tabuleiro");
                ok = false;
            }
            //prioridade periodo
            if (controller.VerificarDisponivel((int)numPrioridade.Value, dtpDtInicio.Value, dtpDtFim.Value))
            {
                MessageBox.Show("Período selecionado não está disponível na prioridade definida. Escolha outro período ou mude a prioridade");
                ok = false;
            }

            return ok;
        }

        private void SeasonDetalhes_Load(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Season season = ConsolidarObjeto();

            if (controller.VerificarRemovivel(season.Id))
            {
                DialogResult resposta = MessageBox.Show("Deseja remover a season? Esta ação não pode ser revertida.", "Atenção", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                    if (controller.Remover(season.Id))
                    {
                        MessageBox.Show("Season removida", "Aviso");
                        Close();
                    }
            }
            else
            {
                MessageBox.Show("Não é possível remover a season, pois existem vendas associadas.", "Aviso");
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

        private void cbbTabuleiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExibirDadosTabuleiro((cbbTabuleiros.SelectedItem as ItemTabuleiro).Value);
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            int idTabuleiro = (cbbTabuleiros.SelectedItem as ItemTabuleiro).Value;
            new TabuleiroDetalhes(idTabuleiro).ShowDialog();
            CarregarTabuleiros();
            ExibirDadosTabuleiro(idTabuleiro);
        }

        private void dtpDtInicio_ValueChanged(object sender, EventArgs e)
        {
            DateTime inicio = dtpDtInicio.Value;
            DateTime fim = dtpDtFim.Value;

            if (inicio > fim)
                dtpDtFim.Value = inicio;
        }

        private void dtpDtFim_ValueChanged(object sender, EventArgs e)
        {
            DateTime inicio = dtpDtInicio.Value;
            DateTime fim = dtpDtFim.Value;

            if (inicio > fim)
                dtpDtInicio.Value = fim;
        }
    }

    public partial class SeasonDetalhesController
    {
        JdoDAO dao;

        public SeasonDetalhesController()
        {
            dao = new JdoDAO();
        }

        public bool Remover(int idSeason)
        {
            try
            {
                dao.RemoverSeason(idSeason);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void Inserir(Season tabuleiro)
        {
            dao.InserirSeason(tabuleiro);
        }

        public void Atualizar(Season tabuleiro)
        {
            dao.AtualizarSeason(tabuleiro);
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

        public Tabuleiro ConsultarTabuleiro(int idTabuleiro)
        {
            return dao.ConsultarTabuleiro(idTabuleiro);
        }

        internal List<Tabuleiro> ConsultarTabuleiros()
        {
            return dao.ConsultarTabuleiros();
        }

        internal bool VerificarDisponivel(int prioridade, DateTime inicio, DateTime fim)
        {
            return dao.IsPeriodoDisponivelSeason(prioridade, inicio, fim);
        }

        internal bool VerificarRemovivel(int id)
        {
            throw new NotImplementedException();
        }
    }
}
