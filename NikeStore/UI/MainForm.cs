using NikeStore.BL;
using NikeStore.UI;

namespace NikeStore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public User User { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (User != null)
            {
                toolStripLabel2.Text = User.ToString();
            }

            DrawSales();
            DrawPayments();
        }

        private void DrawSales(string search = default)
        {
            var sales = BusinessLogic.GetSales(search);
            if (sales != null && sales.Tables.Count > 0)
            {
                dataGridView1.DataSource = sales.Tables[0];
            }
        }

        private void DrawPayments(string search = default)
        {
            var payments = BusinessLogic.GetPayments(search);
            if (payments != null && payments.Tables.Count > 0)
            {
                dataGridView2.DataSource = payments.Tables[0];
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            SaleForm frm = new SaleForm()
            {
                Text = "Satış Yap",
                Sale = new Sale()
                {
                    Id = Guid.NewGuid(),
                }

            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                var result = BusinessLogic.AddSale(frm.Sale);
                if (result)
                {
                    MessageBox.Show("Satış işlemi başarılı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DrawSales();
                }
                else
                {
                    MessageBox.Show("Satış yapılırken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearchSale_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchSale.Text))
            {
                DrawSales();
            }
        }

        private void btnSearchSale_Click(object sender, EventArgs e)
        {
            var search = txtSearchSale.Text;
            if (!string.IsNullOrWhiteSpace(search))
            {
                DrawSales(search);
            }
        }

        private void btnSatışDüzenle_Click(object sender, EventArgs e)
        {
            var selectedSale = dataGridView1.SelectedRows[0];
            SaleForm saleForm = new SaleForm()
            {
                Text = "Satış Düzenle",
                IsUpdateProcess = true,
                Sale = new Sale
                {
                    Id = Guid.Parse(selectedSale?.Cells["Satış Id"]?.Value?.ToString()),
                }
            };
            var sonuc = saleForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                var result = BusinessLogic.UpdateSale(saleForm.Sale);
                if (result)
                {
                    MessageBox.Show("Satış başarıyla güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DrawSales();
                }
                else
                {
                    MessageBox.Show("Satış bilgileri güncellenirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSatışSil_Click(object sender, EventArgs e)
        {
            var selectedSale = dataGridView1.SelectedRows[0];
            var saleId = Guid.Parse(selectedSale?.Cells["Satış Id"]?.Value?.ToString());

            var sonuc = MessageBox.Show("Satış kaydı silinecek onaylıyor musunuz?", "SİLME ONAYI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {

                var result = BusinessLogic.DeleteSale(saleId);
                if (result)
                {
                    MessageBox.Show("Satış kaydı başarıyla silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DrawSales();
                }
                else
                {
                    MessageBox.Show("Satış kaydı silinirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnÖdemeYap_Click(object sender, EventArgs e)
        {

            PaymentForm frm = new PaymentForm()
            {
                Text = "Ödeme Yap",
                Payment = new Payment()
                {
                    Id = Guid.NewGuid(),
                }

            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                var result = BusinessLogic.AddPayment(frm.Payment);
                if (result)
                {
                    MessageBox.Show("Ödeme işlemi başarılı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DrawPayments();
                }
                else
                {
                    MessageBox.Show("Ödeme yapılırken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnÖdemeDüzenle_Click(object sender, EventArgs e)
        {
            var selectedPayment = dataGridView2.SelectedRows[0];
            PaymentForm paymentForm = new PaymentForm()
            {
                Text = "Ödeme Düzenle",
                IsUpdateProcess = true,
                Payment = new Payment
                {
                    Id = Guid.Parse(selectedPayment?.Cells["Ödeme Id"]?.Value?.ToString()),
                }
            };

            var sonuc = paymentForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                var result = BusinessLogic.UpdatePayment(paymentForm.Payment);
                if (result)
                {
                    MessageBox.Show("Ödeme bilgileri güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DrawPayments();
                }
                else
                {
                    MessageBox.Show("Ödeme bilgileri güncellenirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnÖdemeSil_Click(object sender, EventArgs e)
        {
            var selectedPayment = dataGridView2.SelectedRows[0];
            var paymentId = Guid.Parse(selectedPayment?.Cells["Ödeme Id"]?.Value?.ToString());

            var sonuc = MessageBox.Show("Ödeme kaydı silinecek onaylıyor musunuz?", "SİLME ONAYI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                var result = BusinessLogic.DeletePayment(paymentId);
                if (result)
                {
                    MessageBox.Show("Ödeme kaydı başarıyla silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DrawPayments();
                }
                else
                {
                    MessageBox.Show("Ödeme kaydı silinirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearchPayment_Click(object sender, EventArgs e)
        {
            var search = txtSearchPayment.Text;
            if (!string.IsNullOrWhiteSpace(search))
            {
                DrawPayments(search);
            }
        }

        private void txtSearchPayment_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchPayment.Text))
            {
                DrawPayments();
            }
        }
    }
}