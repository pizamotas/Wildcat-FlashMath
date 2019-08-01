using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wildcat_FlashMath
{
    public partial class background_info : Form
    {
        public List<string> lesons = new List<string>();
        public background_info()
        {
            InitializeComponent();
        }

        private void background_info_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
