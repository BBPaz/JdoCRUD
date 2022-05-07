
namespace JdoCRUD.Forms
{
    partial class test
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jdoDataSet = new JdoCRUD.jdoDataSet();
            this.jdoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabuleiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabuleiroTableAdapter = new JdoCRUD.jdoDataSetTableAdapters.tabuleiroTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagemTabuleiroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corTematicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabuleiroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imagemTabuleiroDataGridViewTextBoxColumn,
            this.dtCriacaoDataGridViewTextBoxColumn,
            this.corTematicaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabuleiroBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // jdoDataSet
            // 
            this.jdoDataSet.DataSetName = "jdoDataSet";
            this.jdoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jdoDataSetBindingSource
            // 
            this.jdoDataSetBindingSource.DataSource = this.jdoDataSet;
            this.jdoDataSetBindingSource.Position = 0;
            // 
            // tabuleiroBindingSource
            // 
            this.tabuleiroBindingSource.DataMember = "tabuleiro";
            this.tabuleiroBindingSource.DataSource = this.jdoDataSetBindingSource;
            // 
            // tabuleiroTableAdapter
            // 
            this.tabuleiroTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // imagemTabuleiroDataGridViewTextBoxColumn
            // 
            this.imagemTabuleiroDataGridViewTextBoxColumn.DataPropertyName = "imagemTabuleiro";
            this.imagemTabuleiroDataGridViewTextBoxColumn.HeaderText = "imagemTabuleiro";
            this.imagemTabuleiroDataGridViewTextBoxColumn.Name = "imagemTabuleiroDataGridViewTextBoxColumn";
            // 
            // dtCriacaoDataGridViewTextBoxColumn
            // 
            this.dtCriacaoDataGridViewTextBoxColumn.DataPropertyName = "dtCriacao";
            this.dtCriacaoDataGridViewTextBoxColumn.HeaderText = "dtCriacao";
            this.dtCriacaoDataGridViewTextBoxColumn.Name = "dtCriacaoDataGridViewTextBoxColumn";
            // 
            // corTematicaDataGridViewTextBoxColumn
            // 
            this.corTematicaDataGridViewTextBoxColumn.DataPropertyName = "corTematica";
            this.corTematicaDataGridViewTextBoxColumn.HeaderText = "corTematica";
            this.corTematicaDataGridViewTextBoxColumn.Name = "corTematicaDataGridViewTextBoxColumn";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabuleiroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource jdoDataSetBindingSource;
        private jdoDataSet jdoDataSet;
        private System.Windows.Forms.BindingSource tabuleiroBindingSource;
        private jdoDataSetTableAdapters.tabuleiroTableAdapter tabuleiroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagemTabuleiroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corTematicaDataGridViewTextBoxColumn;
    }
}