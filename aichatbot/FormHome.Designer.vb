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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.aichatbot.My.Resources.Resources.Screenshot_2024_10_26_at_09_50_12_Font_Awesome
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(393, 336)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 174)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonQB
        '
        Me.ButtonQB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonQB.Location = New System.Drawing.Point(197, 348)
        Me.ButtonQB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonQB.Name = "ButtonQB"
        Me.ButtonQB.Size = New System.Drawing.Size(169, 155)
        Me.ButtonQB.TabIndex = 2
        Me.ButtonQB.Text = "Question Bank"
        Me.ButtonQB.UseVisualStyleBackColor = True
        '
        'ButtonEval
        '
        Me.ButtonEval.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonEval.Location = New System.Drawing.Point(612, 348)
        Me.ButtonEval.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonEval.Name = "ButtonEval"
        Me.ButtonEval.Size = New System.Drawing.Size(169, 155)
        Me.ButtonEval.TabIndex = 3
        Me.ButtonEval.Text = "Evaluation"
        Me.ButtonEval.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.aichatbot.My.Resources.Resources.Copy_of_vbnet_ai_menu_page
        Me.PictureBox1.Location = New System.Drawing.Point(265, 156)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(436, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.BackgroundImage = Global.aichatbot.My.Resources.Resources.img_2024_10_26_09_14_18_cleanup
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 711)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonEval)
        Me.Controls.Add(Me.ButtonQB)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormHome"
        Me.Text = "FormHome"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonQB As Button
    Friend WithEvents ButtonEval As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
