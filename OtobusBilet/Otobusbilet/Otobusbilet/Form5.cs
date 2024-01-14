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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "İstanbul")
            {
                panel3.Visible = true;
                panel4.Visible = false;

                listView1.Visible = true;
                listView2.Visible = false;

                textBox3.Text = "220 TL";
                textBox5.Text = "0005";
            }

            if (comboBox1.Text == "Ankara")
            {
                panel3.Visible = false;
                panel4.Visible = true;

                listView1.Visible = false;
                listView2.Visible = true;

                textBox3.Text = "220 TL";
                textBox5.Text = "0006";

            }
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-T2I0C3B\\SQLEXPRESS;Initial Catalog=otobus;Integrated Security=True");


        private void verigel()
        {
            listView1.Items.Clear();
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
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void veriekle()
        {
            if (checkBox1.Checked)
            {
                textBox6.Text = "Erkek";
            }

            else if (checkBox2.Checked)
            {
                textBox6.Text = "Kadın";
            }

            baglan.Open();
            SqlCommand kayit = new SqlCommand("Insert into  istankara (AdSoyad,Telefon,Cinsiyet,Koltuk,SeferNo,Binis,Varis,Saat,Ucret) values ('" + textBox1.Text.ToString() + "' , '" + textBox2.Text.ToString() + "' , '" + textBox6.Text.ToString() + "', '" + textBox4.Text.ToString() + "', '" + textBox5.Text.ToString() + "', '" + comboBox1.Text.ToString() + "' , '" + comboBox2.Text.ToString() + "', '" + comboBox3.Text.ToString() + "' , '" + textBox3.Text.ToString() + "')", baglan);
            kayit.ExecuteNonQuery();
            baglan.Close();
            verigel();
        }

        private void verigel1()
        {
            listView2.Items.Clear();
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
                listView2.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void veriekle1()
        {
            if (checkBox1.Checked)
            {
                textBox6.Text = "Erkek";
            }

            else if (checkBox2.Checked)
            {
                textBox6.Text = "Kadın";
            }

            baglan.Open();
            SqlCommand kayit = new SqlCommand("Insert into ankaraist (AdSoyad,Telefon,Cinsiyet,Koltuk,SeferNo,Binis,Varis,Saat,Ucret) values ('" + textBox1.Text.ToString() + "' , '" + textBox2.Text.ToString() + "' , '" + textBox6.Text.ToString() + "', '" + textBox4.Text.ToString() + "', '" + textBox5.Text.ToString() + "', '" + comboBox1.Text.ToString() + "' , '" + comboBox2.Text.ToString() + "', '" + comboBox3.Text.ToString() + "' , '" + textBox3.Text.ToString() + "')", baglan);
            kayit.ExecuteNonQuery();
            baglan.Close();
            verigel1();
        }


        private void button32_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "İstanbul")
            {
                veriekle();
            }

            if (comboBox1.Text == "Ankara")
            {
                veriekle1();
            }

        }

        private void button63_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "1";
                textBox4.Enabled = false;
                button1.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "1";
                textBox4.Enabled = false;
                button1.BackColor = Color.LightPink;
            }
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "2";
                textBox4.Enabled = false;
                button2.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "2";
                textBox4.Enabled = false;
                button2.BackColor = Color.LightPink;
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "3";
                textBox4.Enabled = false;
                button3.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "3";
                textBox4.Enabled = false;
                button3.BackColor = Color.LightPink;
            }
            button3.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "4";
                textBox4.Enabled = false;
                button20.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "4";
                textBox4.Enabled = false;
                button20.BackColor = Color.LightPink;
            }
            button20.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "5";
                textBox4.Enabled = false;
                button5.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "5";
                textBox4.Enabled = false;
                button5.BackColor = Color.LightPink;
            }
            button5.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "6";
                textBox4.Enabled = false;
                button4.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "6";
                textBox4.Enabled = false;
                button4.BackColor = Color.LightPink;
            }
            button4.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "7";
                textBox4.Enabled = false;
                button21.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "7";
                textBox4.Enabled = false;
                button21.BackColor = Color.LightPink;
            }
            button21.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "8";
                textBox4.Enabled = false;
                button7.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "8";
                textBox4.Enabled = false;
                button7.BackColor = Color.LightPink;
            }
            button7.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "9";
                textBox4.Enabled = false;
                button6.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "9";
                textBox4.Enabled = false;
                button6.BackColor = Color.LightPink;
            }
            button6.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "10";
                textBox4.Enabled = false;
                button22.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "10";
                textBox4.Enabled = false;
                button22.BackColor = Color.LightPink;
            }
            button22.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "11";
                textBox4.Enabled = false;
                button9.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "11";
                textBox4.Enabled = false;
                button9.BackColor = Color.LightPink;
            }
            button9.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "12";
                textBox4.Enabled = false;
                button8.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "12";
                textBox4.Enabled = false;
                button8.BackColor = Color.LightPink;
            }
            button8.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "13";
                textBox4.Enabled = false;
                button23.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "13";
                textBox4.Enabled = false;
                button23.BackColor = Color.LightPink;
            }
            button23.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "14";
                textBox4.Enabled = false;
                button11.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "14";
                textBox4.Enabled = false;
                button11.BackColor = Color.LightPink;
            }
            button11.Enabled = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "15";
                textBox4.Enabled = false;
                button10.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "15";
                textBox4.Enabled = false;
                button10.BackColor = Color.LightPink;
            }
            button10.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "16";
                textBox4.Enabled = false;
                button24.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "16";
                textBox4.Enabled = false;
                button24.BackColor = Color.LightPink;
            }
            button24.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "17";
                textBox4.Enabled = false;
                button13.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "17";
                textBox4.Enabled = false;
                button13.BackColor = Color.LightPink;
            }
            button13.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "18";
                textBox4.Enabled = false;
                button12.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "18";
                textBox4.Enabled = false;
                button12.BackColor = Color.LightPink;
            }
            button12.Enabled = false;

        }

        private void button25_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                textBox4.Text = "19";
                textBox4.Enabled = false;
                button25.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "19";
                textBox4.Enabled = false;
                button25.BackColor = Color.LightPink;
            }
            button25.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "20";
                textBox4.Enabled = false;
                button15.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "20";
                textBox4.Enabled = false;
                button15.BackColor = Color.LightPink;
            }
            button15.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "21";
                textBox4.Enabled = false;
                button14.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "21";
                textBox4.Enabled = false;
                button14.BackColor = Color.LightPink;
            }
            button14.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "22";
                textBox4.Enabled = false;
                button26.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "22";
                textBox4.Enabled = false;
                button26.BackColor = Color.LightPink;
            }
            button26.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "23";
                textBox4.Enabled = false;
                button17.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "23";
                textBox4.Enabled = false;
                button17.BackColor = Color.LightPink;
            }
            button17.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "24";
                textBox4.Enabled = false;
                button16.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "24";
                textBox4.Enabled = false;
                button16.BackColor = Color.LightPink;
            }
            button16.Enabled = false;

        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "25";
                textBox4.Enabled = false;
                button28.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "25";
                textBox4.Enabled = false;
                button28.BackColor = Color.LightPink;
            }
            button28.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "26";
                textBox4.Enabled = false;
                button19.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "26";
                textBox4.Enabled = false;
                button19.BackColor = Color.LightPink;
            }
            button19.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "27";
                textBox4.Enabled = false;
                button18.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "27";
                textBox4.Enabled = false;
                button18.BackColor = Color.LightPink;
            }
            button18.Enabled = false;

        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "28";
                textBox4.Enabled = false;
                button27.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "28";
                textBox4.Enabled = false;
                button27.BackColor = Color.LightPink;
            }
            button27.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "29";
                textBox4.Enabled = false;
                button30.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "29";
                textBox4.Enabled = false;
                button30.BackColor = Color.LightPink;
            }
            button30.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "30";
                textBox4.Enabled = false;
                button29.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "30";
                textBox4.Enabled = false;
                button29.BackColor = Color.LightPink;
            }
            button29.Enabled = false;
        }



        private void button62_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "1";
                textBox4.Enabled = false;
                button62.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "1";
                textBox4.Enabled = false;
                button62.BackColor = Color.LightPink;
            }
            button62.Enabled = false;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "2";
                textBox4.Enabled = false;
                button61.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "2";
                textBox4.Enabled = false;
                button61.BackColor = Color.LightPink;
            }
            button61.Enabled = false;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "3";
                textBox4.Enabled = false;
                button60.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "3";
                textBox4.Enabled = false;
                button60.BackColor = Color.LightPink;
            }
            button60.Enabled = false;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "4";
                textBox4.Enabled = false;
                button43.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "4";
                textBox4.Enabled = false;
                button43.BackColor = Color.LightPink;
            }
            button43.Enabled = false;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "5";
                textBox4.Enabled = false;
                button59.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "5";
                textBox4.Enabled = false;
                button59.BackColor = Color.LightPink;
            }
            button59.Enabled = false;

        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "6";
                textBox4.Enabled = false;
                button58.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "6";
                textBox4.Enabled = false;
                button58.BackColor = Color.LightPink;
            }
            button58.Enabled = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "7";
                textBox4.Enabled = false;
                button42.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "7";
                textBox4.Enabled = false;
                button42.BackColor = Color.LightPink;
            }
            button42.Enabled = false;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "8";
                textBox4.Enabled = false;
                button57.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "8";
                textBox4.Enabled = false;
                button57.BackColor = Color.LightPink;
            }
            button57.Enabled = false;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "9";
                textBox4.Enabled = false;
                button56.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "9";
                textBox4.Enabled = false;
                button56.BackColor = Color.LightPink;
            }
            button56.Enabled = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "10";
                textBox4.Enabled = false;
                button41.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "10";
                textBox4.Enabled = false;
                button41.BackColor = Color.LightPink;
            }
            button41.Enabled = false;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "11";
                textBox4.Enabled = false;
                button55.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "11";
                textBox4.Enabled = false;
                button55.BackColor = Color.LightPink;
            }
            button55.Enabled = false;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "12";
                textBox4.Enabled = false;
                button54.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "12";
                textBox4.Enabled = false;
                button54.BackColor = Color.LightPink;
            }
            button54.Enabled = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "13";
                textBox4.Enabled = false;
                button40.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "13";
                textBox4.Enabled = false;
                button40.BackColor = Color.LightPink;
            }
            button40.Enabled = false;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "14";
                textBox4.Enabled = false;
                button53.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "14";
                textBox4.Enabled = false;
                button53.BackColor = Color.LightPink;
            }
            button53.Enabled = false;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "15";
                textBox4.Enabled = false;
                button52.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "15";
                textBox4.Enabled = false;
                button52.BackColor = Color.LightPink;
            }
            button52.Enabled = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "16";
                textBox4.Enabled = false;
                button39.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "16";
                textBox4.Enabled = false;
                button39.BackColor = Color.LightPink;
            }
            button39.Enabled = false;

        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "17";
                textBox4.Enabled = false;
                button51.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "17";
                textBox4.Enabled = false;
                button51.BackColor = Color.LightPink;
            }
            button51.Enabled = false;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "18";
                textBox4.Enabled = false;
                button50.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "18";
                textBox4.Enabled = false;
                button50.BackColor = Color.LightPink;
            }
            button50.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "19";
                textBox4.Enabled = false;
                button38.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "19";
                textBox4.Enabled = false;
                button38.BackColor = Color.LightPink;
            }
            button38.Enabled = false;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "20";
                textBox4.Enabled = false;
                button49.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "20";
                textBox4.Enabled = false;
                button49.BackColor = Color.LightPink;
            }
            button49.Enabled = false;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "21";
                textBox4.Enabled = false;
                button48.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "21";
                textBox4.Enabled = false;
                button48.BackColor = Color.LightPink;
            }
            button48.Enabled = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "22";
                textBox4.Enabled = false;
                button37.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "22";
                textBox4.Enabled = false;
                button37.BackColor = Color.LightPink;
            }
            button37.Enabled = false;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "23";
                textBox4.Enabled = false;
                button47.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "23";
                textBox4.Enabled = false;
                button47.BackColor = Color.LightPink;
            }
            button47.Enabled = false;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "24";
                textBox4.Enabled = false;
                button46.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "24";
                textBox4.Enabled = false;
                button46.BackColor = Color.LightPink;
            }
            button46.Enabled = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "25";
                textBox4.Enabled = false;
                button36.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "25";
                textBox4.Enabled = false;
                button36.BackColor = Color.LightPink;
            }
            button36.Enabled = false;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "26";
                textBox4.Enabled = false;
                button45.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "26";
                textBox4.Enabled = false;
                button45.BackColor = Color.LightPink;
            }
            button45.Enabled = false;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "27";
                textBox4.Enabled = false;
                button44.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "27";
                textBox4.Enabled = false;
                button44.BackColor = Color.LightPink;
            }
            button44.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "28";
                textBox4.Enabled = false;
                button33.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "28";
                textBox4.Enabled = false;
                button33.BackColor = Color.LightPink;
            }
            button33.Enabled = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "29";
                textBox4.Enabled = false;
                button35.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "29";
                textBox4.Enabled = false;
                button35.BackColor = Color.LightPink;
            }
            button35.Enabled = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.Text = "30";
                textBox4.Enabled = false;
                button34.BackColor = Color.LightBlue;

            }
            else if (checkBox2.Checked)
            {
                textBox4.Text = "30";
                textBox4.Enabled = false;
                button34.BackColor = Color.LightPink;
            }
            button34.Enabled = false;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            Form2 git = new Form2();
            git.Show();
            this.Hide(); 
        }
    }
}
