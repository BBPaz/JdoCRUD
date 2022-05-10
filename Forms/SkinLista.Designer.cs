
namespace JdoCRUD.Forms
{
    partial class SkinLista
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
            this.skinDataGridView = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.imgExibicao = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeSkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagemSkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corTematica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jdoDataSet = new JdoCRUD.jdoDataSet();
            this.skinTableAdapter = new JdoCRUD.jdoDataSetTableAdapters.skinTableAdapter();
            this.tableAdapterManager = new JdoCRUD.jdoDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // skinDataGridView
            // 
            this.skinDataGridView.AllowUserToAddRows = false;
            this.skinDataGridView.AllowUserToDeleteRows = false;
            this.skinDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinDataGridView.AutoGenerateColumns = false;
            this.skinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nomeSkin,
            this.imgExibicao,
            this.Cor,
            this.Tipo,
            this.imagemSkin,
            this.tipoPeca,
            this.corTematica});
            this.skinDataGridView.DataSource = this.skinBindingSource;
            this.skinDataGridView.Location = new System.Drawing.Point(12, 12);
            this.skinDataGridView.Name = "skinDataGridView";
            this.skinDataGridView.ReadOnly = true;
            this.skinDataGridView.RowTemplate.Height = 50;
            this.skinDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.skinDataGridView.Size = new System.Drawing.Size(547, 411);
            this.skinDataGridView.TabIndex = 1;
            this.skinDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skinDataGridView_CellContentClick);
            this.skinDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skinDataGridView_CellDoubleClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.Location = new System.Drawing.Point(93, 429);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalhes.Location = new System.Drawing.Point(12, 429);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhes.TabIndex = 3;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Location = new System.Drawing.Point(484, 429);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // imgExibicao
            // 
            this.imgExibicao.HeaderText = "Imagem";
            this.imgExibicao.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imgExibicao.Name = "imgExibicao";
            this.imgExibicao.ReadOnly = true;
            // 
            // Cor
            // 
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // nomeSkin
            // 
            this.nomeSkin.DataPropertyName = "nomeSkin";
            this.nomeSkin.HeaderText = "Nome";
            this.nomeSkin.Name = "nomeSkin";
            this.nomeSkin.ReadOnly = true;
            this.nomeSkin.Width = 150;
            // 
            // imagemSkin
            // 
            this.imagemSkin.DataPropertyName = "imagemSkin";
            this.imagemSkin.HeaderText = "imagemSkin";
            this.imagemSkin.Name = "imagemSkin";
            this.imagemSkin.ReadOnly = true;
            this.imagemSkin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imagemSkin.Visible = false;
            // 
            // tipoPeca
            // 
            this.tipoPeca.DataPropertyName = "tipoPeca";
            this.tipoPeca.HeaderText = "tipoPeca";
            this.tipoPeca.Name = "tipoPeca";
            this.tipoPeca.ReadOnly = true;
            this.tipoPeca.Visible = false;
            // 
            // corTematica
            // 
            this.corTematica.DataPropertyName = "corTematica";
            this.corTematica.HeaderText = "corTematica";
            this.corTematica.Name = "corTematica";
            this.corTematica.ReadOnly = true;
            this.corTematica.Visible = false;
            // 
            // skinBindingSource
            // 
            this.skinBindingSource.DataMember = "skin";
            this.skinBindingSource.DataSource = this.jdoDataSet;
            // 
            // jdoDataSet
            // 
            this.jdoDataSet.DataSetName = "jdoDataSet";
            this.jdoDataSet.Locale = new System.Globalization.CultureInfo("pt-BR");
            this.jdoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skinTableAdapter
            // 
            this.skinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.seasonTableAdapter = null;
            this.tableAdapterManager.skinTableAdapter = this.skinTableAdapter;
            this.tableAdapterManager.tabuleiroTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JdoCRUD.jdoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // SkinLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 464);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.skinDataGridView);
            this.Name = "SkinLista";
            this.Text = "SkinLista";
            this.Load += new System.EventHandler(this.SkinLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private jdoDataSet jdoDataSet;
        private System.Windows.Forms.BindingSource skinBindingSource;
        private jdoDataSetTableAdapters.skinTableAdapter skinTableAdapter;
        private jdoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView skinDataGridView;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeSkin;
        private System.Windows.Forms.DataGridViewImageColumn imgExibicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagemSkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn corTematica;
    }
}