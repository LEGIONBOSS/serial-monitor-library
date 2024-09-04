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

namespace YoutubeTutorial
{
    public partial class LEDForm : Form
    {
        public LEDForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Add available serial ports to comboBox_Ports
            foreach (string port in SerialPort.GetPortNames())
            {
                comboBox_Ports.Items.Add(port);
            }

            // Select first
            comboBox_Ports.SelectedIndex = 0;
            comboBox_Ports_SelectionChangeCommitted(null, EventArgs.Empty);
        }

        private void OpenSerial(string port, int baud)
        {
            if (serialPort.IsOpen) serialPort.Close();

            serialPort.PortName = port;
            serialPort.BaudRate = baud;
            serialPort.NewLine = "\r\n"; // default line break from MCU
            serialPort.Open();
        }

        private void comboBox_Ports_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string port = comboBox_Ports.SelectedItem.ToString();

            try
            {
                OpenSerial(port, 115200);
                MessageBox.Show($"Opened serial port {port}", port);
                this.Text = port;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot open serial port {port}\n\n{ex.Message}", port);
            }
        }

        private void button_ON_Click(object sender, EventArgs e)
        {
            serialPort.Write("A");
        }

        private void button_OFF_Click(object sender, EventArgs e)
        {
            serialPort.Write("B");
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_Input.Text))
            {
                serialPort.Write(textBox_Input.Text);
                textBox_Input.Text = string.Empty;
                textBox_Input.Focus();
            }
        }

    }
}
