
namespace AhmetMansurOzerUreticiler.Ureticiler
{
    partial class ureticilerListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ureticilerListesi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.araBtn = new System.Windows.Forms.Button();
            this.araTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ureticiEkleBtn = new System.Windows.Forms.Button();
            this.dgvUreticiler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ureticiDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.sifreDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.depolarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ureticiSil = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUreticiler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.araBtn);
            this.panel1.Controls.Add(this.araTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ureticiEkleBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 60);
            this.panel1.TabIndex = 0;
            // 
            // araBtn
            // 
            this.araBtn.Image = ((System.Drawing.Image)(resources.GetObject("araBtn.Image")));
            this.araBtn.Location = new System.Drawing.Point(477, 15);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(32, 32);
            this.araBtn.TabIndex = 3;
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // araTxt
            // 
            this.araTxt.Location = new System.Drawing.Point(281, 22);
            this.araTxt.Name = "araTxt";
            this.araTxt.Size = new System.Drawing.Size(190, 20);
            this.araTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üretici Adı:";
            // 
            // ureticiEkleBtn
            // 
            this.ureticiEkleBtn.Image = ((System.Drawing.Image)(resources.GetObject("ureticiEkleBtn.Image")));
            this.ureticiEkleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ureticiEkleBtn.Location = new System.Drawing.Point(12, 12);
            this.ureticiEkleBtn.Name = "ureticiEkleBtn";
            this.ureticiEkleBtn.Size = new System.Drawing.Size(101, 38);
            this.ureticiEkleBtn.TabIndex = 0;
            this.ureticiEkleBtn.Text = "Üretici Ekle";
            this.ureticiEkleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ureticiEkleBtn.UseVisualStyleBackColor = true;
            this.ureticiEkleBtn.Click += new System.EventHandler(this.ureticiEkleBtn_Click);
            // 
            // dgvUreticiler
            // 
            this.dgvUreticiler.AllowUserToAddRows = false;
            this.dgvUreticiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUreticiler.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUreticiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUreticiler.Location = new System.Drawing.Point(0, 60);
            this.dgvUreticiler.MultiSelect = false;
            this.dgvUreticiler.Name = "dgvUreticiler";
            this.dgvUreticiler.ReadOnly = true;
            this.dgvUreticiler.RowHeadersVisible = false;
            this.dgvUreticiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUreticiler.Size = new System.Drawing.Size(784, 501);
            this.dgvUreticiler.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ureticiDegistir,
            this.sifreDegistir,
            this.depolarMenu,
            this.ureticiSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // ureticiDegistir
            // 
            this.ureticiDegistir.Image = ((System.Drawing.Image)(resources.GetObject("ureticiDegistir.Image")));
            this.ureticiDegistir.Name = "ureticiDegistir";
            this.ureticiDegistir.Size = new System.Drawing.Size(180, 22);
            this.ureticiDegistir.Text = "Üretici Değiştir";
            this.ureticiDegistir.Click += new System.EventHandler(this.ureticiDegistir_Click);
            // 
            // sifreDegistir
            // 
            this.sifreDegistir.Image = ((System.Drawing.Image)(resources.GetObject("sifreDegistir.Image")));
            this.sifreDegistir.Name = "sifreDegistir";
            this.sifreDegistir.Size = new System.Drawing.Size(180, 22);
            this.sifreDegistir.Text = "Şifre Değiştir";
            this.sifreDegistir.Click += new System.EventHandler(this.sifreDegistir_Click);
            // 
            // depolarMenu
            // 
            this.depolarMenu.Image = ((System.Drawing.Image)(resources.GetObject("depolarMenu.Image")));
            this.depolarMenu.Name = "depolarMenu";
            this.depolarMenu.Size = new System.Drawing.Size(180, 22);
            this.depolarMenu.Text = "Depolar";
            this.depolarMenu.Click += new System.EventHandler(this.depolarMenu_Click);
            // 
            // ureticiSil
            // 
            this.ureticiSil.Image = ((System.Drawing.Image)(resources.GetObject("ureticiSil.Image")));
            this.ureticiSil.Name = "ureticiSil";
            this.ureticiSil.Size = new System.Drawing.Size(180, 22);
            this.ureticiSil.Text = "Üretici Sil";
            this.ureticiSil.Click += new System.EventHandler(this.ureticiSil_Click);
            // 
            // ureticilerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvUreticiler);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ureticilerListesi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üreticiler Listesi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUreticiler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ureticiEkleBtn;
        private System.Windows.Forms.DataGridView dgvUreticiler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.TextBox araTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ureticiDegistir;
        private System.Windows.Forms.ToolStripMenuItem ureticiSil;
        private System.Windows.Forms.ToolStripMenuItem depolarMenu;
        private System.Windows.Forms.ToolStripMenuItem sifreDegistir;
    }
}