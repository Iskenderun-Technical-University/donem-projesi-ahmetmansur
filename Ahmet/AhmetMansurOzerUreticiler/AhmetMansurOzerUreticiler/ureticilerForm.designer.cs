
namespace AhmetMansurOzerUreticiler
{
    partial class ureticilerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ureticilerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.araBtn = new System.Windows.Forms.Button();
            this.araTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stocklarimBtn = new System.Windows.Forms.Button();
            this.urunlerBtn = new System.Windows.Forms.Button();
            this.depolarBtn = new System.Windows.Forms.Button();
            this.ureticilerBtn = new System.Windows.Forms.Button();
            this.musterilerBtn = new System.Windows.Forms.Button();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siparisTamam = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.araBtn);
            this.panel1.Controls.Add(this.araTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.stocklarimBtn);
            this.panel1.Controls.Add(this.urunlerBtn);
            this.panel1.Controls.Add(this.depolarBtn);
            this.panel1.Controls.Add(this.ureticilerBtn);
            this.panel1.Controls.Add(this.musterilerBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 65);
            this.panel1.TabIndex = 0;
            // 
            // araBtn
            // 
            this.araBtn.Image = ((System.Drawing.Image)(resources.GetObject("araBtn.Image")));
            this.araBtn.Location = new System.Drawing.Point(801, 18);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(32, 32);
            this.araBtn.TabIndex = 7;
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // araTxt
            // 
            this.araTxt.Location = new System.Drawing.Point(605, 25);
            this.araTxt.Name = "araTxt";
            this.araTxt.Size = new System.Drawing.Size(190, 20);
            this.araTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Müşteri Adı:";
            // 
            // stocklarimBtn
            // 
            this.stocklarimBtn.Image = ((System.Drawing.Image)(resources.GetObject("stocklarimBtn.Image")));
            this.stocklarimBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stocklarimBtn.Location = new System.Drawing.Point(396, 11);
            this.stocklarimBtn.Name = "stocklarimBtn";
            this.stocklarimBtn.Size = new System.Drawing.Size(92, 47);
            this.stocklarimBtn.TabIndex = 4;
            this.stocklarimBtn.Text = "Stoklarım";
            this.stocklarimBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stocklarimBtn.UseVisualStyleBackColor = true;
            this.stocklarimBtn.Click += new System.EventHandler(this.stoklarimBtn_Click);
            // 
            // urunlerBtn
            // 
            this.urunlerBtn.Image = ((System.Drawing.Image)(resources.GetObject("urunlerBtn.Image")));
            this.urunlerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.urunlerBtn.Location = new System.Drawing.Point(307, 11);
            this.urunlerBtn.Name = "urunlerBtn";
            this.urunlerBtn.Size = new System.Drawing.Size(83, 47);
            this.urunlerBtn.TabIndex = 3;
            this.urunlerBtn.Text = "Ürünler";
            this.urunlerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.urunlerBtn.UseVisualStyleBackColor = true;
            this.urunlerBtn.Click += new System.EventHandler(this.urunlerBtn_Click);
            // 
            // depolarBtn
            // 
            this.depolarBtn.Image = ((System.Drawing.Image)(resources.GetObject("depolarBtn.Image")));
            this.depolarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.depolarBtn.Location = new System.Drawing.Point(213, 11);
            this.depolarBtn.Name = "depolarBtn";
            this.depolarBtn.Size = new System.Drawing.Size(88, 47);
            this.depolarBtn.TabIndex = 2;
            this.depolarBtn.Text = "Depolar";
            this.depolarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.depolarBtn.UseVisualStyleBackColor = true;
            this.depolarBtn.Click += new System.EventHandler(this.depolarBtn_Click);
            // 
            // ureticilerBtn
            // 
            this.ureticilerBtn.Image = ((System.Drawing.Image)(resources.GetObject("ureticilerBtn.Image")));
            this.ureticilerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ureticilerBtn.Location = new System.Drawing.Point(115, 11);
            this.ureticilerBtn.Name = "ureticilerBtn";
            this.ureticilerBtn.Size = new System.Drawing.Size(92, 47);
            this.ureticilerBtn.TabIndex = 1;
            this.ureticilerBtn.Text = "Üreticiler";
            this.ureticilerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ureticilerBtn.UseVisualStyleBackColor = true;
            this.ureticilerBtn.Click += new System.EventHandler(this.ureticilerBtn_Click);
            // 
            // musterilerBtn
            // 
            this.musterilerBtn.Image = ((System.Drawing.Image)(resources.GetObject("musterilerBtn.Image")));
            this.musterilerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musterilerBtn.Location = new System.Drawing.Point(12, 11);
            this.musterilerBtn.Name = "musterilerBtn";
            this.musterilerBtn.Size = new System.Drawing.Size(97, 48);
            this.musterilerBtn.TabIndex = 0;
            this.musterilerBtn.Text = "Müşteriler";
            this.musterilerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.musterilerBtn.UseVisualStyleBackColor = true;
            this.musterilerBtn.Click += new System.EventHandler(this.musterilerBtn_Click);
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AllowUserToAddRows = false;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSiparisler.Location = new System.Drawing.Point(0, 65);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.ReadOnly = true;
            this.dgvSiparisler.RowHeadersVisible = false;
            this.dgvSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisler.Size = new System.Drawing.Size(1073, 385);
            this.dgvSiparisler.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisTamam});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(224, 26);
            // 
            // siparisTamam
            // 
            this.siparisTamam.Image = ((System.Drawing.Image)(resources.GetObject("siparisTamam.Image")));
            this.siparisTamam.Name = "siparisTamam";
            this.siparisTamam.Size = new System.Drawing.Size(223, 22);
            this.siparisTamam.Text = "Sipariş Durumu Tamamlandı";
            this.siparisTamam.Click += new System.EventHandler(this.siparisTamam_Click);
            // 
            // ureticilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.dgvSiparisler);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ureticilerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Üreticiler Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ureticilerForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Button musterilerBtn;
        private System.Windows.Forms.Button ureticilerBtn;
        private System.Windows.Forms.Button depolarBtn;
        private System.Windows.Forms.Button urunlerBtn;
        private System.Windows.Forms.Button stocklarimBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.TextBox araTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparisTamam;
    }
}