using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWindow
{
    public partial class About : Form
    {
        private Form1 form1;
        public About(Form1 fr)
        {
            InitializeComponent();
            form1 = fr;

        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Close();
        }
    }
}
