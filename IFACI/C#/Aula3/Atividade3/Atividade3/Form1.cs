using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        private bool isState1 = true;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Aluno\\Desktop\\Atividade3\\verde.bmp");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Tag = "Verde";
            pictureBox4.Tag = "Verde";
            pictureBox2.Image = Image.FromFile("C:\\Users\\Aluno\\Desktop\\Atividade3\\amarelo.bmp");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Tag = "Amarelo";
            pictureBox5.Tag = "Amarelo";
            pictureBox3.Image = Image.FromFile("C:\\Users\\Aluno\\Desktop\\Atividade3\\vermelho.bmp");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Tag = "Vermelho";
            pictureBox6.Tag = "Vermelho";

           
           
            timer2.Interval = 5000;  //Emergencia
            timer3.Interval = 2000;  //Verde
            timer4.Interval = 1000;  //Amarelo
            timer5.Interval = 3000;  //Vermelho
            
            timer2.Tick += timer2_Tick;
            timer3.Tick += timer3_Tick;
            timer4.Tick += timer4_Tick;
            timer5.Tick += timer5_Tick;

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();  
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetAmarelo();
            timer2.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            SetAmarelo();
            timer2.Start();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();

            pictureBox1.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox2.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox3.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox4.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox5.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox6.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void SetState1()
        {
           
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\Verde.bmp");
            pictureBox2.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox3.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox4.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox5.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox6.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\Vermelho.bmp");
        }

        private void SetState2()
        {
            
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox2.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox3.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\Vermelho.bmp");
            pictureBox4.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\Verde.bmp");
            pictureBox5.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox6.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
        }

        private void SetAmarelo()
        {
            
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox2.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\amarelo.bmp");
            pictureBox3.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox4.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
            pictureBox5.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\amarelo.bmp");
            pictureBox6.Image = Image.FromFile(@"C:\Users\Aluno\Desktop\Atividade3\desligado.bmp");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           timer2.Stop();
            if (isState1)
            {
                SetState1(); 
                timer5.Start(); 
            }
            else
            {
                SetState2(); 
                timer3.Start(); 
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            SetState1();
            isState1 = true;
            timer2.Interval = 5000;
            timer2.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            SetState2(); 
            isState1 = false;
            timer2.Interval = 5000;
            timer2.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Stop();
            SetAmarelo(); 
            timer4.Start(); 
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Process.Start("www.saocarlosoficial.com.br/empresaseservicos/?e=Policia+Militar+do+Estado+de+Sao+Paulo+-+38+Batalhao_R7DZYVE1FN");
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            Process.Start("www.corpodebombeiros.sp.gov.br");
        }
    }
}
