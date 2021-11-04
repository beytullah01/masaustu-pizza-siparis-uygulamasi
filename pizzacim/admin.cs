using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace pizzacim { 
 
    public partial class login : Form
    {
      

        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MessageBox.Show("PİZZACIM YÖNETİM PANELİNE HOŞGELDİNİZ. İŞLEMLER İÇİN LÜTFEN GİRİŞ YAPINIZ.");
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan bagg = new baglan();
            
            MySqlConnection con = new MySqlConnection(bagg.baglanti());
            con.Open();
            
           


            string komut = "SELECT *FROM admin WHERE (admin='"+kullanici.Text+"') and (admin_sifre='"+sifre.Text+"')  ";

            MySqlDataAdapter sorgu = new MySqlDataAdapter(komut, con);
            DataTable datalarım = new DataTable();

            sorgu.Fill(datalarım);

            
            if (datalarım.Rows.Count==1 )
            {

                MessageBox.Show("giris basarılı,sipariş alma ekranına yönlendiriyorsunuz");
                this.Hide();
                siparis_form form1 = new siparis_form();
                form1.Show();
            }
            else
            {
                MessageBox.Show("giris basarısız. kullanıcı adı ve şifrenizi kontrol ediniz.");

            }

          




        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void kullanici_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void sifre_TextChanged_1(object sender, EventArgs e)
        {
        
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            siparis_form yeni = new siparis_form();
            this.Hide();
            yeni.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sifre.PasswordChar= '\0';

            }
            else
            {
                sifre.PasswordChar = '*';

            }
        }
    }
}
