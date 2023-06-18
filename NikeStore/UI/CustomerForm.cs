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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        public Customer Customer { get; set; }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            CustomerUpsertForm customerForm = new CustomerUpsertForm()
            {
                Text = "Müşteri Ekle",

                Customer = new Customer()
                {
                    Id = Guid.NewGuid(),
                }
            };
            var sonuc = customerForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                var result = BusinessLogic.AddCustomer(customerForm.Customer);
                if (result)
                {
                    MessageBox.Show("Müşteri başarıyla eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DrawCustomers();
                }
                else
                {
                    MessageBox.Show("Müşteri eklenirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            var search = toolStripTextBox1.Text;
            if (!string.IsNullOrWhiteSpace(search))
            {
                DrawCustomers(search);
            }
        }

        private void btnMusteriDüzenle_Click(object sender, EventArgs e)
        {
            var selectedCustomer = dataGridView1.SelectedRows[0];
            CustomerUpsertForm customerForm = new CustomerUpsertForm()
            {
                Text = "Müşteri Düzenle",
                IsUpdateProcess = true,
                Customer = new Customer
                {
                    Id = Guid.Parse(selectedCustomer?.Cells["Id"]?.Value?.ToString()),
                    Name = selectedCustomer?.Cells["Name"]?.Value?.ToString(),
                    Surname = selectedCustomer?.Cells["Surname"]?.Value?.ToString(),
                    Phone = selectedCustomer?.Cells["Phone"]?.Value?.ToString(),
                    Mail = selectedCustomer?.Cells["Mail"]?.Value?.ToString(),
                    Address = selectedCustomer?.Cells["Address"]?.Value?.ToString()
                }
            };
            var sonuc = customerForm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                var result = BusinessLogic.UpdateCustomer(customerForm.Customer);
                if (result)
                {
                    MessageBox.Show("Müşteri başarıyla güncellendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DrawCustomers();
                }
                else
                {
                    MessageBox.Show("Müşteri bilgileri güncellenirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            var selectedCustomer = dataGridView1.SelectedRows[0];
            var customerId = Guid.Parse(selectedCustomer?.Cells["Id"]?.Value?.ToString());


            var sonuc = MessageBox.Show("Müşteri silinecek onaylıyor musunuz?", "SİLME ONAYI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {

                var result = BusinessLogic.DeleteCustomer(customerId);
                if (result)
                {
                    MessageBox.Show("Müşteri başarıyla silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DrawCustomers();
                }
                else
                {
                    MessageBox.Show("Müşteri silinirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DrawCustomers(string search = default)
        {
            var customers = BusinessLogic.GetCustomers(search);
            if (customers != null && customers.Tables.Count > 0)
            {
                dataGridView1.DataSource = customers.Tables[0];
            }
        }
        private void toolStripTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toolStripTextBox1.Text))
            {
                DrawCustomers();
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            DrawCustomers();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var selectedCustomer = dataGridView1.SelectedRows[0];

            Customer = new Customer
            {
                Id = Guid.Parse(selectedCustomer?.Cells["Id"]?.Value?.ToString()),
                Name = selectedCustomer?.Cells["Name"]?.Value?.ToString(),
                Surname = selectedCustomer?.Cells["Surname"]?.Value?.ToString(),
                Phone = selectedCustomer?.Cells["Phone"]?.Value?.ToString(),
                Mail = selectedCustomer?.Cells["Mail"]?.Value?.ToString(),
                Address = selectedCustomer?.Cells["Address"]?.Value?.ToString()
            };


            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
