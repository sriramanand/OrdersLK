﻿namespace OrdersLK
{
    partial class InventoryANDSupplierHome
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
            this.supplierbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.inventorybtn = new System.Windows.Forms.Button();
            this.purchasedproductbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplierbtn
            // 
            this.supplierbtn.Location = new System.Drawing.Point(117, 215);
            this.supplierbtn.Name = "supplierbtn";
            this.supplierbtn.Size = new System.Drawing.Size(167, 23);
            this.supplierbtn.TabIndex = 0;
            this.supplierbtn.Text = "Supplier Details";
            this.supplierbtn.UseVisualStyleBackColor = true;
            this.supplierbtn.Click += new System.EventHandler(this.supplierbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(1167, 22);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 1;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // inventorybtn
            // 
            this.inventorybtn.Location = new System.Drawing.Point(357, 220);
            this.inventorybtn.Name = "inventorybtn";
            this.inventorybtn.Size = new System.Drawing.Size(75, 23);
            this.inventorybtn.TabIndex = 2;
            this.inventorybtn.Text = "Invetory Details";
            this.inventorybtn.UseVisualStyleBackColor = true;
            this.inventorybtn.Click += new System.EventHandler(this.inventorybtn_Click);
            // 
            // purchasedproductbtn
            // 
            this.purchasedproductbtn.Location = new System.Drawing.Point(542, 235);
            this.purchasedproductbtn.Name = "purchasedproductbtn";
            this.purchasedproductbtn.Size = new System.Drawing.Size(120, 23);
            this.purchasedproductbtn.TabIndex = 3;
            this.purchasedproductbtn.Text = "Purchased Products";
            this.purchasedproductbtn.UseVisualStyleBackColor = true;
            this.purchasedproductbtn.Click += new System.EventHandler(this.purchasedproductbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 69);
            this.panel1.TabIndex = 4;
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
            // InventoryANDSupplierHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.purchasedproductbtn);
            this.Controls.Add(this.inventorybtn);
            this.Controls.Add(this.supplierbtn);
            this.Name = "InventoryANDSupplierHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryANDSupplierHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button supplierbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button inventorybtn;
        private System.Windows.Forms.Button purchasedproductbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}