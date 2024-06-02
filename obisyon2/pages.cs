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
    public partial class pages : Form
    {
        public pages()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form app = new direction();
            app.ShowDialog();
        }

        private void pages_Load(object sender, EventArgs e)
        {

        }
    }
}
