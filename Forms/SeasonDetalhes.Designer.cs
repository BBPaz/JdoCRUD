
namespace JdoCRUD.Forms
{
    partial class SeasonDetalhes
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
            this.txtNomeSeason = new System.Windows.Forms.TextBox();
            this.lblNomeSeason = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDtInicio = new System.Windows.Forms.Label();
            this.lblDtFim = new System.Windows.Forms.Label();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.dtpDtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpDtFim = new System.Windows.Forms.DateTimePicker();
            this.numPrioridade = new System.Windows.Forms.NumericUpDown();
            this.jdoDataSet1 = new JdoCRUD.jdoDataSet();
            this.grpTabuleiro = new System.Windows.Forms.GroupBox();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.lblCorTematica = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtCorTematica = new System.Windows.Forms.TextBox();
            this.picImagemTabuleiro = new System.Windows.Forms.PictureBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbbTabuleiros = new System.Windows.Forms.ComboBox();
            this.lblTabuleiro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPrioridade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdoDataSet1)).BeginInit();
            this.grpTabuleiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemTabuleiro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeSeason
            // 
            this.txtNomeSeason.Location = new System.Drawing.Point(135, 32);
            this.txtNomeSeason.Name = "txtNomeSeason";
            this.txtNomeSeason.Size = new System.Drawing.Size(183, 20);
            this.txtNomeSeason.TabIndex = 2;
            // 
            // lblNomeSeason
            // 
            this.lblNomeSeason.AutoSize = true;
            this.lblNomeSeason.Location = new System.Drawing.Point(12, 35);
            this.lblNomeSeason.Name = "lblNomeSeason";
            this.lblNomeSeason.Size = new System.Drawing.Size(92, 13);
            this.lblNomeSeason.TabIndex = 30;
            this.lblNomeSeason.Text = "Nome da Season:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(135, 6);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "ID:";
            // 
            // lblDtInicio
            // 
            this.lblDtInicio.AutoSize = true;
            this.lblDtInicio.Location = new System.Drawing.Point(12, 64);
            this.lblDtInicio.Name = "lblDtInicio";
            this.lblDtInicio.Size = new System.Drawing.Size(93, 13);
            this.lblDtInicio.TabIndex = 37;
            this.lblDtInicio.Text = "Inicio da vigência:";
            // 
            // lblDtFim
            // 
            this.lblDtFim.AutoSize = true;
            this.lblDtFim.Location = new System.Drawing.Point(12, 90);
            this.lblDtFim.Name = "lblDtFim";
            this.lblDtFim.Size = new System.Drawing.Size(84, 13);
            this.lblDtFim.TabIndex = 39;
            this.lblDtFim.Text = "Fim da vigência:";
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Location = new System.Drawing.Point(12, 113);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(57, 13);
            this.lblPrioridade.TabIndex = 41;
            this.lblPrioridade.Text = "Prioridade:";
            // 
            // dtpDtInicio
            // 
            this.dtpDtInicio.Location = new System.Drawing.Point(135, 58);
            this.dtpDtInicio.Name = "dtpDtInicio";
            this.dtpDtInicio.Size = new System.Drawing.Size(183, 20);
            this.dtpDtInicio.TabIndex = 3;
            this.dtpDtInicio.ValueChanged += new System.EventHandler(this.dtpDtInicio_ValueChanged);
            // 
            // dtpDtFim
            // 
            this.dtpDtFim.Location = new System.Drawing.Point(135, 84);
            this.dtpDtFim.Name = "dtpDtFim";
            this.dtpDtFim.Size = new System.Drawing.Size(183, 20);
            this.dtpDtFim.TabIndex = 4;
            this.dtpDtFim.ValueChanged += new System.EventHandler(this.dtpDtFim_ValueChanged);
            // 
            // numPrioridade
            // 
            this.numPrioridade.Location = new System.Drawing.Point(135, 111);
            this.numPrioridade.Name = "numPrioridade";
            this.numPrioridade.Size = new System.Drawing.Size(36, 20);
            this.numPrioridade.TabIndex = 5;
            // 
            // jdoDataSet1
            // 
            this.jdoDataSet1.DataSetName = "jdoDataSet";
            this.jdoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpTabuleiro
            // 
            this.grpTabuleiro.Controls.Add(this.btnDetalhes);
            this.grpTabuleiro.Controls.Add(this.lblCorTematica);
            this.grpTabuleiro.Controls.Add(this.lblCor);
            this.grpTabuleiro.Controls.Add(this.txtCorTematica);
            this.grpTabuleiro.Controls.Add(this.picImagemTabuleiro);
            this.grpTabuleiro.Location = new System.Drawing.Point(12, 166);
            this.grpTabuleiro.Name = "grpTabuleiro";
            this.grpTabuleiro.Size = new System.Drawing.Size(244, 126);
            this.grpTabuleiro.TabIndex = 46;
            this.grpTabuleiro.TabStop = false;
            this.grpTabuleiro.Text = "Tabuleiro";
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalhes.Location = new System.Drawing.Point(161, 91);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhes.TabIndex = 37;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // lblCorTematica
            // 
            this.lblCorTematica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCorTematica.AutoSize = true;
            this.lblCorTematica.Location = new System.Drawing.Point(139, 16);
            this.lblCorTematica.Name = "lblCorTematica";
            this.lblCorTematica.Size = new System.Drawing.Size(69, 13);
            this.lblCorTematica.TabIndex = 36;
            this.lblCorTematica.Text = "Cor temática:";
            // 
            // lblCor
            // 
            this.lblCor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(139, 55);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(97, 13);
            this.lblCor.TabIndex = 35;
            this.lblCor.Text = "                              ";
            // 
            // txtCorTematica
            // 
            this.txtCorTematica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCorTematica.Enabled = false;
            this.txtCorTematica.Location = new System.Drawing.Point(136, 32);
            this.txtCorTematica.MaxLength = 7;
            this.txtCorTematica.Name = "txtCorTematica";
            this.txtCorTematica.ReadOnly = true;
            this.txtCorTematica.Size = new System.Drawing.Size(100, 20);
            this.txtCorTematica.TabIndex = 34;
            // 
            // picImagemTabuleiro
            // 
            this.picImagemTabuleiro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImagemTabuleiro.Location = new System.Drawing.Point(6, 19);
            this.picImagemTabuleiro.MinimumSize = new System.Drawing.Size(100, 100);
            this.picImagemTabuleiro.Name = "picImagemTabuleiro";
            this.picImagemTabuleiro.Size = new System.Drawing.Size(100, 100);
            this.picImagemTabuleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagemTabuleiro.TabIndex = 32;
            this.picImagemTabuleiro.TabStop = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Location = new System.Drawing.Point(102, 298);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 49;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(183, 298);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 48;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(264, 298);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 47;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbbTabuleiros
            // 
            this.cbbTabuleiros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTabuleiros.FormattingEnabled = true;
            this.cbbTabuleiros.Location = new System.Drawing.Point(135, 137);
            this.cbbTabuleiros.Name = "cbbTabuleiros";
            this.cbbTabuleiros.Size = new System.Drawing.Size(183, 21);
            this.cbbTabuleiros.TabIndex = 6;
            this.cbbTabuleiros.SelectedIndexChanged += new System.EventHandler(this.cbbTabuleiros_SelectedIndexChanged);
            // 
            // lblTabuleiro
            // 
            this.lblTabuleiro.AutoSize = true;
            this.lblTabuleiro.Location = new System.Drawing.Point(12, 140);
            this.lblTabuleiro.Name = "lblTabuleiro";
            this.lblTabuleiro.Size = new System.Drawing.Size(114, 13);
            this.lblTabuleiro.TabIndex = 51;
            this.lblTabuleiro.Text = "Tabuleiro selecionado:";
            // 
            // SeasonDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 333);
            this.Controls.Add(this.lblTabuleiro);
            this.Controls.Add(this.cbbTabuleiros);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpTabuleiro);
            this.Controls.Add(this.numPrioridade);
            this.Controls.Add(this.dtpDtFim);
            this.Controls.Add(this.dtpDtInicio);
            this.Controls.Add(this.lblPrioridade);
            this.Controls.Add(this.lblDtFim);
            this.Controls.Add(this.lblDtInicio);
            this.Controls.Add(this.txtNomeSeason);
            this.Controls.Add(this.lblNomeSeason);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.MinimumSize = new System.Drawing.Size(367, 372);
            this.Name = "SeasonDetalhes";
            this.Text = "SeasonDetalhes";
            this.Load += new System.EventHandler(this.SeasonDetalhes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrioridade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdoDataSet1)).EndInit();
            this.grpTabuleiro.ResumeLayout(false);
            this.grpTabuleiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemTabuleiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeSeason;
        private System.Windows.Forms.Label lblNomeSeason;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDtInicio;
        private System.Windows.Forms.Label lblDtFim;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.DateTimePicker dtpDtInicio;
        private System.Windows.Forms.DateTimePicker dtpDtFim;
        private System.Windows.Forms.NumericUpDown numPrioridade;
        private jdoDataSet jdoDataSet1;
        private System.Windows.Forms.GroupBox grpTabuleiro;
        private System.Windows.Forms.PictureBox picImagemTabuleiro;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtCorTematica;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblCorTematica;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.ComboBox cbbTabuleiros;
        private System.Windows.Forms.Label lblTabuleiro;
    }
}