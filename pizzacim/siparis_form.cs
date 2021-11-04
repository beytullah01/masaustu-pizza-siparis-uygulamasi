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

namespace pizzacim
{
    public partial class siparis_form : Form
    {
        public siparis_form()
        {
            InitializeComponent();
        }
        public int toplamtutar = 30;
        public  string cesit1, cesit2, cesit3, cesit4  = " ";
       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt32(adet.SelectedItem);
            if (boyut.SelectedItem == "küçük boy")
            {
                toplamtutar = 30;
                textBox6.Text =Convert.ToString( toplamtutar * fiyat);
            }
            if (boyut.SelectedItem == "orta boy")
            {
                toplamtutar = 45;
                textBox6.Text = Convert.ToString(toplamtutar * fiyat);
            }
            if (boyut.SelectedItem == "büyük boy")
            {
                toplamtutar = 60;
                textBox6.Text = Convert.ToString(toplamtutar * fiyat);

            }

        }

        private void siparis_form_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            boyut.Items.Add("küçük boy");
                boyut.Items.Add("orta boy");
                boyut.Items.Add("büyük boy");
                
                hamurt_tipi.Items.Add("Klasik");
                hamurt_tipi.Items.Add("İnce");
                hamurt_tipi.Text = "klasik";
                
                 kenar_tipi.Items.Add("Simit kenar");
                 kenar_tipi.Items.Add("Peynir kenar");
                 kenar_tipi.Text = "Simit ";

            
                pizza_turu.Items.Add("EFSANE BEŞLİ");
                pizza_turu.Items.Add("AKDENİZ");
                pizza_turu.Items.Add("PATSO");
                pizza_turu.Items.Add("VEJETERRA");
                pizza_turu.Items.Add("PARTİERRA");
                pizza_turu.Text = "EFSANE BEŞLİ";

            
            

            for (int i = 1; i < 10; i++)
            {
                adet.Items.Add(i);

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TEXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (pizza_turu.SelectedIndex ==0)
            {
                pictureBox1.ImageLocation = "TR.jpg";

            }
            if (pizza_turu.SelectedIndex == 1)
            {
                pictureBox1.ImageLocation = "TR1.jpg";

            }
            if (pizza_turu.SelectedIndex == 2)
            {
                pictureBox1.ImageLocation = "TR2.jpg";

            }
            if (pizza_turu.SelectedIndex == 3)
            {
                pictureBox1.ImageLocation = "TR3.jpg";

            }
            if (pizza_turu.SelectedIndex == 4)
            {
                pictureBox1.ImageLocation = "TR4.jpg";

            }

        }

       

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("siparişiniz alındı");

            baglan bagg = new baglan();

            MySqlConnection con = new MySqlConnection(bagg.baglanti());
            con.Open();

         //   string cesit1, cesit2, cesit3, cesit4  = " ";
            if (checkBox1.Checked)
            {
               cesit1 = "kaşar";
            }
            if (checkBox2.Checked)
            {
                 cesit2= "zeytin";
            }
            if (checkBox3.Checked)
            {
                 cesit3 = "salam";
            }
            if (checkBox4.Checked)
            {
                cesit4= "sucuk";
            }
            string pizza_icerik = cesit1 + cesit2 + cesit3 + cesit4 ;
           

            string komut = "INSERT INTO  siparisler(s_musteri_adsoyad,s_musteri_telefon,s_musteri_adres, s_pizzalar,s_hamur_tipi" +
                ", s_adet,s_tutar,s_kenartipi,s_pizza_icerik) VALUES('"
                + ad.Text+ " "+soyad.Text+ "','" + telefon.Text + "','" + adres.Text + "','" + pizza_turu.SelectedItem.ToString()+ "','"
                + hamurt_tipi.SelectedItem.ToString() + "','" + adet.SelectedItem.ToString() + "','" + textBox6.Text.ToString() + "'," +
                "'" + kenar_tipi.SelectedItem.ToString() + "','" + pizza_icerik + "') ";
           


            MySqlCommand sorgu = new MySqlCommand(komut, con);
            MySqlDataReader datalarım = sorgu.ExecuteReader();

            
            con.Close();
            
            con.Open();

            string komut1 = "SELECT * FROM siparisler  where s_musteri_telefon='" +telefon.Text+ "'";
            MySqlCommand sorgu1 = new MySqlCommand(komut1, con);
            MySqlDataReader datalarım1 = sorgu1.ExecuteReader();

