
namespace JdoCRUD.Forms
{
    partial class SeasonLista
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
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.seasonDataGridView = new System.Windows.Forms.DataGridView();
            this.jdoDataSet = new JdoCRUD.jdoDataSet();
            this.seasonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seasonTableAdapter = new JdoCRUD.jdoDataSetTableAdapters.seasonTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeSeasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicioVigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fimVigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTabuleiroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.seasonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalhes.Location = new System.Drawing.Point(12, 391);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhes.TabIndex = 8;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.Location = new System.Drawing.Point(93, 391);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.Location = new System.Drawing.Point(585, 391);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // seasonDataGridView
            // 
            this.seasonDataGridView.AllowUserToAddRows = false;
            this.seasonDataGridView.AllowUserToDeleteRows = false;
            this.seasonDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seasonDataGridView.AutoGenerateColumns = false;
            this.seasonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seasonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeSeasonDataGridViewTextBoxColumn,
            this.inicioVigenciaDataGridViewTextBoxColumn,
            this.fimVigenciaDataGridViewTextBoxColumn,
            this.idTabuleiroDataGridViewTextBoxColumn,
            this.prioridadeDataGridViewTextBoxColumn});
            this.seasonDataGridView.DataSource = this.seasonBindingSource;
            this.seasonDataGridView.Location = new System.Drawing.Point(13, 13);
            this.seasonDataGridView.Name = "seasonDataGridView";
            this.seasonDataGridView.ReadOnly = true;
            this.seasonDataGridView.Size = new System.Drawing.Size(647, 372);
            this.seasonDataGridView.TabIndex = 10;
            this.seasonDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seasonDataGridView_CellDoubleClick);
            // 
            // jdoDataSet
            // 
            this.jdoDataSet.DataSetName = "jdoDataSet";
            this.jdoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seasonBindingSource
            // 
            this.seasonBindingSource.DataMember = "season";
            this.seasonBindingSource.DataSource = this.jdoDataSet;
            // 
            // seasonTableAdapter
            // 
            this.seasonTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeSeasonDataGridViewTextBoxColumn
            // 
            this.nomeSeasonDataGridViewTextBoxColumn.DataPropertyName = "nomeSeason";
            this.nomeSeasonDataGridViewTextBoxColumn.HeaderText = "nomeSeason";
            this.nomeSeasonDataGridViewTextBoxColumn.Name = "nomeSeasonDataGridViewTextBoxColumn";
            this.nomeSeasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inicioVigenciaDataGridViewTextBoxColumn
            // 
            this.inicioVigenciaDataGridViewTextBoxColumn.DataPropertyName = "inicioVigencia";
            this.inicioVigenciaDataGridViewTextBoxColumn.HeaderText = "inicioVigencia";
            this.inicioVigenciaDataGridViewTextBoxColumn.Name = "inicioVigenciaDataGridViewTextBoxColumn";
            this.inicioVigenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fimVigenciaDataGridViewTextBoxColumn
            // 
            this.fimVigenciaDataGridViewTextBoxColumn.DataPropertyName = "fimVigencia";
            this.fimVigenciaDataGridViewTextBoxColumn.HeaderText = "fimVigencia";
            this.fimVigenciaDataGridViewTextBoxColumn.Name = "fimVigenciaDataGridViewTextBoxColumn";
            this.fimVigenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTabuleiroDataGridViewTextBoxColumn
            // 
            this.idTabuleiroDataGridViewTextBoxColumn.DataPropertyName = "idTabuleiro";
            this.idTabuleiroDataGridViewTextBoxColumn.HeaderText = "idTabuleiro";
            this.idTabuleiroDataGridViewTextBoxColumn.Name = "idTabuleiroDataGridViewTextBoxColumn";
            this.idTabuleiroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prioridadeDataGridViewTextBoxColumn
            // 
            this.prioridadeDataGridViewTextBoxColumn.DataPropertyName = "prioridade";
            this.prioridadeDataGridViewTextBoxColumn.HeaderText = "prioridade";
            this.prioridadeDataGridViewTextBoxColumn.Name = "prioridadeDataGridViewTextBoxColumn";
            this.prioridadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SeasonLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 426);
            this.Controls.Add(this.seasonDataGridView);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.btnNovo);
            this.Name = "SeasonLista";
            this.Text = "SeasonLista";
            this.Load += new System.EventHandler(this.SeasonLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seasonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView seasonDataGridView;
        private jdoDataSet jdoDataSet;
        private System.Windows.Forms.BindingSource seasonBindingSource;
        private jdoDataSetTableAdapters.seasonTableAdapter seasonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeSeasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioVigenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fimVigenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTabuleiroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn;
    }
}