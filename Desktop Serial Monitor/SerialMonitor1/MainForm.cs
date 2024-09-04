using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialMonitor1
{
    public partial class MainForm : Form
    {
        private bool ClearInputAfterSend = false;
        private bool AutoScroll = false;
        private bool TimeStamp = true;

        private void AddText(string text)
        {
            if (!string.IsNullOrWhiteSpace(textBox_Output.Text))
            {
                textBox_Output.Text += "\r\n";
            }

            if (TimeStamp)
            {
                textBox_Output.Text += DateTime.Now.ToString("HH:mm:ss.fff") + " -> ";
            }

            if (AutoScroll)
            {
                textBox_Output.AppendText(text);
            }
            else
            {
                textBox_Output.Text += text;
            }
        }

        private void OpenSerial(string port, int baud)
        {
            serialPort.PortName = port;
            serialPort.BaudRate = baud;
            serialPort.NewLine = "\r\n";
            serialPort.Open();
        }

        private void SendText(string text)
        {
            serialPort.WriteLine(text);
        }

        public MainForm()
        {
            InitializeComponent();
            OpenSerial("COM33", 115200);
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_Input.Text))
            {
                AddText(textBox_Input.Text);
                SendText(textBox_Input.Text);

                if (ClearInputAfterSend)
                {
                    textBox_Input.Text = string.Empty;
                }
            }

            textBox_Input.Focus();
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string received = serialPort.ReadLine();
            //AddText(received);
        }
    }
}
