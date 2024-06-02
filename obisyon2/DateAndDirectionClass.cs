using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obisyon2
{
    
    public class DateAndDirectionClass
    {
        app app = new app();
        public void AddButtonsFromClass()
        {

            //panelbutton.Controls.Clear();
            app.panelbutton.Controls.Clear();
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



                app.panelbutton.Controls.Add(btnArray[n]);

                xPos += btnArray[n].Width;

                var nn = n + 1;


                btnArray[n].Text = nn.ToString();
                btnArray[n].Click += new EventHandler(app.ClickButton);

                n++;


                //// Veritabanı nesnesinin olusturuldugu yer 
                //OleDbConnection connection2 = new OleDbConnection();
                //string res2;
                //OleDbCommand command2;
                //OleDbDataReader reader2;
                //DataTable dt2 = new DataTable();
                //connection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\MONSTER\\Documents\\obisyondb.accdb";
                ////res2 = "SELECT * from " + label1.Text + ""  ;
                //res2 = "SELECT * FROM yolcular WHERE kalkis_noktasi = '" + label3.Text + "' AND varis_noktasi = '" + label4.Text + "' AND firma = '" + label1.Text + "'AND tarih = '" + label5.Text + "'";
                //dt2.Clear();
                //connection2.Open();
                //command2 = new OleDbCommand(res2, connection2);
                //reader2 = command2.ExecuteReader();
                //dt2.Load(reader2);

                //for (int k = 0; k < dt2.Rows.Count; k++)
                //{
                //    if (dt2.Rows[k][5] != null)
                //    {
                //        int fullplace = Convert.ToInt32(dt2.Rows[k][5]);
                //        btnArray[fullplace - 1].Enabled = false;
                //        btnArray[fullplace - 1].Text = "Dolu";
                //        btnArray[fullplace - 1].BackColor = Color.Red;
                //    }
                //    else
                //    {
                //        label2.Text = "a";
                //    }
                //}
                //connection2.Close();


            }
        }
    }
}
