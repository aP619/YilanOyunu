﻿namespace YilanOyunu
{
    partial class SkorlarForm
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
            this.lvwSkorlar = new MetroFramework.Controls.MetroListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zaman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvwSkorlar
            // 
            this.lvwSkorlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.Zaman});
            this.lvwSkorlar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvwSkorlar.FullRowSelect = true;
            this.lvwSkorlar.Location = new System.Drawing.Point(23, 63);
            this.lvwSkorlar.Name = "lvwSkorlar";
            this.lvwSkorlar.OwnerDraw = true;
            this.lvwSkorlar.Size = new System.Drawing.Size(496, 280);
            this.lvwSkorlar.TabIndex = 0;
            this.lvwSkorlar.UseCompatibleStateImageBehavior = false;
            this.lvwSkorlar.UseSelectable = true;
            this.lvwSkorlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Oyuncu";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Skor";
            this.columnHeader3.Width = 66;
            // 
            // Zaman
            // 
            this.Zaman.Tag = "Zaman";
            this.Zaman.Text = "Zaman";
            // 
            // SkorlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 373);
            this.Controls.Add(this.lvwSkorlar);
            this.Name = "SkorlarForm";
            this.Text = "En Yüksek Skorlar";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lvwSkorlar;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader Zaman;
    }
}