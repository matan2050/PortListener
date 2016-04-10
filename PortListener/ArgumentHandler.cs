using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortListener
{
	public class ArgumentHandler
	{
		#region FIELDS
		private List<string> arginList;
		private List<string> abbreviatedList;
		#endregion

		#region CONSTRUCTOR
		public ArgumentHandler()
		{
			// TODO: consider using external configuration file (json, xml, whatevs)

			arginList = new List<string>();

			// implicit args, followed by '=' sign and value
			arginList.Add("-com");					// com port
			arginList.Add("-baudrate");				// baud rate
			arginList.Add("-parity");				// parity
			arginList.Add("-stopbits");				// stop bits

			// explicit args, followed by value
			abbreviatedList = new List<string>(arginList.Capacity);
			abbreviatedList.Add("-c");              // com port
			abbreviatedList.Add("-b");              // baud rate
			abbreviatedList.Add("-p");              // parity
			abbreviatedList.Add("-s");				// stop bits
		}
		#endregion

		#region METHODS
		public PortHandleParameters CheckArgs(string[] args)
		{
			var portHandleParams = new PortHandleParameters();

			for (int i = 0; i < args.Count(); i++)
			{
				foreach (string argin in arginList)
				{
					if (args[i] == argin)
					{
					}
					else
					{

					}

				}
			}
			return portHandleParams;
		}
		#endregion
	}
}

