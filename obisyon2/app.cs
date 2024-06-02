using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace obisyon2
{
    public partial class app : Form
    {

        public app()
        {
            InitializeComponent();
    }

        OleDbConnection connection = new OleDbConnection();
        string res;
        OleDbCommand command;
        OleDbDataReader reader;
        DataTable dt = new DataTable();
        


        private void app_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\MONSTER\\Documents\\obisyondb.accdb";
            res = "SELECT * from  buss";
            dt.Clear();
            connection.Open();
            command = new OleDbCommand(res, connection);
            reader = command.ExecuteReader();
            dt.Load(reader);

            label13.Text = " \t     Saat: " + dt.Rows[3][4].ToString() + " \t     Kalkış Noktası: " + label3.Text + " \t     Varış Noktası: " +label4.Text;
            label17.Text =  " \t   Saat: "+ dt.Rows[1][4].ToString() + " \t     Kalkış Noktası: " + label3.Text + " \t     Varış Noktası: " + label4.Text; ;
            label18.Text =  " \t   Saat: " + dt.Rows[2][4].ToString() + " \t     Kalkış Noktası: " + label3.Text + " \t     Varış Noktası: " + label4.Text; ;
            label19.Text =  " \t   Saat: " + dt.Rows[0][4].ToString() + " \t     Kalkış Noktası: " + label3.Text + " \t     Varış Noktası: " + label4.Text; ;
            connection.Close();



            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\MONSTER\\Documents\\obisyondb.accdb";
            res = "SELECT fiyat FROM busprice WHERE (konum1 = '"+label3.Text+ "' AND konum2 = '" + label4.Text + "') OR (konum1 = '" + label4.Text + "' AND konum2 = '" + label3.Text + "');";
            dt.Clear();
            connection.Open();
            command = new OleDbCommand(res, connection);
            reader = command.ExecuteReader();
            Random random = new Random();

            if (reader.Read())
            {
                int priceconvert = Convert.ToInt32(reader["fiyat"]);

                int randomNumber = random.Next(-50, 51);
                int sonuc = priceconvert + randomNumber;
                label6.Text = "Bilet fiyatı: " + sonuc.ToString();

                randomNumber = random.Next(-100, 101);
                sonuc = priceconvert + randomNumber;
                label7.Text = "Bilet fiyatı: " + sonuc.ToString();


                randomNumber = random.Next(-100, 101);
                sonuc = priceconvert + randomNumber;
                label8.Text = "Bilet fiyatı: " + sonuc.ToString();


                randomNumber = random.Next(-100, 101);
                sonuc = priceconvert + randomNumber;
                label9.Text = "Bilet fiyatı: " + sonuc.ToString();
            }
            else
            {
                label6.Text = res;
            }

        }

        private void AddButtons()
        {
            
            panelbutton.Controls.Clear();

            int yPos = 0;
            int xPos = 0;


            Button[] btnArray = new Button[32];

            for (int i = 0; i < 32; i++)
            {

                btnArray[i] = new Button();
            }
            
            int n = 0;

            while (n < 32)
            {

                btnArray[n].Tag = n + 1;
                btnArray[n].Width = 40;
                btnArray[n].Height = 40;
                btnArray[n].BackColor = Color.Gray;
                


                switch (n)
                {
                    case 2:
                        xPos = 120;
                        yPos = 0;
                        break;
                    case 4:
                        xPos = 0;
                        yPos = 40;
                        break;
                    case 6:
                        xPos = 120;
                        yPos = 40;
                        break;
                    case 8:
                        xPos = 0;
                        yPos = 80;
                        break;
                    case 10:
                        xPos = 120;
                        yPos = 80;
                        break;
                    case 12:
                        xPos = 0;
                        yPos = 120;
                        break;
                    case 14:
                        xPos = 120;
                        yPos = 120;
                        break;
                    case 16:
                        xPos = 0;
                        yPos = 160;
                        break;
                    case 18:
                        xPos = 120;
                        yPos = 160;
                        break;
                    case 20:
                        xPos = 0;
                        yPos = 200;
                        break;
                    case 22:
                        xPos = 120;
                        yPos = 200;
                        break;
                    case 24:
                        xPos = 0;
                        yPos = 240;
                        break;
                    case 26:
                        xPos = 120;
                        yPos = 240;
                        break;
                    case 28:
                        xPos = 0;
                        yPos = 280;
                        break;
                    case 30:
                        xPos = 120;
                        yPos = 280;
                        break;
                        
                }

                
                btnArray[n].Top = yPos;
                btnArray[n].Left = xPos;
                
                

                panelbutton.Controls.Add(btnArray[n]);

                xPos += btnArray[n].Width;

                var nn = n + 1;

                
                btnArray[n].Text = nn.ToString();
                btnArray[n].Click += new EventHandler(ClickButton);

                n++;
                
                
                // Veritabanı nesnesinin olusturuldugu yer 
                OleDbConnection connection2 = new OleDbConnection();
                string res2;
                OleDbCommand command2;
                OleDbDataReader reader2;
                DataTable dt2 = new DataTable();
                connection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\MONSTER\\Documents\\obisyondb.accdb";
                res2 = "SELECT * FROM yolcular WHERE kalkis_noktasi = '" + label3.Text + "' AND varis_noktasi = '" + label4.Text + "' AND firma = '"+label1.Text+ "'AND tarih = '"+label5.Text+"'";
                dt2.Clear();
                connection2.Open();
                command2 = new OleDbCommand(res2, connection2);
                reader2 = command2.ExecuteReader();
                dt2.Load(reader2);
                
                for(int k = 0; k < dt2.Rows.Count; k++)
                {
                    if(dt2.Rows[k][5] != null)
                    {
                        int fullplace = Convert.ToInt32(dt2.Rows[k][5]);
                        btnArray[fullplace - 1].Enabled = false;
                        btnArray[fullplace - 1].Text = "Dolu";
                        btnArray[fullplace - 1].BackColor = Color.Red ;
                    }
                    else
                    {
                        label2.Text = "a";
                    }
                }
                connection2.Close();
                

            }
        }

        
        public   void ClickButton(object sender, EventArgs e)
        {
            
            
            Button btn = (Button)sender;
            
            // app Formunda ki Verilerin BuyTicket'a Gönderildiği Kısım
            buyTicket buyticket = new buyTicket();
            buyticket.label2.Text = label1.Text;
            buyticket.label3.Text = btn.Text;
            buyticket.kalkis.Text = label3.Text;
            buyticket.varis.Text = label4.Text;
            buyticket.tarih.Text = label5.Text;
            buyticket.label4.Text = btn.Text + " Numaralı Koltuk İle İşlem Yapıyorsunuz";
            
            DialogResult sonuc = buyticket.ShowDialog();

            
            if (sonuc == DialogResult.OK)
            {
                
                if (buyticket.rdbbay.Checked)
                {
                    btn.BackColor = Color.Blue;
                }
                if (buyticket.rdbbayan.Checked)
                {
                    btn.BackColor = Color.Pink;
                }
                
            }
            
        }
       
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = pictureBox1.Image;
            label1.Text = "sbatman";
            AddButtons();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = pictureBox2.Image;
            label1.Text = "mseyhat";
            AddButtons();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = pictureBox3.Image;
            label1.Text = "sec";
            AddButtons();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = pictureBox4.Image;
            label1.Text = "martur";
            AddButtons();
        }
    }
}
