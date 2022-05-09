
namespace JdoCRUD.Forms
{
    partial class TabuleiroDetalhes
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
            this.rtxtImagemTabuleiro = new System.Windows.Forms.RichTextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.picImagemTabuleiro = new System.Windows.Forms.PictureBox();
            this.txtCorTematica = new System.Windows.Forms.TextBox();
            this.lblCorTematica = new System.Windows.Forms.Label();
            this.lblImagemTabuleiro = new System.Windows.Forms.Label();
            this.txtNomeTabuleiro = new System.Windows.Forms.TextBox();
            this.lblNomeTabuleiro = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtDtCriacao = new System.Windows.Forms.TextBox();
            this.lblDtCriacao = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemTabuleiro)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtImagemTabuleiro
            // 
            this.rtxtImagemTabuleiro.Location = new System.Drawing.Point(114, 58);
            this.rtxtImagemTabuleiro.Name = "rtxtImagemTabuleiro";
            this.rtxtImagemTabuleiro.Size = new System.Drawing.Size(426, 53);
            this.rtxtImagemTabuleiro.TabIndex = 34;
            this.rtxtImagemTabuleiro.Text = "";
            this.rtxtImagemTabuleiro.Leave += new System.EventHandler(this.rtxtImagemTabuleiro_Leave);
            // 
            // lblCor
            // 
            this.lblCor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(117, 242);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(97, 13);
            this.lblCor.TabIndex = 33;
            this.lblCor.Text = "                              ";
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColorDialog.Location = new System.Drawing.Point(114, 258);
            this.btnColorDialog.MaximumSize = new System.Drawing.Size(110, 23);
            this.btnColorDialog.MinimumSize = new System.Drawing.Size(110, 23);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(110, 23);
            this.btnColorDialog.TabIndex = 32;
            this.btnColorDialog.Text = "Seletor de cores";
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // picImagemTabuleiro
            // 
            this.picImagemTabuleiro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImagemTabuleiro.Location = new System.Drawing.Point(114, 117);
            this.picImagemTabuleiro.MinimumSize = new System.Drawing.Size(70, 70);
            this.picImagemTabuleiro.Name = "picImagemTabuleiro";
            this.picImagemTabuleiro.Size = new System.Drawing.Size(78, 70);
            this.picImagemTabuleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagemTabuleiro.TabIndex = 31;
            this.picImagemTabuleiro.TabStop = false;
            this.picImagemTabuleiro.Click += new System.EventHandler(this.picImagemTabuleiro_Click);
            // 
            // txtCorTematica
            // 
            this.txtCorTematica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCorTematica.Location = new System.Drawing.Point(114, 219);
            this.txtCorTematica.MaxLength = 7;
            this.txtCorTematica.Name = "txtCorTematica";
            this.txtCorTematica.Size = new System.Drawing.Size(100, 20);
            this.txtCorTematica.TabIndex = 30;
            // 
            // lblCorTematica
            // 
            this.lblCorTematica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCorTematica.AutoSize = true;
            this.lblCorTematica.Location = new System.Drawing.Point(12, 222);
            this.lblCorTematica.Name = "lblCorTematica";
            this.lblCorTematica.Size = new System.Drawing.Size(69, 13);
            this.lblCorTematica.TabIndex = 29;
            this.lblCorTematica.Text = "Cor temática:";
            // 
            // lblImagemTabuleiro
            // 
            this.lblImagemTabuleiro.AutoSize = true;
            this.lblImagemTabuleiro.Location = new System.Drawing.Point(12, 61);
            this.lblImagemTabuleiro.Name = "lblImagemTabuleiro";
            this.lblImagemTabuleiro.Size = new System.Drawing.Size(94, 13);
            this.lblImagemTabuleiro.TabIndex = 28;
            this.lblImagemTabuleiro.Text = "Imagem Tabuleiro:";
            // 
            // txtNomeTabuleiro
            // 
            this.txtNomeTabuleiro.Location = new System.Drawing.Point(114, 32);
            this.txtNomeTabuleiro.Name = "txtNomeTabuleiro";
            this.txtNomeTabuleiro.Size = new System.Drawing.Size(183, 20);
            this.txtNomeTabuleiro.TabIndex = 27;
            // 
            // lblNomeTabuleiro
            // 
            this.lblNomeTabuleiro.AutoSize = true;
            this.lblNomeTabuleiro.Location = new System.Drawing.Point(12, 35);
            this.lblNomeTabuleiro.Name = "lblNomeTabuleiro";
            this.lblNomeTabuleiro.Size = new System.Drawing.Size(100, 13);
            this.lblNomeTabuleiro.TabIndex = 26;
            this.lblNomeTabuleiro.Text = "Nome do Tabuleiro:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(114, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 25;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "ID:";
            // 
            // txtDtCriacao
            // 
            this.txtDtCriacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDtCriacao.Enabled = false;
            this.txtDtCriacao.Location = new System.Drawing.Point(114, 193);
            this.txtDtCriacao.Name = "txtDtCriacao";
            this.txtDtCriacao.Size = new System.Drawing.Size(100, 20);
            this.txtDtCriacao.TabIndex = 36;
            // 
            // lblDtCriacao
            // 
            this.lblDtCriacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDtCriacao.AutoSize = true;
            this.lblDtCriacao.Location = new System.Drawing.Point(12, 196);
            this.lblDtCriacao.Name = "lblDtCriacao";
            this.lblDtCriacao.Size = new System.Drawing.Size(86, 13);
            this.lblDtCriacao.TabIndex = 35;
            this.lblDtCriacao.Text = "Data de criação:";
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Location = new System.Drawing.Point(381, 294);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 39;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(462, 294);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 38;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(543, 294);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.Location = new System.Drawing.Point(546, 88);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 40;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // TabuleiroDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 329);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDtCriacao);
            this.Controls.Add(this.lblDtCriacao);
            this.Controls.Add(this.rtxtImagemTabuleiro);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.btnColorDialog);
            this.Controls.Add(this.picImagemTabuleiro);
            this.Controls.Add(this.txtCorTematica);
            this.Controls.Add(this.lblCorTematica);
            this.Controls.Add(this.lblImagemTabuleiro);
            this.Controls.Add(this.txtNomeTabuleiro);
            this.Controls.Add(this.lblNomeTabuleiro);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.MinimumSize = new System.Drawing.Size(638, 368);
            this.Name = "TabuleiroDetalhes";
            this.Text = "TabuleiroDetalhes";
            this.Load += new System.EventHandler(this.TabuleiroDetalhes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagemTabuleiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtImagemTabuleiro;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.PictureBox picImagemTabuleiro;
        private System.Windows.Forms.TextBox txtCorTematica;
        private System.Windows.Forms.Label lblCorTematica;
        private System.Windows.Forms.Label lblImagemTabuleiro;
        private System.Windows.Forms.TextBox txtNomeTabuleiro;
        private System.Windows.Forms.Label lblNomeTabuleiro;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtDtCriacao;
        private System.Windows.Forms.Label lblDtCriacao;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnUpload;
    }
}