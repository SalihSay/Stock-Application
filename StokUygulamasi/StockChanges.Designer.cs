namespace StokUygulamasi
{
    partial class StockChanges
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
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockChangesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockApplicationDataSet6 = new StokUygulamasi.StockApplicationDataSet6();
            this.stockChangesTableAdapter = new StokUygulamasi.StockApplicationDataSet6TableAdapters.StockChangesTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockChangesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockApplicationDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.changedByDataGridViewTextBoxColumn,
            this.changeDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockChangesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1311, 524);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // changedByDataGridViewTextBoxColumn
            // 
            this.changedByDataGridViewTextBoxColumn.DataPropertyName = "ChangedBy";
            this.changedByDataGridViewTextBoxColumn.HeaderText = "ChangedBy";
            this.changedByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.changedByDataGridViewTextBoxColumn.Name = "changedByDataGridViewTextBoxColumn";
            this.changedByDataGridViewTextBoxColumn.Width = 125;
            // 
            // changeDateDataGridViewTextBoxColumn
            // 
            this.changeDateDataGridViewTextBoxColumn.DataPropertyName = "ChangeDate";
            this.changeDateDataGridViewTextBoxColumn.HeaderText = "ChangeDate";
            this.changeDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.changeDateDataGridViewTextBoxColumn.Name = "changeDateDataGridViewTextBoxColumn";
            this.changeDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockChangesBindingSource
            // 
            this.stockChangesBindingSource.DataMember = "StockChanges";
            this.stockChangesBindingSource.DataSource = this.stockApplicationDataSet6;
            // 
            // stockApplicationDataSet6
            // 
            this.stockApplicationDataSet6.DataSetName = "StockApplicationDataSet6";
            this.stockApplicationDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockChangesTableAdapter
            // 
            this.stockChangesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Product :";
            // 
            // StockChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1314, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StockChanges";
            this.Text = "Stock Changes";
            this.Load += new System.EventHandler(this.StockChanges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockChangesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockApplicationDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StockApplicationDataSet6 stockApplicationDataSet6;
        private System.Windows.Forms.BindingSource stockChangesBindingSource;
        private StockApplicationDataSet6TableAdapters.StockChangesTableAdapter stockChangesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}