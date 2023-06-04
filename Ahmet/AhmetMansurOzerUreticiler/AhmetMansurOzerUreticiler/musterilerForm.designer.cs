
namespace AhmetMansurOzerUreticiler
{
    partial class musterilerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musterilerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.stoklarBtn = new System.Windows.Forms.Button();
            this.siparislerBtn = new System.Windows.Forms.Button();
            this.araBtn = new System.Windows.Forms.Button();
            this.araTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siparisDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisSil = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stoklarBtn);
            this.panel1.Controls.Add(this.siparislerBtn);
            this.panel1.Controls.Add(this.araBtn);
            this.panel1.Controls.Add(this.araTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 65);
            this.panel1.TabIndex = 2;
            // 
            // stoklarBtn
            // 
            this.stoklarBtn.Image = ((System.Drawing.Image)(resources.GetObject("stoklarBtn.Image")));
            this.stoklarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stoklarBtn.Location = new System.Drawing.Point(108, 12);
            this.stoklarBtn.Name = "stoklarBtn";
            this.stoklarBtn.Size = new System.Drawing.Size(83, 40);
            this.stoklarBtn.TabIndex = 11;
            this.stoklarBtn.Text = "Stoklar";
            this.stoklarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stoklarBtn.UseVisualStyleBackColor = true;
            this.stoklarBtn.Click += new System.EventHandler(this.stoklarBtn_Click);
            // 
            // siparislerBtn
            // 
            this.siparislerBtn.Image = ((System.Drawing.Image)(resources.GetObject("siparislerBtn.Image")));
            this.siparislerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siparislerBtn.Location = new System.Drawing.Point(13, 12);
            this.siparislerBtn.Name = "siparislerBtn";
            this.siparislerBtn.Size = new System.Drawing.Size(89, 40);
            this.siparislerBtn.TabIndex = 10;
            this.siparislerBtn.Text = "Siparişler";
            this.siparislerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.siparislerBtn.UseVisualStyleBackColor = true;
            this.siparislerBtn.Click += new System.EventHandler(this.siparislerBtn_Click);
            // 
            // araBtn
            // 
            this.araBtn.Image = ((System.Drawing.Image)(resources.GetObject("araBtn.Image")));
            this.araBtn.Location = new System.Drawing.Point(598, 16);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(32, 32);
            this.araBtn.TabIndex = 7;
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // araTxt
            // 
            this.araTxt.Location = new System.Drawing.Point(402, 23);
            this.araTxt.Name = "araTxt";
            this.araTxt.Size = new System.Drawing.Size(190, 20);
            this.araTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Adı:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSiparisler);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1080, 385);
            this.panel3.TabIndex = 4;
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AllowUserToAddRows = false;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSiparisler.Location = new System.Drawing.Point(0, 0);
            this.dgvSiparisler.MultiSelect = false;
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.ReadOnly = true;
            this.dgvSiparisler.RowHeadersVisible = false;
            this.dgvSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisler.Size = new System.Drawing.Size(1080, 385);
            this.dgvSiparisler.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisDegistir,
            this.siparisSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 48);
            // 
            // siparisDegistir
            // 
            this.siparisDegistir.Image = ((System.Drawing.Image)(resources.GetObject("siparisDegistir.Image")));
            this.siparisDegistir.Name = "siparisDegistir";
            this.siparisDegistir.Size = new System.Drawing.Size(151, 22);
            this.siparisDegistir.Text = "Sipariş Değiştir";
            this.siparisDegistir.Click += new System.EventHandler(this.siparisDegistir_Click);
            // 
            // siparisSil
            // 
            this.siparisSil.Image = ((System.Drawing.Image)(resources.GetObject("siparisSil.Image")));
            this.siparisSil.Name = "siparisSil";
            this.siparisSil.Size = new System.Drawing.Size(151, 22);
            this.siparisSil.Text = "Sipariş Sil";
            this.siparisSil.Click += new System.EventHandler(this.siparisSil_Click);
            // 
            // musterilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "musterilerForm";
            this.Text = "Müşteriler Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.musterilerForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.TextBox araTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Button siparislerBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparisDegistir;
        private System.Windows.Forms.ToolStripMenuItem siparisSil;
        private System.Windows.Forms.Button stoklarBtn;
    }
}