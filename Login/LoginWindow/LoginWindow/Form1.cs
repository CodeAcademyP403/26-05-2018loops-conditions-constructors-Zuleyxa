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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text == "") && (textBoxSurname.Text == "") &&
                (textBoxPassword.Text == "") && (textBoxEmail.Text == ""))
            {
                this.Hide();
                About about = new About(this);
                about.ShowDialog();
                MessageBox.Show("Congratulations,you login is true");
            }

            else
            {
                MessageBox.Show("Error");
            }


        }


    }
      
 }

