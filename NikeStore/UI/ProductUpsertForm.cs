using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NikeStore.UI
{
    public partial class ProductUpsertForm : Form
    {
        public ProductUpsertForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Product Product { get; set; }
        public bool IsUpdateProcess { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtUrun)) return;
            if (!ErrorControl(cbKategori)) return;
            if (!ErrorControl(nmFiyat)) return;
            if (!ErrorControl(nmStok)) return;
            if (!ErrorControl(cbBirim)) return;
            if (!ErrorControl(txtAçıklama)) return;

            Product.Name = txtUrun.Text;
            Product.Category = cbKategori.Text;
            Product.Price = (double)nmFiyat.Value;
            Product.StockAmount = (double)nmStok.Value;
            Product.UnitPrice = cbBirim.Text;
            Product.Detail = txtAçıklama.Text;

            DialogResult = DialogResult.OK;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }

            }

            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }

            }
            return true;

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            txtID.Text = Product.Id.ToString();
            if (IsUpdateProcess)
            {
                txtUrun.Text = Product.Name;
                nmFiyat.Value = (decimal)Product.Price;
                cbBirim.SelectedText = Product.UnitPrice;
                nmStok.Value = (decimal)Product.StockAmount;
                cbKategori.SelectedText = Product.Category;
                txtAçıklama.Text = Product.Detail;
            }
        }


    }
}
