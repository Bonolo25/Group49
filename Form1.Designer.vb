<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btnsetup = New System.Windows.Forms.Button()
        Me.txtdisplay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btnsavetofile = New System.Windows.Forms.Button()
        Me.Btnreadfromfile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btnsetup
        '
        Me.Btnsetup.Location = New System.Drawing.Point(15, 284)
        Me.Btnsetup.Name = "Btnsetup"
        Me.Btnsetup.Size = New System.Drawing.Size(131, 48)
        Me.Btnsetup.TabIndex = 0
        Me.Btnsetup.Text = "SETUP"
        Me.Btnsetup.UseVisualStyleBackColor = True
        '
        'txtdisplay
        '
        Me.txtdisplay.Location = New System.Drawing.Point(14, 25)
        Me.txtdisplay.Multiline = True
        Me.txtdisplay.Name = "txtdisplay"
        Me.txtdisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtdisplay.Size = New System.Drawing.Size(585, 241)
        Me.txtdisplay.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Display"
        '
        'Btnsavetofile
        '
        Me.Btnsavetofile.Location = New System.Drawing.Point(181, 284)
        Me.Btnsavetofile.Name = "Btnsavetofile"
        Me.Btnsavetofile.Size = New System.Drawing.Size(122, 48)
        Me.Btnsavetofile.TabIndex = 5
        Me.Btnsavetofile.Text = "SAVETOFILE"
        Me.Btnsavetofile.UseVisualStyleBackColor = True
        '
        'Btnreadfromfile
        '
        Me.Btnreadfromfile.Location = New System.Drawing.Point(340, 285)
        Me.Btnreadfromfile.Name = "Btnreadfromfile"
        Me.Btnreadfromfile.Size = New System.Drawing.Size(161, 47)
        Me.Btnreadfromfile.TabIndex = 6
        Me.Btnreadfromfile.Text = "READFROMFILE"
        Me.Btnreadfromfile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(643, 348)
        Me.Controls.Add(Me.Btnreadfromfile)
        Me.Controls.Add(Me.Btnsavetofile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdisplay)
        Me.Controls.Add(Me.Btnsetup)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "ERADICATE EXTREME POVERTY AND HUNGER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnsetup As Button
    Friend WithEvents txtdisplay As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnsavetofile As Button
    Friend WithEvents Btnreadfromfile As Button
End Class
