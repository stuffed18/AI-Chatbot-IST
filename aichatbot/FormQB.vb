Public Class FormQB
    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        sender.BackgroundImage = My.Resources.Resources.homewhite
        FormHome.Show()
        sender.BackgroundImage = My.Resources.Resources.home_button_logo
        Me.Hide()
    End Sub
    Private Sub ButtonHome_MouseEnter(sender As Object, e As EventArgs) Handles ButtonHome.MouseEnter
        sender.BackgroundImage = My.Resources.Resources.homepink
    End Sub

    Private Sub ButtonHome_MouseLeave(sender As Object, e As EventArgs) Handles ButtonHome.MouseLeave
        sender.BackgroundImage = My.Resources.Resources.home_button_logo
    End Sub

    Private Sub FormQB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Questions = Split("What is the meaning of life?/How do I declare a variable?/How do I create a For loop?/How can I change the text of a Label?/How do I handle a button click event?/How do I check if a string contains another string?/How do I convert a string to an integer?/How do I add a button to a Windows Form?/How do I set the default startup form in a VB.NET Windows Forms application?/How do I create a form with a transparent background?/How do I create a custom function?/How do I check if a number is even or odd?/How do I change the background colour of a form?/How do I create an array?/How do I add an item to a ListBox?/How do I add a background image to a form?/How do I create a class?/How do I disable resizing of a Windows Form?/How can I remove all items from a ListBox?/How do I close a Form with code?/How do I generate random numbers?/How do I open a new form?/What are the advantages of following a consistent naming convention in code?/When should I consider refactoring my code?/What is the DRY principle, and why is it important?", "/")
        Dim Flag As Boolean = True
        For Each Q In Questions
            Dim QLabel As New Label
            QLabel.Text = Q
            QLabel.AutoSize = True
            If Flag Then
                QLabel.BackColor = Color.FromArgb(50, 218, 66, 245)
                Flag = False
            Else
                QLabel.BackColor = Color.FromArgb(50, 242, 155, 210)
                Flag = True
            End If
            QLabel.Font = New Font("Segoe UI", 10)
            QLabel.AutoSize = False
            QLabel.Width = FlowLayoutPanelQB.Width - 10
            FlowLayoutPanelQB.Controls.Add(QLabel)
        Next
    End Sub

    Private Sub transblackpanel_Paint(sender As Object, e As PaintEventArgs) Handles transblackpanel.Paint
        ' Set up a semi-transparent black color
        Dim translucentBlack As Color = Color.FromArgb(128, 0, 0, 0) ' 128 = 50% opacity
        Using brush As New SolidBrush(translucentBlack)
            ' Fill the panel with the translucent color
            e.Graphics.FillRectangle(brush, transblackpanel.ClientRectangle)
        End Using
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams
End Class