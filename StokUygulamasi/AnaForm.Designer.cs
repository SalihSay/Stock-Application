namespace StokUygulamasi
{
    partial class AnaForm
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
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.buttonPCB = new System.Windows.Forms.Button();
            this.buttonProduction = new System.Windows.Forms.Button();
            this.buttonStockChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.Location = new System.Drawing.Point(221, 153);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(155, 48);
            this.buttonNewUser.TabIndex = 0;
            this.buttonNewUser.Text = "New User Registiration";
            this.buttonNewUser.UseVisualStyleBackColor = true;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonProduction_Click);
            // 
            // buttonPCB
            // 
            this.buttonPCB.Location = new System.Drawing.Point(221, 83);
            this.buttonPCB.Name = "buttonPCB";
            this.buttonPCB.Size = new System.Drawing.Size(155, 48);
            this.buttonPCB.TabIndex = 1;
            this.buttonPCB.Text = "PCB Stock";
            this.buttonPCB.UseVisualStyleBackColor = true;
            this.buttonPCB.Click += new System.EventHandler(this.buttonPCB_Click);
            // 
            // buttonProduction
            // 
            this.buttonProduction.Location = new System.Drawing.Point(221, 221);
            this.buttonProduction.Name = "buttonProduction";
            this.buttonProduction.Size = new System.Drawing.Size(155, 48);
            this.buttonProduction.TabIndex = 2;
            this.buttonProduction.Text = "Production Stock";
            this.buttonProduction.UseVisualStyleBackColor = true;
            this.buttonProduction.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // buttonStockChanges
            // 
            this.buttonStockChanges.Location = new System.Drawing.Point(221, 296);
            this.buttonStockChanges.Name = "buttonStockChanges";
            this.buttonStockChanges.Size = new System.Drawing.Size(155, 48);
            this.buttonStockChanges.TabIndex = 3;
            this.buttonStockChanges.Text = "Stock Changes and Descriptions";
            this.buttonStockChanges.UseVisualStyleBackColor = true;
            this.buttonStockChanges.Click += new System.EventHandler(this.buttonStockChanges_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.buttonStockChanges);
            this.Controls.Add(this.buttonProduction);
            this.Controls.Add(this.buttonPCB);
            this.Controls.Add(this.buttonNewUser);
            this.Name = "AnaForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.Button buttonPCB;
        private System.Windows.Forms.Button buttonProduction;
        private System.Windows.Forms.Button buttonStockChanges;
    }
}