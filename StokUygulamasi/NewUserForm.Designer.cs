namespace StokUygulamasi
{
    partial class NewUserForm
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stockApplicationDataSet5 = new StokUygulamasi.StockApplicationDataSet5();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockApplicationDataSet4 = new StokUygulamasi.StockApplicationDataSet4();
            this.userTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableTableAdapter = new StokUygulamasi.StockApplicationDataSet4TableAdapters.UserTableTableAdapter();
            this.userTableTableAdapter1 = new StokUygulamasi.StockApplicationDataSet5TableAdapters.UserTableTableAdapter();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelDeleteUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxDeleteUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDeletePassword = new System.Windows.Forms.Label();
            this.labelNewUsername = new System.Windows.Forms.Label();
            this.textBoxDeletePassword = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelDeleteUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxUpdatedPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxUpdatedRole = new System.Windows.Forms.ComboBox();
            this.textBoxUpdatedUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxUpdatedGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockApplicationDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockApplicationDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userTableBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1351, 276);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn1.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn4.HeaderText = "Role";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsAdmin";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsAdmin";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // userTableBindingSource2
            // 
            this.userTableBindingSource2.DataMember = "UserTable";
            this.userTableBindingSource2.DataSource = this.stockApplicationDataSet5;
            // 
            // stockApplicationDataSet5
            // 
            this.stockApplicationDataSet5.DataSetName = "StockApplicationDataSet5";
            this.stockApplicationDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "UserTable";
            // 
            // stockApplicationDataSet4
            // 
            this.stockApplicationDataSet4.DataSetName = "StockApplicationDataSet4";
            this.stockApplicationDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableBindingSource1
            // 
            this.userTableBindingSource1.DataMember = "UserTable";
            this.userTableBindingSource1.DataSource = this.stockApplicationDataSet4;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // userTableTableAdapter1
            // 
            this.userTableTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(188, 196);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(100, 36);
            this.buttonSignUp.TabIndex = 4;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(188, 92);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelRole.Location = new System.Drawing.Point(124, 128);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(59, 22);
            this.labelRole.TabIndex = 15;
            this.labelRole.Text = "Role :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelPassword.Location = new System.Drawing.Point(84, 92);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(99, 22);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password :";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBoxRole.Location = new System.Drawing.Point(188, 128);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(100, 24);
            this.comboBoxRole.TabIndex = 17;
            // 
            // labelDeleteUsername
            // 
            this.labelDeleteUsername.AutoSize = true;
            this.labelDeleteUsername.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelDeleteUsername.Location = new System.Drawing.Point(344, 52);
            this.labelDeleteUsername.Name = "labelDeleteUsername";
            this.labelDeleteUsername.Size = new System.Drawing.Size(99, 22);
            this.labelDeleteUsername.TabIndex = 7;
            this.labelDeleteUsername.Text = "Username :";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(188, 52);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 22);
            this.textBoxUsername.TabIndex = 1;
            // 
            // textBoxDeleteUsername
            // 
            this.textBoxDeleteUsername.Location = new System.Drawing.Point(442, 52);
            this.textBoxDeleteUsername.Name = "textBoxDeleteUsername";
            this.textBoxDeleteUsername.Size = new System.Drawing.Size(100, 22);
            this.textBoxDeleteUsername.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(104, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Gender :";
            // 
            // labelDeletePassword
            // 
            this.labelDeletePassword.AutoSize = true;
            this.labelDeletePassword.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelDeletePassword.Location = new System.Drawing.Point(344, 92);
            this.labelDeletePassword.Name = "labelDeletePassword";
            this.labelDeletePassword.Size = new System.Drawing.Size(99, 22);
            this.labelDeletePassword.TabIndex = 9;
            this.labelDeletePassword.Text = "Password :";
            // 
            // labelNewUsername
            // 
            this.labelNewUsername.AutoSize = true;
            this.labelNewUsername.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelNewUsername.Location = new System.Drawing.Point(84, 52);
            this.labelNewUsername.Name = "labelNewUsername";
            this.labelNewUsername.Size = new System.Drawing.Size(99, 22);
            this.labelNewUsername.TabIndex = 0;
            this.labelNewUsername.Text = "Username :";
            this.labelNewUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDeletePassword
            // 
            this.textBoxDeletePassword.Location = new System.Drawing.Point(442, 92);
            this.textBoxDeletePassword.Name = "textBoxDeletePassword";
            this.textBoxDeletePassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxDeletePassword.TabIndex = 10;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(188, 163);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(100, 24);
            this.comboBoxGender.TabIndex = 19;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(442, 136);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 36);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelDeleteUser
            // 
            this.labelDeleteUser.AutoSize = true;
            this.labelDeleteUser.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelDeleteUser.Location = new System.Drawing.Point(368, 15);
            this.labelDeleteUser.Name = "labelDeleteUser";
            this.labelDeleteUser.Size = new System.Drawing.Size(205, 22);
            this.labelDeleteUser.TabIndex = 12;
            this.labelDeleteUser.Text = "Delete User Registration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(136, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "New User Regisitration";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(701, 196);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 36);
            this.buttonUpdate.TabIndex = 24;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxUpdatedPassword
            // 
            this.textBoxUpdatedPassword.Location = new System.Drawing.Point(701, 92);
            this.textBoxUpdatedPassword.Name = "textBoxUpdatedPassword";
            this.textBoxUpdatedPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpdatedPassword.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.Location = new System.Drawing.Point(641, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "Role :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.Location = new System.Drawing.Point(601, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Password :";
            // 
            // comboBoxUpdatedRole
            // 
            this.comboBoxUpdatedRole.FormattingEnabled = true;
            this.comboBoxUpdatedRole.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBoxUpdatedRole.Location = new System.Drawing.Point(701, 128);
            this.comboBoxUpdatedRole.Name = "comboBoxUpdatedRole";
            this.comboBoxUpdatedRole.Size = new System.Drawing.Size(100, 24);
            this.comboBoxUpdatedRole.TabIndex = 27;
            // 
            // textBoxUpdatedUsername
            // 
            this.textBoxUpdatedUsername.Location = new System.Drawing.Point(701, 52);
            this.textBoxUpdatedUsername.Name = "textBoxUpdatedUsername";
            this.textBoxUpdatedUsername.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpdatedUsername.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label5.Location = new System.Drawing.Point(621, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(601, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Username :";
            // 
            // comboBoxUpdatedGender
            // 
            this.comboBoxUpdatedGender.FormattingEnabled = true;
            this.comboBoxUpdatedGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxUpdatedGender.Location = new System.Drawing.Point(701, 163);
            this.comboBoxUpdatedGender.Name = "comboBoxUpdatedGender";
            this.comboBoxUpdatedGender.Size = new System.Drawing.Size(100, 24);
            this.comboBoxUpdatedGender.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(626, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Update User Regisitration";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxUpdatedGender);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxUpdatedUsername);
            this.groupBox1.Controls.Add(this.comboBoxUpdatedRole);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxUpdatedPassword);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelDeleteUser);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.comboBoxGender);
            this.groupBox1.Controls.Add(this.textBoxDeletePassword);
            this.groupBox1.Controls.Add(this.labelNewUsername);
            this.groupBox1.Controls.Add(this.labelDeletePassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxDeleteUsername);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.labelDeleteUsername);
            this.groupBox1.Controls.Add(this.comboBoxRole);
            this.groupBox1.Controls.Add(this.labelPassword);
            this.groupBox1.Controls.Add(this.labelRole);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.buttonSignUp);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1351, 236);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1375, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NewUserForm";
            this.Text = "New User";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockApplicationDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockApplicationDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
       // private StockApplicationDataSet stockApplicationDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
       // private StockApplicationDataSetTableAdapters.UserTableTableAdapter userTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısAdminDataGridViewCheckBoxColumn;
        private StockApplicationDataSet4 stockApplicationDataSet4;
        private System.Windows.Forms.BindingSource userTableBindingSource1;
        private StockApplicationDataSet4TableAdapters.UserTableTableAdapter userTableTableAdapter;
        private StockApplicationDataSet5 stockApplicationDataSet5;
        private System.Windows.Forms.BindingSource userTableBindingSource2;
        private StockApplicationDataSet5TableAdapters.UserTableTableAdapter userTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label labelDeleteUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxDeleteUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDeletePassword;
        private System.Windows.Forms.Label labelNewUsername;
        private System.Windows.Forms.TextBox textBoxDeletePassword;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelDeleteUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxUpdatedPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxUpdatedRole;
        private System.Windows.Forms.TextBox textBoxUpdatedUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxUpdatedGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}