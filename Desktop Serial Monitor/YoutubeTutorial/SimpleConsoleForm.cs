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
    public partial class SimpleConsoleForm : Form
    {
        private SerialPort Port;

        public SimpleConsoleForm(string port, int baud)
        {
            InitializeComponent();
            SetupSerial(port, baud);
            SetupUI();
        }

        private void SetupSerial(string port, int baud)
        {
            Port = new SerialPort()
            {
                PortName = port,
                BaudRate = baud,
                NewLine = "\r\n"
            };

            Port.DataReceived += DataReceived;

            Port.Open();
        }

        private void SetupUI()
        {
            this.Text = Port.PortName;
            checkBox_Autoscroll.Checked = true;
            checkBox_ClearInput.Checked = true;
            checkBox_Echo.Checked = true;
            textBox_Input.Focus();
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string message = Port.ReadLine();
            if (!string.IsNullOrWhiteSpace(message))
            {
                PrintMessage(message);
            }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_Input.Text))
            {
                string message = textBox_Input.Text;

                // Send
                Port.Write(message);

                // Echo
                if (checkBox_Echo.Checked)
                {
                    PrintMessage($"SENT: \"{message}\"");
                }

                // Clear
                if (checkBox_ClearInput.Checked)
                {
                    textBox_Input.Clear();
                }

                // Reset focus
                textBox_Input.Focus();
            }
        }

        private delegate void PrintMessageCallback(string message);

        private void PrintMessage(string message)
        {
            // Check for cross-thread calls
            if (textBox_Ouput.InvokeRequired)
            {
                PrintMessageCallback cb = new PrintMessageCallback(PrintMessage);
                Invoke(cb, new object[] { message });
            }
            else
            {
                // Line break skip (except for first line)
                if (!string.IsNullOrWhiteSpace(textBox_Ouput.Text))
                {
                    textBox_Ouput.Text += Environment.NewLine;
                }

                // Timestamp (if needed)
                if (checkBox_Timestamps.Checked)
                {
                    textBox_Ouput.Text += DateTime.Now.ToString("HH:mm:ss.fff") + " -> ";
                }

                // Insert message (autoscroll if needed)
                if (checkBox_Autoscroll.Checked)
                {
                    textBox_Ouput.AppendText(message);
                }
                else
                {
                    textBox_Ouput.Text += message;
                }
            }
        }

        private void SimpleConsoleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Port.IsOpen)
            {
                Port.Close();
            }
        }
    }
}
