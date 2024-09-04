using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialMonitorLib
{
    public class SerialHandler
    {
        public static List<string> COMPortsAvailable => SerialPort.GetPortNames().ToList();
        private Dictionary<string, SerialDevice> SerialDevices = new Dictionary<string, SerialDevice>();
    }

    internal class SerialDevice
    {
        /* COM Port (string)
         * Sevice name (string)
         * Baud rate (int)
         * Line ending type (string selection)
         */
    }

    internal static class LineEnding
    {
        internal static string None => "";
        internal static string LF => "\n";
        internal static string CR => "\r";
        internal static string CRLF => CR + LF;
    }
}
