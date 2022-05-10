
namespace JdoCRUD.Forms
{
    partial class VendaLista
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
            this.vendaDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSeasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSkinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jdoDataSet = new JdoCRUD.jdoDataSet();
            this.vendaTableAdapter = new JdoCRUD.jdoDataSetTableAdapters.vendaTableAdapter();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vendaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vendaDataGridView
            // 
            this.vendaDataGridView.AllowUserToAddRows = false;
            this.vendaDataGridView.AllowUserToDeleteRows = false;
            this.vendaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vendaDataGridView.AutoGenerateColumns = false;
            this.vendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.idSeasonDataGridViewTextBoxColumn,
            this.idSkinDataGridViewTextBoxColumn});
            this.vendaDataGridView.DataSource = this.vendaBindingSource;
            this.vendaDataGridView.Location = new System.Drawing.Point(13, 13);
            this.vendaDataGridView.Name = "vendaDataGridView";
            this.vendaDataGridView.ReadOnly = true;
            this.vendaDataGridView.Size = new System.Drawing.Size(446, 336);
            this.vendaDataGridView.TabIndex = 0;
            this.vendaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendaDataGridView_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSeasonDataGridViewTextBoxColumn
            // 
            this.idSeasonDataGridViewTextBoxColumn.DataPropertyName = "idSeason";
            this.idSeasonDataGridViewTextBoxColumn.HeaderText = "idSeason";
            this.idSeasonDataGridViewTextBoxColumn.Name = "idSeasonDataGridViewTextBoxColumn";
            this.idSeasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSkinDataGridViewTextBoxColumn
            // 
            this.idSkinDataGridViewTextBoxColumn.DataPropertyName = "idSkin";
            this.idSkinDataGridViewTextBoxColumn.HeaderText = "idSkin";
            this.idSkinDataGridViewTextBoxColumn.Name = "idSkinDataGridViewTextBoxColumn";
            this.idSkinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.jdoDataSet;
            // 
            // jdoDataSet
            // 
            this.jdoDataSet.DataSetName = "jdoDataSet";
            this.jdoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalhes.Location = new System.Drawing.Point(12, 355);
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
            this.btnNovo.Location = new System.Drawing.Point(93, 355);
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
            this.btnAtualizar.Location = new System.Drawing.Point(384, 355);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // VendaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 390);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.vendaDataGridView);
            this.Name = "VendaLista";
            this.Text = "VendaLista";
            this.Load += new System.EventHandler(this.VendaLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vendaDataGridView;
        private jdoDataSet jdoDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private jdoDataSetTableAdapters.vendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSeasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAtualizar;
    }
}