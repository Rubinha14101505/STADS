using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula06
{
    public partial class Form1 : Form
    {
        private StringBuilder bufferRecebido = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 2000;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    if (btLigar.Text == "Ligar")
                    {
                        serialPort1.Write("L\n");
                        btLigar.Text = "Desligar";
                    }
                    else
                    {
                        serialPort1.Write("D\n");
                        btLigar.Text = "btLigar";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar comando: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void atualizaListaCOMs()
        {
            comboBox1.Items.Clear();
            string[] portas = SerialPort.GetPortNames();

            if (portas.Length == 0)
            {
                comboBox1.Items.Add("Nenhuma porta encontrada");
                comboBox1.SelectedIndex = 0;
                return;
            }

            foreach (string porta in portas)
                comboBox1.Items.Add(porta);

            comboBox1.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                desconectarSerial();
            }
            else
            {
                conectarSerial();
            }

        }
        private void conectarSerial()
        {
            if (comboBox1.SelectedItem == null || comboBox1.SelectedItem.ToString() == "Nenhuma porta encontrada")
            {
                MessageBox.Show("Selecione uma porta com válida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                serialPort1.PortName = comboBox1.SelectedItem.ToString();
                serialPort1.BaudRate = 9600;
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;

                serialPort1.Open();
                button1.Text = "Desconectar";
                comboBox1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
    }
}

