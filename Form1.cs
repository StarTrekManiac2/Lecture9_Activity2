using System;
using System.Windows.Forms;

namespace Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((txtFirstName.TextLength < 1) && (txtLastName.TextLength < 1))
            {
                // Message Box displays error message if input boxes are empty
                MessageBox.Show("Please ensure input boxes contain 1 or more characters!");
            }
            else
            {
                MessageBox.Show(
                    "Hello " + txtFirstName.Text + " " + txtLastName.Text + ". " +
                    "You are " + numAge.Value + " years old."
                );
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If current key is a number, do not input
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If current key is a number, do not input
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
