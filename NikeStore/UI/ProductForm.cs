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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        public Product Product { get; set; }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            DrawProducts();

        }

        private void btnÜrünEkle_Click(object sender, EventArgs e)
        {
            ProductUpsertForm productForm = new ProductUpsertForm()
            {
                Text = "Ürün Ekle",
                Product = new Product()
                {
                    Id = Guid.NewGuid(),
                }
            };
            var sonuc = productForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                var result = BusinessLogic.AddProduct(productForm.Product);
                if (result)
                {
                    MessageBox.Show("Ürün başarıyla eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DrawProducts();
                }
                else
                {
                    MessageBox.Show("Ürün eklenirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnÜrünBul_Click(object sender, EventArgs e)
        {
            var search = toolStripTextBox2.Text;
            DrawProducts(search);
        }

        private void btnÜrünDüzenle_Click(object sender, EventArgs e)
        {
            var selectedProduct = dataGridView2.SelectedRows[0];
            ProductUpsertForm productForm = new ProductUpsertForm()
            {
                Text = "Ürün Düzenle",
                IsUpdateProcess = true,
                Product = new Product
                {
                    Id = Guid.Parse(selectedProduct?.Cells["Id"]?.Value?.ToString()),
                    Name = selectedProduct?.Cells["Name"]?.Value?.ToString(),
                    Detail = selectedProduct?.Cells["Detail"]?.Value?.ToString(),
                    Category = selectedProduct?.Cells["Category"]?.Value?.ToString(),
                    StockAmount = (double)selectedProduct?.Cells["StockAmount"]?.Value,
                    UnitPrice = selectedProduct?.Cells["UnitPrice"]?.Value?.ToString(),
                    Price = (double)selectedProduct?.Cells["Price"]?.Value
                }
            };
            var sonuc = productForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                var result = BusinessLogic.UpdateProduct(productForm.Product);
                if (result)
                {
                    MessageBox.Show("Ürün başarıyla güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DrawProducts();
                }
                else
                {
                    MessageBox.Show("Ürün bilgileri güncellenirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnÜrünSil_Click(object sender, EventArgs e)
        {
            var selectedProduct = dataGridView2.SelectedRows[0];
            var productId = Guid.Parse(selectedProduct?.Cells["Id"]?.Value?.ToString());


            var sonuc = MessageBox.Show("Ürün silinecek onaylıyor musunuz?", "SİLME ONAYI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {

                var result = BusinessLogic.DeleteProduct(productId);
                if (result)
                {
                    MessageBox.Show("Ürün başarıyla silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DrawProducts();
                }
                else
                {
                    MessageBox.Show("Ürün silinirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripTextBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toolStripTextBox2.Text))
            {
                DrawProducts();
            }
        }

        private void DrawProducts(string search = default)
        {
            var products = BusinessLogic.GetProducts(search);
            if (products != null && products.Tables.Count > 0)
            {
                dataGridView2.DataSource = products.Tables[0];
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var selectedProduct = dataGridView2.SelectedRows[0];

            Product = new Product
            {
                Id = Guid.Parse(selectedProduct?.Cells["Id"]?.Value?.ToString()),
                Name = selectedProduct?.Cells["Name"]?.Value?.ToString(),
                Detail = selectedProduct?.Cells["Detail"]?.Value?.ToString(),
                Category = selectedProduct?.Cells["Category"]?.Value?.ToString(),
                StockAmount = (double)selectedProduct?.Cells["StockAmount"]?.Value,
                UnitPrice = selectedProduct?.Cells["UnitPrice"]?.Value?.ToString(),
                Price = (double)selectedProduct?.Cells["Price"]?.Value

            };
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
