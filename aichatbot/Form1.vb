Imports System.Drawing.Imaging
Imports System.Speech.Synthesis

Public Class Form1
    Dim SoundFlag As Boolean = True
    Private Shared rand As New Random

    Dim synth As New SpeechSynthesizer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sender.BackgroundImage = My.Resources.sendwhite
        RunSendMessages(TextBoxInput.Text)
        sender.BackgroundImage = My.Resources.Resources.Untitled_design_5_
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxInput.MaxLength = 200

        SendMessage(False, RandomItemFrom("Hi, I'm Codex, your personal chatbot assistant. What would you like to know about VB.net Windows Forms?"))

        FlowSuggestions.Controls.Clear()
        AddSuggestion("How do I declare a variable?")
        AddSuggestion("How do I handle a button click event?")

        FlowSuggestions.BackColor = Color.FromArgb(4, 31, 96)
        PictureBox1.BackColor = Color.FromArgb(4, 31, 96)

        ComboBoxVoice.SelectedIndex = 0
    End Sub

    Private Sub AddSuggestion(str)
        Dim Suggestion As New Button
        Suggestion.Text = str
        Suggestion.AutoSize = True
        Suggestion.BackColor = ColorTranslator.FromHtml("#FFFFFF")
        Suggestion.Font = New Font("Segoe UI", 8)
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

            'Dim Answers = {"No.", "Sure buddy", "blud thought he was doing something With that", "Ok who asked", "Not my problem", "No one cares bro", "No thanks, I'm good.", "Maybe if you use 1% of your brain for once", "Beep boop im an AI chatbot ready at your service. Jsut kidding i dont care go die"}
            SendMessage(False, DecideChatbotAnswer(Input))

            If rand.Next(10, 15) = 11 Then
                SendImage()
            End If

            Dim QuestionSuggestions = Split("What is the meaning of life?/How do I declare a variable?/How do I create a For loop?/How can I change the text of a Label?/How do I handle a button click event?/How do I check if a string contains another string?/How do I convert a string to an integer?/How do I add a button to a Windows Form?/How do I set the default startup form in a VB.NET Windows Forms application?/How do I create a form with a transparent background?/How do I create a custom function?/How do I check if a number is even or odd?/How do I change the background colour of a form?/How do I create an array?/How do I add an item to a ListBox?/How do I add a background image to a form?/How do I create a class?/How do I disable resizing of a Windows Form?/How can I remove all items from a ListBox?/How do I close a Form with code?/How do I generate random numbers?/How do I open a new form?/What are the advantages of following a consistent naming convention in code?/When should I consider refactoring my code?/What is the DRY principle, and why is it important?", "/")

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

        NewImage.Margin = New Padding(NewImage.Margin.Left + 5, NewImage.Margin.Top + 5, NewImage.Margin.Right, NewImage.Margin.Bottom + 5)

        FlowLayoutPanel1.Controls.Add(NewImage)
        FlowLayoutPanel1.Controls.SetChildIndex(NewImage, 0)
        FlowLayoutPanel1.ScrollControlIntoView(NewImage)
        synth.SpeakAsync("I'm going to go now")
    End Sub
    Private Sub SendMessage(UserSent As Boolean, Message As String)
        Dim NewPanel As New FlowLayoutPanel
        Dim NewMessage As New Label

        Dim Message2 = Split(Message, ":: ")

        NewMessage.Text = Message2(0)
        NewMessage.Font = New Font("Segoe UI", 8)

        NewPanel.Padding = New Padding(NewPanel.Padding.Left, NewPanel.Padding.Top + 5, NewPanel.Padding.Right + 3, NewPanel.Padding.Bottom + 5)

        If UserSent Then
            NewPanel.BackColor = ColorTranslator.FromHtml("#BCD2EE")
            NewMessage.BackColor = ColorTranslator.FromHtml("#BCD2EE")

            Dim LeftMargin = FlowLayoutPanel1.Width - NewMessage.PreferredWidth - NewPanel.Margin.Right - 25 - NewPanel.Padding.Left - NewPanel.Padding.Right
            If LeftMargin > 0 Then
                NewPanel.Margin = New Padding(LeftMargin, NewPanel.Margin.Top + 5, 5, NewPanel.Margin.Bottom + 5)
            Else
                NewPanel.Margin = New Padding(FlowLayoutPanel1.Width - 300 - NewPanel.Margin.Right - 20 - NewPanel.Padding.Left - NewPanel.Padding.Right, NewPanel.Margin.Top + 5, 5, NewPanel.Margin.Bottom + 5)
            End If

            NewPanel.Anchor = AnchorStyles.Right
            NewMessage.TextAlign = ContentAlignment.MiddleRight
            NewPanel.Dock = DockStyle.Right
        Else
            NewPanel.BackColor = ColorTranslator.FromHtml("#fa52bf")
            NewMessage.BackColor = ColorTranslator.FromHtml("#fa52bf")
            NewPanel.Margin = New Padding(NewPanel.Margin.Left + 5, NewPanel.Margin.Top + 5, NewPanel.Margin.Right, NewPanel.Margin.Bottom + 5)
        End If

        NewMessage.AutoSize = True
        NewPanel.AutoSize = True
        NewPanel.MaximumSize = New Size(300, 0)

        NewPanel.Controls.Add(NewMessage)

        If UserSent = False And Message.Contains(":: ") Then
            NewMessage.Text &= ":" & vbNewLine & vbNewLine

            Dim CodeMessage As New Label

            CodeMessage.Text = Message2(1)
            CodeMessage.BackColor = ColorTranslator.FromHtml("#c8b3ee")
            CodeMessage.ForeColor = ColorTranslator.FromHtml("#591057")
            CodeMessage.AutoSize = True
            CodeMessage.Padding = New Padding(CodeMessage.Padding.Left + 5, CodeMessage.Padding.Top + 5, NewPanel.PreferredSize.Width - CodeMessage.PreferredWidth - CodeMessage.Padding.Left - 15, CodeMessage.Padding.Bottom + 5)

            NewPanel.Controls.Add(CodeMessage)
        End If

        FlowLayoutPanel1.Controls.Add(NewPanel)
        FlowLayoutPanel1.Controls.SetChildIndex(NewPanel, 0)
        FlowLayoutPanel1.ScrollControlIntoView(NewPanel)

        If UserSent = False Then
            synth.SpeakAsyncCancelAll()
            synth.SpeakAsync(Message2(0))
        End If
    End Sub


    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        sender.BackgroundImage = My.Resources.Resources.sendpink
    End Sub

    Private Sub Button1_MouseExit(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        sender.BackgroundImage = My.Resources.Resources.Untitled_design_5_
    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        sender.BackgroundImage = My.Resources.Resources.homewhite
        FormHome.Show()
        sender.BackgroundImage = My.Resources.Resources.home_button_logo
        Me.Hide()
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        synth.Dispose()
        MyBase.OnFormClosing(e)
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams

    Private Sub TextBoxInput_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxInput.KeyDown
        If e.KeyCode = Keys.Return Then
            RunSendMessages(TextBoxInput.Text)
            TextBoxInput.Text = ""
        End If
    End Sub

    Private Sub TextBoxInput_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxInput.KeyUp
        If e.KeyCode = Keys.Return Then
            TextBoxInput.Text = ""
        End If
    End Sub

    Private Function DecideChatbotAnswer(UserInput_)
        Dim UserInput As String = UserInput_.ToLower()
        If Multicontains(UserInput, "fact/funfact") Then
            Return RandomItemFrom("Venus is the only planet to spin clockwise",
                                  "Bananas are berries, but strawberries aren’t!",
                                  "The longest place name in the world is the name of a village in Wales: Llanfair­pwllgwyngyll­gogery­chwyrn­drobwll­llan­tysilio­gogo­goch. Try fitting that on a postcard!",
                                  "Believe it or not, the unicorn is Scotland’s national animal. They’ve been associated with Scotland for centuries")
        ElseIf Multicontains(UserInput, "joke/funny") Then
            Return RandomItemFrom("Sean: I’m so sorry, my dog ate my homework. \n Teacher: Your dog ate your coding assignment? \n Sean: It took him a couple bytes",
                                  "Why do programmers prefer dark mode? \n Because light attracts bugs.",
                                  "How many programmers does it take to change a light bulb? \n None, that's a hardware problem.")
        ElseIf Multicontains(UserInput, "variable/var", "declare/make/create") Then
            Return RandomItemFrom("In VB.NET, you can declare a variable using the Dim keyword. For example, the following declares the variable myNumber as type Integer:: Dim myNumber As Integer")
        ElseIf Multicontains(UserInput, "button", "click/tap/event") Then
            Return RandomItemFrom("You can handle a button click event by double clicking the button in the designer. This will automatically add an event handler that looks something like this:: Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click \n MessageBox.Show(""Button Clicked!"")")
        ElseIf Multicontains(UserInput, "string", "contains/has/contain", "check/whether/if/when") Then
            Return RandomItemFrom("You can use the Contains method:: Dim Text As String = ""Hello World"" \n If Text.Contains(""World"") Then \n     Console.WriteLine(""String found!"") \n End If")
        ElseIf Multicontains(UserInput, "hello/hi/hallo/hey/good day/afternoon/morning/evening/bonjour/greet/howdy/long time/hiya/greeting/whats up/what's up") Then
            Return RandomItemFrom("Hello! How can I assist you today?",
                                  "What's up?",
                                  "Hello! What would you like to know about VB.net?")
        ElseIf Multicontains(UserInput, "bye/adios/see ya/see you/catch you/later") Then
            Return RandomItemFrom("Thank you for using VB.net AI!",
                                  "Goodbye. I hope I was of assisstance today!",
                                  "Happy coding!")
        ElseIf Multicontains(UserInput, "meaning of life/meaning of the universe/meaning of it all/meaning of everything") Then
            Return RandomItemFrom("I am an AI chatbot made to answer questions about VB.net, not the meaning of life. However, I hope you find some meaning in your coding journey!")
        ElseIf Multicontains(UserInput, "while", "loop") Then
            Return RandomItemFrom("A While loop can be used to repeat code while something is true. For example, the following code repeats while i is lower or equal to 10: While i <= 10 \n     Console.WriteLine(i) \n     i += 1 \n End While")
        ElseIf Multicontains(UserInput, "loop") Then
            Return RandomItemFrom("A basic For loop can be used to repeat code Like so: For i As Integer = 1 To 10 \n     Console.WriteLine(i)Next")
        ElseIf Multicontains(UserInput, "label") Then
            Return RandomItemFrom("You can change the text a Label displays by setting it in the Properties window under the property ‘Text’. To change the text by code, you can set the property like so:: Label1.Text = ""New Text""")
        End If

        Return RandomItemFrom("Sorry, I'm not sure I understand.",
                              "Sorry, could you rephrase that question?",
                              "I don't know the answer to that. Try asking a question about Visual Basic or Windows Forms.")
    End Function

    Private Function Multicontains(Text As String, ByVal ParamArray words As String())
        For Each Word In words
            Dim Subwords As String() = Split(Word, "/")
            Dim Valid As Boolean = False
            For Each SWord In Subwords
                If ContainsWord(Text, SWord) Then
                    Valid = True
                End If
            Next
            If Valid = False Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function ContainsWord(Text_ As String, CWord As String)
        Dim Text As String = Text_.Replace("?", "")
        Text = Text.Replace(".", "")
        Text = Text.Replace(",", "")
        Text = Text.Replace("!", "")
        Text = Text.Replace("(", "")
        Text = Text.Replace(")", "")
        Text = Text.Replace("*", "")
        Text = Text.Replace("&", "")
        Text = Text.Replace("/", "")
        Text = Text.Replace("\", "")
        For Each Word In Split(Text, " ")
            If Word = CWord Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function RandomItemFrom(ByVal ParamArray List As String())
        Return SplitNewLines(List(rand.Next(0, List.Length)))
    End Function

    Private Function SplitNewLines(Text)
        Dim NewText As String = Text
        NewText = NewText.Replace(" \n ", vbNewLine)

        Return NewText
    End Function

    Private Sub ButtonHome_MouseEnter(sender As Object, e As EventArgs) Handles ButtonHome.MouseEnter
        sender.BackgroundImage = My.Resources.Resources.homepink
    End Sub

    Private Sub ButtonHome_MouseLeave(sender As Object, e As EventArgs) Handles ButtonHome.MouseLeave
        sender.BackgroundImage = My.Resources.Resources.home_button_logo
    End Sub

    Private Sub ButtonClearChat_Click(sender As Object, e As EventArgs) Handles Label2.Click, ButtonClearChat.Click
        Dim Answer As DialogResult = MessageBox.Show("Are you sure you want to clear chat history?", "VB.net AI asks:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If Answer = vbYes Then
            FlowLayoutPanel1.Controls.Clear()
            SendMessage(False, RandomItemFrom("Hi, let's start over. What would you like to know about VB.net.",
                                          "Alright, resetting. How can I assist you today?",
                                          "Let's have a new conversation. What can I help you with?"))
        End If
    End Sub

    Private Sub ButtonClearChat_MouseEnter(sender As Object, e As EventArgs) Handles ButtonClearChat.MouseEnter, Label2.MouseEnter
        Label2.ForeColor = ColorTranslator.FromHtml("#fa52bf")
        ButtonClearChat.BackgroundImage = My.Resources.Resources.Untitled_design_8_
    End Sub

    Private Sub ButtonClearChat_MouseLeave(sender As Object, e As EventArgs) Handles ButtonClearChat.MouseLeave, Label2.MouseLeave
        Label2.ForeColor = ColorTranslator.FromHtml("#c8b3ee")
        ButtonClearChat.BackgroundImage = My.Resources.Resources.Untitled_design_5_2
    End Sub
    Private Sub ButtonSound_Click(sender As Object, e As EventArgs) Handles ButtonSound.Click
        If SoundFlag Then
            SoundFlag = False
            sender.BackgroundImage = My.Resources.Resources.volume_xmark_solid__1_
            synth.Volume = 0
            synth.SpeakAsyncCancelAll()
        Else
            SoundFlag = True
            sender.BackgroundImage = My.Resources.Resources.volume_high_solid__1_
            synth.Volume = 100
        End If
    End Sub

    Private Sub ButtonSound_MouseEnter(sender As Object, e As EventArgs) Handles ButtonSound.MouseEnter
        If SoundFlag Then
            sender.BackgroundImage = My.Resources.Resources.volume_high_solid__1_
        Else
            sender.BackgroundImage = My.Resources.Resources.volume_xmark_solid__1_
        End If
    End Sub

    Private Sub ButtonSound_MouseLeave(sender As Object, e As EventArgs) Handles ButtonSound.MouseLeave
        If SoundFlag Then
            sender.BackgroundImage = My.Resources.Resources.volume_high_solid
        Else
            sender.BackgroundImage = My.Resources.Resources.volume_xmark_solid
        End If
    End Sub

    Private Sub ComboBoxVoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVoice.SelectedIndexChanged
        If ComboBoxVoice.SelectedIndex = 0 Then
            synth.SelectVoiceByHints(VoiceGender.Male)
        Else
            synth.SelectVoiceByHints(VoiceGender.Female)
        End If
    End Sub
End Class