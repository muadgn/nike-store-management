using NikeStore.BL;

namespace NikeStore.UI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;

            label1.Location = new Point(UIHelper.CenterX(label1, this), UIHelper.After(pictureBox1, 20));
            label2.Location = new Point(UIHelper.CenterX(label2, this), UIHelper.After(label1, 20));

            txtName.Location = new Point(UIHelper.CenterX(txtName, this), UIHelper.After(label2, 30));
            txtName.GotFocus += UIHelper.CustomTextBox_GotFocus;
            txtName.LostFocus += UIHelper.CustomTextBox_LostFocus;

            txtSurname.Location = new Point(UIHelper.CenterX(txtSurname, this), UIHelper.After(txtName, 5));
            txtSurname.GotFocus += UIHelper.CustomTextBox_GotFocus;
            txtSurname.LostFocus += UIHelper.CustomTextBox_LostFocus;

            txtEmail.Location = new Point(UIHelper.CenterX(txtEmail, this), UIHelper.After(txtSurname, 5));
            txtEmail.GotFocus += UIHelper.CustomTextBox_GotFocus;
            txtEmail.LostFocus += UIHelper.CustomTextBox_LostFocus;

            txtUsername.Location = new Point(UIHelper.CenterX(txtUsername, this), UIHelper.After(txtEmail, 5));
            txtUsername.GotFocus += UIHelper.CustomTextBox_GotFocus;
            txtUsername.LostFocus += UIHelper.CustomTextBox_LostFocus;

            txtPassword.Location = new Point(UIHelper.CenterX(txtPassword, this), UIHelper.After(txtUsername, 5));
            txtPassword.GotFocus += UIHelper.CustomTextBox_GotFocus;
            txtPassword.LostFocus += UIHelper.CustomTextBox_LostFocus;

            button1.Location = new Point(UIHelper.CenterX(button1, this), UIHelper.After(txtPassword, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtName.IsValid(errorProvider1)) return;
            if (!txtSurname.IsValid(errorProvider1)) return;
            if (!txtEmail.IsValid(errorProvider1)) return;
            if (!txtUsername.IsValid(errorProvider1)) return;
            if (!txtPassword.IsValid(errorProvider1)) return;

            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                PasswordClear = txtPassword.Text,
            };

            var result = BusinessLogic.UserRegister(user);
            if (result)
            {
                MessageBox.Show("kullanıcı oluşturuldu.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                return;
            }
            else
            {
                MessageBox.Show("kullanıcı zaten var veya bir sorun oluştu.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
