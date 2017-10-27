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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NavBar = New System.Windows.Forms.ToolStrip()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnForward = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.txtURL = New System.Windows.Forms.ToolStripTextBox()
        Me.btnGo = New System.Windows.Forms.ToolStripButton()
        Me.btnStop = New System.Windows.Forms.ToolStripButton()
        Me.btnSettings = New System.Windows.Forms.ToolStripButton()
        Me.btnEmail = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Browser = New System.Windows.Forms.WebBrowser()
        Me.NavBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'NavBar
        '
        Me.NavBar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NavBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBack, Me.btnForward, Me.btnRefresh, Me.txtURL, Me.btnGo, Me.btnStop, Me.btnSettings, Me.btnEmail, Me.ToolStripLabel1})
        Me.NavBar.Location = New System.Drawing.Point(0, 0)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.Size = New System.Drawing.Size(657, 25)
        Me.NavBar.TabIndex = 1
        Me.NavBar.Text = "NavBar"
        '
        'btnBack
        '
        Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(23, 22)
        Me.btnBack.Text = "BACK"
        '
        'btnForward
        '
        Me.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnForward.Image = CType(resources.GetObject("btnForward.Image"), System.Drawing.Image)
        Me.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(23, 22)
        Me.btnForward.Text = "FORWARD"
        '
        'btnRefresh
        '
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(23, 22)
        Me.btnRefresh.Text = "REFRESH"
        '
        'txtURL
        '
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(300, 25)
        '
        'btnGo
        '
        Me.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGo.Image = CType(resources.GetObject("btnGo.Image"), System.Drawing.Image)
        Me.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(23, 22)
        Me.btnGo.Text = "GO"
        '
        'btnStop
        '
        Me.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(23, 22)
        Me.btnStop.Text = "STOP"
        '
        'btnSettings
        '
        Me.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(23, 22)
        Me.btnSettings.Text = "SETTINGS"
        '
        'btnEmail
        '
        Me.btnEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEmail.Enabled = False
        Me.btnEmail.Image = CType(resources.GetObject("btnEmail.Image"), System.Drawing.Image)
        Me.btnEmail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(23, 22)
        Me.btnEmail.Text = "EMAIL"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel1.Text = "Alpha 0.3"
        '
        'Browser
        '
        Me.Browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Browser.Location = New System.Drawing.Point(0, 25)
        Me.Browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(657, 541)
        Me.Browser.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 566)
        Me.Controls.Add(Me.Browser)
        Me.Controls.Add(Me.NavBar)
        Me.Name = "Form1"
        Me.Text = "Web Browser"
        Me.NavBar.ResumeLayout(False)
        Me.NavBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NavBar As ToolStrip
    Friend WithEvents txtURL As ToolStripTextBox
    Friend WithEvents Browser As System.Windows.Forms.WebBrowser
    Friend WithEvents btnGo As ToolStripButton
    Friend WithEvents btnStop As ToolStripButton
    Friend WithEvents btnRefresh As ToolStripButton
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnForward As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btnSettings As ToolStripButton
    Friend WithEvents btnEmail As ToolStripButton
End Class
