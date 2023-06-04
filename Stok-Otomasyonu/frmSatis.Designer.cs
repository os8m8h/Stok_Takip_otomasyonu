namespace Stok_Otomasyonu
{
    partial class frmSatis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplamFiyatı = new System.Windows.Forms.TextBox();
            this.txtSatışFiyatı = new System.Windows.Forms.TextBox();
            this.txtMiktarı = new System.Windows.Forms.TextBox();
            this.txtÜrünAdı = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSatışİptal = new System.Windows.Forms.Button();
            this.btnSatışyap = new System.Windows.Forms.Button();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(347, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 371);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Location = new System.Drawing.Point(26, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri işlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD Soyad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(149, 101);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(149, 63);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(149, 29);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 22);
            this.txtTC.TabIndex = 0;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtToplamFiyatı);
            this.groupBox2.Controls.Add(this.txtSatışFiyatı);
            this.groupBox2.Controls.Add(this.txtMiktarı);
            this.groupBox2.Controls.Add(this.txtÜrünAdı);
            this.groupBox2.Controls.Add(this.txtBarkodNo);
            this.groupBox2.Location = new System.Drawing.Point(26, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 214);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Toplam Fİyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "BarkodNo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtToplamFiyatı
            // 
            this.txtToplamFiyatı.Location = new System.Drawing.Point(150, 149);
            this.txtToplamFiyatı.Name = "txtToplamFiyatı";
            this.txtToplamFiyatı.Size = new System.Drawing.Size(100, 22);
            this.txtToplamFiyatı.TabIndex = 4;
            this.txtToplamFiyatı.TextChanged += new System.EventHandler(this.txtToplamFiyatı_TextChanged);
            // 
            // txtSatışFiyatı
            // 
            this.txtSatışFiyatı.Location = new System.Drawing.Point(150, 118);
            this.txtSatışFiyatı.Name = "txtSatışFiyatı";
            this.txtSatışFiyatı.Size = new System.Drawing.Size(100, 22);
            this.txtSatışFiyatı.TabIndex = 3;
            this.txtSatışFiyatı.TextChanged += new System.EventHandler(this.txtSatışFiyatı_TextChanged);
            // 
            // txtMiktarı
            // 
            this.txtMiktarı.Location = new System.Drawing.Point(149, 90);
            this.txtMiktarı.Name = "txtMiktarı";
            this.txtMiktarı.Size = new System.Drawing.Size(102, 22);
            this.txtMiktarı.TabIndex = 2;
            this.txtMiktarı.Text = "1";
            this.txtMiktarı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiktarı.TextChanged += new System.EventHandler(this.txtMiktarı_TextChanged);
            // 
            // txtÜrünAdı
            // 
            this.txtÜrünAdı.Location = new System.Drawing.Point(150, 59);
            this.txtÜrünAdı.Name = "txtÜrünAdı";
            this.txtÜrünAdı.Size = new System.Drawing.Size(100, 22);
            this.txtÜrünAdı.TabIndex = 1;
            this.txtÜrünAdı.TextChanged += new System.EventHandler(this.txtÜrünAdı_TextChanged);
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(150, 31);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 22);
            this.txtBarkodNo.TabIndex = 0;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnekle.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnekle.Location = new System.Drawing.Point(408, 571);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(89, 37);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1162, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSatışİptal
            // 
            this.txtSatışİptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtSatışİptal.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSatışİptal.Location = new System.Drawing.Point(1162, 233);
            this.txtSatışİptal.Name = "txtSatışİptal";
            this.txtSatışİptal.Size = new System.Drawing.Size(107, 35);
            this.txtSatışİptal.TabIndex = 5;
            this.txtSatışİptal.Text = "Satış İptal";
            this.txtSatışİptal.UseVisualStyleBackColor = false;
            this.txtSatışİptal.Click += new System.EventHandler(this.txtSatışİptal_Click);
            // 
            // btnSatışyap
            // 
            this.btnSatışyap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSatışyap.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatışyap.Location = new System.Drawing.Point(981, 575);
            this.btnSatışyap.Name = "btnSatışyap";
            this.btnSatışyap.Size = new System.Drawing.Size(111, 33);
            this.btnSatışyap.TabIndex = 6;
            this.btnSatışyap.Text = "Satış Yap";
            this.btnSatışyap.UseVisualStyleBackColor = false;
            this.btnSatışyap.Click += new System.EventHandler(this.btnSatışyap_Click);
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(858, 578);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(0, 16);
            this.lblGenelToplam.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(706, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Genel Toplam";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 132);
            this.panel1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(974, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "Kategori";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1098, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Marka";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button10.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(401, 46);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(153, 40);
            this.button10.TabIndex = 5;
            this.button10.Text = "Ürün Ekleme";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button9.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(742, 46);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(191, 40);
            this.button9.TabIndex = 4;
            this.button9.Text = "Satışları Listeleme";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button7.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(560, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(157, 40);
            this.button7.TabIndex = 2;
            this.button7.Text = "Ürün Liteleme";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button6.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(199, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 40);
            this.button6.TabIndex = 1;
            this.button6.Text = "Müşteri Listeleme";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(26, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "Müşteri Ekleme";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmSatis
            // 
            this.AcceptButton = this.btnekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1388, 767);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.btnSatışyap);
            this.Controls.Add(this.txtSatışİptal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplamFiyatı;
        private System.Windows.Forms.TextBox txtSatışFiyatı;
        private System.Windows.Forms.TextBox txtMiktarı;
        private System.Windows.Forms.TextBox txtÜrünAdı;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button txtSatışİptal;
        private System.Windows.Forms.Button btnSatışyap;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}

