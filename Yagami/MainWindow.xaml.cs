using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
		System.Windows.Controls.Primitives.ToggleButton tb = new ToggleButton();
		public MainWindow()
		{
			InitializeComponent();
			initButtonbar();
			Buttonbar(60);

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
			string[] buffVals = "".Split(';'); //set this to buffer of values
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

		public void initButtonbar()
		{
			RowDefinition gridRow = new RowDefinition();
			gridRow.Name = "Led";
			DynamicGrid.RowDefinitions.Add(gridRow);
		}

		public void Buttonbar(int bar)
		{

			DynamicGrid.ColumnDefinitions.Clear();
			//DynamicGrid.Width = 21;

			for (int x = 0; x < bar; x++)
			{
				ColumnDefinition gridCol = new ColumnDefinition();
				gridCol.Name = "Column" + x.ToString();
				DynamicGrid.ColumnDefinitions.Add(gridCol);
				int count = 1;
				Button MyControl1 = new Button();
				MyControl1.Content = count.ToString();
				MyControl1.Name = "Button" + count.ToString();

				Grid.SetColumn(MyControl1, x);
				Grid.SetRow(MyControl1, 1);
				DynamicGrid.Children.Add(MyControl1);

				count++;

				tb.VerticalAlignment = VerticalAlignment.Stretch;
				tb.HorizontalAlignment = HorizontalAlignment.Stretch;
				Grid.SetColumn(tb, x);
				Grid.SetRow(tb, 1);
					
			}
		}

	}


}

