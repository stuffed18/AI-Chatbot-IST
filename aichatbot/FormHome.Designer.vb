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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonQB = New System.Windows.Forms.Button()
        Me.ButtonEval = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("5th Avenue", 34.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(116, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(531, 121)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to VB.ai!"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(316, 291)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 150)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Chat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonQB
        '
        Me.ButtonQB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonQB.Location = New System.Drawing.Point(137, 355)
        Me.ButtonQB.Name = "ButtonQB"
        Me.ButtonQB.Size = New System.Drawing.Size(136, 130)
        Me.ButtonQB.TabIndex = 2
        Me.ButtonQB.Text = "Question Bank"
        Me.ButtonQB.UseVisualStyleBackColor = True
        '
        'ButtonEval
        '
        Me.ButtonEval.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ButtonEval.Location = New System.Drawing.Point(511, 355)
        Me.ButtonEval.Name = "ButtonEval"
        Me.ButtonEval.Size = New System.Drawing.Size(136, 130)
        Me.ButtonEval.TabIndex = 3
        Me.ButtonEval.Text = "Evaluation"
        Me.ButtonEval.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button2.Location = New System.Drawing.Point(299, 509)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 78)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Referencing"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 692)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonEval)
        Me.Controls.Add(Me.ButtonQB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormHome"
        Me.Text = "FormHome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonQB As Button
    Friend WithEvents ButtonEval As Button
    Friend WithEvents Button2 As Button
End Class
