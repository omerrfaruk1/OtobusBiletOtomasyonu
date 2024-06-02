using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obisyon2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "o" && textBox2.Text == "1")
            {
                Form pages = new pages();
                pages.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
