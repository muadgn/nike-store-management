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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Payment Payment { get; set; }
        public Customer Customer { get; set; }

        public bool IsUpdateProcess { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (nmTutar.Value == 0)
            {
                errorProvider1.SetError(nmTutar, "Lütfen tutar giriniz!");
                nmTutar.Focus();
                return;

            }
            else
            {
                errorProvider1.SetError(nmTutar, "");
            }
            if (cbTur.SelectedItem == null)
            {
                errorProvider1.SetError(cbTur, "Ödeme türü seçiniz!");
                cbTur.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cbTur, "");

            }
            if (txtAçıklama.Text == null)
            {
                errorProvider1.SetError(txtAçıklama, "Eksik veya hatalı bilgi");
                txtAçıklama.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtAçıklama, "");

            }

            Payment.PaymentType = cbTur.SelectedItem.ToString();
            Payment.Amount = (double)nmTutar.Value;
            Payment.Description = txtAçıklama.Text;
            Payment.TransactionDate = dtTarih.Value;
            Payment.Customer = Customer;


            DialogResult = DialogResult.OK;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            txtID.Text = Payment.Id.ToString();

            if (IsUpdateProcess)
            {
                var payment = BusinessLogic.GetPaymentById(Payment.Id);
                Customer = payment.Customer;

                txtMusteri.Text = payment.Customer.ToString();
                nmTutar.Value = (decimal)payment.Amount;
                dtTarih.Value = payment.TransactionDate;
                cbTur.SelectedItem = payment.PaymentType;
                txtAçıklama.Text = payment.Description.ToString();
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
    }
}
