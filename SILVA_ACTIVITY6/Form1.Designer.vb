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
        Label1 = New Label()
        Label2 = New Label()
        lblResult = New Label()
        txtFirstNum = New TextBox()
        txtSecondNum = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 15)
        Label2.TabIndex = 1
        Label2.Text = "Second Number"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(20, 236)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(41, 15)
        lblResult.TabIndex = 2
        lblResult.Text = "Label3"
        ' 
        ' txtFirstNum
        ' 
        txtFirstNum.Location = New Point(20, 54)
        txtFirstNum.Name = "txtFirstNum"
        txtFirstNum.Size = New Size(97, 23)
        txtFirstNum.TabIndex = 3
        ' 
        ' txtSecondNum
        ' 
        txtSecondNum.Location = New Point(21, 143)
        txtSecondNum.Name = "txtSecondNum"
        txtSecondNum.Size = New Size(96, 23)
        txtSecondNum.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(21, 192)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 5
        Button1.Text = "Divide"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(txtSecondNum)
        Controls.Add(txtFirstNum)
        Controls.Add(lblResult)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents txtSecondNum As TextBox
    Friend WithEvents Button1 As Button
End Class
