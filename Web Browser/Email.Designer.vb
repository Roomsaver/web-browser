<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email
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
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(12, 25)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(100, 20)
        Me.txtFrom.TabIndex = 0
        Me.txtFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(47, 9)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 1
        Me.lblFrom.Text = "From"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(172, 25)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(100, 20)
        Me.txtTo.TabIndex = 2
        Me.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(212, 9)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 3
        Me.lblTo.Text = "To"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(123, 48)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(43, 13)
        Me.lblSubject.TabIndex = 4
        Me.lblSubject.Text = "Subject"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(12, 64)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(260, 20)
        Me.txtSubject.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(13, 91)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(259, 130)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Text = "Enter message here"
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSend.Location = New System.Drawing.Point(13, 227)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(259, 23)
        Me.btnSend.TabIndex = 7
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(12, 257)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 8
        Me.txtEmail.Text = "email@gmail.com"
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(172, 257)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 9
        Me.txtPassword.Text = "password"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(12, 283)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(260, 23)
        Me.progressBar.TabIndex = 10
        '
        'Email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(284, 314)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.txtFrom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Email"
        Me.Text = "Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFrom As TextBox
    Friend WithEvents lblFrom As Label
    Friend WithEvents txtTo As TextBox
    Friend WithEvents lblTo As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents progressBar As ProgressBar
End Class
