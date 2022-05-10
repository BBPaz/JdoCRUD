
namespace JdoCRUD.Forms
{
    partial class VendaDetalhes
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
            this.lblSeason = new System.Windows.Forms.Label();
            this.cbbSeasons = new System.Windows.Forms.ComboBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpTabuleiro = new System.Windows.Forms.GroupBox();
            this.pnlCorTematicaTabuleiro = new System.Windows.Forms.Panel();
            this.lblTabuleiro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIdSeason = new System.Windows.Forms.Label();
            this.txtNomeSeason = new System.Windows.Forms.TextBox();
            this.txtIdSeason = new System.Windows.Forms.TextBox();
            this.btnDetalhesSeason = new System.Windows.Forms.Button();
            this.lblCorTematica = new System.Windows.Forms.Label();
            this.txtCorTematicaTabuleiro = new System.Windows.Forms.TextBox();
            this.picImagemTabuleiro = new System.Windows.Forms.PictureBox();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSkin = new System.Windows.Forms.Label();
            this.cbbSkins = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDetalhesSkin = new System.Windows.Forms.Button();
            this.pnlCorTematicaSkin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCorTematicaSkin = new System.Windows.Forms.Label();
            this.txtCorTematicaSkin = new System.Windows.Forms.TextBox();
            this.picImagemSkin = new System.Windows.Forms.PictureBox();
            this.grpTabuleiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemTabuleiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemSkin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Location = new System.Drawing.Point(12, 221);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(106, 13);
            this.lblSeason.TabIndex = 67;
            this.lblSeason.Text = "Season selecionada:";
            // 
            // cbbSeasons
            // 
            this.cbbSeasons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSeasons.FormattingEnabled = true;
            this.cbbSeasons.Location = new System.Drawing.Point(135, 218);
            this.cbbSeasons.Name = "cbbSeasons";
            this.cbbSeasons.Size = new System.Drawing.Size(183, 21);
            this.cbbSeasons.TabIndex = 57;
            this.cbbSeasons.SelectedIndexChanged += new System.EventHandler(this.cbbSeasons_SelectedIndexChanged);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Location = new System.Drawing.Point(166, 415);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 66;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(247, 415);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 65;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(328, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 64;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grpTabuleiro
            // 
            this.grpTabuleiro.Controls.Add(this.pnlCorTematicaTabuleiro);
            this.grpTabuleiro.Controls.Add(this.lblTabuleiro);
            this.grpTabuleiro.Controls.Add(this.label4);
            this.grpTabuleiro.Controls.Add(this.lblIdSeason);
            this.grpTabuleiro.Controls.Add(this.txtNomeSeason);
            this.grpTabuleiro.Controls.Add(this.txtIdSeason);
            this.grpTabuleiro.Controls.Add(this.btnDetalhesSeason);
            this.grpTabuleiro.Controls.Add(this.lblCorTematica);
            this.grpTabuleiro.Controls.Add(this.txtCorTematicaTabuleiro);
            this.grpTabuleiro.Controls.Add(this.picImagemTabuleiro);
            this.grpTabuleiro.Location = new System.Drawing.Point(12, 245);
            this.grpTabuleiro.Name = "grpTabuleiro";
            this.grpTabuleiro.Size = new System.Drawing.Size(391, 152);
            this.grpTabuleiro.TabIndex = 63;
            this.grpTabuleiro.TabStop = false;
            this.grpTabuleiro.Text = "Season";
            // 
            // pnlCorTematicaTabuleiro
            // 
            this.pnlCorTematicaTabuleiro.Location = new System.Drawing.Point(266, 62);
            this.pnlCorTematicaTabuleiro.Name = "pnlCorTematicaTabuleiro";
            this.pnlCorTematicaTabuleiro.Size = new System.Drawing.Size(100, 33);
            this.pnlCorTematicaTabuleiro.TabIndex = 44;
            // 
            // lblTabuleiro
            // 
            this.lblTabuleiro.AutoSize = true;
            this.lblTabuleiro.Location = new System.Drawing.Point(133, 20);
            this.lblTabuleiro.Name = "lblTabuleiro";
            this.lblTabuleiro.Size = new System.Drawing.Size(108, 13);
            this.lblTabuleiro.TabIndex = 42;
            this.lblTabuleiro.Text = "Tabuleiro da Season:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Nome da Season:";
            // 
            // lblIdSeason
            // 
            this.lblIdSeason.AutoSize = true;
            this.lblIdSeason.Location = new System.Drawing.Point(7, 20);
            this.lblIdSeason.Name = "lblIdSeason";
            this.lblIdSeason.Size = new System.Drawing.Size(75, 13);
            this.lblIdSeason.TabIndex = 40;
            this.lblIdSeason.Text = "ID da Season:";
            // 
            // txtNomeSeason
            // 
            this.txtNomeSeason.Enabled = false;
            this.txtNomeSeason.Location = new System.Drawing.Point(6, 75);
            this.txtNomeSeason.Name = "txtNomeSeason";
            this.txtNomeSeason.ReadOnly = true;
            this.txtNomeSeason.Size = new System.Drawing.Size(100, 20);
            this.txtNomeSeason.TabIndex = 39;
            // 
            // txtIdSeason
            // 
            this.txtIdSeason.Enabled = false;
            this.txtIdSeason.Location = new System.Drawing.Point(6, 36);
            this.txtIdSeason.Name = "txtIdSeason";
            this.txtIdSeason.ReadOnly = true;
            this.txtIdSeason.Size = new System.Drawing.Size(100, 20);
            this.txtIdSeason.TabIndex = 38;
            // 
            // btnDetalhesSeason
            // 
            this.btnDetalhesSeason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalhesSeason.Location = new System.Drawing.Point(266, 121);
            this.btnDetalhesSeason.Name = "btnDetalhesSeason";
            this.btnDetalhesSeason.Size = new System.Drawing.Size(119, 23);
            this.btnDetalhesSeason.TabIndex = 37;
            this.btnDetalhesSeason.Text = "Detalhes da Season";
            this.btnDetalhesSeason.UseVisualStyleBackColor = true;
            this.btnDetalhesSeason.Click += new System.EventHandler(this.btnDetalhesSeason_Click);
            // 
            // lblCorTematica
            // 
            this.lblCorTematica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCorTematica.AutoSize = true;
            this.lblCorTematica.Location = new System.Drawing.Point(269, 20);
            this.lblCorTematica.Name = "lblCorTematica";
            this.lblCorTematica.Size = new System.Drawing.Size(69, 13);
            this.lblCorTematica.TabIndex = 36;
            this.lblCorTematica.Text = "Cor temática:";
            // 
            // txtCorTematicaTabuleiro
            // 
            this.txtCorTematicaTabuleiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCorTematicaTabuleiro.Enabled = false;
            this.txtCorTematicaTabuleiro.Location = new System.Drawing.Point(266, 36);
            this.txtCorTematicaTabuleiro.MaxLength = 7;
            this.txtCorTematicaTabuleiro.Name = "txtCorTematicaTabuleiro";
            this.txtCorTematicaTabuleiro.ReadOnly = true;
            this.txtCorTematicaTabuleiro.Size = new System.Drawing.Size(100, 20);
            this.txtCorTematicaTabuleiro.TabIndex = 34;
            // 
            // picImagemTabuleiro
            // 
            this.picImagemTabuleiro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImagemTabuleiro.Location = new System.Drawing.Point(136, 34);
            this.picImagemTabuleiro.MinimumSize = new System.Drawing.Size(110, 110);
            this.picImagemTabuleiro.Name = "picImagemTabuleiro";
            this.picImagemTabuleiro.Size = new System.Drawing.Size(110, 110);
            this.picImagemTabuleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagemTabuleiro.TabIndex = 32;
            this.picImagemTabuleiro.TabStop = false;
            // 
            // numValor
            // 
            this.numValor.Location = new System.Drawing.Point(135, 33);
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(100, 20);
            this.numValor.TabIndex = 56;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 35);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 59;
            this.lblValor.Text = "Valor:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(135, 6);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 52;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 58;
            this.lblId.Text = "ID:";
            // 
            // lblSkin
            // 
            this.lblSkin.AutoSize = true;
            this.lblSkin.Location = new System.Drawing.Point(12, 62);
            this.lblSkin.Name = "lblSkin";
            this.lblSkin.Size = new System.Drawing.Size(91, 13);
            this.lblSkin.TabIndex = 69;
            this.lblSkin.Text = "Skin selecionada:";
            // 
            // cbbSkins
            // 
            this.cbbSkins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSkins.FormattingEnabled = true;
            this.cbbSkins.Location = new System.Drawing.Point(135, 59);
            this.cbbSkins.Name = "cbbSkins";
            this.cbbSkins.Size = new System.Drawing.Size(183, 21);
            this.cbbSkins.TabIndex = 68;
            this.cbbSkins.SelectedIndexChanged += new System.EventHandler(this.cbbSkins_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDetalhesSkin);
            this.groupBox1.Controls.Add(this.pnlCorTematicaSkin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCorTematicaSkin);
            this.groupBox1.Controls.Add(this.txtCorTematicaSkin);
            this.groupBox1.Controls.Add(this.picImagemSkin);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 126);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skin";
            // 
            // btnDetalhesSkin
            // 
            this.btnDetalhesSkin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalhesSkin.Location = new System.Drawing.Point(136, 97);
            this.btnDetalhesSkin.Name = "btnDetalhesSkin";
            this.btnDetalhesSkin.Size = new System.Drawing.Size(124, 23);
            this.btnDetalhesSkin.TabIndex = 37;
            this.btnDetalhesSkin.Text = "Detalhes da Skin";
            this.btnDetalhesSkin.UseVisualStyleBackColor = true;
            this.btnDetalhesSkin.Click += new System.EventHandler(this.btnDetalhesSkin_Click);
            // 
            // pnlCorTematicaSkin
            // 
            this.pnlCorTematicaSkin.Location = new System.Drawing.Point(136, 58);
            this.pnlCorTematicaSkin.Name = "pnlCorTematicaSkin";
            this.pnlCorTematicaSkin.Size = new System.Drawing.Size(100, 33);
            this.pnlCorTematicaSkin.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cor temática:";
            // 
            // lblCorTematicaSkin
            // 
            this.lblCorTematicaSkin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCorTematicaSkin.AutoSize = true;
            this.lblCorTematicaSkin.Location = new System.Drawing.Point(139, 55);
            this.lblCorTematicaSkin.Name = "lblCorTematicaSkin";
            this.lblCorTematicaSkin.Size = new System.Drawing.Size(97, 13);
            this.lblCorTematicaSkin.TabIndex = 35;
            this.lblCorTematicaSkin.Text = "                              ";
            // 
            // txtCorTematicaSkin
            // 
            this.txtCorTematicaSkin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCorTematicaSkin.Enabled = false;
            this.txtCorTematicaSkin.Location = new System.Drawing.Point(136, 32);
            this.txtCorTematicaSkin.MaxLength = 7;
            this.txtCorTematicaSkin.Name = "txtCorTematicaSkin";
            this.txtCorTematicaSkin.ReadOnly = true;
            this.txtCorTematicaSkin.Size = new System.Drawing.Size(100, 20);
            this.txtCorTematicaSkin.TabIndex = 34;
            // 
            // picImagemSkin
            // 
            this.picImagemSkin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImagemSkin.Location = new System.Drawing.Point(6, 19);
            this.picImagemSkin.MinimumSize = new System.Drawing.Size(100, 100);
            this.picImagemSkin.Name = "picImagemSkin";
            this.picImagemSkin.Size = new System.Drawing.Size(100, 100);
            this.picImagemSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagemSkin.TabIndex = 32;
            this.picImagemSkin.TabStop = false;
            // 
            // VendaDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSkin);
            this.Controls.Add(this.cbbSkins);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.cbbSeasons);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpTabuleiro);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "VendaDetalhes";
            this.Text = "VendaDetalhes";
            this.Load += new System.EventHandler(this.VendaDetalhes_Load);
            this.grpTabuleiro.ResumeLayout(false);
            this.grpTabuleiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemTabuleiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemSkin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.ComboBox cbbSeasons;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grpTabuleiro;
        private System.Windows.Forms.Button btnDetalhesSeason;
        private System.Windows.Forms.Label lblCorTematica;
        private System.Windows.Forms.TextBox txtCorTematicaTabuleiro;
        private System.Windows.Forms.PictureBox picImagemTabuleiro;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIdSeason;
        private System.Windows.Forms.TextBox txtNomeSeason;
        private System.Windows.Forms.TextBox txtIdSeason;
        private System.Windows.Forms.Label lblSkin;
        private System.Windows.Forms.ComboBox cbbSkins;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDetalhesSkin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCorTematicaSkin;
        private System.Windows.Forms.TextBox txtCorTematicaSkin;
        private System.Windows.Forms.PictureBox picImagemSkin;
        private System.Windows.Forms.Label lblTabuleiro;
        private System.Windows.Forms.Panel pnlCorTematicaTabuleiro;
        private System.Windows.Forms.Panel pnlCorTematicaSkin;
    }
}