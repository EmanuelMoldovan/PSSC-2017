using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models.Entities;
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1.Interfaces
{
    public partial class Interfata : Form
    {
        public Interfata()
        {
            InitializeComponent();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.SendToBack();
            panel1.BringToFront();
            panel3.SendToBack();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox9.Clear();
            panel1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.SendToBack();
            panel2.BringToFront();
            panel3.SendToBack();
            panel3.Show();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox9.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            panel2.Show();
        }

        private void Interfata_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Colet newColet = new Colet(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, false, textBox9.Text);
            StoreColete.listColete.Add(newColet);
            richTextBox1.Text = newColet.ToString();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox9.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool rec;
            if (textBox8.Text.CompareTo("Da") == 0)
                rec = true;
            else rec = false;
            Scrisoare newScrisoare = new Scrisoare(textBox5.Text, textBox6.Text, textBox7.Text, rec);
            StoreScrisori.listaScrisori.Add(newScrisoare);
            richTextBox1.Text = newScrisoare.ToString();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            foreach (Colet colet in StoreColete.listColete)
                richTextBox1.Text += colet.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            foreach (Scrisoare scrisoare in StoreScrisori.listaScrisori)
                richTextBox1.Text += scrisoare.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.SendToBack();
            panel2.SendToBack();
            panel3.BringToFront();
            textBox10.Clear();
            textBox9.Clear();
            panel3.Show();
            textBox10.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            panel1.SendToBack();
            panel2.SendToBack();
            panel3.BringToFront();
            textBox10.Clear();
            textBox9.Clear();
            textBox10.Enabled = true;
            button9.Enabled = false;
            button10.Enabled = true;



        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Scrisoare scrisoare_to_delete = new Scrisoare();
            foreach (Scrisoare scrisoare in StoreScrisori.listaScrisori)
            {
                if (scrisoare.Destinatar.CompareTo(textBox11.Text) == 0)
                {
                    scrisoare_to_delete = scrisoare;
                }
            }
            StoreScrisori.listaScrisori.Remove(scrisoare_to_delete);
            textBox10.Clear();
            textBox9.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Colet colet_to_delete = new Colet();
            foreach (Colet colet in StoreColete.listColete)
            {
                if (colet.Destinatar.CompareTo(textBox11.Text) == 0 && colet.Numar_inregistrare.CompareTo(textBox10.Text) == 0)
                {
                    colet_to_delete= colet;
                }
            }
            StoreColete.listColete.Remove(colet_to_delete);
            textBox10.Clear();
            textBox9.Clear();

        }
    }
}
