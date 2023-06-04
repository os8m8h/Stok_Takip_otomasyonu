namespace Stok_Otomasyonu
{
    partial class frmMüşteriListele
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
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(218, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 315);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGüncelle.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGüncelle.Location = new System.Drawing.Point(97, 287);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(91, 31);
            this.btnGüncelle.TabIndex = 21;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGücnelle);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 242);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(119, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(86, 212);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(102, 20);
            this.txtAdres.TabIndex = 19;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(86, 178);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(102, 20);
            this.txtTelefon.TabIndex = 18;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(86, 148);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(102, 20);
            this.txtAdSoyad.TabIndex = 17;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(86, 118);
            this.txtTC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(102, 20);
            this.txtTC.TabIndex = 16;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "TC";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSil.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(792, 72);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(71, 30);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(644, 32);
            this.txtTcAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(106, 20);
            this.txtTcAra.TabIndex = 23;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(580, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "TC Ara";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmMüşteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(880, 497);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTcAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMüşteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmMüşteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.Label label6;
    }
}