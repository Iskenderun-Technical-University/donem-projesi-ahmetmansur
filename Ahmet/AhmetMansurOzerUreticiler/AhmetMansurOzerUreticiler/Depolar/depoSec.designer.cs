﻿
namespace AhmetMansurOzerUreticiler.Depolar
{
    partial class depoSec
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
            this.label3 = new System.Windows.Forms.Label();
            this.depolarLst = new System.Windows.Forms.ListBox();
            this.secBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Depolar:";
            // 
            // depolarLst
            // 
            this.depolarLst.FormattingEnabled = true;
            this.depolarLst.Location = new System.Drawing.Point(15, 35);
            this.depolarLst.Name = "depolarLst";
            this.depolarLst.Size = new System.Drawing.Size(284, 238);
            this.depolarLst.TabIndex = 5;
            // 
            // secBtn
            // 
            this.secBtn.Location = new System.Drawing.Point(221, 290);
            this.secBtn.Name = "secBtn";
            this.secBtn.Size = new System.Drawing.Size(75, 23);
            this.secBtn.TabIndex = 6;
            this.secBtn.Text = "Seç";
            this.secBtn.UseVisualStyleBackColor = true;
            this.secBtn.Click += new System.EventHandler(this.secBtn_Click);
            // 
            // depoSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 328);
            this.Controls.Add(this.secBtn);
            this.Controls.Add(this.depolarLst);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(324, 367);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(324, 367);
            this.Name = "depoSec";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo Seç";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.depoSec_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox depolarLst;
        private System.Windows.Forms.Button secBtn;
    }
}