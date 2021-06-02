using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW12
{
    public partial class Form1 : Form
    {
        //Initializes the Components in the window
        public Form1()
        {
            InitializeComponent();
            
        }

        //Provides action for the when the button is click
        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "confirm")
            {
                string message = string.Format("Confirmed");
                MessageBox.Show(message);
            }
            else
            {
                string message = string.Format("Not Confirmed");
                MessageBox.Show(message);
            }
        }

        //Provides action when the checkbox is clicked
        private void richTextBox1_Changed(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                if (!"confirm".StartsWith(richTextBox1.Text))
                {
                    MessageBox.Show(string.Format("'confirm does not contain '{0}'", richTextBox1.Text));
                }
            }
        }
    }
}
