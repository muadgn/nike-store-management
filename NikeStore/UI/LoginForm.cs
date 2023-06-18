using NikeStore.BL;
using NikeStore.UI;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace NikeStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;

            label1.Location = new Point(UIHelper.CenterX(label1, this), UIHelper.After(pictureBox1, 20));
            label2.Location = new Point(UIHelper.CenterX(label2, this), UIHelper.After(label1, 20));

            textBox1.Location = new Point(UIHelper.CenterX(textBox1, this), UIHelper.After(label2, 30));
            textBox1.GotFocus += UIHelper.CustomTextBox_GotFocus;
            textBox1.LostFocus += UIHelper.CustomTextBox_LostFocus;

            textBox2.Location = new Point(UIHelper.CenterX(textBox2, this), UIHelper.After(textBox1, 10));
            textBox2.GotFocus += UIHelper.CustomTextBox_GotFocus;
            textBox2.LostFocus += UIHelper.CustomTextBox_LostFocus;

            button1.Location = new Point(UIHelper.CenterX(button1, this), UIHelper.After(textBox2, 20));

            linkRegister.Location = new Point(UIHelper.CenterX(linkRegister, this), UIHelper.After(button1, 10));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.IsValid(errorProvider1)) return;
            if (!textBox2.IsValid(errorProvider1)) return;

            var user = BusinessLogic.UserLogin(textBox1.Text, textBox2.Text);
            if (user is null)
            {
                MessageBox.Show("kullanıcı bulunamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MainForm mainForm = new MainForm
            {
                User = user,
            };

            Hide();
            mainForm.Show();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var register = new RegisterForm();
            var result = register.ShowDialog();
        }
    }
}
