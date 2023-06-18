namespace NikeStore.UI
{
    partial class CustomerForm
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
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnMusteriEkle = new ToolStripButton();
            btnMusteriDüzenle = new ToolStripButton();
            btnMusteriSil = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            btnMusteriBul = new ToolStripButton();
            tabControl1 = new TabControl();
            btnCancel = new Button();
            btnOK = new Button();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(toolStrip1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(652, 385);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "MÜŞTERİLER";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(3, 34);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(646, 348);
            dataGridView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnMusteriEkle, btnMusteriDüzenle, btnMusteriSil, toolStripSeparator1, toolStripLabel1, toolStripTextBox1, btnMusteriBul });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(646, 31);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Image = Properties.Resources.user_add;
            btnMusteriEkle.ImageTransparentColor = Color.Magenta;
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(64, 28);
            btnMusteriEkle.Text = "Ekle";
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // btnMusteriDüzenle
            // 
            btnMusteriDüzenle.Image = Properties.Resources.user_edit;
            btnMusteriDüzenle.ImageTransparentColor = Color.Magenta;
            btnMusteriDüzenle.Name = "btnMusteriDüzenle";
            btnMusteriDüzenle.Size = new Size(91, 28);
            btnMusteriDüzenle.Text = "Düzenle";
            btnMusteriDüzenle.Click += btnMusteriDüzenle_Click;
            // 
            // btnMusteriSil
            // 
            btnMusteriSil.Image = Properties.Resources.user_remove;
            btnMusteriSil.ImageTransparentColor = Color.Magenta;
            btnMusteriSil.Name = "btnMusteriSil";
            btnMusteriSil.Size = new Size(53, 28);
            btnMusteriSil.Text = "Sil";
            btnMusteriSil.Click += btnMusteriSil_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(32, 28);
            toolStripLabel1.Text = "Ara";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.AutoSize = false;
            toolStripTextBox1.BorderStyle = BorderStyle.FixedSingle;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(180, 27);
            toolStripTextBox1.Leave += toolStripTextBox1_Leave;
            // 
            // btnMusteriBul
            // 
            btnMusteriBul.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMusteriBul.Image = Properties.Resources.search;
            btnMusteriBul.ImageTransparentColor = Color.Magenta;
            btnMusteriBul.Name = "btnMusteriBul";
            btnMusteriBul.Size = new Size(29, 28);
            btnMusteriBul.Text = "Bul";
            btnMusteriBul.Click += btnMusteriBul_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(660, 418);
            tabControl1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(537, 424);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(437, 424);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 7;
            btnOK.Text = "Tamam";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // CustomerForm
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(660, 465);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(tabControl1);
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Müşteri Yönetimi";
            Load += CustomerForm_Load;
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnMusteriEkle;
        private ToolStripButton btnMusteriDüzenle;
        private ToolStripButton btnMusteriSil;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton btnMusteriBul;
        private TabControl tabControl1;
        private Button btnCancel;
        private Button btnOK;
    }
}