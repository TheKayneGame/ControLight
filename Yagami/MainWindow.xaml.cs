using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Yagami
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		SerialPort serialPort = new SerialPort("COM5");
		public MainWindow()
		{
			InitializeComponent();

			if (serialPort is SerialPort)
			{
				serialPort.DataBits = 8;
				serialPort.Parity = Parity.None;
				serialPort.StopBits = StopBits.One;
				serialPort.BaudRate = 115200;
				serialPort.WriteTimeout = 5;
				serialPort.ReadTimeout = 5;

				try
				{
					serialPort.Open();
					serialPort.DiscardOutBuffer();
					serialPort.DiscardInBuffer();

					serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
				}
				catch (Exception exc)
				{
				}// end CATCH portion of TRY/CATCH block
			}// end IF serialPort is viable

		}
		
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string[] buffVals = "" //set this to buffer of values
			int[] vals = Array.ConvertAll<string, int>(buffVals, int.Parse);
			string command = "";

			for (int i = 0; i < vals.Length; i++)
			{
				command = command + Convert.ToChar(vals[i]).ToString();
			}
			
			Debug.WriteLine(command);
			serialPort.Write(command);
		}

		private static void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
		{
			SerialPort sp = (SerialPort)sender;
			string indata = sp.ReadExisting();
			Debug.WriteLine(indata.ToString());

		}
	}
}
