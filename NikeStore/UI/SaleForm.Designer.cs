namespace NikeStore.UI
{
    partial class SaleForm
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
            nmFiyat = new NumericUpDown();
            btnCancel = new Button();
            btnOK = new Button();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            txtMusteri = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            txtUrun = new TextBox();
            dtTarih = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            btnMüşteriSeç = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nmFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // nmFiyat
            // 
            nmFiyat.Location = new Point(70, 113);
            nmFiyat.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
            nmFiyat.Name = "nmFiyat";
            nmFiyat.Size = new Size(223, 27);
            nmFiyat.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(182, 203);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(82, 203);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 5;
            btnOK.Text = "Tamam";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 156);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 25;
            label3.Text = "Tarih";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 115);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 26;
            label4.Text = "Fiyat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 72);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 28;
            label7.Text = "Ürün";
            // 
            // txtMusteri
            // 
            txtMusteri.Location = new Point(70, 36);
            txtMusteri.Name = "txtMusteri";
            txtMusteri.Size = new Size(223, 27);
            txtMusteri.TabIndex = 1;
            txtMusteri.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 36);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 29;
            label2.Text = "Müşteri";
            // 
            // txtID
            // 
            txtID.Location = new Point(70, 3);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(223, 27);
            txtID.TabIndex = 0;
            txtID.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 8);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 30;
            label1.Text = "ID";
            // 
            // txtUrun
            // 
            txtUrun.Location = new Point(70, 69);
            txtUrun.Name = "txtUrun";
            txtUrun.ReadOnly = true;
            txtUrun.Size = new Size(223, 27);
            txtUrun.TabIndex = 2;
            txtUrun.TabStop = false;
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(70, 151);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(223, 27);
            dtTarih.TabIndex = 4;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnMüşteriSeç
            // 
            btnMüşteriSeç.Location = new Point(299, 63);
            btnMüşteriSeç.Name = "btnMüşteriSeç";
            btnMüşteriSeç.Size = new Size(168, 29);
            btnMüşteriSeç.TabIndex = 31;
            btnMüşteriSeç.Text = "Müşteri Seç";
            btnMüşteriSeç.UseVisualStyleBackColor = true;
            btnMüşteriSeç.Click += btnMüşteriSeç_Click;
            // 
            // button2
            // 
            button2.Location = new Point(299, 98);
            button2.Name = "button2";
            button2.Size = new Size(168, 29);
            button2.TabIndex = 31;
            button2.Text = "Ürün Seç";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SaleForm
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(475, 259);
            Controls.Add(button2);
            Controls.Add(btnMüşteriSeç);
            Controls.Add(dtTarih);
            Controls.Add(nmFiyat);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txtMusteri);
            Controls.Add(txtUrun);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SaleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Satış Yönetimi";
            Load += SaleForm_Load;
            ((System.ComponentModel.ISupportInitialize)nmFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown nmFiyat;
        private Button btnCancel;
        private Button btnOK;
        private Label label3;
        private Label label4;
        private Label label7;
        private TextBox txtMusteri;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private TextBox txtUrun;
        private DateTimePicker dtTarih;
        private ErrorProvider errorProvider1;
        private Button button2;
        private Button btnMüşteriSeç;
    }
}