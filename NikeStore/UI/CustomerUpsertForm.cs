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
    public partial class CustomerUpsertForm : Form
    {
        public CustomerUpsertForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Customer Customer { get; set; }
        public bool IsUpdateProcess  { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(label3)) return;
            if (!ErrorControl(txtTel)) return;
            if (!ErrorControl(txtMail)) return;
            if (!ErrorControl(txtAdres)) return;

            Customer.Name = txtAd.Text;
            Customer.Surname = txtSoy.Text;
            Customer.Phone = txtTel.Text;
            Customer.Mail = txtMail.Text;
            Customer.Address = txtAdres.Text;

            DialogResult = DialogResult.OK;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
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

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
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

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            txtID.Text = Customer.Id.ToString();
            if (IsUpdateProcess)
            {
                txtAd.Text = Customer.Name;
                txtSoy.Text = Customer.Surname;
                txtTel.Text = Customer.Phone;
                txtMail.Text = Customer.Mail;
                txtAdres.Text = Customer.Address;
            }
        }
    }
}

