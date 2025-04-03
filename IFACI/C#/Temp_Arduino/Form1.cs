using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Temp_Arduino
{
    public partial class Termometro : Form
    {
        public Termometro()
        {
            InitializeComponent(); //inicializa componentes do formulario
        }

        private void lerTemperatura(object sender, EventArgs e)
        {
            byte[] dados = new byte[2];
            string valor;

            valor = serialPort1.ReadExisting();

            if (valor != "")
            {
                thermControl1.UpdateControl(Convert.ToInt32(valor));

                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(lerTemperatura));
        }
        private void Termometro_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Iniciar_Click(object sender, EventArgs e)
        {
            if (TxPorta.Text != "") //verifica se foi informada uma porta
                serialPort1.PortName = TxPorta.Text; //configura a porta serial
            if (!serialPort1.IsOpen)
                serialPort1.Open();//abre a conexão serial
        }

        private void bt_Finalizar_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
                serialPort1.Close();//fecha a conexão Serial

            Application.Exit(); //encerra a aplicação
        }
    }
}
