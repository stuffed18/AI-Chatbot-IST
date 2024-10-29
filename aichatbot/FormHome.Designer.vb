<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonQB = New System.Windows.Forms.Button()
        Me.ButtonEval = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.aichatbot.My.Resources.Resources.Screenshot_2024_10_26_at_09_50_12_Font_Awesome
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(295, 273)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 142)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonQB
        '
        Me.ButtonQB.BackgroundImage = Global.aichatbot.My.Resources.Resources.Untitled_design_15_1
        Me.ButtonQB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonQB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonQB.Location = New System.Drawing.Point(145, 283)
        Me.ButtonQB.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonQB.Name = "ButtonQB"
        Me.ButtonQB.Size = New System.Drawing.Size(127, 127)
        Me.ButtonQB.TabIndex = 2
        Me.ButtonQB.UseVisualStyleBackColor = True
        '
        'ButtonEval
        '
        Me.ButtonEval.BackgroundImage = Global.aichatbot.My.Resources.Resources.Untitled_design_14_
        Me.ButtonEval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEval.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonEval.Location = New System.Drawing.Point(460, 283)
        Me.ButtonEval.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEval.Name = "ButtonEval"
        Me.ButtonEval.Size = New System.Drawing.Size(127, 127)
        Me.ButtonEval.TabIndex = 3
        Me.ButtonEval.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.aichatbot.My.Resources.Resources.Copy_of_vbnet_ai_menu_page
        Me.PictureBox1.Location = New System.Drawing.Point(199, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExit.BackgroundImage = Global.aichatbot.My.Resources.Resources.Untitled_design_16_
        Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft YaHei", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(11, 11)
        Me.ButtonExit.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(50, 50)
        Me.ButtonExit.TabIndex = 6
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(140, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Question Bank"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(284, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 30)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Chat with Codex"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(475, 411)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Evaluation"
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.BackgroundImage = Global.aichatbot.My.Resources.Resources.img_2024_10_26_09_14_18_cleanup
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(738, 578)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonEval)
        Me.Controls.Add(Me.ButtonQB)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FormHome"
        Me.Text = "VB.net AI: Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonQB As Button
    Friend WithEvents ButtonEval As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ButtonExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
