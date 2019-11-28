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
                MessageBox.Show("Error! Please ensure valid inputs");
            }
            else
            {
                MessageBox.Show(
                    "Hello " + txtFirstName.Text + " " + txtLastName.Text + ". " +
                    "You are " + numAge.Value + " years old."
                );
            }
        }
    }
}
