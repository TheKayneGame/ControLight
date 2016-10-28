<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
		Me.Button1 = New System.Windows.Forms.Button()
		Me.ToLed = New System.Windows.Forms.Label()
		Me.ColorDialog = New System.Windows.Forms.ColorDialog()
		Me.valRedBox = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.valGreenBox = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.valBlueBox = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.BrightnessControl = New System.Windows.Forms.TrackBar()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.LedFrom = New System.Windows.Forms.NumericUpDown()
		Me.FromLed = New System.Windows.Forms.Label()
		Me.LedTo = New System.Windows.Forms.NumericUpDown()
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.SavePreset = New System.Windows.Forms.ToolStripButton()
		Me.LoadPreset = New System.Windows.Forms.ToolStripButton()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
		Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
		Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
		Me.Button7 = New System.Windows.Forms.Button()
		CType(Me.BrightnessControl, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LedFrom, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LedTo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ToolStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(13, 29)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Pick Color"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'ToLed
		'
		Me.ToLed.AutoSize = True
		Me.ToLed.Location = New System.Drawing.Point(94, 144)
		Me.ToLed.Name = "ToLed"
		Me.ToLed.Size = New System.Drawing.Size(20, 13)
		Me.ToLed.TabIndex = 12
		Me.ToLed.Text = "To"
		'
		'ColorDialog
		'
		'
		'valRedBox
		'
		Me.valRedBox.Location = New System.Drawing.Point(139, 31)
		Me.valRedBox.Name = "valRedBox"
		Me.valRedBox.ReadOnly = True
		Me.valRedBox.Size = New System.Drawing.Size(71, 20)
		Me.valRedBox.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(94, 34)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(27, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Red"
		'
		'valGreenBox
		'
		Me.valGreenBox.Location = New System.Drawing.Point(139, 57)
		Me.valGreenBox.Name = "valGreenBox"
		Me.valGreenBox.ReadOnly = True
		Me.valGreenBox.Size = New System.Drawing.Size(71, 20)
		Me.valGreenBox.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(94, 60)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(36, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Green"
		'
		'valBlueBox
		'
		Me.valBlueBox.Location = New System.Drawing.Point(139, 83)
		Me.valBlueBox.Name = "valBlueBox"
		Me.valBlueBox.ReadOnly = True
		Me.valBlueBox.Size = New System.Drawing.Size(71, 20)
		Me.valBlueBox.TabIndex = 5
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(94, 86)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(28, 13)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Blue"
		'
		'BrightnessControl
		'
		Me.BrightnessControl.Location = New System.Drawing.Point(15, 102)
		Me.BrightnessControl.Maximum = 255
		Me.BrightnessControl.Name = "BrightnessControl"
		Me.BrightnessControl.Orientation = System.Windows.Forms.Orientation.Vertical
		Me.BrightnessControl.Size = New System.Drawing.Size(45, 260)
		Me.BrightnessControl.TabIndex = 7
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(12, 86)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(56, 13)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Brightness"
		'
		'LedFrom
		'
		Me.LedFrom.Location = New System.Drawing.Point(139, 115)
		Me.LedFrom.Name = "LedFrom"
		Me.LedFrom.Size = New System.Drawing.Size(71, 20)
		Me.LedFrom.TabIndex = 9
		'
		'FromLed
		'
		Me.FromLed.AutoSize = True
		Me.FromLed.Location = New System.Drawing.Point(94, 117)
		Me.FromLed.Name = "FromLed"
		Me.FromLed.Size = New System.Drawing.Size(30, 13)
		Me.FromLed.TabIndex = 10
		Me.FromLed.Text = "From"
		'
		'LedTo
		'
		Me.LedTo.Location = New System.Drawing.Point(139, 142)
		Me.LedTo.Name = "LedTo"
		Me.LedTo.Size = New System.Drawing.Size(71, 20)
		Me.LedTo.TabIndex = 11
		'
		'ListBox1
		'
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.Location = New System.Drawing.Point(216, 28)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(202, 329)
		Me.ListBox1.TabIndex = 13
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(135, 168)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 14
		Me.Button2.Text = "Add"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(135, 197)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 23)
		Me.Button3.TabIndex = 15
		Me.Button3.Text = "Remove"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(135, 227)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(75, 23)
		Me.Button4.TabIndex = 16
		Me.Button4.Text = "Move Up"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button5
		'
		Me.Button5.Location = New System.Drawing.Point(135, 257)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(75, 23)
		Me.Button5.TabIndex = 17
		Me.Button5.Text = "Move Down"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button6
		'
		Me.Button6.Location = New System.Drawing.Point(135, 305)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(75, 23)
		Me.Button6.TabIndex = 19
		Me.Button6.Text = "Apply"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'SavePreset
		'
		Me.SavePreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.SavePreset.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.SavePreset.Name = "SavePreset"
		Me.SavePreset.Size = New System.Drawing.Size(70, 22)
		Me.SavePreset.Text = "Save Preset"
		'
		'LoadPreset
		'
		Me.LoadPreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.LoadPreset.Image = CType(resources.GetObject("LoadPreset.Image"), System.Drawing.Image)
		Me.LoadPreset.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.LoadPreset.Name = "LoadPreset"
		Me.LoadPreset.Size = New System.Drawing.Size(69, 22)
		Me.LoadPreset.Text = "LoadPreset"
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SavePreset, Me.LoadPreset, Me.ToolStripLabel1, Me.ToolStripComboBox1})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(430, 25)
		Me.ToolStrip1.TabIndex = 18
		Me.ToolStrip1.Text = "ToolStrip1"
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(61, 22)
		Me.ToolStripLabel1.Text = "Com Port:"
		'
		'ToolStripComboBox1
		'
		Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
		Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 25)
		'
		'Button7
		'
		Me.Button7.Location = New System.Drawing.Point(135, 334)
		Me.Button7.Name = "Button7"
		Me.Button7.Size = New System.Drawing.Size(75, 23)
		Me.Button7.TabIndex = 20
		Me.Button7.Text = "ForceUpdate"
		Me.Button7.UseVisualStyleBackColor = True
		'
		'Main
		'
		Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(430, 398)
		Me.Controls.Add(Me.Button7)
		Me.Controls.Add(Me.Button6)
		Me.Controls.Add(Me.ToolStrip1)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.ListBox1)
		Me.Controls.Add(Me.ToLed)
		Me.Controls.Add(Me.LedTo)
		Me.Controls.Add(Me.FromLed)
		Me.Controls.Add(Me.LedFrom)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.BrightnessControl)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.valBlueBox)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.valGreenBox)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.valRedBox)
		Me.Controls.Add(Me.Button1)
		Me.DoubleBuffered = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "Main"
		Me.Text = "Main"
		CType(Me.BrightnessControl, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LedFrom, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LedTo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents ToLed As Label
	Friend WithEvents ColorDialog As ColorDialog
	Friend WithEvents valRedBox As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents valGreenBox As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents valBlueBox As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents BrightnessControl As TrackBar
	Friend WithEvents Label4 As Label
	Friend WithEvents LedFrom As NumericUpDown
	Friend WithEvents FromLed As Label
	Friend WithEvents LedTo As NumericUpDown
	Friend WithEvents ListBox1 As ListBox
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Button5 As Button
	Friend WithEvents Button6 As Button
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents SavePreset As ToolStripButton
	Friend WithEvents LoadPreset As ToolStripButton
	Friend WithEvents ToolStrip1 As ToolStrip
	Friend WithEvents ToolStripLabel1 As ToolStripLabel
	Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
	Friend WithEvents SerialPort1 As IO.Ports.SerialPort
	Friend WithEvents Button7 As Button
End Class
