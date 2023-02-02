using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace казик
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int t = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();        
              

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num1 = rnd.Next(1, 8);
            int num2 = rnd.Next(1, 8);
            int num3 = rnd.Next(1, 8);
            int count = 0;         

                textBox1.Text = (int.Parse(textBox1.Text) - int.Parse(textBox2.Text)).ToString();
                pictureBox1.Image = Image.FromFile($"{num1.ToString()}.png");
                pictureBox2.Image = Image.FromFile($"{num2.ToString()}.png");
                pictureBox3.Image = Image.FromFile($"{num3.ToString()}.png");
                if (num1 == 7)
                    count++;
                if (num2 == 7) count++;
                if (num3 == 7) count++;
                if (count == 0) label3.Text = "ничего не выпало";
                if (count == 1)
                {
                    label3.Text = "вам повезло! выпала одна семерка";
                    textBox1.Text = ((int.Parse(textBox2.Text) * 2) + int.Parse(textBox1.Text)).ToString();
                }
                if (count == 2)
                {
                    label3.Text = "вам повезло! выпало две семерки!";
                    textBox1.Text = ((int.Parse(textBox2.Text) * 4) + int.Parse(textBox1.Text)).ToString();
                }
                if (count == 3)
                {
                    label3.Text = "ЗАНОС!!!!!!!!!";
                    textBox1.Text = ((int.Parse(textBox2.Text) * 35) + int.Parse(textBox1.Text)).ToString();
                }
                timer1.Stop();          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = "";
            if (int.TryParse(textBox2.Text, out int meow) == false || int.TryParse(textBox1.Text, out int meo) == false)
            {
                timer2.Stop();
                MessageBox.Show("Введи число");
               
            }
            else if (int.Parse(textBox1.Text) == 0)
            {
                timer2.Stop();
                button3.Visible = true;
                MessageBox.Show("ноль на балансе");
                
            }
            else if (int.Parse(textBox1.Text) < 0 || int.Parse(textBox2.Text) < 0)
            {
                timer2.Stop();
                MessageBox.Show("баланс не может быть меньше нуля");
                
            }
            else if (int.Parse(textBox2.Text) > int.Parse(textBox1.Text))
            {
                timer2.Stop();
                MessageBox.Show("У вас недостаточно средств для такой ставки");
            }
            
            else if (int.Parse(textBox2.Text) < 100)
            {
                timer2.Stop();
                MessageBox.Show("Минимальная ставка от 100");
            }
                

            else
            {
                
                button2.Visible = true;
                int num1 = rnd.Next(1, 8);
                int num2 = rnd.Next(1, 8);
                int num3 = rnd.Next(1, 8);
                pictureBox1.Image = Image.FromFile($"{num1.ToString()}.png");
                pictureBox2.Image = Image.FromFile($"{num2.ToString()}.png");
                pictureBox3.Image = Image.FromFile($"{num3.ToString()}.png");
                t++;
                if (t >= 30)
                {
                    button2.Visible = false;
                    timer2.Stop();
                    timer1.Start();
                    t= 0;
               
                }                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            button2.Visible = false;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "10000";
            button3.Visible = false;
        }
    }
}
