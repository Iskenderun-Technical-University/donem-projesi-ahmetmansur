
namespace AhmetMansurOzerUreticiler.Depolar
{
    partial class depolarListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depolarListesi));
            this.dgvDepolar = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.depoDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.depoSil = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.araBtn = new System.Windows.Forms.Button();
            this.araTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.depoEkleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepolar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDepolar
            // 
            this.dgvDepolar.AllowUserToAddRows = false;
            this.dgvDepolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepolar.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDepolar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepolar.Location = new System.Drawing.Point(0, 60);
            this.dgvDepolar.MultiSelect = false;
            this.dgvDepolar.Name = "dgvDepolar";
            this.dgvDepolar.ReadOnly = true;
            this.dgvDepolar.RowHeadersVisible = false;
            this.dgvDepolar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepolar.Size = new System.Drawing.Size(784, 501);
            this.dgvDepolar.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depoDegistir,
            this.depoSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 48);
            // 
            // depoDegistir
            // 
            this.depoDegistir.Image = ((System.Drawing.Image)(resources.GetObject("depoDegistir.Image")));
            this.depoDegistir.Name = "depoDegistir";
            this.depoDegistir.Size = new System.Drawing.Size(179, 22);
            this.depoDegistir.Text = "Depo Bilgisi Değiştir";
            this.depoDegistir.Click += new System.EventHandler(this.depoDegistir_Click);
            // 
            // depoSil
            // 
            this.depoSil.Image = ((System.Drawing.Image)(resources.GetObject("depoSil.Image")));
            this.depoSil.Name = "depoSil";
            this.depoSil.Size = new System.Drawing.Size(180, 22);
            this.depoSil.Text = "Depo Sil";
            this.depoSil.Click += new System.EventHandler(this.depoSil_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.araBtn);
            this.panel1.Controls.Add(this.araTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.depoEkleBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 60);
            this.panel1.TabIndex = 2;
            // 
            // araBtn
            // 
            this.araBtn.Image = ((System.Drawing.Image)(resources.GetObject("araBtn.Image")));
            this.araBtn.Location = new System.Drawing.Point(485, 15);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(32, 32);
            this.araBtn.TabIndex = 3;
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // araTxt
            // 
            this.araTxt.Location = new System.Drawing.Point(289, 22);
            this.araTxt.Name = "araTxt";
            this.araTxt.Size = new System.Drawing.Size(190, 20);
            this.araTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Depo Adı:";
            // 
            // depoEkleBtn
            // 
            this.depoEkleBtn.Image = ((System.Drawing.Image)(resources.GetObject("depoEkleBtn.Image")));
            this.depoEkleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.depoEkleBtn.Location = new System.Drawing.Point(12, 12);
            this.depoEkleBtn.Name = "depoEkleBtn";
            this.depoEkleBtn.Size = new System.Drawing.Size(96, 38);
            this.depoEkleBtn.TabIndex = 0;
            this.depoEkleBtn.Text = "Depo Ekle";
            this.depoEkleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.depoEkleBtn.UseVisualStyleBackColor = true;
            this.depoEkleBtn.Click += new System.EventHandler(this.depoEkleBtn_Click);
            // 
            // depolarListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvDepolar);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "depolarListesi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depolar Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepolar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepolar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.TextBox araTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button depoEkleBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem depoDegistir;
        private System.Windows.Forms.ToolStripMenuItem depoSil;
    }
}