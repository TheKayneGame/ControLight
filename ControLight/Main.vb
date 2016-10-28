Imports System.Windows.Input

Public Class Main

	Dim valRed
	Dim valGreen
	Dim valBlue

	Private Sub ColorDialog_Disposed(sender As Object, e As EventArgs) Handles ColorDialog.Disposed

	End Sub

	Private Sub PickColor_Click(sender As Object, e As EventArgs) Handles Button1.Click
		ColorDialog.ShowDialog()
		valRed = ColorDialog.Color.R()
		valGreen = ColorDialog.Color.G()
		valBlue = ColorDialog.Color.B()
		valRedBox.Text = valRed
		valGreenBox.Text = valGreen
		valBlueBox.Text = valBlue


	End Sub

	Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs) Handles ToolStripComboBox1.Click
		ToolStripComboBox1.Items.Clear()
		For Each s As String In SerialPort1.GetPortNames()
			ToolStripComboBox1.Items.Add(s)

		Next
	End Sub

	Private Sub AddClick(sender As Object, e As EventArgs) Handles Button2.Click
		ListBox1.Items.Add(LedFrom.Value & ";" & LedTo.Value & ";" & valRed & ";" & valGreen & ";" & valBlue)
	End Sub

	Private Sub RemoveClick(sender As Object, e As EventArgs) Handles Button3.Click
		If ListBox1.SelectedIndex > 0 Then
			ListBox1.Items.RemoveAt(ListBox1.SelectedIndex())
		End If
	End Sub

	Private Sub MoveDown_Click(sender As Object, e As EventArgs) Handles Button5.Click
		If ListBox1.Items.Count > 0 Then
			Dim index As Integer = ListBox1.SelectedIndex + 1
			If index <= ListBox1.Items.Count - 1 Then
				ListBox1.Items.Insert(index + 1, ListBox1.SelectedItem)
				ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
				ListBox1.SelectedIndex = index
			End If
		End If
	End Sub

	Private Sub MoveUp_Click(sender As Object, e As EventArgs) Handles Button4.Click
		If ListBox1.Items.Count > 0 Then
			Dim index As Integer = ListBox1.SelectedIndex - 1
			If index >= 0 Then
				ListBox1.Items.Insert(index, ListBox1.SelectedItem)
				ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
				ListBox1.SelectedIndex = index

			End If
		End If
	End Sub

	Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Button6.Click
		SerialPort1.BaudRate = 115200
		If SerialPort1.IsOpen Then

			'For Each s As String In ListBox1.Items.Count.ToString()
			'For s = 0 To ListBox1.Items.Count Step 1

			Dim Commands

			Dim s As Integer = Nothing
			While s < ListBox1.Items.Count
				Commands = Commands + "readVal;0;" + ListBox1.Items.Item(s).ToString()
				s += 1
			End While
			Commands = s.ToString() + ";" + Commands + "displayColours;0;0;0;0;0;0/"
			Console.WriteLine(Commands)
			SerialPort1.WriteLine(Commands)
			SerialPort1.WriteTimeout = 100
			SerialPort1.DiscardOutBuffer()
		End If

	End Sub



	Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
		SerialPort1.Close()
		SerialPort1.PortName() = "COM3"
		SerialPort1.Open()
		Dim PortName = ToolStripComboBox1.SelectedText()
	End Sub

	Private Sub onCLose(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		SerialPort1.Close()
	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		SerialPort1.DiscardOutBuffer()
		SerialPort1.WriteLine("displayColours")
		SerialPort1.WriteTimeout = 100
		SerialPort1.DiscardOutBuffer()
	End Sub
End Class
