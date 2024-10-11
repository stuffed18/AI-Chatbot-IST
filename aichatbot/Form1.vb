Imports System.Drawing.Imaging

Public Class Form1
    Dim Index As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBoxInput.Text) = False Then
            SendMessage(True, TextBoxInput.Text)
            TextBoxInput.Text = ""

            Dim Answers = {"No.", "Sure buddy", "blud thought he was doing something with that", "Ok who asked", "Not my problem", "No one cares bro", "No thanks, I'm good.", "Maybe if you use 1% of your brain for once", "Beep boop im an AI chatbot ready at your service. Jsut kidding i dont care go die"}
            Dim rnd = New Random()
            SendMessage(False, Answers(rnd.Next(0, Answers.Count)))

            If rnd.Next(10, 15) = 11 Then
                SendImage()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxInput.MaxLength = 200

        SendMessage(False, "Hi, I'm VBot! What can i do for you on this fine 23 degree day")
    End Sub

    Private Sub SendImage()
        Dim NewImage As New PictureBox
        NewImage.Image = My.Resources.im_going_to_go_now__1_1
        NewImage.SizeMode = PictureBoxSizeMode.StretchImage
        NewImage.Size = New System.Drawing.Size(200, 200)

        FlowLayoutPanel1.Controls.Add(NewImage)
        FlowLayoutPanel1.Controls.SetChildIndex(NewImage, 0)
        FlowLayoutPanel1.ScrollControlIntoView(NewImage)
    End Sub
    Private Sub SendMessage(UserSent As Boolean, Message As String)
        Dim NewMessage As New Label
        Index = Index + 1
        NewMessage.Name = "chat" & Index

        NewMessage.Text = Message
        NewMessage.Font = New Font(NewMessage.Font.FontFamily.ToString(), 10)

        NewMessage.Padding = New Padding(NewMessage.Padding.Left + 3, NewMessage.Padding.Top + 8, NewMessage.Padding.Right + 3, NewMessage.Padding.Bottom + 8)

        If UserSent Then
            NewMessage.BackColor = Color.Lime

            Dim LeftMargin = FlowLayoutPanel1.Width - NewMessage.PreferredWidth - NewMessage.Margin.Right - 5 - NewMessage.Padding.Left - NewMessage.Padding.Right
            If LeftMargin > 0 Then
                NewMessage.Margin = New Padding(LeftMargin, NewMessage.Margin.Top + 5, NewMessage.Margin.Right + 5, NewMessage.Margin.Bottom + 5)
            Else
                NewMessage.Margin = New Padding(FlowLayoutPanel1.Width - 300 - NewMessage.Margin.Right - 5 - NewMessage.Padding.Left - NewMessage.Padding.Right, NewMessage.Margin.Top + 5, NewMessage.Margin.Right + 5, NewMessage.Margin.Bottom + 5)
            End If

            NewMessage.Anchor = AnchorStyles.Right
            NewMessage.TextAlign = ContentAlignment.MiddleRight
            NewMessage.Dock = DockStyle.Right
        Else
            NewMessage.BackColor = Color.Pink
            NewMessage.Margin = New Padding(NewMessage.Margin.Left + 5, NewMessage.Margin.Top + 5, NewMessage.Margin.Right, NewMessage.Margin.Bottom + 5)
        End If

        NewMessage.AutoSize = True
        NewMessage.MaximumSize = New Size(300, 0)

        FlowLayoutPanel1.Controls.Add(NewMessage)
        FlowLayoutPanel1.Controls.SetChildIndex(NewMessage, 0)
        FlowLayoutPanel1.ScrollControlIntoView(NewMessage)
    End Sub
End Class