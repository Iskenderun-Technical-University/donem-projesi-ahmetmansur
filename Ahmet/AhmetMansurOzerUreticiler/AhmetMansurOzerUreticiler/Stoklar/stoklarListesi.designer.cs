
namespace AhmetMansurOzerUreticiler.Stoklar
{
    partial class stoklarListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stoklarListesi));
            this.dgvStoklar = new System.Windows.Forms.DataGridView();
            this.sagTusMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stokGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.stokSil = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.depoCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.araBtn = new System.Windows.Forms.Button();
            this.araTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoklar)).BeginInit();
            this.sagTusMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStoklar
            // 
            this.dgvStoklar.AllowUserToAddRows = false;
            this.dgvStoklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoklar.ContextMenuStrip = this.sagTusMenu;
            this.dgvStoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStoklar.Location = new System.Drawing.Point(0, 60);
            this.dgvStoklar.MultiSelect = false;
            this.dgvStoklar.Name = "dgvStoklar";
            this.dgvStoklar.ReadOnly = true;
            this.dgvStoklar.RowHeadersVisible = false;
            this.dgvStoklar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoklar.Size = new System.Drawing.Size(784, 501);
            this.dgvStoklar.TabIndex = 7;
            // 
            // sagTusMenu
            // 
            this.sagTusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokGuncelle,
            this.stokSil});
            this.sagTusMenu.Name = "contextMenuStrip1";
            this.sagTusMenu.Size = new System.Drawing.Size(147, 48);
            // 
            // stokGuncelle
            // 
            this.stokGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("stokGuncelle.Image")));
            this.stokGuncelle.Name = "stokGuncelle";
            this.stokGuncelle.Size = new System.Drawing.Size(146, 22);
            this.stokGuncelle.Text = "Stok Güncelle";
            this.stokGuncelle.Click += new System.EventHandler(this.stokGuncelle_Click);
            // 
            // stokSil
            // 
            this.stokSil.Image = ((System.Drawing.Image)(resources.GetObject("stokSil.Image")));
            this.stokSil.Name = "stokSil";
            this.stokSil.Size = new System.Drawing.Size(146, 22);
            this.stokSil.Text = "Stok Sil";
            this.stokSil.Click += new System.EventHandler(this.stokSil_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.depoCmb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.araBtn);
            this.panel1.Controls.Add(this.araTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 60);
            this.panel1.TabIndex = 6;
            // 
            // depoCmb
            // 
            this.depoCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depoCmb.FormattingEnabled = true;
            this.depoCmb.Location = new System.Drawing.Point(65, 22);
            this.depoCmb.Name = "depoCmb";
            this.depoCmb.Size = new System.Drawing.Size(238, 21);
            this.depoCmb.TabIndex = 5;
            this.depoCmb.SelectedIndexChanged += new System.EventHandler(this.depoCmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Depolar:";
            // 
            // araBtn
            // 
            this.araBtn.Image = ((System.Drawing.Image)(resources.GetObject("araBtn.Image")));
            this.araBtn.Location = new System.Drawing.Point(623, 15);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(32, 32);
            this.araBtn.TabIndex = 3;
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // araTxt
            // 
            this.araTxt.Location = new System.Drawing.Point(427, 22);
            this.araTxt.Name = "araTxt";
            this.araTxt.Size = new System.Drawing.Size(190, 20);
            this.araTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı:";
            // 
            // stoklarListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvStoklar);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "stoklarListesi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoklar)).EndInit();
            this.sagTusMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStoklar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.TextBox araTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox depoCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip sagTusMenu;
        private System.Windows.Forms.ToolStripMenuItem stokGuncelle;
        private System.Windows.Forms.ToolStripMenuItem stokSil;
    }
}