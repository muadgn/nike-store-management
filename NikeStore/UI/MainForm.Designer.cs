namespace NikeStore
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            btnCustomers = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnSatışYap = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnÖdemeYap = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            toolStrip2 = new ToolStrip();
            btnSatışDüzenle = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            btnSatışSil = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            txtSearchSale = new ToolStripTextBox();
            btnSearchSale = new ToolStripButton();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            toolStrip3 = new ToolStrip();
            btnÖdemeDüzenle = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            btnÖdemeSil = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            txtSearchPayment = new ToolStripTextBox();
            btnSearchPayment = new ToolStripButton();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip2.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            toolStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCustomers, toolStripSeparator1, toolStripButton2, toolStripSeparator2, btnSatışYap, toolStripSeparator3, btnÖdemeYap, toolStripSeparator4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 39);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnCustomers
            // 
            btnCustomers.Image = Properties.Resources._003_group;
            btnCustomers.ImageTransparentColor = Color.Magenta;
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(129, 36);
            btnCustomers.Text = "MÜŞTERİLER";
            btnCustomers.Click += btnCustomers_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources._004_bag;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(109, 36);
            toolStripButton2.Text = "ÜRÜNLER";
            toolStripButton2.Click += btnProducts_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            // 
            // btnSatışYap
            // 
            btnSatışYap.Image = Properties.Resources.satış;
            btnSatışYap.ImageTransparentColor = Color.Magenta;
            btnSatışYap.Name = "btnSatışYap";
            btnSatışYap.Size = new Size(111, 36);
            btnSatışYap.Text = "SATIŞ YAP";
            btnSatışYap.Click += btnSatışYap_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 39);
            // 
            // btnÖdemeYap
            // 
            btnÖdemeYap.Image = Properties.Resources.ödeme;
            btnÖdemeYap.ImageTransparentColor = Color.Magenta;
            btnÖdemeYap.Name = "btnÖdemeYap";
            btnÖdemeYap.Size = new Size(125, 36);
            btnÖdemeYap.Text = "ÖDEME YAP";
            btnÖdemeYap.Click += btnÖdemeYap_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 39);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 39);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 411);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(toolStrip2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 378);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "SATIŞLAR";
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
            dataGridView1.Size = new Size(786, 341);
            dataGridView1.TabIndex = 1;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(24, 24);
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnSatışDüzenle, toolStripSeparator6, btnSatışSil, toolStripSeparator5, toolStripLabel1, txtSearchSale, btnSearchSale });
            toolStrip2.Location = new Point(3, 3);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(786, 31);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnSatışDüzenle
            // 
            btnSatışDüzenle.Image = Properties.Resources._001_shopping;
            btnSatışDüzenle.ImageTransparentColor = Color.Magenta;
            btnSatışDüzenle.Name = "btnSatışDüzenle";
            btnSatışDüzenle.Size = new Size(91, 28);
            btnSatışDüzenle.Text = "Düzenle";
            btnSatışDüzenle.Click += btnSatışDüzenle_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 31);
            // 
            // btnSatışSil
            // 
            btnSatışSil.Image = Properties.Resources._002_label;
            btnSatışSil.ImageTransparentColor = Color.Magenta;
            btnSatışSil.Name = "btnSatışSil";
            btnSatışSil.Size = new Size(53, 28);
            btnSatışSil.Text = "Sil";
            btnSatışSil.Click += btnSatışSil_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 31);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(32, 28);
            toolStripLabel1.Text = "Ara";
            // 
            // txtSearchSale
            // 
            txtSearchSale.AutoSize = false;
            txtSearchSale.BorderStyle = BorderStyle.FixedSingle;
            txtSearchSale.Name = "txtSearchSale";
            txtSearchSale.Size = new Size(180, 27);
            txtSearchSale.Leave += txtSearchSale_Leave;
            // 
            // btnSearchSale
            // 
            btnSearchSale.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSearchSale.Image = Properties.Resources.search;
            btnSearchSale.ImageTransparentColor = Color.Magenta;
            btnSearchSale.Name = "btnSearchSale";
            btnSearchSale.Size = new Size(29, 28);
            btnSearchSale.Text = "Bul";
            btnSearchSale.Click += btnSearchSale_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(toolStrip3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 378);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ÖDEMELER";
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
            dataGridView2.Size = new Size(786, 341);
            dataGridView2.TabIndex = 3;
            // 
            // toolStrip3
            // 
            toolStrip3.ImageScalingSize = new Size(24, 24);
            toolStrip3.Items.AddRange(new ToolStripItem[] { btnÖdemeDüzenle, toolStripSeparator7, btnÖdemeSil, toolStripSeparator8, toolStripLabel2, txtSearchPayment, btnSearchPayment });
            toolStrip3.Location = new Point(3, 3);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(786, 31);
            toolStrip3.TabIndex = 2;
            toolStrip3.Text = "toolStrip3";
            // 
            // btnÖdemeDüzenle
            // 
            btnÖdemeDüzenle.Image = Properties.Resources._001_money;
            btnÖdemeDüzenle.ImageTransparentColor = Color.Magenta;
            btnÖdemeDüzenle.Name = "btnÖdemeDüzenle";
            btnÖdemeDüzenle.Size = new Size(91, 28);
            btnÖdemeDüzenle.Text = "Düzenle";
            btnÖdemeDüzenle.Click += btnÖdemeDüzenle_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 31);
            // 
            // btnÖdemeSil
            // 
            btnÖdemeSil.Image = Properties.Resources._002_money_1;
            btnÖdemeSil.ImageTransparentColor = Color.Magenta;
            btnÖdemeSil.Name = "btnÖdemeSil";
            btnÖdemeSil.Size = new Size(53, 28);
            btnÖdemeSil.Text = "Sil";
            btnÖdemeSil.Click += btnÖdemeSil_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 31);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(32, 28);
            toolStripLabel2.Text = "Ara";
            // 
            // txtSearchPayment
            // 
            txtSearchPayment.AutoSize = false;
            txtSearchPayment.BorderStyle = BorderStyle.FixedSingle;
            txtSearchPayment.Name = "txtSearchPayment";
            txtSearchPayment.Size = new Size(180, 27);
            txtSearchPayment.Leave += txtSearchPayment_Leave;
            // 
            // btnSearchPayment
            // 
            btnSearchPayment.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSearchPayment.Image = Properties.Resources.search;
            btnSearchPayment.ImageTransparentColor = Color.Magenta;
            btnSearchPayment.Name = "btnSearchPayment";
            btnSearchPayment.Size = new Size(29, 28);
            btnSearchPayment.Text = "Bul";
            btnSearchPayment.Click += btnSearchPayment_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NIKE STORE";
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnCustomers;
        private ToolStripButton toolStripButton2;
        private ToolStripButton btnSatışYap;
        private ToolStripButton btnÖdemeYap;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip2;
        private ToolStripButton btnSatışDüzenle;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton btnSatışSil;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtSearchSale;
        private ToolStripButton btnSearchSale;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private ToolStrip toolStrip3;
        private ToolStripButton btnÖdemeDüzenle;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton btnÖdemeSil;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox txtSearchPayment;
        private ToolStripButton btnSearchPayment;
    }
}