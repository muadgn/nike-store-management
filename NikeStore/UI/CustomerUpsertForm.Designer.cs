namespace NikeStore.UI
{
    partial class CustomerUpsertForm
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
            label1 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMail = new TextBox();
            label6 = new Label();
            txtAdres = new TextBox();
            txtTel = new MaskedTextBox();
            btnOK = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            txtSoy = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 24);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(79, 21);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(224, 27);
            txtID.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 57);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 0;
            label2.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(79, 54);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(224, 27);
            txtAd.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 90);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 123);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 0;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 156);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 0;
            label5.Text = "Mail";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(79, 153);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(224, 27);
            txtMail.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 189);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 0;
            label6.Text = "Adres";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(79, 187);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.ScrollBars = ScrollBars.Both;
            txtAdres.Size = new Size(224, 114);
            txtAdres.TabIndex = 5;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(79, 124);
            txtTel.Mask = "\\0(599) 000-0000";
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(224, 27);
            txtTel.TabIndex = 3;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(109, 318);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 6;
            btnOK.Text = "Tamam";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(209, 318);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtSoy
            // 
            txtSoy.Location = new Point(79, 87);
            txtSoy.Name = "txtSoy";
            txtSoy.Size = new Size(224, 27);
            txtSoy.TabIndex = 2;
            // 
            // CustomerForm
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(335, 359);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtTel);
            Controls.Add(txtAdres);
            Controls.Add(label6);
            Controls.Add(txtMail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtSoy);
            Controls.Add(label3);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterParent;
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private Label label2;
        private TextBox txtAd;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMail;
        private Label label6;
        private TextBox txtAdres;
        private MaskedTextBox txtTel;
        private Button btnOK;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
        private TextBox txtSoy;
    }
}