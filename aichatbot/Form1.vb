Imports System.Drawing.Imaging

Public Class Form1
    Dim Index As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SendMessage(True, TextBoxInput.Text)

        Dim Answers = {"No.", "Sure buddy", "blud thought he was doing something with that", "Ok who asked", "Not my problem", "No one cares bro", "No thanks, I'm good.", "Maybe if you use 1% of your brain for once", "Beep boop im an AI chatbot ready at your service. Jsut kidding i dont care go die"}
        Dim rnd = New Random()
        SendMessage(False, Answers(rnd.Next(0, Answers.Count)))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FlowLayoutPanel1.VerticalScroll.Visible = True
        TextBoxInput.MaxLength = 200
    End Sub

    Private Sub SendMessage(UserSent As Boolean, Message As String)
        Dim NewMessage As New Label
        Index = Index + 1
        NewMessage.Name = "chat" & Index

        NewMessage.Text = Message
        NewMessage.Font = New Font(NewMessage.Font.FontFamily.ToString(), 10)

        If UserSent Then
            NewMessage.BackColor = Color.Lime

            Dim LeftMargin = FlowLayoutPanel1.Width - NewMessage.PreferredWidth - NewMessage.Padding.Right - 10
            If LeftMargin > 0 Then
                NewMessage.Margin = New Padding(LeftMargin, NewMessage.Padding.Top + 5, NewMessage.Padding.Right + 5, NewMessage.Padding.Bottom + 5)
            Else
                NewMessage.Margin = New Padding(FlowLayoutPanel1.Width - 300 - NewMessage.Padding.Right - 10, NewMessage.Padding.Top + 5, NewMessage.Padding.Right + 5, NewMessage.Padding.Bottom + 5)
            End If

            NewMessage.Anchor = AnchorStyles.Right
            NewMessage.TextAlign = ContentAlignment.MiddleRight
            NewMessage.Dock = DockStyle.Right
        Else
            NewMessage.BackColor = Color.Pink
            NewMessage.Margin = New Padding(NewMessage.Padding.Left + 5, NewMessage.Padding.Top + 5, NewMessage.Padding.Right, NewMessage.Padding.Bottom + 5)
        End If

        NewMessage.AutoSize = True
        NewMessage.MaximumSize = New Size(300, 0)

        FlowLayoutPanel1.Controls.Add(NewMessage)
        FlowLayoutPanel1.Controls.SetChildIndex(NewMessage, 0)
        FlowLayoutPanel1.ScrollControlIntoView(NewMessage)
    End Sub
End Class