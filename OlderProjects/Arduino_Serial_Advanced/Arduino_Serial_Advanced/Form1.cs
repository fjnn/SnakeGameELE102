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

namespace Arduino_Serial_Advanced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            baudrateComboBox.Items.Add("9600");
            baudrateComboBox.Items.Add("57600");
            baudrateComboBox.Items.Add("115200");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private SerialPort port;
        bool connectionFlag = false;

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!connectionFlag)
            {
                try
                {
                    port = new SerialPort
                    {
                        //PortName = portTextBox.Text,
                        //BaudRate = Convert.ToInt32(baudrateComboBox.SelectedItem),
                        PortName = "COM20",
                        BaudRate = 9600,
                        Parity = Parity.None,
                        DataBits = 8,
                        StopBits = StopBits.One
                    };
                    port.Open();
                    statusLabel.Text = "Port is OPEN";
                    connectionFlag = true;
                    connectButton.Text = "DISCONNECT";
                }

                catch (Exception)
                {
                    MessageBox.Show(portTextBox.Text + " does not exist.");
                    connectionFlag = false;
                }
            }

            else
            {
                port.Close();
                connectionFlag = false;
                statusLabel.Text = "Port is CLOSED";
                connectButton.Text = "CONNECT";
            }
        }

        byte[] dataArray = new byte[6];

        private void onButton_Click(object sender, EventArgs e)
        {
            if(connectionFlag)
            {
                dataArray[0] = 5; // header
                dataArray[1] = 1; // Send data to Arduino
                dataArray[2] = 1; // ON button pressed
                //MessageBox.Show(Convert.ToString(Convert.ToInt32(led1CheckBox.Checked)));
                dataArray[3] = Convert.ToByte(led1CheckBox.Checked);
                dataArray[4] = Convert.ToByte(led2CheckBox.Checked);
                dataArray[5] = Convert.ToByte(led3CheckBox.Checked);
                port.Write(dataArray, 0, dataArray.Length);
            }
            else
                MessageBox.Show("Connection problem");
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            if (connectionFlag)
            {
                dataArray[0] = 5; // header
                dataArray[1] = 1; // Send data to Arduino
                dataArray[2] = 0; // OFF button pressed
                dataArray[3] = Convert.ToByte(led1CheckBox.Checked);
                dataArray[4] = Convert.ToByte(led2CheckBox.Checked);
                dataArray[5] = Convert.ToByte(led3CheckBox.Checked);
                port.Write(dataArray, 0, dataArray.Length);
            }
            else
                MessageBox.Show("Connection problem");
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            if (connectionFlag)
            {
                dataArray[0] = 5; // header
                dataArray[1] = 1; // Send data to Arduino
                dataArray[2] = 2; // TOGGLE button pressed
                dataArray[3] = Convert.ToByte(led1CheckBox.Checked);
                dataArray[4] = Convert.ToByte(led2CheckBox.Checked);
                dataArray[5] = Convert.ToByte(led3CheckBox.Checked);
                port.Write(dataArray, 0, dataArray.Length);
            }
            else
                MessageBox.Show("Connection problem");
        }

        private void potreadButton_Click(object sender, EventArgs e)
        {
            if (connectionFlag)
            {
                dataArray[0] = 5; // header
                dataArray[1] = 2; // Receive data from Arduino
                port.Write(dataArray, 0, dataArray.Length);
                port.DataReceived += new SerialDataReceivedEventHandler(ReceivedSerialHandler);
            }
            else
                MessageBox.Show("Connection problem");
        }

        private void ReceivedSerialHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            double voltage = float.Parse(sp.ReadExisting());
            this.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = Convert.ToInt16(voltage);
            });
            voltage = voltage * (5.0 / 1023.0);
            this.Invoke((MethodInvoker)delegate
            {
                voltageLabel.Text = string.Format("{0:#,##0.00} V", voltage);
            });
        }
    }
}
