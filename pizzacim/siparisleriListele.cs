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
    public partial class siparisler :Form
    {
        
        public siparisler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void listele()
        {

            baglan bagg = new baglan();

            MySqlConnection con = new MySqlConnection(bagg.baglanti());

            string komut = "SELECT * FROM siparisler";
            MySqlDataAdapter sorgu = new MySqlDataAdapter(komut, con);
            DataSet data = new DataSet();
            con.Open();
            sorgu.Fill(data, "siparisler");
            dataGridView1.DataSource = data.Tables["siparisler"];
            con.Close();


        }
        void kaydıSil(int numara)
        {
            baglan bagg = new baglan();

            MySqlConnection con = new MySqlConnection(bagg.baglanti());
            string komut = "DELETE FROM siparisler WHERE  siparis_id=@numara";
            MySqlCommand sorgu = new MySqlCommand(komut, con);
            sorgu.Parameters.AddWithValue("@numara", numara);
            con.Open();
            sorgu.ExecuteNonQuery();
            con.Close();


        }

        
           
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            listele();
            baglan bagg = new baglan();

            MySqlConnection con = new MySqlConnection(bagg.baglanti());
            string komut = "SELECT *FROM siparisler ";
            MySqlDataAdapter sorgu1 = new MySqlDataAdapter(komut, con);
            DataTable data = new DataTable();
            sorgu1.Fill(data);
            dataGridView1.DataSource = data;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void siparisGoster_Click_1(object sender, EventArgs e)
        {
           

                foreach(DataGridViewRow drow in dataGridView1.SelectedRows){

                int numara = Convert.ToInt32(drow.Cells[0].Value);
                
                kaydıSil(numara);



            }

            listele();
            
            
           
                
            

          

          
        }

        
       

    

        

      

       

        private void button2_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            Application.Exit();
        }

        private void siparis_ekrranı_Click(object sender, EventArgs e)
        {
            this.Hide();
            siparis_form form1 = new siparis_form();
            form1.Show();
        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {
            string aranan_siparis = textBox1.Text.Trim().ToUpper();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan_siparis)
                            {
                                cell.Style.BackColor = Color.Red;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
