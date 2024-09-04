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

namespace YoutubeTutorial
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Ports combobox
            RefreshPorts();

            // Baud rates combobox
            comboBox_Bauds.Items.AddRange(new string[]{
                "300",
                "600",
                "1200",
                "2400",
                "4800",
                "9600",
                "14400",
                "19200",
                "28800",
                "31250",
                "38400",
                "57600",
                "115200",
            });
            comboBox_Bauds.SelectedIndex = 0;
        }

        private void RefreshPorts()
        {
            comboBox_Ports.Items.Clear();
            comboBox_Ports.Items.AddRange(SerialPort.GetPortNames());
            if (comboBox_Ports.Items.Count > 0)
                comboBox_Ports.SelectedIndex = 0;
        }

        private void button_RefreshPorts_Click(object sender, EventArgs e)
        {
            RefreshPorts();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            new SimpleConsoleForm(comboBox_Ports.Text, int.Parse(comboBox_Bauds.Text)).Show();

            // TODO: do not let 2 windows open for the same serial port
        }
    }
}
