using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace obisyon2
{
    public partial class direction : Form
    {
        public direction()
        {
            InitializeComponent();
        }
       
        OleDbConnection connection = new OleDbConnection();
        string res;
        OleDbCommand command;
        OleDbDataReader reader;
        

       

        private void direction_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MM yyyy";

            button1.Enabled = false;
            try
            {
                connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\MONSTER\\Documents\\obisyondb.accdb";
                res = "SELECT * from  cities";
                connection.Open();
                command = new OleDbCommand(res,connection);
                reader = command.ExecuteReader();

               
                comboBox2.Items.Clear();

                while (reader.Read())
                {
                    comboBox2.Items.Add(reader.GetString(1));
                    comboBox3.Items.Add(reader.GetString(1));
                }

                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
               
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox2.SelectedIndex == comboBox3.SelectedIndex) {
                MessageBox.Show("Lütfen Farklı Bir Güzeergah Seçiniz");
                
            }
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox2.SelectedIndex == comboBox3.SelectedIndex)
            {
                MessageBox.Show("Lütfen Farklı Bir Güzeergah Seçiniz");
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            

            app app = new app();
            app.label3.Text = comboBox2.SelectedItem.ToString();
            app.label4.Text = comboBox3.SelectedItem.ToString();
            app.label5.Text = dateTimePicker1.Value.ToString().Split(' ')[0];
            app.ShowDialog();
            
        }

        
    }
}
