<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		TextBox1 = New TextBox()
		TextBox2 = New TextBox()
		TextBox3 = New TextBox()
		Button1 = New Button()
		Label1 = New Label()
		Label2 = New Label()
		SuspendLayout()
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(238, 40)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(150, 31)
		TextBox1.TabIndex = 0
		' 
		' TextBox2
		' 
		TextBox2.Location = New Point(238, 95)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(150, 31)
		TextBox2.TabIndex = 1
		' 
		' TextBox3
		' 
		TextBox3.Location = New Point(242, 151)
		TextBox3.Name = "TextBox3"
		TextBox3.Size = New Size(150, 31)
		TextBox3.TabIndex = 2
		' 
		' Button1
		' 
		Button1.Location = New Point(102, 148)
		Button1.Name = "Button1"
		Button1.Size = New Size(112, 34)
		Button1.TabIndex = 3
		Button1.Text = "c equals to"
		Button1.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(119, 46)
		Label1.Name = "Label1"
		Label1.Size = New Size(66, 25)
		Label1.TabIndex = 4
		Label1.Text = "Enter a"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(119, 95)
		Label2.Name = "Label2"
		Label2.Size = New Size(68, 25)
		Label2.TabIndex = 5
		Label2.Text = "Enter b"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(Button1)
		Controls.Add(TextBox3)
		Controls.Add(TextBox2)
		Controls.Add(TextBox1)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
End Class
