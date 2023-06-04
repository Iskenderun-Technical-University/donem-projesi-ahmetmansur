
namespace AhmetMansurOzerUreticiler.Urunler
{
    partial class auurunler
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
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOzellikler = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(15, 43);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(291, 20);
            this.txtUrun.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Özellikleri:";
            // 
            // txtOzellikler
            // 
            this.txtOzellikler.Location = new System.Drawing.Point(15, 92);
            this.txtOzellikler.Multiline = true;
            this.txtOzellikler.Name = "txtOzellikler";
            this.txtOzellikler.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOzellikler.Size = new System.Drawing.Size(291, 106);
            this.txtOzellikler.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // auurunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOzellikler);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(334, 292);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(334, 292);
            this.Name = "auurunler";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "auurun";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.auurun_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOzellikler;
        private System.Windows.Forms.Button button1;
    }
}