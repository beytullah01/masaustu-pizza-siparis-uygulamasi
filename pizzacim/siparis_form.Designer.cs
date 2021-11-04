namespace pizzacim
{
    partial class siparis_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparis_form));
            this.boyut = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hamurt_tipi = new System.Windows.Forms.ComboBox();
            this.kenar_tipi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pizza_turu = new System.Windows.Forms.ComboBox();
            this.siparis_al = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.sepet_guncelle = new System.Windows.Forms.Button();
            this.adet = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // boyut
            // 
            this.boyut.FormattingEnabled = true;
            this.boyut.Location = new System.Drawing.Point(210, 247);
            this.boyut.Name = "boyut";
            this.boyut.Size = new System.Drawing.Size(133, 24);
            this.boyut.TabIndex = 4;
            this.boyut.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Boyut";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Hamur Tipi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // hamurt_tipi
            // 
            this.hamurt_tipi.FormattingEnabled = true;
            this.hamurt_tipi.Location = new System.Drawing.Point(209, 146);
            this.hamurt_tipi.Name = "hamurt_tipi";
            this.hamurt_tipi.Size = new System.Drawing.Size(134, 24);
            this.hamurt_tipi.TabIndex = 7;
            this.hamurt_tipi.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // kenar_tipi
            // 
            this.kenar_tipi.FormattingEnabled = true;
            this.kenar_tipi.Location = new System.Drawing.Point(210, 198);
            this.kenar_tipi.Name = "kenar_tipi";
            this.kenar_tipi.Size = new System.Drawing.Size(133, 24);
            this.kenar_tipi.TabIndex = 25;
            this.kenar_tipi.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Kenar Tipi ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "EKSTRALAR";
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(208, 492);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(135, 22);
            this.soyad.TabIndex = 28;
            this.soyad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(208, 530);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(136, 22);
            this.telefon.TabIndex = 29;
            this.telefon.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(209, 570);
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(250, 121);
            this.adres.TabIndex = 31;
            this.adres.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(19, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ad";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(20, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Soyad";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(20, 605);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 36;
            this.label8.Text = "Adres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(20, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 24);
            this.label9.TabIndex = 37;
            this.label9.Text = "Telefon";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(13, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 25);
            this.label10.TabIndex = 42;
            this.label10.Text = "Pizzalar";
            // 
            // pizza_turu
            // 
            this.pizza_turu.FormattingEnabled = true;
            this.pizza_turu.Location = new System.Drawing.Point(209, 97);
            this.pizza_turu.Name = "pizza_turu";
            this.pizza_turu.Size = new System.Drawing.Size(134, 24);
            this.pizza_turu.TabIndex = 43;
            this.pizza_turu.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // siparis_al
            // 
            this.siparis_al.AutoEllipsis = true;
            this.siparis_al.BackColor = System.Drawing.Color.Honeydew;
            this.siparis_al.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("siparis_al.BackgroundImage")));
            this.siparis_al.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.siparis_al.CausesValidation = false;
            this.siparis_al.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siparis_al.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siparis_al.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siparis_al.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.siparis_al.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siparis_al.Location = new System.Drawing.Point(822, 615);
            this.siparis_al.Name = "siparis_al";
            this.siparis_al.Size = new System.Drawing.Size(207, 56);
            this.siparis_al.TabIndex = 44;
            this.siparis_al.Text = " sipariş al";
            this.siparis_al.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.siparis_al.UseVisualStyleBackColor = false;
            this.siparis_al.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(208, 428);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(135, 22);
            this.textBox6.TabIndex = 50;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(13, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 23);
            this.label11.TabIndex = 55;
            this.label11.Text = "Adet";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "FİŞ"});
            this.listBox1.Location = new System.Drawing.Point(873, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 242);
            this.listBox1.TabIndex = 56;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(208, 458);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(135, 22);
            this.ad.TabIndex = 57;
            this.ad.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // sepet_guncelle
            // 
            this.sepet_guncelle.BackColor = System.Drawing.Color.Honeydew;
            this.sepet_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sepet_guncelle.BackgroundImage")));
            this.sepet_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sepet_guncelle.CausesValidation = false;
            this.sepet_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sepet_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sepet_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sepet_guncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sepet_guncelle.Location = new System.Drawing.Point(512, 615);
            this.sepet_guncelle.Name = "sepet_guncelle";
            this.sepet_guncelle.Size = new System.Drawing.Size(244, 56);
            this.sepet_guncelle.TabIndex = 58;
            this.sepet_guncelle.Text = "sepeti guncelle";
            this.sepet_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sepet_guncelle.UseVisualStyleBackColor = false;
            this.sepet_guncelle.Click += new System.EventHandler(this.button4_Click);
            // 
            // adet
            // 
            this.adet.FormattingEnabled = true;
            this.adet.Location = new System.Drawing.Point(210, 286);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(133, 24);
            this.adet.TabIndex = 59;
            this.adet.SelectedIndexChanged += new System.EventHandler(this.adet_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(20, 426);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 24);
            this.label12.TabIndex = 33;
            this.label12.Text = "tutar";
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(161, 332);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 53);
            this.checkBox1.TabIndex = 50;
            this.checkBox1.Text = "kaşar";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.ThreeState = true;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.LavenderBlush;
            this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.Location = new System.Drawing.Point(255, 332);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 53);
            this.checkBox2.TabIndex = 50;
            this.checkBox2.Text = "zeytin";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.ThreeState = true;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.Color.LavenderBlush;
            this.checkBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox3.Location = new System.Drawing.Point(349, 332);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(88, 53);
            this.checkBox3.TabIndex = 50;
            this.checkBox3.Text = "salam";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.ThreeState = true;
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.BackColor = System.Drawing.Color.LavenderBlush;
            this.checkBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox4.ForeColor = System.Drawing.Color.Black;
            this.checkBox4.Location = new System.Drawing.Point(442, 332);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(88, 53);
            this.checkBox4.TabIndex = 50;
            this.checkBox4.Text = "sucuk";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.ThreeState = true;
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(1069, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 56);
            this.button1.TabIndex = 60;
            this.button1.Text = "siparişlerim";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(873, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 29);
            this.button2.TabIndex = 61;
            this.button2.Text = "fişi temizle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(1148, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 65);
            this.button3.TabIndex = 62;
            this.button3.Text = "çıkış";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Black;
            this.imageList2.Images.SetKeyName(0, "60px-Gnome-system-log-out.svg.png");
            this.imageList2.Images.SetKeyName(1, "undo_blue.png");
            this.imageList2.Images.SetKeyName(2, "ERP_Features_Sales.png");
            this.imageList2.Images.SetKeyName(3, "Png_Ok_isaretleri_pfeile_Resimleri_V100320181244_N58.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.InitialImage = global::pizzacim.Properties.Resources.food_pizza_tomatoes_1798543;
            this.pictureBox1.Location = new System.Drawing.Point(477, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // siparis_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.sepet_guncelle);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.siparis_al);
            this.Controls.Add(this.pizza_turu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kenar_tipi);
            this.Controls.Add(this.hamurt_tipi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boyut);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.Name = "siparis_form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "siparis ekranı";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.siparis_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox boyut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hamurt_tipi;
        private System.Windows.Forms.ComboBox kenar_tipi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox pizza_turu;
        private System.Windows.Forms.Button siparis_al;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Button sepet_guncelle;
        private System.Windows.Forms.ComboBox adet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}