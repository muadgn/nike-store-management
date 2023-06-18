using NikeStore.BL;
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
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public Sale Sale { get; set; }
        public bool IsUpdateProcess { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (nmFiyat.Value == 0)
            {
                errorProvider1.SetError(nmFiyat, "Lütfen fiyat giriniz!");
                nmFiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmFiyat, "");
            }

            Sale.SaleDate = dtTarih.Value;
            Sale.SalePrice = (double)nmFiyat.Value;
            Sale.Customer = Customer;
            Sale.Product = Product;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            txtID.Text = Sale.Id.ToString();

            if (IsUpdateProcess)
            {
                var sale = BusinessLogic.GetSaleById(Sale.Id);
                Customer = sale.Customer;
                Product = sale.Product;

                txtMusteri.Text = sale.Customer.ToString();
                txtUrun.Text = sale.Product.ToString();
                nmFiyat.Value = (decimal)sale.SalePrice;
                dtTarih.Value = sale.SaleDate;
            }
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            CustomerForm frm = new CustomerForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Customer = frm.Customer;
                txtMusteri.Text = Customer.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Product = frm.Product;
                txtUrun.Text = Product.ToString();
            }
        }
    }
}
