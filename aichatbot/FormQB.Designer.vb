<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormQB
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
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonClearChat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanelQB = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonHome
        '
        Me.ButtonHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ButtonHome.BackgroundImage = Global.aichatbot.My.Resources.Resources.home_button_logo
        Me.ButtonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonHome.FlatAppearance.BorderSize = 0
        Me.ButtonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ButtonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHome.Location = New System.Drawing.Point(12, 12)
        Me.ButtonHome.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(43, 41)
        Me.ButtonHome.TabIndex = 9
        Me.ButtonHome.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.ButtonClearChat)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-8, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 544)
        Me.Panel1.TabIndex = 10
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(243, 86)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.FlowLayoutPanel1.TabIndex = 11
        '
        'ButtonClearChat
        '
        Me.ButtonClearChat.FlatAppearance.BorderSize = 0
        Me.ButtonClearChat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonClearChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonClearChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClearChat.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearChat.ForeColor = System.Drawing.Color.White
        Me.ButtonClearChat.Location = New System.Drawing.Point(42, 491)
        Me.ButtonClearChat.Name = "ButtonClearChat"
        Me.ButtonClearChat.Size = New System.Drawing.Size(97, 27)
        Me.ButtonClearChat.TabIndex = 9
        Me.ButtonClearChat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 74)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Question" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bank"
        '
        'FlowLayoutPanelQB
        '
        Me.FlowLayoutPanelQB.AutoScroll = True
        Me.FlowLayoutPanelQB.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanelQB.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanelQB.Location = New System.Drawing.Point(257, 26)
        Me.FlowLayoutPanelQB.Name = "FlowLayoutPanelQB"
        Me.FlowLayoutPanelQB.Size = New System.Drawing.Size(422, 499)
        Me.FlowLayoutPanelQB.TabIndex = 11
        Me.FlowLayoutPanelQB.WrapContents = False
        '
        'FormQB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.aichatbot.My.Resources.Resources.vs_background
        Me.ClientSize = New System.Drawing.Size(755, 537)
        Me.Controls.Add(Me.FlowLayoutPanelQB)
        Me.Controls.Add(Me.ButtonHome)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormQB"
        Me.Text = "FormQB"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonHome As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonClearChat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanelQB As FlowLayoutPanel
End Class
