using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wildcat_FlashMath
{
    public partial class enter_email : Form
    {
        public enter_email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["email"] = textBox1.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void enter_email_Load(object sender, EventArgs e)
        {
            label2.Text = "Currently set email: " + Properties.Settings.Default.email;
        }
    }
}
