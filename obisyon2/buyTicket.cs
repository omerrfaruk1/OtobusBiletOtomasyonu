using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace obisyon2
{
    public partial class buyTicket : Form
    {
        OleDbConnection connection = new OleDbConnection();
        string res;
        OleDbCommand command;
        OleDbDataReader reader;
        DataTable dt = new DataTable();

        

        public buyTicket()
        {
            InitializeComponent();
            
        }


        private void buyTicket_Load(object sender, EventArgs e)
        {
            
            button2.Enabled = false;
        }

        private void checkedchange(object  sender, EventArgs e)
        {
            if(rdbbay.Checked == true || rdbbayan.Checked == true)
            {
                button2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text) ) 
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }else
            {
                string checkboxvalue;
                if (rdbbay.Checked)
                {
                    checkboxvalue = "bay";
                }else {
                    checkboxvalue = "bayan";
                }
                addToDb(checkboxvalue); 
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        } 
       
        public void addToDb(object sender)
        {
            
            //label2.Te
            Form drc = new direction();
            
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\MONSTER\\Documents\\obisyondb.accdb";
            
            connection.Open();
            //string ekle = "insert into " +label2.Text+"(ad,soyad,telefon,cinsiyet,koltuk) values (@ad,@soyad,@telefon,@cinsiyet,@koltuk)";
            string ekle = "insert into yolcular (ad,soyad,telefon,cinsiyet,koltuk,kalkis_noktasi,varis_noktasi,tarih,firma) values (@ad,@soyad,@telefon,@cinsiyet,@koltuk,@kalkis,@varis,@tarih,@firma)";
            OleDbCommand komut = new OleDbCommand(ekle, connection);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@telefon", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@cinsiyet", sender.ToString());
            komut.Parameters.AddWithValue("@koltuk", label3.Text);
            komut.Parameters.AddWithValue("@kalkis", kalkis.Text);
            komut.Parameters.AddWithValue("@varis", varis.Text);
            komut.Parameters.AddWithValue("@tarih", tarih.Text);
            komut.Parameters.AddWithValue("@firma", label2.Text);

            komut.ExecuteNonQuery();

        }

        }

    }

