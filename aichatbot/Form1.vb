Imports System.Drawing.Imaging

Public Class Form1
    Dim Index As Integer = 0
    Private Shared rand As New Random
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RunSendMessages(TextBoxInput.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxInput.MaxLength = 200

        SendMessage(False, "Hi, I'm VBot! What can i do for you on this fine 23 degree day")

        FlowSuggestions.Controls.Clear()
        AddSuggestion("How do buttons work?")
        AddSuggestion("How do I make a form?")
        AddSuggestion("What does the properties window do?")
    End Sub

    Private Sub AddSuggestion(str)
        Dim Suggestion As New Button
        Suggestion.Text = str
        Suggestion.AutoSize = True
        Suggestion.BackColor = ColorTranslator.FromHtml("#BCD2EE")
        AddHandler Suggestion.Click, AddressOf SuggestionClick
        FlowSuggestions.Controls.Add(Suggestion)
    End Sub

    Private Sub SuggestionClick(sender As Object, e As EventArgs)
        RunSendMessages(sender.Text)
    End Sub
    Private Sub RunSendMessages(Input)
        If String.IsNullOrEmpty(Input) = False Then
            SendMessage(True, Input)
            TextBoxInput.Text = ""

            Dim Answers = {"No.", "Sure buddy", "blud thought he was doing something with that", "Ok who asked", "Not my problem", "No one cares bro", "No thanks, I'm good.", "Maybe if you use 1% of your brain for once", "Beep boop im an AI chatbot ready at your service. Jsut kidding i dont care go die"}
            SendMessage(False, Answers(rand.Next(0, Answers.Count)))

            If rand.Next(10, 15) = 11 Then
                SendImage()
            End If

            Dim QuestionSuggestions = {
                "How do buttons work?",
                "How do I make a form?",
                "What does the properties window do?",
                "How do I declare a variable?",
                "How do I create a for loop?",
                "How do I change the text of a Label?",
                "How do I handle a button click event?",
                "How do I check if a string contains another string?",
                "How do I set the default startup form in a Windows Forms application?"
            }

            FlowSuggestions.Controls.Clear()
            For i As Integer = 1 To rand.Next(3, 4)
                AddSuggestion(QuestionSuggestions(rand.Next(0, QuestionSuggestions.Count)))
            Next
        End If
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
        NewMessage.Font = New Font(NewMessage.Font.FontFamily.ToString(), 8)

        NewMessage.Padding = New Padding(NewMessage.Padding.Left + 3, NewMessage.Padding.Top + 8, NewMessage.Padding.Right + 3, NewMessage.Padding.Bottom + 8)

        If UserSent Then
            NewMessage.BackColor = ColorTranslator.FromHtml("#BCD2EE")

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
            NewMessage.BackColor = ColorTranslator.FromHtml("#D90368")
            NewMessage.Margin = New Padding(NewMessage.Margin.Left + 5, NewMessage.Margin.Top + 5, NewMessage.Margin.Right, NewMessage.Margin.Bottom + 5)
        End If

        NewMessage.AutoSize = True
        NewMessage.MaximumSize = New Size(300, 0)

        FlowLayoutPanel1.Controls.Add(NewMessage)
        FlowLayoutPanel1.Controls.SetChildIndex(NewMessage, 0)
        FlowLayoutPanel1.ScrollControlIntoView(NewMessage)
    End Sub
End Class