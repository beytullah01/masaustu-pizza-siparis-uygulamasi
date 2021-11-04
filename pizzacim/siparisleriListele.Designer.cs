namespace pizzacim
{
    partial class siparisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparisler));
            this.siparisGoster = new System.Windows.Forms.Button();
            this.siparis_ekrranı = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // siparisGoster
            // 
            this.siparisGoster.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.siparisGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisGoster.ForeColor = System.Drawing.Color.DarkCyan;
            this.siparisGoster.Location = new System.Drawing.Point(1071, 615);
            this.siparisGoster.Name = "siparisGoster";
            this.siparisGoster.Size = new System.Drawing.Size(189, 38);
            this.siparisGoster.TabIndex = 9;
            this.siparisGoster.Text = "SİL";
            this.siparisGoster.UseVisualStyleBackColor = false;
            this.siparisGoster.Click += new System.EventHandler(this.siparisGoster_Click_1);
            // 
            // siparis_ekrranı
            // 
            this.siparis_ekrranı.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.siparis_ekrranı.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("siparis_ekrranı.BackgroundImage")));
            this.siparis_ekrranı.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.siparis_ekrranı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparis_ekrranı.ForeColor = System.Drawing.Color.Green;
            this.siparis_ekrranı.Location = new System.Drawing.Point(23, 12);
            this.siparis_ekrranı.Name = "siparis_ekrranı";
            this.siparis_ekrranı.Size = new System.Drawing.Size(286, 78);
            this.siparis_ekrranı.TabIndex = 13;
            this.siparis_ekrranı.Text = "siparis ekranına dön";
            this.siparis_ekrranı.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.siparis_ekrranı.UseVisualStyleBackColor = false;
            this.siparis_ekrranı.Click += new System.EventHandler(this.siparis_ekrranı_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(1175, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 88);
            this.button2.TabIndex = 14;
            this.button2.Text = "çıkış";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 482);
            this.dataGridView1.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(483, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 22);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(453, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "ara";
            // 
            // siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.siparis_ekrranı);
            this.Controls.Add(this.siparisGoster);
            this.MaximizeBox = false;
            this.Name = "siparisler";
            this.Text = "Siparişler Listesi";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button siparisGoster;
        private System.Windows.Forms.Button siparis_ekrranı;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}