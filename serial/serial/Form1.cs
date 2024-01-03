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

namespace serial
{
    public partial class Form1 : Form
    {
        string RxString;
        public Form1()
        {
            InitializeComponent();
            timerCom.Enabled = true;  
        }
        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();

                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    btnConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;

                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    btnConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }

            }
        }

        private void timerCom_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta
                serialPort1.Close();            //fecha a porta
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)          //porta está aberta
                serialPort1.Write(txtEnviar.Text);  //envia o texto presente no textbox Enviar
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(tratadadosrecebidos));
        }
        private void tratadadosrecebidos(object sender,EventArgs e)
        {
            txtRecebido.AppendText(RxString);

        }
    }
}
