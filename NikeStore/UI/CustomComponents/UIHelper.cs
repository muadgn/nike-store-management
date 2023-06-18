namespace NikeStore
{
    public class UIHelper
    {
        public static void CustomTextBox_GotFocus(object? sender, EventArgs e)
        {
            if (sender is not CustomTextBox myTextBox)
                return;

            if (string.IsNullOrWhiteSpace(myTextBox.PlaceholderText))
                return;

            if (myTextBox.Text == myTextBox.PlaceholderText)
                myTextBox.Text = "";

        }

        public static void CustomTextBox_LostFocus(object? sender, EventArgs e)
        {
            if (sender is not CustomTextBox myTextBox)
                return;

            if (string.IsNullOrWhiteSpace(myTextBox.PlaceholderText))
                return;

            if (string.IsNullOrWhiteSpace(myTextBox.Text))
                myTextBox.Text = myTextBox.PlaceholderText;

        }

        public static int After(Control control, int paddingAfter = 0)
        {
            return control.Location.Y + control.Size.Height + paddingAfter;
        }

        public static int CenterX(Control control, Form frm)
        {
            return (frm.ClientSize.Width - control.Size.Width) / 2;
        }
    }
}
