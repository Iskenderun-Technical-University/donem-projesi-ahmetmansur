
namespace AhmetMansurOzerUreticiler.Musteriler
{
    partial class musterilerListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musterilerListesi));
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.musteriDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.sifreDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriSil = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.araBtn = new System.Windows.Forms.Button();
            this.araTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.musteriEkleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.AllowUserToAddRows = false;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMusteriler.Location = new System.Drawing.Point(0, 60);
            this.dgvMusteriler.MultiSelect = false;
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.ReadOnly = true;
            this.dgvMusteriler.RowHeadersVisible = false;
            this.dgvMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriler.Size = new System.Drawing.Size(784, 501);
            this.dgvMusteriler.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriDegistir,
            this.sifreDegistir,
            this.musteriSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 92);
            // 
            // musteriDegistir
            // 
            this.musteriDegistir.Image = ((System.Drawing.Image)(resources.GetObject("musteriDegistir.Image")));
            this.musteriDegistir.Name = "musteriDegistir";
            this.musteriDegistir.Size = new System.Drawing.Size(191, 22);
            this.musteriDegistir.Text = "Müşteri Bilgisi Değiştir";
            this.musteriDegistir.Click += new System.EventHandler(this.musteriDegistir_Click);
            // 
            // sifreDegistir
            // 
            this.sifreDegistir.Image = ((System.Drawing.Image)(resources.GetObject("sifreDegistir.Image")));
            this.sifreDegistir.Name = "sifreDegistir";
            this.sifreDegistir.Size = new System.Drawing.Size(191, 22);
            this.sifreDegistir.Text = "Şifre Değiştir";
            this.sifreDegistir.Click += new System.EventHandler(this.sifreDegistir_Click);
            // 
            // musteriSil
            // 
            this.musteriSil.Image = ((System.Drawing.Image)(resources.GetObject("musteriSil.Image")));
            this.musteriSil.Name = "musteriSil";
            this.musteriSil.Size = new System.Drawing.Size(191, 22);
            this.musteriSil.Text = "Müşteri Sil";
            this.musteriSil.Click += new System.EventHandler(this.musteriSil_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.araBtn);
            this.panel1.Controls.Add(this.araTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.musteriEkleBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 60);
            this.panel1.TabIndex = 4;
            // 
            // araBtn
            // 
            this.araBtn.Image = ((System.Drawing.Image)(resources.GetObject("araBtn.Image")));
            this.araBtn.Location = new System.Drawing.Point(473, 15);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(32, 32);
            this.araBtn.TabIndex = 3;
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // araTxt
            // 
            this.araTxt.Location = new System.Drawing.Point(277, 22);
            this.araTxt.Name = "araTxt";
            this.araTxt.Size = new System.Drawing.Size(190, 20);
            this.araTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Adı:";
            // 
            // musteriEkleBtn
            // 
            this.musteriEkleBtn.Image = ((System.Drawing.Image)(resources.GetObject("musteriEkleBtn.Image")));
            this.musteriEkleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musteriEkleBtn.Location = new System.Drawing.Point(12, 12);
            this.musteriEkleBtn.Name = "musteriEkleBtn";
            this.musteriEkleBtn.Size = new System.Drawing.Size(104, 38);
            this.musteriEkleBtn.TabIndex = 0;
            this.musteriEkleBtn.Text = "Müşteri Ekle";
            this.musteriEkleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.musteriEkleBtn.UseVisualStyleBackColor = true;
            this.musteriEkleBtn.Click += new System.EventHandler(this.musteriEkle_Click);
            // 
            // musterilerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvMusteriler);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "musterilerListesi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.TextBox araTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button musteriEkleBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem musteriDegistir;
        private System.Windows.Forms.ToolStripMenuItem musteriSil;
        private System.Windows.Forms.ToolStripMenuItem sifreDegistir;
    }
}