            while (datalarım1.Read()){
                 listBox1.Items.Add(datalarım1["siparis_id"].ToString());
                 listBox1.Items.Add("ad:"+datalarım1["s_musteri_adsoyad"].ToString());
                 listBox1.Items.Add("telefon:"+datalarım1["s_musteri_telefon"].ToString());
                 listBox1.Items.Add("adres:"+datalarım1["s_musteri_adres"].ToString());
                 listBox1.Items.Add("pizza:" + datalarım1["s_pizzalar"].ToString());
                 listBox1.Items.Add("ekstralar:" + datalarım1["s_pizza_icerik"].ToString());
                 listBox1.Items.Add("kenar tipi:" + datalarım1["s_kenartipi"].ToString());
                 listBox1.Items.Add("adet:" + datalarım1["s_adet"].ToString());
                 listBox1.Items.Add("toplam tutar:" + datalarım1["s_tutar"].ToString());
                 listBox1.Items.Add("sipariş tarihi:" + datalarım1["s_tarihi"].ToString());
            }
         
            
             con.Close(); 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            siparisler form1 = new siparisler();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            Application.Exit();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz güncellendi");


            baglan bagg = new baglan();

            MySqlConnection con = new MySqlConnection(bagg.baglanti());
            con.Open();

        //****************************************************
            if (checkBox1.Checked)
            {
                cesit1 = "kaşar";
            }
            if (checkBox2.Checked)
            {
                cesit2 = "zeytin";
            }
            if (checkBox3.Checked)
            {
                cesit3 = "salam";
            }
            if (checkBox4.Checked)
            {
                cesit4 = "sucuk";
            }

            string pizza_icerik = cesit1 + cesit2 + cesit3 + cesit4;

       //****************************************************************     
            
            
            string komut = "UPDATE siparisler SET  s_pizzalar='" +pizza_turu.SelectedItem.ToString()+ "',s_hamur_tipi='" + hamurt_tipi.SelectedItem.ToString() 
                + "',s_pizza_icerik='" +pizza_icerik + "',s_adet='" + adet.Text.ToString()+"',s_tutar='"+textBox6.Text+ "',s_kenartipi='" + kenar_tipi.SelectedItem.ToString() + "' WHERE  s_musteri_telefon='"+telefon.Text+"' ";
            
            MySqlCommand sorgu = new MySqlCommand(komut, con);
            MySqlDataReader datalarım = sorgu.ExecuteReader();

            con.Close();
            con.Open();
               

             string komut1 = "SELECT * FROM siparisler  WHERE s_musteri_telefon='" + telefon.Text + "'";
             MySqlCommand sorgu1 = new MySqlCommand(komut1, con);
             MySqlDataReader datalarım1 = sorgu1.ExecuteReader();
                
                while (datalarım1.Read())
                {
                listBox1.Items.Clear();

                listBox1.Items.Add(datalarım1["siparis_id"].ToString());
                listBox1.Items.Add("ad:" + datalarım1["s_musteri_adsoyad"].ToString());
                listBox1.Items.Add("telefon:" + datalarım1["s_musteri_telefon"].ToString());
                listBox1.Items.Add("adres"+datalarım1["s_musteri_adres"].ToString());
                listBox1.Items.Add("pizza:" + datalarım1["s_pizzalar"].ToString());
                listBox1.Items.Add("ekstralar:" + datalarım1["s_pizza_icerik"].ToString());
                listBox1.Items.Add("kenar tipi:" + datalarım1["s_kenartipi"].ToString());
                listBox1.Items.Add("adet:" + datalarım1["s_adet"].ToString());
                listBox1.Items.Add("toplam tutar:" + datalarım1["s_tutar"].ToString());
                listBox1.Items.Add("sipariş tarihi:" + datalarım1["s_tarihi"].ToString());

            }

             con.Close();




        }

        private void adet_SelectedIndexChanged(object sender, EventArgs e)
        {   


            int fiyat = Convert.ToInt32(adet.SelectedItem);
            if (boyut.SelectedItem == "küçük boy")
            {
                toplamtutar = 30;
                textBox6.Text = Convert.ToString(toplamtutar * fiyat);
            }
            if (boyut.SelectedItem == "orta boy")
            {
                toplamtutar = 45;
                textBox6.Text = Convert.ToString(toplamtutar * fiyat);
            }
            if (boyut.SelectedItem == "büyük boy")
            {
                toplamtutar = 60;
                textBox6.Text = Convert.ToString(toplamtutar * fiyat);

            }
        }
    }
}
