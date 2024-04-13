<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adbpair
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
        Me.TextBoxPairAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxPairCode = New System.Windows.Forms.TextBox()
        Me.CodeLabel = New System.Windows.Forms.Label()
        Me.ButtonPair = New System.Windows.Forms.Button()
        Me.LinkLabelReadme = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'TextBoxPairAddress
        '
        Me.TextBoxPairAddress.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBoxPairAddress.ForeColor = System.Drawing.Color.White
        Me.TextBoxPairAddress.Location = New System.Drawing.Point(72, 3)
        Me.TextBoxPairAddress.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxPairAddress.MaxLength = 30
        Me.TextBoxPairAddress.Name = "TextBoxPairAddress"
        Me.TextBoxPairAddress.ShortcutsEnabled = False
        Me.TextBoxPairAddress.Size = New System.Drawing.Size(126, 20)
        Me.TextBoxPairAddress.TabIndex = 22
        Me.TextBoxPairAddress.Text = "10.0.0.27:5555"
        Me.TextBoxPairAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(-1, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Address/Port:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.UseCompatibleTextRendering = True
        '
        'TextBoxPairCode
        '
        Me.TextBoxPairCode.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBoxPairCode.ForeColor = System.Drawing.Color.White
        Me.TextBoxPairCode.Location = New System.Drawing.Point(109, 23)
        Me.TextBoxPairCode.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxPairCode.MaxLength = 6
        Me.TextBoxPairCode.Name = "TextBoxPairCode"
        Me.TextBoxPairCode.ShortcutsEnabled = False
        Me.TextBoxPairCode.Size = New System.Drawing.Size(89, 20)
        Me.TextBoxPairCode.TabIndex = 24
        Me.TextBoxPairCode.Text = "123456"
        Me.TextBoxPairCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CodeLabel
        '
        Me.CodeLabel.AutoSize = True
        Me.CodeLabel.BackColor = System.Drawing.Color.Transparent
        Me.CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.CodeLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CodeLabel.Location = New System.Drawing.Point(36, 23)
        Me.CodeLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.CodeLabel.Name = "CodeLabel"
        Me.CodeLabel.Size = New System.Drawing.Size(73, 17)
        Me.CodeLabel.TabIndex = 23
        Me.CodeLabel.Text = "Pairing Code:"
        Me.CodeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CodeLabel.UseCompatibleTextRendering = True
        '
        'ButtonPair
        '
        Me.ButtonPair.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPair.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPair.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ButtonPair.Location = New System.Drawing.Point(86, 43)
        Me.ButtonPair.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPair.Name = "ButtonPair"
        Me.ButtonPair.Size = New System.Drawing.Size(112, 25)
        Me.ButtonPair.TabIndex = 25
        Me.ButtonPair.Text = "Attempt Pairing"
        Me.ButtonPair.UseVisualStyleBackColor = False
        '
        'LinkLabelReadme
        '
        Me.LinkLabelReadme.AutoSize = True
        Me.LinkLabelReadme.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelReadme.Location = New System.Drawing.Point(4, 68)
        Me.LinkLabelReadme.Name = "LinkLabelReadme"
        Me.LinkLabelReadme.Size = New System.Drawing.Size(118, 13)
        Me.LinkLabelReadme.TabIndex = 26
        Me.LinkLabelReadme.TabStop = True
        Me.LinkLabelReadme.Text = "Link to readme for help."
        '
        'adbpair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.adb1.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(200, 100)
        Me.Controls.Add(Me.LinkLabelReadme)
        Me.Controls.Add(Me.ButtonPair)
        Me.Controls.Add(Me.TextBoxPairCode)
        Me.Controls.Add(Me.CodeLabel)
        Me.Controls.Add(Me.TextBoxPairAddress)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adbpair"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Pair ADB"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxPairAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxPairCode As TextBox
    Friend WithEvents CodeLabel As Label
    Friend WithEvents ButtonPair As Button
    Friend WithEvents LinkLabelReadme As LinkLabel
End Class
