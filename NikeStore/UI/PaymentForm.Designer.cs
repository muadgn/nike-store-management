namespace NikeStore.UI
{
    partial class PaymentForm
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
            dtTarih = new DateTimePicker();
            nmTutar = new NumericUpDown();
            btnCancel = new Button();
            btnOK = new Button();
            label3 = new Label();
            label4 = new Label();
            txtMusteri = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            txtAçıklama = new TextBox();
            label6 = new Label();
            cbTur = new ComboBox();
            txtSoy = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnMüşteriSeç = new Button();
            ((System.ComponentModel.ISupportInitialize)nmTutar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(103, 112);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(245, 27);
            dtTarih.TabIndex = 3;
            // 
            // nmTutar
            // 
            nmTutar.Location = new Point(103, 145);
            nmTutar.Maximum = new decimal(new int[] { 600000, 0, 0, 0 });
            nmTutar.Name = "nmTutar";
            nmTutar.Size = new Size(245, 27);
            nmTutar.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(237, 315);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(137, 315);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 6;
            btnOK.Text = "Tamam";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 117);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 38;
            label3.Text = "Tarih";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 147);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 39;
            label4.Text = "Tutar";
            // 
            // txtMusteri
            // 
            txtMusteri.Location = new Point(103, 45);
            txtMusteri.Name = "txtMusteri";
            txtMusteri.Size = new Size(245, 27);
            txtMusteri.TabIndex = 1;
            txtMusteri.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 48);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 41;
            label2.Text = "Müşteri";
            // 
            // txtID
            // 
            txtID.Location = new Point(103, 12);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(245, 27);
            txtID.TabIndex = 0;
            txtID.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 15);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 42;
            label1.Text = "ID";
            // 
            // txtAçıklama
            // 
            txtAçıklama.Location = new Point(103, 178);
            txtAçıklama.Multiline = true;
            txtAçıklama.Name = "txtAçıklama";
            txtAçıklama.ScrollBars = ScrollBars.Both;
            txtAçıklama.Size = new Size(245, 114);
            txtAçıklama.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 181);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 44;
            label6.Text = "Açıklama";
            // 
            // cbTur
            // 
            cbTur.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTur.FormattingEnabled = true;
            cbTur.Items.AddRange(new object[] { "Nakit", "Kredi Kartı", "Banka Ödemesi" });
            cbTur.Location = new Point(103, 78);
            cbTur.Name = "cbTur";
            cbTur.Size = new Size(245, 28);
            cbTur.TabIndex = 2;
            // 
            // txtSoy
            // 
            txtSoy.AutoSize = true;
            txtSoy.Location = new Point(3, 78);
            txtSoy.Name = "txtSoy";
            txtSoy.Size = new Size(91, 20);
            txtSoy.TabIndex = 46;
            txtSoy.Text = "Ödeme Türü";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnMüşteriSeç
            // 
            btnMüşteriSeç.Location = new Point(354, 45);
            btnMüşteriSeç.Name = "btnMüşteriSeç";
            btnMüşteriSeç.Size = new Size(148, 29);
            btnMüşteriSeç.TabIndex = 47;
            btnMüşteriSeç.Text = "Müşteri Seç";
            btnMüşteriSeç.UseVisualStyleBackColor = true;
            btnMüşteriSeç.Click += btnMüşteriSeç_Click;
            // 
            // PaymentForm
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(507, 360);
            Controls.Add(btnMüşteriSeç);
            Controls.Add(cbTur);
            Controls.Add(txtSoy);
            Controls.Add(txtAçıklama);
            Controls.Add(label6);
            Controls.Add(dtTarih);
            Controls.Add(nmTutar);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtMusteri);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ödeme Yönetimi";
            Load += PaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmTutar).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtTarih;
        private NumericUpDown nmTutar;
        private Button btnCancel;
        private Button btnOK;
        private Label label3;
        private Label label4;
        private TextBox txtMusteri;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private TextBox txtAçıklama;
        private Label label6;
        private ComboBox cbTur;
        private Label txtSoy;
        private ErrorProvider errorProvider1;
        private Button btnMüşteriSeç;
    }
}