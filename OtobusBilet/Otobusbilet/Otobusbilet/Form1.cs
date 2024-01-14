using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Otobusbilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string k1 = "Ali Koç", k2 = "Özgür Şahin",s1="Koc23",s2="özgür123" ;


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==k1 && textBox2.Text==s1 ) {

                Form2 git = new Form2();
                git.Show();
                this.Hide();           
            }

         

            if (textBox1.Text==k2 && textBox2.Text==s2 )
            {
                Form2 git = new Form2();
                git.Show();
                this.Hide();             
            }

            else
            {
                label3.Visible = true;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
