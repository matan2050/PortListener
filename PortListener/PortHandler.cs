using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;

namespace PortListener
{
	public class PortHandler
	{
		#region FIELDS
		private		SerialPort		port;
		private		string			outputPath;
		private     int				baudRate;
		private     Parity			parity;
		private     StopBits		stopBits;
		#endregion

		#region CONSTRUCTOR
		public PortHandler(string _outputPath, string _portId, int _baudRate, Parity _parity, StopBits _stopBits)
		{
			// set params
			outputPath = _outputPath;
			port.PortName = _portId;
			port.Parity = _parity;
			port.StopBits = _stopBits;

			// create new file for writing
			if (!File.Exists(outputPath))
			{
				File.Create(outputPath);
			}
			else
			{
				throw new Exception();
			}
		}

		~PortHandler()
		{
			port.Close();
		}
		#endregion

		#region METHODS
		public void Record()
		{
			bool keepRecording = true;

			while (keepRecording)
			{
				var availBytes = port.ReadExisting();
				using (StreamWriter sw = new StreamWriter(outputPath))
				{
					sw.Write(availBytes);
				}
			}
		}
		#endregion
	}
}
