namespace obisyon2
{
    partial class buyTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbbayan = new System.Windows.Forms.RadioButton();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rdbbay = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.obisyondbDataSet = new obisyon2.obisyondbDataSet();
            this.bussBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bussTableAdapter = new obisyon2.obisyondbDataSetTableAdapters.bussTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kalkis = new System.Windows.Forms.Label();
            this.varis = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.obisyondbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bussBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(262, 273);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 26);
            this.button2.TabIndex = 32;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 273);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 31;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rdbbayan
            // 
            this.rdbbayan.AutoSize = true;
            this.rdbbayan.Location = new System.Drawing.Point(262, 229);
            this.rdbbayan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbbayan.Name = "rdbbayan";
            this.rdbbayan.Size = new System.Drawing.Size(67, 20);
            this.rdbbayan.TabIndex = 30;
            this.rdbbayan.Text = "Bayan";
            this.rdbbayan.UseVisualStyleBackColor = true;
            this.rdbbayan.CheckedChanged += new System.EventHandler(this.checkedchange);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(193, 184);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(153, 22);
            this.maskedTextBox1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Soyad";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 142);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 22);
            this.textBox2.TabIndex = 26;
            // 
            // rdbbay
            // 
            this.rdbbay.AutoSize = true;
            this.rdbbay.Location = new System.Drawing.Point(170, 229);
            this.rdbbay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbbay.Name = "rdbbay";
            this.rdbbay.Size = new System.Drawing.Size(52, 20);
            this.rdbbay.TabIndex = 25;
            this.rdbbay.Text = "Bay";
            this.rdbbay.UseVisualStyleBackColor = true;
            this.rdbbay.CheckedChanged += new System.EventHandler(this.checkedchange);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 23;
            // 
            // obisyondbDataSet
            // 
            this.obisyondbDataSet.DataSetName = "obisyondbDataSet";
            this.obisyondbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bussBindingSource
            // 
            this.bussBindingSource.DataMember = "buss";
            this.bussBindingSource.DataSource = this.obisyondbDataSet;
            // 
            // bussTableAdapter
            // 
            this.bussTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Otobus Firmasi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "no";
            // 
            // kalkis
            // 
            this.kalkis.AutoSize = true;
            this.kalkis.Location = new System.Drawing.Point(43, 338);
            this.kalkis.Name = "kalkis";
            this.kalkis.Size = new System.Drawing.Size(42, 16);
            this.kalkis.TabIndex = 35;
            this.kalkis.Text = "kalkis";
            // 
            // varis
            // 
            this.varis.AutoSize = true;
            this.varis.Location = new System.Drawing.Point(94, 338);
            this.varis.Name = "varis";
            this.varis.Size = new System.Drawing.Size(36, 16);
            this.varis.TabIndex = 36;
            this.varis.Text = "varis";
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Location = new System.Drawing.Point(145, 337);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(32, 16);
            this.tarih.TabIndex = 37;
            this.tarih.Text = "tarih";
            // 
            // buyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 373);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.varis);
            this.Controls.Add(this.kalkis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbbayan);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rdbbay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "buyTicket";
            this.Text = "buyTicket";
            this.Load += new System.EventHandler(this.buyTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obisyondbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bussBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RadioButton rdbbayan;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.RadioButton rdbbay;
        private System.Windows.Forms.Label label7;
        private obisyondbDataSet obisyondbDataSet;
        private System.Windows.Forms.BindingSource bussBindingSource;
        private obisyondbDataSetTableAdapters.bussTableAdapter bussTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label kalkis;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label varis;
        public System.Windows.Forms.Label tarih;
    }
}