namespace NikeStore.UI
{
    partial class ProductForm
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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            toolStrip2 = new ToolStrip();
            btnÜrünEkle = new ToolStripButton();
            btnÜrünDüzenle = new ToolStripButton();
            btnÜrünSil = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            toolStripTextBox2 = new ToolStripTextBox();
            btnÜrünBul = new ToolStripButton();
            btnCancel = new Button();
            btnOK = new Button();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(640, 458);
            tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(toolStrip2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(632, 425);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ÜRÜNLER";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView2.Location = new Point(3, 34);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(626, 388);
            dataGridView2.TabIndex = 3;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(24, 24);
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnÜrünEkle, btnÜrünDüzenle, btnÜrünSil, toolStripSeparator2, toolStripLabel2, toolStripTextBox2, btnÜrünBul });
            toolStrip2.Location = new Point(3, 3);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(626, 31);
            toolStrip2.TabIndex = 2;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnÜrünEkle
            // 
            btnÜrünEkle.Image = Properties.Resources.bag_add;
            btnÜrünEkle.ImageTransparentColor = Color.Magenta;
            btnÜrünEkle.Name = "btnÜrünEkle";
            btnÜrünEkle.Size = new Size(64, 28);
            btnÜrünEkle.Text = "Ekle";
            btnÜrünEkle.Click += btnÜrünEkle_Click;
            // 
            // btnÜrünDüzenle
            // 
            btnÜrünDüzenle.Image = Properties.Resources.bag_edit;
            btnÜrünDüzenle.ImageTransparentColor = Color.Magenta;
            btnÜrünDüzenle.Name = "btnÜrünDüzenle";
            btnÜrünDüzenle.Size = new Size(91, 28);
            btnÜrünDüzenle.Text = "Düzenle";
            btnÜrünDüzenle.Click += btnÜrünDüzenle_Click;
            // 
            // btnÜrünSil
            // 
            btnÜrünSil.Image = Properties.Resources.bag_remove;
            btnÜrünSil.ImageTransparentColor = Color.Magenta;
            btnÜrünSil.Name = "btnÜrünSil";
            btnÜrünSil.Size = new Size(53, 28);
            btnÜrünSil.Text = "Sil";
            btnÜrünSil.Click += btnÜrünSil_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(32, 28);
            toolStripLabel2.Text = "Ara";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.AutoSize = false;
            toolStripTextBox2.BorderStyle = BorderStyle.FixedSingle;
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(180, 27);
            toolStripTextBox2.Leave += toolStripTextBox2_Leave;
            // 
            // btnÜrünBul
            // 
            btnÜrünBul.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnÜrünBul.Image = Properties.Resources.search;
            btnÜrünBul.ImageTransparentColor = Color.Magenta;
            btnÜrünBul.Name = "btnÜrünBul";
            btnÜrünBul.Size = new Size(29, 28);
            btnÜrünBul.Text = "Bul";
            btnÜrünBul.Click += btnÜrünBul_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(517, 480);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(417, 480);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 9;
            btnOK.Text = "Tamam";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // ProductForm
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(640, 521);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(tabControl1);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürün Yönetimi";
            Load += ProductForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private ToolStrip toolStrip2;
        private ToolStripButton btnÜrünEkle;
        private ToolStripButton btnÜrünDüzenle;
        private ToolStripButton btnÜrünSil;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripButton btnÜrünBul;
        private Button btnCancel;
        private Button btnOK;
    }
}