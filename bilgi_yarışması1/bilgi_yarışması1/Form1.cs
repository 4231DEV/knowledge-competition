using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarışması1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int sorusay=0, dogrusay=0, yanlıssayı=0;

        private void btnB_Click(object sender, EventArgs e)
        {
            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogrusay++;
                lbldogru.Text = dogrusay.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıssayı++;
                lblyanlıs.Text = yanlıssayı.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonra.Enabled = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogrusay++;
                lbldogru.Text = dogrusay.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıssayı++;
                lblyanlıs.Text = yanlıssayı.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonra.Enabled = true;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogrusay++;
                lbldogru.Text = dogrusay.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıssayı++;
                lblyanlıs.Text = yanlıssayı.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonra.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogrusay++;
                lbldogru.Text = dogrusay.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlıssayı++;
                lblyanlıs.Text = yanlıssayı.ToString();
                pictureBox2.Visible = true;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonra.Enabled = true;

        }

        private void btnsonra_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnsonra.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            sorusay++;
            lblsoru.Text = sorusay.ToString();
            if (sorusay == 1)
            {
                richTextBox1.Text = "   Malazgirt savaşı ne zaman gerçekleşmişdir ?";
                btnA.Text = "1461";
                btnB.Text = "571";
                btnC.Text = "1071";
                btnD.Text = "1981";
                label4.Text = "1071";

                    
            }
            if (sorusay == 2) { 
            richTextBox1.Text = "Giresun hangi bölgemizdedir ?";
            btnA.Text = "Karadeniz";
            btnB.Text = "OrtaAnadolu";
            btnC.Text = "Ege";
            btnD.Text = "DoğuAnadolu";
            label4.Text = "Karadeniz";
            }


            if (sorusay == 3) {
            richTextBox1.Text = "Metro serisi ile bildğimiz kitap serisinin yazarı kimdir";
            btnA.Text = "George Orwel";
            btnB.Text = "Stephan Hawking";
            btnC.Text = "Sait Faik";
            btnD.Text = "Dimitri Gluhovski";
            label4.Text = "Dimitri Gluhovski";
                btnsonra.Text = "sonuçlar";
            }
            if(sorusay== 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                MessageBox.Show("Doğru :" + dogrusay + "\n" + "Yanlış :" + yanlıssayı);
                
            }


        }
    }
}
