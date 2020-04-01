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

namespace Arduino_Serial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SerialPort port;

        private void ledButton_Click(object sender, EventArgs e)
        {
            port = new SerialPort("COM19", 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("led");
            port.Close();

        }

        private void potButton_Click(object sender, EventArgs e)
        {
            port = new SerialPort("COM19", 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("voltage");
            port.DataReceived += new SerialDataReceivedEventHandler(ReceivedSerialHandler);
        }

        private void ReceivedSerialHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            double voltage = float.Parse(sp.ReadExisting());
            voltage = voltage * (5.0 / 1023.0);
            this.Invoke((MethodInvoker)delegate
            {
                textBox1.Text = string.Format("{0:#,##0.00} V", voltage);
            });
            port.Close();
        }
    }
}
