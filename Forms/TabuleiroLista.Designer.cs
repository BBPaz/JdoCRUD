
namespace JdoCRUD.Forms
{
    partial class TabuleiroLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabuleiroDataGridView = new System.Windows.Forms.DataGridView();
            this.tabuleiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jdoDataSet = new JdoCRUD.jdoDataSet();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabuleiroTableAdapter = new JdoCRUD.jdoDataSetTableAdapters.tabuleiroTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTabuleiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagemTabuleiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corTematica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabuleiroDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabuleiroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabuleiroDataGridView
            // 
            this.tabuleiroDataGridView.AllowUserToAddRows = false;
            this.tabuleiroDataGridView.AllowUserToDeleteRows = false;
            this.tabuleiroDataGridView.AllowUserToOrderColumns = true;
            this.tabuleiroDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabuleiroDataGridView.AutoGenerateColumns = false;
            this.tabuleiroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabuleiroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nomeTabuleiro,
            this.Imagem,
            this.Cor,
            this.dtCriacao,
            this.imagemTabuleiro,
            this.corTematica});
            this.tabuleiroDataGridView.DataSource = this.tabuleiroBindingSource;
            this.tabuleiroDataGridView.Location = new System.Drawing.Point(12, 12);
            this.tabuleiroDataGridView.Name = "tabuleiroDataGridView";
            this.tabuleiroDataGridView.ReadOnly = true;
            this.tabuleiroDataGridView.RowTemplate.Height = 50;
            this.tabuleiroDataGridView.Size = new System.Drawing.Size(555, 397);
            this.tabuleiroDataGridView.TabIndex = 0;
            this.tabuleiroDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabuleiroDataGridView_CellDoubleClick);
            // 
            // tabuleiroBindingSource
            // 
            this.tabuleiroBindingSource.DataMember = "tabuleiro";
            this.tabuleiroBindingSource.DataSource = this.jdoDataSet;
            // 
            // jdoDataSet
            // 
            this.jdoDataSet.DataSetName = "jdoDataSet";
            this.jdoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Location = new System.Drawing.Point(492, 415);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalhes.Location = new System.Drawing.Point(12, 415);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhes.TabIndex = 6;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.Location = new System.Drawing.Point(93, 415);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tabuleiroTableAdapter
            // 
            this.tabuleiroTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // nomeTabuleiro
            // 
            this.nomeTabuleiro.DataPropertyName = "nomeTabuleiro";
            this.nomeTabuleiro.HeaderText = "Nome";
            this.nomeTabuleiro.Name = "nomeTabuleiro";
            // 
            // Imagem
            // 
            this.Imagem.HeaderText = "Imagem";
            this.Imagem.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagem.Name = "Imagem";
            // 
            // Cor
            // 
            this.Cor.HeaderText = "Cor temática";
            this.Cor.Name = "Cor";
            // 
            // dtCriacao
            // 
            this.dtCriacao.DataPropertyName = "dtCriacao";
            this.dtCriacao.HeaderText = "Data de criação";
            this.dtCriacao.Name = "dtCriacao";
            this.dtCriacao.Width = 110;
            // 
            // imagemTabuleiro
            // 
            this.imagemTabuleiro.DataPropertyName = "imagemTabuleiro";
            this.imagemTabuleiro.HeaderText = "imagemTabuleiro";
            this.imagemTabuleiro.Name = "imagemTabuleiro";
            this.imagemTabuleiro.Visible = false;
            // 
            // corTematica
            // 
            this.corTematica.DataPropertyName = "corTematica";
            this.corTematica.HeaderText = "corTematica";
            this.corTematica.Name = "corTematica";
            this.corTematica.Visible = false;
            // 
            // TabuleiroLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.tabuleiroDataGridView);
            this.MinimumSize = new System.Drawing.Size(534, 39);
            this.Name = "TabuleiroLista";
            this.Text = "TabuleiroLista";
            this.Load += new System.EventHandler(this.TabuleiroLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabuleiroDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabuleiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabuleiroDataGridView;
        private jdoDataSetTableAdapters.tabuleiroTableAdapter tabuleiroTableAdapter;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Button btnNovo;
        private jdoDataSet jdoDataSet;
        private System.Windows.Forms.BindingSource tabuleiroBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTabuleiro;
        private System.Windows.Forms.DataGridViewImageColumn Imagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagemTabuleiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn corTematica;
    }
}