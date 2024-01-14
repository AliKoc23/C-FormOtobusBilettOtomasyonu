using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otobusbilet
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 git = new Form2();
            git.Show();
            this.Hide();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-T2I0C3B\\SQLEXPRESS;Initial Catalog=otobus;Integrated Security=True");

        private void istiz()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From istizoglen", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Koltuk"].ToString());
                ekle.SubItems.Add(oku["SeferNo"].ToString());
                ekle.SubItems.Add(oku["Binis"].ToString());
                ekle.SubItems.Add(oku["Varis"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void izist()
        {
            listView2.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From izistoglen", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Koltuk"].ToString());
                ekle.SubItems.Add(oku["SeferNo"].ToString());
                ekle.SubItems.Add(oku["Binis"].ToString());
                ekle.SubItems.Add(oku["Varis"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                listView2.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void istaydin()
        {
            listView3.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From istaydin", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Koltuk"].ToString());
                ekle.SubItems.Add(oku["SeferNo"].ToString());
                ekle.SubItems.Add(oku["Binis"].ToString());
                ekle.SubItems.Add(oku["Varis"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                listView3.Items.Add(ekle);
            }
            baglan.Close();

        }
        private void aydinist()
        {
            listView4.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From aydinist", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Koltuk"].ToString());
                ekle.SubItems.Add(oku["SeferNo"].ToString());
                ekle.SubItems.Add(oku["Binis"].ToString());
                ekle.SubItems.Add(oku["Varis"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                listView4.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void istankara()
        {
            listView5.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From istankara", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Koltuk"].ToString());
                ekle.SubItems.Add(oku["SeferNo"].ToString());
                ekle.SubItems.Add(oku["Binis"].ToString());
                ekle.SubItems.Add(oku["Varis"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                listView5.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void ankaraist()
        {
            listView6.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From ankaraist", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Koltuk"].ToString());
                ekle.SubItems.Add(oku["SeferNo"].ToString());
                ekle.SubItems.Add(oku["Binis"].ToString());
                ekle.SubItems.Add(oku["Varis"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                listView6.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void istmugla()
        {
            listView7.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From istmugla", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Koltuk"].ToString());
                ekle.SubItems.Add(oku["SeferNo"].ToString());
                ekle.SubItems.Add(oku["Binis"].ToString());
                ekle.SubItems.Add(oku["Varis"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                listView7.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void muglaist()
        {
            listView8.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From muglaist", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Koltuk"].ToString());
                ekle.SubItems.Add(oku["SeferNo"].ToString());
                ekle.SubItems.Add(oku["Binis"].ToString());
                ekle.SubItems.Add(oku["Varis"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                listView8.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void izmirankara()
        {
            listView9.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From izmirankara", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Koltuk"].ToString());
                ekle.SubItems.Add(oku["SeferNo"].ToString());
                ekle.SubItems.Add(oku["Binis"].ToString());
                ekle.SubItems.Add(oku["Varis"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                listView9.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void ankaraizmir()
        {
            listView10.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From ankaraizmir", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Koltuk"].ToString());
                ekle.SubItems.Add(oku["SeferNo"].ToString());
                ekle.SubItems.Add(oku["Binis"].ToString());
                ekle.SubItems.Add(oku["Varis"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                listView10.Items.Add(ekle);
            }
            baglan.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "İstanbul" && comboBox2.Text == "İzmir")
            {
                istiz();
                listView1.Visible = true;
                listView2.Visible = false;
                listView3.Visible = false;
                listView4.Visible = false;
                listView5.Visible = false;
                listView6.Visible = false;
                listView7.Visible = false;
                listView8.Visible = false;
                listView9.Visible = false;
                listView10.Visible = false;
            }

            if (comboBox1.Text == "İzmir" && comboBox2.Text == "İstanbul")
            {
                izist();
                listView1.Visible = false;
                listView2.Visible = true;
                listView3.Visible = false;
                listView4.Visible = false;
                listView5.Visible = false;
                listView6.Visible = false;
                listView7.Visible = false;
                listView8.Visible = false;
                listView9.Visible = false;
                listView10.Visible = false;
            }

            if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Aydın")
            {
                istaydin();
                listView1.Visible = false;
                listView2.Visible = false;
                listView3.Visible = true;
                listView4.Visible = false;
                listView5.Visible = false;
                listView6.Visible = false;
                listView7.Visible = false;
                listView8.Visible = false;
                listView9.Visible = false;
                listView10.Visible = false;
            }

            if (comboBox1.Text == "Aydın" && comboBox2.Text == "İstanbul")
            {
                aydinist();
                listView1.Visible = false;
                listView2.Visible = false;
                listView3.Visible = false;
                listView4.Visible = true;
                listView5.Visible = false;
                listView6.Visible = false;
                listView7.Visible = false;
                listView8.Visible = false;
                listView9.Visible = false;
                listView10.Visible = false;
            }

            if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Ankara")
            {
                istankara();
                listView1.Visible = false;
                listView2.Visible = false;
                listView3.Visible = false;
                listView4.Visible = false;
                listView5.Visible = true;
                listView6.Visible = false;
                listView7.Visible = false;
                listView8.Visible = false;
                listView9.Visible = false;
                listView10.Visible = false;
            }

            if (comboBox1.Text == "Ankara" && comboBox2.Text == "İstanbul")
            {
                ankaraist();
                listView1.Visible = false;
                listView2.Visible = false;
                listView3.Visible = false;
                listView4.Visible = false;
                listView5.Visible = false;
                listView6.Visible = true;
                listView7.Visible = false;
                listView8.Visible = false;
                listView9.Visible = false;
                listView10.Visible = false;
            }

            if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Muğla")
            {
                istmugla();
                listView1.Visible = false;
                listView2.Visible = false;
                listView3.Visible = false;
                listView4.Visible = false;
                listView5.Visible = false;
                listView6.Visible = false;
                listView7.Visible = true;
                listView8.Visible = false;
                listView9.Visible = false;
                listView10.Visible = false;
            }

            if (comboBox1.Text == "Muğla" && comboBox2.Text == "İstanbul")
            {
                muglaist();
                listView1.Visible = false;
                listView2.Visible = false;
                listView3.Visible = false;
                listView4.Visible = false;
                listView5.Visible = false;
                listView6.Visible = false;
                listView7.Visible = false;
                listView8.Visible = true;
                listView9.Visible = false;
                listView10.Visible = false;
            }

            if (comboBox1.Text == "İzmir" && comboBox2.Text == "Ankara")
            {
                izmirankara();
                listView1.Visible = true;
                listView2.Visible = false;
                listView3.Visible = false;
                listView4.Visible = false;
                listView5.Visible = false;
                listView6.Visible = false;
                listView7.Visible = false;
                listView8.Visible = false;
                listView9.Visible = true;
                listView10.Visible = false;
            }

            if (comboBox1.Text == "Ankara" && comboBox2.Text == "İzmir")
            {
                ankaraizmir();
                listView1.Visible = false;
                listView2.Visible = false;
                listView3.Visible = false;
                listView4.Visible = false;
                listView5.Visible = false;
                listView6.Visible = false;
                listView7.Visible = false;
                listView8.Visible = false;
                listView9.Visible = false;
                listView10.Visible = true;
            }


            if (comboBox1.Text == "Ankara" && comboBox2.Text == "Muğla")
            {
                MessageBox.Show("Böyle Bir Sefer Bulunmamaktadır !");
            }

            if (comboBox1.Text == "Ankara" && comboBox2.Text == "Aydın")
            {
                MessageBox.Show("Böyle Bir Sefer Bulunmamaktadır !");
            }

            if (comboBox1.Text == "Aydın" && comboBox2.Text == "İzmir")
            {
                MessageBox.Show("Böyle Bir Sefer Bulunmamaktadır !");
            }

            if (comboBox1.Text == "Aydın" && comboBox2.Text == "Ankara")
            {
                MessageBox.Show("Böyle Bir Sefer Bulunmamaktadır !");
            }

            if (comboBox1.Text == "Aydın" && comboBox2.Text == "Muğla")
            {
                MessageBox.Show("Böyle Bir Sefer Bulunmamaktadır !");
            }

            if (comboBox1.Text == "Muğla" && comboBox2.Text == "Aydın")
            {
                MessageBox.Show("Böyle Bir Sefer Bulunmamaktadır !");
            }

            if (comboBox1.Text == "Muğla" && comboBox2.Text == "İzmir")
            {
                MessageBox.Show("Böyle Bir Sefer Bulunmamaktadır !");
            }

            if (comboBox1.Text == "Muğla" && comboBox2.Text == "Ankara")
            {
                MessageBox.Show("Böyle Bir Sefer Bulunmamaktadır !");
            }

            if (comboBox1.Text == "İzmir" && comboBox2.Text == "Aydın")
            {
                MessageBox.Show("Böyle Bir Sefer Bulunmamaktadır !");
            }

            if (comboBox1.Text == "İzmir" && comboBox2.Text == "Muğla")
            {
                MessageBox.Show("Böyle Bir Sefer Bulunmamaktadır !");
            }
        }

        private void istizgüncel()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update istizoglen set Koltuk = '" + textBox3.Text.ToString() + "', AdSoyad= '" + textBox1.Text.ToString() + "', Telefon= '" + textBox2.Text.ToString() + "', Cinsiyet= '" + comboBox3.Text.ToString() + "' where Koltuk= '"+textBox4.Text+"'  ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            istiz();
        }
        private void izistgüncel()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update izistoglen set Koltuk = '" + textBox3.Text.ToString() + "', AdSoyad= '" + textBox1.Text.ToString() + "', Telefon= '" + textBox2.Text.ToString() + "', Cinsiyet= '" + comboBox3.Text.ToString() + "' where Koltuk= '" + textBox4.Text + "'  ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            izist();
        }
        private void istaydingüncel()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update istaydin set Koltuk = '" + textBox3.Text.ToString() + "', AdSoyad= '" + textBox1.Text.ToString() + "', Telefon= '" + textBox2.Text.ToString() + "', Cinsiyet= '" + comboBox3.Text.ToString() + "' where Koltuk= '" + textBox4.Text + "'  ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            istaydin();
        }
        private void aydinistgüncel()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update aydinist set Koltuk = '" + textBox3.Text.ToString() + "', AdSoyad= '" + textBox1.Text.ToString() + "', Telefon= '" + textBox2.Text.ToString() + "', Cinsiyet= '" + comboBox3.Text.ToString() + "' where Koltuk= '" + textBox4.Text + "'  ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            aydinist();
        }
        private void istankaragüncel()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update istankara set Koltuk = '" + textBox3.Text.ToString() + "', AdSoyad= '" + textBox1.Text.ToString() + "', Telefon= '" + textBox2.Text.ToString() + "', Cinsiyet= '" + comboBox3.Text.ToString() + "' where Koltuk= '" + textBox4.Text + "'  ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            istankara();
        }
        private void ankaraistgüncel()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update ankaraist set Koltuk = '" + textBox3.Text.ToString() + "', AdSoyad= '" + textBox1.Text.ToString() + "', Telefon= '" + textBox2.Text.ToString() + "', Cinsiyet= '" + comboBox3.Text.ToString() + "' where Koltuk= '" + textBox4.Text + "'  ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            ankaraist();
        }
        private void istmuglagüncel()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update istmugla set Koltuk = '" + textBox3.Text.ToString() + "', AdSoyad= '" + textBox1.Text.ToString() + "', Telefon= '" + textBox2.Text.ToString() + "', Cinsiyet= '" + comboBox3.Text.ToString() + "' where Koltuk= '" + textBox4.Text + "'  ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            istmugla();
        }
        private void muglaistgüncel()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update muglaist set Koltuk = '" + textBox3.Text.ToString() + "', AdSoyad= '" + textBox1.Text.ToString() + "', Telefon= '" + textBox2.Text.ToString() + "', Cinsiyet= '" + comboBox3.Text.ToString() + "' where Koltuk= '" + textBox4.Text + "'  ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            muglaist();
        }
        private void izmirankaragüncel()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update izmirankara set Koltuk = '" + textBox3.Text.ToString() + "', AdSoyad= '" + textBox1.Text.ToString() + "', Telefon= '" + textBox2.Text.ToString() + "', Cinsiyet= '" + comboBox3.Text.ToString() + "' where Koltuk= '" + textBox4.Text + "'  ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            izmirankara();
        }
        private void ankaraizmirgüncel()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update ankaraizmir set Koltuk = '" + textBox3.Text.ToString() + "', AdSoyad= '" + textBox1.Text.ToString() + "', Telefon= '" + textBox2.Text.ToString() + "', Cinsiyet= '" + comboBox3.Text.ToString() + "' where Koltuk= '" + textBox4.Text + "'  ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            ankaraizmir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="İstanbul" && comboBox2.Text=="İzmir")
            {
                istizgüncel();
            }

            if (comboBox1.Text=="İzmir" && comboBox2.Text=="İstanbul")
            {
                izistgüncel();

            }

            if (comboBox1.Text=="İstanbul" &&  comboBox2.Text=="Aydın")
            {
                istaydingüncel();
            }

            if (comboBox1.Text=="Aydın" && comboBox2.Text=="İstanbul")
            {
                aydinistgüncel();
            }

            if (comboBox1.Text=="İstanbul" && comboBox2.Text=="Ankara")
            {
                istankaragüncel();
            }

            if (comboBox1.Text=="Ankara" && comboBox2.Text=="İstanbul")
            {
                ankaraistgüncel();
            }

            if (comboBox1.Text=="İstanbul" && comboBox2.Text=="Muğla")
            {
                istmuglagüncel();
            }

            if (comboBox1.Text=="Muğla" && comboBox2.Text=="İstanbul")
            {
                muglaistgüncel();
            }

            if (comboBox1.Text=="İzmir" && comboBox2.Text=="Ankara")
            {
                izmirankaragüncel();
            }
            
            if (comboBox1.Text=="Ankara" && comboBox2.Text=="İzmir")
            {
                ankaraizmirgüncel();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 git = new Form10();
            git.Show();
            git.Hide();
        }
    }
}
