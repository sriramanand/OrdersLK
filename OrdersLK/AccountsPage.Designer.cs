namespace OrdersLK
{
    partial class AccountsPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backbtn = new System.Windows.Forms.Button();
            this.pettycashdetails = new System.Windows.Forms.Button();
            this.statementbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders.lk";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 69);
            this.panel1.TabIndex = 3;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(1167, 23);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 0;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // pettycashdetails
            // 
            this.pettycashdetails.Location = new System.Drawing.Point(394, 202);
            this.pettycashdetails.Name = "pettycashdetails";
            this.pettycashdetails.Size = new System.Drawing.Size(75, 23);
            this.pettycashdetails.TabIndex = 2;
            this.pettycashdetails.Text = "Petty Cash";
            this.pettycashdetails.UseVisualStyleBackColor = true;
            this.pettycashdetails.Click += new System.EventHandler(this.pettycashdetails_Click);
            // 
            // statementbtn
            // 
            this.statementbtn.Location = new System.Drawing.Point(394, 289);
            this.statementbtn.Name = "statementbtn";
            this.statementbtn.Size = new System.Drawing.Size(75, 23);
            this.statementbtn.TabIndex = 4;
            this.statementbtn.Text = "Statement";
            this.statementbtn.UseVisualStyleBackColor = true;
            this.statementbtn.Click += new System.EventHandler(this.statementbtn_Click);
            // 
            // AccountsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.statementbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pettycashdetails);
            this.Name = "AccountsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountsPage";
            this.Load += new System.EventHandler(this.AccountsPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button pettycashdetails;
        private System.Windows.Forms.Button statementbtn;
    }
}