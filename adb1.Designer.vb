﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FM
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FM))
        Me.ButtonPP = New System.Windows.Forms.Button()
        Me.ButtonM = New System.Windows.Forms.Button()
        Me.NI = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CMSE = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSMIE = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonLV = New System.Windows.Forms.Button()
        Me.ButtonRV = New System.Windows.Forms.Button()
        Me.ButtonE = New System.Windows.Forms.Button()
        Me.TextBoxV = New System.Windows.Forms.TextBox()
        Me.ButtonP = New System.Windows.Forms.Button()
        Me.ButtonN = New System.Windows.Forms.Button()
        Me.ButtonSV = New System.Windows.Forms.Button()
        Me.LT = New System.Windows.Forms.Label()
        Me.PBC = New System.Windows.Forms.PictureBox()
        Me.TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ButtonPair = New System.Windows.Forms.Button()
        Me.ErrorDetailsLabel = New System.Windows.Forms.Label()
        Me.ShortStatusLabel = New System.Windows.Forms.Label()
        Me.CMSE.SuspendLayout()
        CType(Me.PBC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonPP
        '
        Me.ButtonPP.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.ButtonPP.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonPP.Location = New System.Drawing.Point(64, 30)
        Me.ButtonPP.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPP.Name = "ButtonPP"
        Me.ButtonPP.Size = New System.Drawing.Size(62, 20)
        Me.ButtonPP.TabIndex = 4
        Me.ButtonPP.Text = "Pause/Play"
        Me.ButtonPP.UseVisualStyleBackColor = False
        '
        'ButtonM
        '
        Me.ButtonM.BackColor = System.Drawing.Color.Transparent
        Me.ButtonM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonM.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonM.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonM.Location = New System.Drawing.Point(100, 2)
        Me.ButtonM.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonM.Name = "ButtonM"
        Me.ButtonM.Size = New System.Drawing.Size(55, 20)
        Me.ButtonM.TabIndex = 6
        Me.ButtonM.Text = "Minimize"
        Me.TT.SetToolTip(Me.ButtonM, "Minimizes tool to tray.")
        Me.ButtonM.UseVisualStyleBackColor = False
        '
        'NI
        '
        Me.NI.Icon = CType(resources.GetObject("NI.Icon"), System.Drawing.Icon)
        Me.NI.Text = "WIFI ADB GUI"
        Me.NI.Visible = True
        '
        'CMSE
        '
        Me.CMSE.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMIE})
        Me.CMSE.Name = "CMSE"
        Me.CMSE.Size = New System.Drawing.Size(94, 24)
        '
        'TSMIE
        '
        Me.TSMIE.Name = "TSMIE"
        Me.TSMIE.Padding = New System.Windows.Forms.Padding(0)
        Me.TSMIE.Size = New System.Drawing.Size(93, 20)
        Me.TSMIE.Text = "Exit"
        '
        'ButtonLV
        '
        Me.ButtonLV.BackColor = System.Drawing.Color.Transparent
        Me.ButtonLV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLV.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonLV.Location = New System.Drawing.Point(178, 73)
        Me.ButtonLV.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonLV.Name = "ButtonLV"
        Me.ButtonLV.Size = New System.Drawing.Size(20, 20)
        Me.ButtonLV.TabIndex = 9
        Me.ButtonLV.Text = "-"
        Me.ButtonLV.UseVisualStyleBackColor = False
        '
        'ButtonRV
        '
        Me.ButtonRV.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRV.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonRV.Location = New System.Drawing.Point(178, 33)
        Me.ButtonRV.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonRV.Name = "ButtonRV"
        Me.ButtonRV.Size = New System.Drawing.Size(20, 20)
        Me.ButtonRV.TabIndex = 10
        Me.ButtonRV.Text = "+"
        Me.ButtonRV.UseVisualStyleBackColor = False
        '
        'ButtonE
        '
        Me.ButtonE.BackColor = System.Drawing.Color.Red
        Me.ButtonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonE.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonE.ForeColor = System.Drawing.Color.White
        Me.ButtonE.Location = New System.Drawing.Point(155, 2)
        Me.ButtonE.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonE.Name = "ButtonE"
        Me.ButtonE.Size = New System.Drawing.Size(43, 20)
        Me.ButtonE.TabIndex = 11
        Me.ButtonE.Text = "Exit"
        Me.TT.SetToolTip(Me.ButtonE, "Disconnects and exits the application.")
        Me.ButtonE.UseVisualStyleBackColor = False
        '
        'TextBoxV
        '
        Me.TextBoxV.BackColor = System.Drawing.Color.DarkGreen
        Me.TextBoxV.ForeColor = System.Drawing.Color.White
        Me.TextBoxV.Location = New System.Drawing.Point(178, 53)
        Me.TextBoxV.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxV.MaxLength = 2
        Me.TextBoxV.Name = "TextBoxV"
        Me.TextBoxV.ShortcutsEnabled = False
        Me.TextBoxV.Size = New System.Drawing.Size(20, 20)
        Me.TextBoxV.TabIndex = 13
        Me.TextBoxV.Text = "00"
        Me.TextBoxV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TT.SetToolTip(Me.TextBoxV, "Max volume 15 if I remember correctly")
        '
        'ButtonP
        '
        Me.ButtonP.BackColor = System.Drawing.Color.Transparent
        Me.ButtonP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.ButtonP.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonP.Location = New System.Drawing.Point(12, 30)
        Me.ButtonP.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonP.Name = "ButtonP"
        Me.ButtonP.Size = New System.Drawing.Size(52, 20)
        Me.ButtonP.TabIndex = 14
        Me.ButtonP.Text = "Previous"
        Me.ButtonP.UseVisualStyleBackColor = False
        '
        'ButtonN
        '
        Me.ButtonN.BackColor = System.Drawing.Color.Transparent
        Me.ButtonN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonN.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.ButtonN.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonN.Location = New System.Drawing.Point(126, 30)
        Me.ButtonN.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonN.Name = "ButtonN"
        Me.ButtonN.Size = New System.Drawing.Size(39, 20)
        Me.ButtonN.TabIndex = 15
        Me.ButtonN.Text = "Next"
        Me.ButtonN.UseVisualStyleBackColor = False
        '
        'ButtonSV
        '
        Me.ButtonSV.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSV.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonSV.Location = New System.Drawing.Point(149, 53)
        Me.ButtonSV.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonSV.Name = "ButtonSV"
        Me.ButtonSV.Size = New System.Drawing.Size(29, 20)
        Me.ButtonSV.TabIndex = 16
        Me.ButtonSV.Text = "Set"
        Me.TT.SetToolTip(Me.ButtonSV, "Make sure to click set after inputting a number.")
        Me.ButtonSV.UseVisualStyleBackColor = False
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.BackColor = System.Drawing.Color.Transparent
        Me.LT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LT.ForeColor = System.Drawing.Color.DarkGreen
        Me.LT.Location = New System.Drawing.Point(1, 130)
        Me.LT.Margin = New System.Windows.Forms.Padding(0)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(109, 22)
        Me.LT.TabIndex = 17
        Me.LT.Text = "WIFI ADB GUI"
        Me.LT.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.TT.SetToolTip(Me.LT, "Made with love.")
        Me.LT.UseCompatibleTextRendering = True
        '
        'PBC
        '
        Me.PBC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PBC.BackColor = System.Drawing.Color.Transparent
        Me.PBC.BackgroundImage = Global.WiFiADBGUI.My.Resources.Resources.adbicon
        Me.PBC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBC.Location = New System.Drawing.Point(1, 2)
        Me.PBC.Margin = New System.Windows.Forms.Padding(0)
        Me.PBC.Name = "PBC"
        Me.PBC.Size = New System.Drawing.Size(22, 22)
        Me.PBC.TabIndex = 18
        Me.PBC.TabStop = False
        Me.TT.SetToolTip(Me.PBC, "Click to reconnect. Already connected if nothing happens.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(0, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Address/Port:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.UseCompatibleTextRendering = True
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.BackColor = System.Drawing.Color.DarkGreen
        Me.TextBoxAddress.ForeColor = System.Drawing.Color.White
        Me.TextBoxAddress.Location = New System.Drawing.Point(73, 93)
        Me.TextBoxAddress.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxAddress.MaxLength = 30
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.ShortcutsEnabled = False
        Me.TextBoxAddress.Size = New System.Drawing.Size(125, 20)
        Me.TextBoxAddress.TabIndex = 20
        Me.TextBoxAddress.Text = "10.0.0.27:5555"
        Me.TextBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonConnect
        '
        Me.ButtonConnect.BackColor = System.Drawing.Color.Transparent
        Me.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonConnect.Location = New System.Drawing.Point(73, 113)
        Me.ButtonConnect.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(57, 22)
        Me.ButtonConnect.TabIndex = 21
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'ButtonPair
        '
        Me.ButtonPair.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPair.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.ButtonPair.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonPair.Location = New System.Drawing.Point(29, 2)
        Me.ButtonPair.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPair.Name = "ButtonPair"
        Me.ButtonPair.Size = New System.Drawing.Size(71, 20)
        Me.ButtonPair.TabIndex = 22
        Me.ButtonPair.Text = "Pair"
        Me.ButtonPair.UseVisualStyleBackColor = False
        '
        'ErrorDetailsLabel
        '
        Me.ErrorDetailsLabel.AutoSize = True
        Me.ErrorDetailsLabel.BackColor = System.Drawing.Color.Red
        Me.ErrorDetailsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorDetailsLabel.Location = New System.Drawing.Point(131, 120)
        Me.ErrorDetailsLabel.Name = "ErrorDetailsLabel"
        Me.ErrorDetailsLabel.Size = New System.Drawing.Size(70, 32)
        Me.ErrorDetailsLabel.TabIndex = 24
        Me.ErrorDetailsLabel.Text = "ERROR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DETAILS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ErrorDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ErrorDetailsLabel.Visible = False
        '
        'ShortStatusLabel
        '
        Me.ShortStatusLabel.AutoSize = True
        Me.ShortStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.ShortStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ShortStatusLabel.ForeColor = System.Drawing.Color.Magenta
        Me.ShortStatusLabel.Location = New System.Drawing.Point(13, 63)
        Me.ShortStatusLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ShortStatusLabel.Name = "ShortStatusLabel"
        Me.ShortStatusLabel.Size = New System.Drawing.Size(0, 20)
        Me.ShortStatusLabel.TabIndex = 25
        Me.ShortStatusLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ShortStatusLabel.UseCompatibleTextRendering = True
        '
        'FM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.WiFiADBGUI.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(200, 150)
        Me.Controls.Add(Me.ShortStatusLabel)
        Me.Controls.Add(Me.ErrorDetailsLabel)
        Me.Controls.Add(Me.ButtonPair)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Controls.Add(Me.TextBoxAddress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBC)
        Me.Controls.Add(Me.LT)
        Me.Controls.Add(Me.ButtonSV)
        Me.Controls.Add(Me.ButtonN)
        Me.Controls.Add(Me.ButtonP)
        Me.Controls.Add(Me.TextBoxV)
        Me.Controls.Add(Me.ButtonE)
        Me.Controls.Add(Me.ButtonRV)
        Me.Controls.Add(Me.ButtonLV)
        Me.Controls.Add(Me.ButtonM)
        Me.Controls.Add(Me.ButtonPP)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "WIFI ADB GUI"
        Me.TopMost = True
        Me.CMSE.ResumeLayout(False)
        CType(Me.PBC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonPP As Button
    Friend WithEvents ButtonM As Button
    Friend WithEvents NI As NotifyIcon
    Friend WithEvents CMSE As ContextMenuStrip
    Friend WithEvents TSMIE As ToolStripMenuItem
    Friend WithEvents ButtonLV As Button
    Friend WithEvents ButtonRV As Button
    Friend WithEvents ButtonE As Button
    Friend WithEvents TextBoxV As TextBox
    Friend WithEvents ButtonP As Button
    Friend WithEvents ButtonN As Button
    Friend WithEvents ButtonSV As Button
    Friend WithEvents LT As Label
    Friend WithEvents PBC As PictureBox
    Friend WithEvents TT As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ButtonPair As Button
    Friend WithEvents ErrorDetailsLabel As Label
    Friend WithEvents ShortStatusLabel As Label
End Class
