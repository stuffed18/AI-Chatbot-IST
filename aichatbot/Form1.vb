Imports System.Drawing.Imaging
Imports System.Net.Mime.MediaTypeNames
Imports System.Speech.Synthesis

Public Class Form1
    Dim SoundFlag As Boolean = True
    Dim SendingImg As Integer = -1
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

            Dim QuestionSuggestions = Split("What is the meaning of life?/How do I declare a variable?/How do I create a For loop?/How can I change the text of a Label?/How do I handle a button click event?/How do I check if a string contains another string?/How do I convert a string to an integer?/How do I add a button to a Windows Form?/How do I set the default startup form in a Windows Forms application?/How do I create a form with a transparent background?/How do I create a custom function?/How do I check if a number is even or odd?/How do I change the background colour of a form?/How do I create an array?/How do I add an item to a ListBox?/How do I add a background image to a form?/How do I create a class?/How do I disable resizing of a Windows Form?/How can I remove all items from a ListBox?/How do I close a Form with code?/How do I generate random numbers?/How do I open a new form?/What are the advantages of following a consistent naming convention in code?/When should I consider refactoring my code?/What is the DRY principle, and why is it important?", "/")

            FlowSuggestions.Controls.Clear()
            For i As Integer = 1 To rand.Next(3, 4)
                AddSuggestion(QuestionSuggestions(rand.Next(0, QuestionSuggestions.Count)))
            Next
        End If
    End Sub
    Private Sub SendImage()
        Dim NewImage As New PictureBox
        If SendingImg = 0 Then
            NewImage.Image = My.Resources.buttonclick_ezgif_com_cut
        ElseIf SendingImg = 1 Then
            NewImage.Image = My.Resources.labelproperties
        ElseIf SendingImg = 2 Then
            NewImage.Image = My.Resources.addingcontrols
        ElseIf SendingImg = 3 Then
            NewImage.Image = My.Resources.Screenshot_2024_10_29_at_12_41_00_IST_WORK_and_stuff_like_that___Google_Docs
        ElseIf SendingImg = 4 Then
        ElseIf SendingImg = 5 Then
            NewImage.Image = My.Resources.formbackcolor
        ElseIf SendingImg = 6 Then
            NewImage.Image = My.Resources.messageboxdemo
        ElseIf SendingImg = 7 Then
            NewImage.Image = My.Resources.formbackgroundimg
        ElseIf SendingImg = 8 Then
            NewImage.Image = My.Resources.fixedsingle

        Else
            NewImage.Image = My.Resources.im_going_to_go_now__1_1
        End If
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
        SendingImg = -1
        Dim UserInput As String = UserInput_.ToLower()
        If Multicontains(UserInput, "fact/funfact") Then
            Return RandomItemFrom("Venus is the only planet to spin clockwise",
                                  "Bananas are berries, but strawberries aren’t!",
                                  "The longest place name in the world is the name of a village in Wales: Llanfair­pwllgwyngyll­gogery­chwyrn­drobwll­llan­tysilio­gogo­goch. Try fitting that on a postcard!",
                                  "Believe it or not, the unicorn is Scotland’s national animal. They’ve been associated with Scotland for centuries",
                                  "Honey Never Spoils: Archaeologists have found pots of honey in ancient Egyptian tombs that are over 3,000 years old and still perfectly edible.")
        ElseIf Multicontains(UserInput, "joke/funny") Then
            Return RandomItemFrom("Sean: I’m so sorry, my dog ate my homework. \n Teacher: Your dog ate your coding assignment? \n Sean: It took him a couple bytes",
                                  "Why do programmers prefer dark mode? \n Because light attracts bugs.",
                                  "How many programmers does it take to change a light bulb? \n None, that's a hardware problem.",
                                  "There are 10 types of people in the world: Those who understand binary, and those who don’t.")
        ElseIf Multicontains(UserInput, "variable/var", "declare/make/create/declaring/making/creating") Then
            Return RandomItemFrom("In VB.NET, you can declare a variable using the Dim keyword. For example, the following declares the variable myNumber as type Integer:: Dim myNumber As Integer")
        ElseIf Multicontains(UserInput, "button", "click/tap/event/clicking/tapping/press/pressing") Then
            SendingImg = 0 'Gif of clicking button and msg box showing up
            Return RandomItemFrom("You can handle a button click event by double clicking the button in the designer. This will automatically add an event handler that looks something like this:: Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click \n MessageBox.Show(""Button Clicked!"")")
        ElseIf Multicontains(UserInput, "string", "contains/has/contain/containing", "check/whether/if/when") Then
            Return RandomItemFrom("You can use the Contains method:: Dim Text As String = ""Hello World"" \n If Text.Contains(""World"") Then \n     Console.WriteLine(""String found!"") \n End If")
        ElseIf Multicontains(UserInput, "hello/hi/hallo/hey/good day/afternoon/morning/evening/bonjour/greet/howdy/long time/hiya/greeting/whats up/what's up") Then
            Return RandomItemFrom("Hello! How can I assist you today?",
                                  "What's up?",
                                  "Hello! What would you like to know about VB.net?")
        ElseIf Multicontains(UserInput, "bye/adios/see ya/see you/catch you/later") Then
            Return RandomItemFrom("Thank you for using VB.net AI!",
                                  "Goodbye. I hope I was of assisstance today!",
                                  "Happy coding!")
        ElseIf Multicontains(UserInput, "meaning", "life/universe/everything/existence/existance") Then
            Return RandomItemFrom("I am an AI chatbot made to answer questions about VB.net, not the meaning of life. However, I hope you find some meaning in your coding journey!")
        ElseIf Multicontains(UserInput, "while", "loop") Then
            Return RandomItemFrom("A While loop can be used to repeat code while something is true. For example, the following code repeats while i is lower or equal to 10:: While i <= 10 \n     Console.WriteLine(i) \n     i += 1 \n End While")
        ElseIf Multicontains(UserInput, "loop") Then
            Return RandomItemFrom("A basic For loop can be used to repeat code Like so:: For i As Integer = 1 To 10 \n     Console.WriteLine(i)Next")
        ElseIf Multicontains(UserInput, "label", "text", "change/set/modify/tweak/alter") Then
            SendingImg = 1 'Label text in properties window
            Return RandomItemFrom("You can change the text a Label displays by setting it in the Properties window under the property ‘Text’. To change the text by code, you can set the property like so:: Label1.Text = ""New Text""")
        ElseIf UserInput.Contains("string to integer") Or UserInput.Contains("string to int") Or UserInput.Contains("str to int") Or UserInput.Contains("str to integer") Or UserInput.Contains("int from str") Or UserInput.Contains("integer from str") Or UserInput.Contains("integer from string") Or UserInput.Contains("int from string") Then
            Return RandomItemFrom("You can use the CInt Function:: Dim num As Integer = CInt(""123"")")
        ElseIf Multicontains(UserInput, "add/create/put/make/access/drag/adding/creating/putting/making/dragging", "ui/button/label/panel/textbox/control/element") Then
            SendingImg = 2 'Toolbox window
            Return RandomItemFrom("In the Visual Studio Designer, you can add any UI element by opening the Toolbox menu and dragging it onto the form. Then, in the properties tab you can change attributes such as the Text, Color, and Name.")
        ElseIf Multicontains(UserInput, "startup/start/default/starting/initial/first/starter", "form/window/forms/windows") Then
            SendingImg = 3 'Setting up start up
            Return RandomItemFrom("You can set the startup form by right-clicking on the project in Solution Explorer, then selecting ""Properties."" After this, select the Web tab on the left-hand side. Under the Start Page section, define the Specific Page you would like to default to when the application is launched. Save your changes.")
        ElseIf Multicontains(UserInput, "transparent/clear/alpha/see-through", "form/window/forms/windows") Then
            SendingImg = 4 'Properties window and transparent form next to it
            Return RandomItemFrom("To make a form's background transparent, click the Form to make sure you are focused on it and go under the Properties window on the right-hand side. Set the form's FormBorderStyle to None and the BackColor property to a specific colour (for example, magenta), then set the TransparencyKey to the same colour.")
        ElseIf Multicontains(UserInput, "function/func/return", "create/make/define/custom/creating/making/defining") Then
            Return RandomItemFrom("You can create a custom function using the Function keyword. To return a value from the Function, use the Return keyword. For example, the function below returns the sum of two integers:: Function AddNumbers(a As Integer, b As Integer) As Integer \n     Return a + b \n End Function")
        ElseIf Multicontains(UserInput, "even/odd", "check/whether/if/when") Then
            Return RandomItemFrom("You can check if a number is even or odd by using the modulus operator which gets the remainder after dividing the number. If the remainder is zero we know the number is even and vice versa like so:: If num Mod 2 = 0 Then \n     Console.WriteLine(""Even"") \n Else \n     Console.WriteLine(""Odd"") \n End If")
        ElseIf Multicontains(UserInput, "bg/backdrop/background", "color/colour", "form/window/forms/windows") Then
            SendingImg = 5 'Properties window and red form next to it
            Return RandomItemFrom("You can change the background colour by setting the BackColor property. To do it with code you can do the following:: Me.BackColor = Color.Red")
        ElseIf Multicontains(UserInput, "messagebox/msgbox/msg/message/alert/warning") Then
            SendingImg = 6 'MessageBox
            Return RandomItemFrom("You can use the MessageBox.Show method to display a message box like so:: MessageBox.Show(""Message To display To the user"")")
        ElseIf Multicontains(UserInput, "array/list", "make/making/create/declare/declaring/initialise/initialize/intialising/initializing/creating") Then
            Return RandomItemFrom("You can declare an array in Visual Basic like this:: Dim numbers() As Integer = {1, 2, 3, 4, 5}")
        ElseIf Multicontains(UserInput, "listbox", "add/append/adding/appending") Then
            Return RandomItemFrom("You can add an item using the Items.Add method:: ListBox1.Items.Add(""New Item"")")
        ElseIf Multicontains(UserInput, "listbox", "remove/clear/empty/clearing/removing/emptying") Then
            Return RandomItemFrom("You can clear all items using the Items.Clear method:: ListBox1.Items.Clear()")
        ElseIf Multicontains(UserInput, "bg/backdrop/background", "image/photo/design/png/jpeg/jpg/file", "form/window/forms/windows") Then
            SendingImg = 7 'Properties window and form with bg image
            Return RandomItemFrom("Click the background to focus on the form. In the properties window, you can set the BackgroundImage property in the Properties window by clicking it and selecting import to import an image as a project resource file. Make sure the image is selected and click OK to apply it to the background.")
        ElseIf Multicontains(UserInput, "class", "make/making/create/declare/declaring/initialise/initialize/intialising/initializing/creating") Then
            Return RandomItemFrom("You can create a class using the Class keyword. For example:: Public Class Car \n     Public Property Make As String \n     Public Property Model As String \n End Class")
        ElseIf Multicontains(UserInput, "form/window/forms/windows", "size/resize/resizing/scale/scaling/rescaling/sized/resized/rescaled/scaled", "disable/stop/prevent/disabling/stopping/preventing") Then
            SendingImg = 8 'Properties window
            Return RandomItemFrom("Select the form. On the Properties window, set the form’s FormBorderStyle property to FixedSingle or FixedDialog to prevent resizing.")
        ElseIf Multicontains(UserInput, "close/shut/kill/hide/closing/shutting/killing/hiding", "form/window/forms/windows") Then
            Return RandomItemFrom("You can close the current form by using Hide:: Me.Hide()")
        ElseIf Multicontains(UserInput, "switch/switching/swap/swapping/go/going/change/changing/changes", "form/window/forms/windows") Then
            Return RandomItemFrom("You can switch between Windows Forms by first hiding the current form and then showing another form. For example, if I wanted to switch to Form2 I would use the following:: Me.Hide() \n Form2.Show()")
        ElseIf Multicontains(UserInput, "random/rand/randomise/randomize/randomising/randomizing/randomisation/randomization", "number/numb/integer/int") Then
            Return RandomItemFrom("You can use the Random class and the Random.Next() method to generate a random integer within a given range. For example, this code generates a number from 1 to 100:: Dim rand As New Random() \n Dim randomNumber As Integer = rand.Next(1, 100)")
        ElseIf Multicontains(UserInput, "open/initialise/initialize/start/starting/opening", "form/window/forms/windows") Then
            Return RandomItemFrom("You can open a new form using the Show method:: Form2.Show()")
        ElseIf Multicontains(UserInput, "naming/convention/name/names/consistent/consistency", "follow/following/use/using/uses/follows/copy/copying/copies/mimic/mimicking") Then
            Return RandomItemFrom("Consistent naming makes code easier to read, understand, and maintain. It allows other developers to quickly grasp the purpose of variables, functions, and classes. Popular conventions, like camelCase for variables in JavaScript or snake_case in Python, help keep code organised and predictable, reducing errors and improving teamwork.")
        ElseIf Multicontains(UserInput, "refactor/refactoring/refactors") Then
            Return RandomItemFrom("It is good practice to refactor when code becomes hard to read, overly complex, or difficult to maintain. Refactoring is especially beneficial after adding new features, as it helps simplify and optimise the underlying structure without changing its functionality. Look for signs like long functions, duplicated code, and excessive if-else chains as cues for refactoring.")
        ElseIf Multicontains(UserInput, "dry") Then
            Return RandomItemFrom(UserInput, "DRY stands for ""Don't Repeat Yourself,"" which emphasises reducing code duplication. Repeated code is harder to maintain, as changes need to be made in multiple places. By keeping code DRY, you ensure that logic is centralised, reducing errors and simplifying updates.")
        End If

        Return RandomItemFrom("Sorry, I'm not sure I understand.",
                              "Sorry, could you rephrase that question?",
                              "I don't know the answer to that. Try asking a question about Visual Basic or Windows Forms.",
                              "I'm sorry, I don't know anything about that.")
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