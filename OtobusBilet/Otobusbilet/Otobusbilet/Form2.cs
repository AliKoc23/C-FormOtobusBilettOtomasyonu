using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Otobusbilet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void bİLETKESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 git = new Form2();
            git.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 git = new Form3();
            git.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 git = new Form4();
            git.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 git = new Form5();
            git.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 git = new Form6();
            git.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 git = new Form7();
            git.Show();
            this.Hide();
        }

        private void bİLETBİLGİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 git = new Form8();
            git.Show();
            this.Hide();
        }

        private void iPTALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 git = new Form9();
            git.Show();
            this.Hide();
        }

        private void gÜNCELEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 git = new Form10();
            git.Show();
            this.Hide();
        }

        private void yAZHANEİLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 git = new Form11();
            git.Show();
            this.Hide();
        }
    }
}
