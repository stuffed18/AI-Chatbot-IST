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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FlowSuggestions = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxVoice = New System.Windows.Forms.ComboBox()
        Me.ButtonSound = New System.Windows.Forms.Button()
        Me.ButtonClearChat = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox5)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(172, -6)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(580, 395)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(3, 342)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(172, 406)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(580, 115)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.PictureBox1.Image = Global.aichatbot.My.Resources.Resources.Copy_of_Chat_with__29_7_x_21_cm__5_
        Me.PictureBox1.Location = New System.Drawing.Point(192, 453)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(530, 49)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.ButtonHome.Location = New System.Drawing.Point(23, 16)
        Me.ButtonHome.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(43, 43)
        Me.ButtonHome.TabIndex = 4
        Me.ButtonHome.UseVisualStyleBackColor = False
        '
        'TextBoxInput
        '
        Me.TextBoxInput.BackColor = System.Drawing.Color.White
        Me.TextBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxInput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInput.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxInput.Location = New System.Drawing.Point(210, 464)
        Me.TextBoxInput.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxInput.Multiline = True
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.Size = New System.Drawing.Size(448, 28)
        Me.TextBoxInput.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.aichatbot.My.Resources.Resources.Untitled_design_5_
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(679, 462)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FlowSuggestions
        '
        Me.FlowSuggestions.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.FlowSuggestions.Location = New System.Drawing.Point(189, 418)
        Me.FlowSuggestions.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowSuggestions.Name = "FlowSuggestions"
        Me.FlowSuggestions.Size = New System.Drawing.Size(525, 28)
        Me.FlowSuggestions.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ComboBoxVoice)
        Me.Panel1.Controls.Add(Me.ButtonSound)
        Me.Panel1.Controls.Add(Me.ButtonClearChat)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ButtonHome)
        Me.Panel1.Location = New System.Drawing.Point(-12, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 544)
        Me.Panel1.TabIndex = 8
        '
        'ComboBoxVoice
        '
        Me.ComboBoxVoice.BackColor = System.Drawing.Color.White
        Me.ComboBoxVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxVoice.FormattingEnabled = True
        Me.ComboBoxVoice.IntegralHeight = False
        Me.ComboBoxVoice.Items.AddRange(New Object() {"Male Voice", "Female Voice"})
        Me.ComboBoxVoice.Location = New System.Drawing.Point(65, 446)
        Me.ComboBoxVoice.Name = "ComboBoxVoice"
        Me.ComboBoxVoice.Size = New System.Drawing.Size(90, 21)
        Me.ComboBoxVoice.TabIndex = 12
        '
        'ButtonSound
        '
        Me.ButtonSound.BackgroundImage = Global.aichatbot.My.Resources.Resources.volume_high_solid
        Me.ButtonSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSound.FlatAppearance.BorderSize = 0
        Me.ButtonSound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ButtonSound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ButtonSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSound.Location = New System.Drawing.Point(24, 441)
        Me.ButtonSound.Name = "ButtonSound"
        Me.ButtonSound.Size = New System.Drawing.Size(30, 30)
        Me.ButtonSound.TabIndex = 11
        Me.ButtonSound.UseVisualStyleBackColor = True
        '
        'ButtonClearChat
        '
        Me.ButtonClearChat.BackgroundImage = Global.aichatbot.My.Resources.Resources.Untitled_design_5_2
        Me.ButtonClearChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonClearChat.FlatAppearance.BorderSize = 0
        Me.ButtonClearChat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonClearChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonClearChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClearChat.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClearChat.ForeColor = System.Drawing.Color.White
        Me.ButtonClearChat.Location = New System.Drawing.Point(24, 479)
        Me.ButtonClearChat.Name = "ButtonClearChat"
        Me.ButtonClearChat.Size = New System.Drawing.Size(30, 30)
        Me.ButtonClearChat.TabIndex = 9
        Me.ButtonClearChat.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(59, 482)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Clear Chat"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.aichatbot.My.Resources.Resources.Copy_of_vbnet_ai_menu_page1
        Me.PictureBox3.Location = New System.Drawing.Point(23, 110)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(135, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chat with"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BackgroundImage = Global.aichatbot.My.Resources.Resources.Copy_of_Chat_with__29_7_x_21_cm_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(755, 537)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxInput)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FlowSuggestions)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Form1"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ButtonHome As Button
    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents FlowSuggestions As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ButtonClearChat As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonSound As Button
    Friend WithEvents ComboBoxVoice As ComboBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
