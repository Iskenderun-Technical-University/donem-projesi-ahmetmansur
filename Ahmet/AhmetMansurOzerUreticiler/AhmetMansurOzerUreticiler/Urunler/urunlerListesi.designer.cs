
namespace AhmetMansurOzerUreticiler.Urunler
{
    partial class urunlerListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunlerListesi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.araBtn = new System.Windows.Forms.Button();
            this.araTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urunEkle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.urunDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.stokEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.urunSil = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.araBtn);
            this.panel1.Controls.Add(this.araTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.urunEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 60);
            this.panel1.TabIndex = 2;
            // 
            // araBtn
            // 
            this.araBtn.Image = ((System.Drawing.Image)(resources.GetObject("araBtn.Image")));
            this.araBtn.Location = new System.Drawing.Point(441, 15);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(32, 32);
            this.araBtn.TabIndex = 3;
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // araTxt
            // 
            this.araTxt.Location = new System.Drawing.Point(245, 22);
            this.araTxt.Name = "araTxt";
            this.araTxt.Size = new System.Drawing.Size(190, 20);
            this.araTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı:";
            // 
            // urunEkle
            // 
            this.urunEkle.Image = ((System.Drawing.Image)(resources.GetObject("urunEkle.Image")));
            this.urunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.urunEkle.Location = new System.Drawing.Point(12, 12);
            this.urunEkle.Name = "urunEkle";
            this.urunEkle.Size = new System.Drawing.Size(94, 38);
            this.urunEkle.TabIndex = 0;
            this.urunEkle.Text = "Ürün Ekle";
            this.urunEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.urunEkle.UseVisualStyleBackColor = true;
            this.urunEkle.Click += new System.EventHandler(this.urunEkle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunDegistir,
            this.stokEkle,
            this.urunSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // urunDegistir
            // 
            this.urunDegistir.Image = ((System.Drawing.Image)(resources.GetObject("urunDegistir.Image")));
            this.urunDegistir.Name = "urunDegistir";
            this.urunDegistir.Size = new System.Drawing.Size(180, 22);
            this.urunDegistir.Text = "Ürün Bilgisi Değiştir";
            this.urunDegistir.Click += new System.EventHandler(this.urunDegistir_Click);
            // 
            // stokEkle
            // 
            this.stokEkle.Image = ((System.Drawing.Image)(resources.GetObject("stokEkle.Image")));
            this.stokEkle.Name = "stokEkle";
            this.stokEkle.Size = new System.Drawing.Size(180, 22);
            this.stokEkle.Text = "Stok Ekle";
            this.stokEkle.Click += new System.EventHandler(this.stokEkle_Click);
            // 
            // urunSil
            // 
            this.urunSil.Image = ((System.Drawing.Image)(resources.GetObject("urunSil.Image")));
            this.urunSil.Name = "urunSil";
            this.urunSil.Size = new System.Drawing.Size(180, 22);
            this.urunSil.Text = "Ürün Sil";
            this.urunSil.Click += new System.EventHandler(this.deleteProductToolStripMenuItem_Click);
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUrunler.Location = new System.Drawing.Point(0, 60);
            this.dgvUrunler.MultiSelect = false;
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.ReadOnly = true;
            this.dgvUrunler.RowHeadersVisible = false;
            this.dgvUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunler.Size = new System.Drawing.Size(684, 401);
            this.dgvUrunler.TabIndex = 3;
            // 
            // urunlerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "urunlerListesi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler Listesi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.TextBox araTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button urunEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem urunDegistir;
        private System.Windows.Forms.ToolStripMenuItem urunSil;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.ToolStripMenuItem stokEkle;
    }
}