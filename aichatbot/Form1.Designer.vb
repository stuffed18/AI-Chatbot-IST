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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.FlowSuggestions = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(28, 87)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(729, 462)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(21, 22)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(263, 39)
        Me.LabelTitle.TabIndex = 3
        Me.LabelTitle.Text = "VB.ai chatbot 👍"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ask:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ButtonHome)
        Me.Panel1.Controls.Add(Me.LabelTitle)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(805, 81)
        Me.Panel1.TabIndex = 7
        '
        'ButtonHome
        '
        Me.ButtonHome.BackColor = System.Drawing.Color.Transparent
        Me.ButtonHome.BackgroundImage = Global.aichatbot.My.Resources.Resources.house_solid__1_
        Me.ButtonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonHome.FlatAppearance.BorderSize = 0
        Me.ButtonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHome.Location = New System.Drawing.Point(688, 12)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(60, 60)
        Me.ButtonHome.TabIndex = 4
        Me.ButtonHome.UseVisualStyleBackColor = False
        '
        'TextBoxInput
        '
        Me.TextBoxInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TextBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInput.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxInput.Location = New System.Drawing.Point(18, 60)
        Me.TextBoxInput.Multiline = True
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.Size = New System.Drawing.Size(594, 70)
        Me.TextBoxInput.TabIndex = 2
        '
        'FlowSuggestions
        '
        Me.FlowSuggestions.Location = New System.Drawing.Point(50, 19)
        Me.FlowSuggestions.Name = "FlowSuggestions"
        Me.FlowSuggestions.Size = New System.Drawing.Size(726, 35)
        Me.FlowSuggestions.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.FlowSuggestions)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TextBoxInput)
        Me.Panel2.Location = New System.Drawing.Point(28, 536)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(729, 160)
        Me.Panel2.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.aichatbot.My.Resources.Resources.send_icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(639, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 70)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 692)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents FlowSuggestions As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonHome As Button
End Class
