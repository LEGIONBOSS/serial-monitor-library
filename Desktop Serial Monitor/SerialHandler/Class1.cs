using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace SerialHandler
{
    public class SerialHandler
    {
        public static List<string> GetSerialPorts
        {
            get
            {
                return new List<string>(System.IO.Ports.SerialPort.GetPortNames());
            }
        }

        public static void CloseAll()
        {
            GetSerialPorts.ForEach(port =>
            {
                try
                {
                    var sp = new System.IO.Ports.SerialPort(port);
                    if (sp.IsOpen)
                    {
                        sp.Close();
                    }
                }
                catch (Exception)
                {
                    //throw;
                }
            });
        }
    }

    public class SerialPort
    {
        public System.IO.Ports.SerialPort SerialPortObject { get; private set; }

        public string PortName
        {
            get
            {
                return SerialPortObject.PortName;
            }
        }

        public int BaudRate
        {
            get
            {
                return SerialPortObject.BaudRate;
            }
        }
    }
}
