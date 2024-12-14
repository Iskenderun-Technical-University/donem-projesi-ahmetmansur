
namespace AhmetMansurOzerUreticiler.Ureticiler
{
    partial class ureticiSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ureticiSec));
            this.label1 = new System.Windows.Forms.Label();
            this.araTxt = new System.Windows.Forms.TextBox();
            this.araBtn = new System.Windows.Forms.Button();
            this.ureticilerLst = new System.Windows.Forms.ListBox();
            this.secBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üretici Adı:";
            // 
            // araTxt
            // 
            this.araTxt.Location = new System.Drawing.Point(16, 41);
            this.araTxt.Name = "araTxt";
            this.araTxt.Size = new System.Drawing.Size(270, 20);
            this.araTxt.TabIndex = 1;
            // 
            // araBtn
            // 
            this.araBtn.Image = ((System.Drawing.Image)(resources.GetObject("araBtn.Image")));
            this.araBtn.Location = new System.Drawing.Point(292, 34);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(32, 32);
            this.araBtn.TabIndex = 2;
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // ureticilerLst
            // 
            this.ureticilerLst.FormattingEnabled = true;
            this.ureticilerLst.Location = new System.Drawing.Point(16, 79);
            this.ureticilerLst.Name = "ureticilerLst";
            this.ureticilerLst.Size = new System.Drawing.Size(308, 212);
            this.ureticilerLst.TabIndex = 3;
            // 
            // secBtn
            // 
            this.secBtn.Location = new System.Drawing.Point(249, 297);
            this.secBtn.Name = "secBtn";
            this.secBtn.Size = new System.Drawing.Size(75, 23);
            this.secBtn.TabIndex = 4;
            this.secBtn.Text = "Select";
            this.secBtn.UseVisualStyleBackColor = true;
            this.secBtn.Click += new System.EventHandler(this.secBtn_Click);
            // 
            // ureticiSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 330);
            this.Controls.Add(this.secBtn);
            this.Controls.Add(this.ureticilerLst);
            this.Controls.Add(this.araBtn);
            this.Controls.Add(this.araTxt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(352, 369);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(352, 369);
            this.Name = "ureticiSec";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üretici Seç";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ureticiSec_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox araTxt;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.ListBox ureticilerLst;
        private System.Windows.Forms.Button secBtn;
    }
}