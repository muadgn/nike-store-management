namespace NikeStore
{
    public class CustomTextBox : TextBox
    {
        public string PlaceholderText { get; set; }

        public bool IsValid()
        {
            return !(string.IsNullOrWhiteSpace(this.Text) || this.Text == this.PlaceholderText);
        }

        public bool IsValid(ErrorProvider errorProvider)
        {
            var isValid = IsValid();
            if (!isValid)
            {
                errorProvider.SetError(this, "Eksik veya hatalı giriş");
                this.Focus();
            }
            return isValid;
        }
    }
}
