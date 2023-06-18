namespace NikeStore.UI
{
    partial class ProductUpsertForm
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
            components = new System.ComponentModel.Container();
            btnCancel = new Button();
            btnOK = new Button();
            txtAçıklama = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label7 = new Label();
            txtUrun = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            cbKategori = new ComboBox();
            nmFiyat = new NumericUpDown();
            label3 = new Label();
            nmStok = new NumericUpDown();
            label5 = new Label();
            cbBirim = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nmFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(222, 356);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(122, 356);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 7;
            btnOK.Text = "Tamam";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtAçıklama
            // 
            txtAçıklama.Location = new Point(110, 225);
            txtAçıklama.Multiline = true;
            txtAçıklama.Name = "txtAçıklama";
            txtAçıklama.ScrollBars = ScrollBars.Both;
            txtAçıklama.Size = new Size(223, 114);
            txtAçıklama.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 228);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 8;
            label6.Text = "Açıklama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 127);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 10;
            label4.Text = "Fiyat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 91);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 11;
            label7.Text = "Kategori";
            // 
            // txtUrun
            // 
            txtUrun.Location = new Point(110, 55);
            txtUrun.Name = "txtUrun";
            txtUrun.Size = new Size(223, 27);
            txtUrun.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 55);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 12;
            label2.Text = "Ürün";
            // 
            // txtID
            // 
            txtID.Location = new Point(110, 22);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(223, 27);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 22);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 14;
            label1.Text = "ID";
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Items.AddRange(new object[] { "Erkek ", "Kadın", "Çoçuk", "Yeni ve Öne Çıkanlar", "İndirimler" });
            cbKategori.Location = new Point(110, 91);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(223, 28);
            cbKategori.TabIndex = 2;
            // 
            // nmFiyat
            // 
            nmFiyat.Location = new Point(110, 125);
            nmFiyat.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
            nmFiyat.Name = "nmFiyat";
            nmFiyat.Size = new Size(223, 27);
            nmFiyat.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 157);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 10;
            label3.Text = "Stok Miktarı";
            // 
            // nmStok
            // 
            nmStok.DecimalPlaces = 2;
            nmStok.Location = new Point(110, 158);
            nmStok.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
            nmStok.Name = "nmStok";
            nmStok.Size = new Size(223, 27);
            nmStok.TabIndex = 4;
            nmStok.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 191);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 11;
            label5.Text = "Birim";
            // 
            // cbBirim
            // 
            cbBirim.FormattingEnabled = true;
            cbBirim.Items.AddRange(new object[] { "Adet" });
            cbBirim.Location = new Point(110, 191);
            cbBirim.Name = "cbBirim";
            cbBirim.Size = new Size(223, 28);
            cbBirim.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ProductForm
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(352, 404);
            Controls.Add(nmStok);
            Controls.Add(nmFiyat);
            Controls.Add(cbBirim);
            Controls.Add(cbKategori);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtAçıklama);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txtUrun);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOK;
        private TextBox txtAçıklama;
        private Label label6;
        private Label label4;
        private Label label7;
        private TextBox txtUrun;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private ComboBox cbKategori;
        private NumericUpDown nmFiyat;
        private Label label3;
        private NumericUpDown nmStok;
        private Label label5;
        private ComboBox cbBirim;
        private ErrorProvider errorProvider1;
    }
}