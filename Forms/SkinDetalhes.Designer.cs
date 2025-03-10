﻿
namespace JdoCRUD.Forms
{
    partial class SkinDetalhes
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNomeSkin = new System.Windows.Forms.TextBox();
            this.lblNomeSkin = new System.Windows.Forms.Label();
            this.lblImagemSkin = new System.Windows.Forms.Label();
            this.txtTipoPeca = new System.Windows.Forms.TextBox();
            this.lblTipoPeca = new System.Windows.Forms.Label();
            this.txtCorTematica = new System.Windows.Forms.TextBox();
            this.lblCorTematica = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.picImagemSkin = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbTipoO = new System.Windows.Forms.RadioButton();
            this.rdbTipoC = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.rtxtImagemSkin = new System.Windows.Forms.RichTextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemSkin)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(114, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtNomeSkin
            // 
            this.txtNomeSkin.Location = new System.Drawing.Point(114, 32);
            this.txtNomeSkin.Name = "txtNomeSkin";
            this.txtNomeSkin.Size = new System.Drawing.Size(183, 20);
            this.txtNomeSkin.TabIndex = 3;
            // 
            // lblNomeSkin
            // 
            this.lblNomeSkin.AutoSize = true;
            this.lblNomeSkin.Location = new System.Drawing.Point(12, 35);
            this.lblNomeSkin.Name = "lblNomeSkin";
            this.lblNomeSkin.Size = new System.Drawing.Size(77, 13);
            this.lblNomeSkin.TabIndex = 2;
            this.lblNomeSkin.Text = "Nome da Skin:";
            // 
            // lblImagemSkin
            // 
            this.lblImagemSkin.AutoSize = true;
            this.lblImagemSkin.Location = new System.Drawing.Point(12, 61);
            this.lblImagemSkin.Name = "lblImagemSkin";
            this.lblImagemSkin.Size = new System.Drawing.Size(71, 13);
            this.lblImagemSkin.TabIndex = 4;
            this.lblImagemSkin.Text = "Imagem Skin:";
            // 
            // txtTipoPeca
            // 
            this.txtTipoPeca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTipoPeca.Location = new System.Drawing.Point(260, 195);
            this.txtTipoPeca.Name = "txtTipoPeca";
            this.txtTipoPeca.Size = new System.Drawing.Size(100, 20);
            this.txtTipoPeca.TabIndex = 9;
            this.txtTipoPeca.Visible = false;
            // 
            // lblTipoPeca
            // 
            this.lblTipoPeca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTipoPeca.AutoSize = true;
            this.lblTipoPeca.Location = new System.Drawing.Point(12, 196);
            this.lblTipoPeca.Name = "lblTipoPeca";
            this.lblTipoPeca.Size = new System.Drawing.Size(71, 13);
            this.lblTipoPeca.TabIndex = 8;
            this.lblTipoPeca.Text = "Tipo da Peça";
            // 
            // txtCorTematica
            // 
            this.txtCorTematica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCorTematica.Location = new System.Drawing.Point(114, 219);
            this.txtCorTematica.MaxLength = 7;
            this.txtCorTematica.Name = "txtCorTematica";
            this.txtCorTematica.Size = new System.Drawing.Size(100, 20);
            this.txtCorTematica.TabIndex = 11;
            this.txtCorTematica.TextChanged += new System.EventHandler(this.txtCorTematica_TextChanged);
            // 
            // lblCorTematica
            // 
            this.lblCorTematica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCorTematica.AutoSize = true;
            this.lblCorTematica.Location = new System.Drawing.Point(12, 222);
            this.lblCorTematica.Name = "lblCorTematica";
            this.lblCorTematica.Size = new System.Drawing.Size(69, 13);
            this.lblCorTematica.TabIndex = 10;
            this.lblCorTematica.Text = "Cor temática:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(560, 296);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(479, 296);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Location = new System.Drawing.Point(398, 296);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 14;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // picImagemSkin
            // 
            this.picImagemSkin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImagemSkin.Location = new System.Drawing.Point(114, 117);
            this.picImagemSkin.MinimumSize = new System.Drawing.Size(70, 70);
            this.picImagemSkin.Name = "picImagemSkin";
            this.picImagemSkin.Size = new System.Drawing.Size(70, 70);
            this.picImagemSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagemSkin.TabIndex = 15;
            this.picImagemSkin.TabStop = false;
            this.picImagemSkin.Click += new System.EventHandler(this.picImagemSkin_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.rdbTipoO);
            this.panel2.Controls.Add(this.rdbTipoC);
            this.panel2.Location = new System.Drawing.Point(114, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 20);
            this.panel2.TabIndex = 20;
            // 
            // rdbTipoO
            // 
            this.rdbTipoO.AutoSize = true;
            this.rdbTipoO.Checked = true;
            this.rdbTipoO.Location = new System.Drawing.Point(3, 3);
            this.rdbTipoO.Name = "rdbTipoO";
            this.rdbTipoO.Size = new System.Drawing.Size(51, 17);
            this.rdbTipoO.TabIndex = 17;
            this.rdbTipoO.TabStop = true;
            this.rdbTipoO.Text = "Onça";
            this.rdbTipoO.UseVisualStyleBackColor = true;
            // 
            // rdbTipoC
            // 
            this.rdbTipoC.AutoSize = true;
            this.rdbTipoC.Location = new System.Drawing.Point(60, 3);
            this.rdbTipoC.Name = "rdbTipoC";
            this.rdbTipoC.Size = new System.Drawing.Size(68, 17);
            this.rdbTipoC.TabIndex = 18;
            this.rdbTipoC.TabStop = true;
            this.rdbTipoC.Text = "Cachorro";
            this.rdbTipoC.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColorDialog.Location = new System.Drawing.Point(114, 258);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(110, 23);
            this.btnColorDialog.TabIndex = 21;
            this.btnColorDialog.Text = "Seletor de cores";
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // rtxtImagemSkin
            // 
            this.rtxtImagemSkin.Location = new System.Drawing.Point(114, 58);
            this.rtxtImagemSkin.Name = "rtxtImagemSkin";
            this.rtxtImagemSkin.Size = new System.Drawing.Size(442, 53);
            this.rtxtImagemSkin.TabIndex = 23;
            this.rtxtImagemSkin.Text = "";
            this.rtxtImagemSkin.Leave += new System.EventHandler(this.rtxtImagemSkin_Leave);
            // 
            // lblCor
            // 
            this.lblCor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(117, 242);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(97, 13);
            this.lblCor.TabIndex = 34;
            this.lblCor.Text = "                              ";
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.Location = new System.Drawing.Point(560, 88);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 35;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // SkinDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 331);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.rtxtImagemSkin);
            this.Controls.Add(this.btnColorDialog);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picImagemSkin);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCorTematica);
            this.Controls.Add(this.lblCorTematica);
            this.Controls.Add(this.txtTipoPeca);
            this.Controls.Add(this.lblTipoPeca);
            this.Controls.Add(this.lblImagemSkin);
            this.Controls.Add(this.txtNomeSkin);
            this.Controls.Add(this.lblNomeSkin);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.MinimumSize = new System.Drawing.Size(584, 370);
            this.Name = "SkinDetalhes";
            this.Text = "SkinDetalhes";
            this.Load += new System.EventHandler(this.SkinDetalhes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagemSkin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNomeSkin;
        private System.Windows.Forms.Label lblNomeSkin;
        private System.Windows.Forms.Label lblImagemSkin;
        private System.Windows.Forms.TextBox txtTipoPeca;
        private System.Windows.Forms.Label lblTipoPeca;
        private System.Windows.Forms.TextBox txtCorTematica;
        private System.Windows.Forms.Label lblCorTematica;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.PictureBox picImagemSkin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbTipoO;
        private System.Windows.Forms.RadioButton rdbTipoC;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.RichTextBox rtxtImagemSkin;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Button btnUpload;
    }
}