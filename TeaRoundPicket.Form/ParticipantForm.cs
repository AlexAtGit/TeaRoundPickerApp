using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AdamMatthew.TeaRoundPicket.UI
{
    public partial class ParticipantForm : Form
    {
        private string _namePattern = @"^([a-zA-Z]+?)([-\s'][a-zA-Z]+)*?$";
        public ParticipantForm()
        {
            InitializeComponent();
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            // Set focus on textBoxFirstname
            textBoxFirstname.Focus();
            if (!Validate()) return;
            Firstname = textBoxFirstname.Text.Trim();

            // Set focus on textBoxFirstname
            textBoxLastname.Focus();
            if (!Validate()) return;
            Lastname  = textBoxLastname.Text.Trim();

            DialogResult = DialogResult.OK;
        }

        private void textBoxFirstname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstname.Text))
            {
                errorProvider.SetError(textBoxFirstname, "First name required!");
            }
            else if (!Regex.IsMatch(textBoxFirstname.Text, _namePattern))
            {
                errorProvider.SetError(textBoxFirstname, "Please enter a proper first name");
            }
            else
            {
                errorProvider.SetError(textBoxFirstname, null);
            }
        }

        private void textBoxLastname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLastname.Text))
            {
                errorProvider.SetError(textBoxLastname, "Last name required!");
            }
            else if (!Regex.IsMatch(textBoxLastname.Text, _namePattern))
            {
                errorProvider.SetError(textBoxLastname, "Please enter a proper first name");
            }
            else
            {
                errorProvider.SetError(textBoxLastname, null);
            }
        }
    }
}
