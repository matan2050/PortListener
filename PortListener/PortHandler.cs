using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace PortListener
{
	public class PortHandler
	{
		#region FIELDS
		private		SerialPort	port;
		private		string      outputPath;
		private     int         baudRate;
		
		#endregion

		#region CONSTRUCTOR
		public PortHandler(string _outputPath, string _portId, int _baudRate, Parity _parity, StopBits _stopBits )
		{
			outputPath = _outputPath;
			port.PortName = _portId;
			port.Parity = _parity;
			port.StopBits = _stopBits;
		}

		~PortHandler()
		{
			port.Close();
		}
		#endregion

		#region METHODS
	
		#endregion
	}
}
