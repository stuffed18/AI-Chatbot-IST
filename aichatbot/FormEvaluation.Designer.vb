<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEvaluation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEvaluation))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.ButtonClearChat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelEval = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.ButtonHome)
        Me.Panel1.Controls.Add(Me.ButtonClearChat)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-9, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 544)
        Me.Panel1.TabIndex = 11
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(243, 86)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.FlowLayoutPanel1.TabIndex = 11
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
        Me.ButtonHome.Location = New System.Drawing.Point(22, 13)
        Me.ButtonHome.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(43, 43)
        Me.ButtonHome.TabIndex = 9
        Me.ButtonHome.UseVisualStyleBackColor = False
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
        Me.Label1.Location = New System.Drawing.Point(15, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Evaluation"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(545, 166)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(183, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Evaluation Questions"
        '
        'LabelEval
        '
        Me.LabelEval.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelEval.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEval.ForeColor = System.Drawing.Color.White
        Me.LabelEval.Location = New System.Drawing.Point(184, 269)
        Me.LabelEval.Name = "LabelEval"
        Me.LabelEval.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelEval.Size = New System.Drawing.Size(545, 274)
        Me.LabelEval.TabIndex = 14
        Me.LabelEval.Text = resources.GetString("LabelEval.Text")
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Kiren's Evaluation", "Benson's Evaluation"})
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Kiren's Evaluation", "Benson's Evaluation"})
        Me.ComboBox1.Location = New System.Drawing.Point(188, 234)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 24)
        Me.ComboBox1.TabIndex = 15
        '
        'FormEvaluation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.aichatbot.My.Resources.Resources.img_2024_10_26_09_14_18_cleanup
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(755, 537)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LabelEval)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormEvaluation"
        Me.Text = "VB.net AI: Evaluation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ButtonHome As Button
    Friend WithEvents ButtonClearChat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelEval As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
