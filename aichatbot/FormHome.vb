Public Class FormHome
    Dim Ticks As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.boot_up, AudioPlayMode.Background)
        Ticks = 0
        PictureBox1.Location = New System.Drawing.Point(PictureBox1.Location.X, PictureBox1.Location.Y - 200)
        Button1.Location = New System.Drawing.Point(Button1.Location.X, Button1.Location.Y + 400)
        Label2.Location = New System.Drawing.Point(Label2.Location.X, Label2.Location.Y + 400)
        ButtonQB.Location = New System.Drawing.Point(ButtonQB.Location.X - 400, ButtonQB.Location.Y)
        Label1.Location = New System.Drawing.Point(Label1.Location.X - 400, Label1.Location.Y)
        ButtonEval.Location = New System.Drawing.Point(ButtonEval.Location.X + 400, ButtonEval.Location.Y)
        Label3.Location = New System.Drawing.Point(Label3.Location.X + 400, Label3.Location.Y)
        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Ticks += 1
        PictureBox1.Location = New System.Drawing.Point(PictureBox1.Location.X, PictureBox1.Location.Y + (2 - (Ticks / 100)))
        Button1.Location = New System.Drawing.Point(Button1.Location.X, Button1.Location.Y - (4 - (Ticks / 50)))
        Label2.Location = New System.Drawing.Point(Label2.Location.X, Label2.Location.Y - (4 - (Ticks / 50)))
        ButtonQB.Location = New System.Drawing.Point(ButtonQB.Location.X + (4 - (Ticks / 50)), ButtonQB.Location.Y)
        Label1.Location = New System.Drawing.Point(Label1.Location.X + (4 - (Ticks / 50)), Label1.Location.Y)
        ButtonEval.Location = New System.Drawing.Point(ButtonEval.Location.X - (4 - (Ticks / 50)), ButtonEval.Location.Y)
        Label3.Location = New System.Drawing.Point(Label3.Location.X - (4 - (Ticks / 50)), Label3.Location.Y)
        If Ticks = 200 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Dim Answer As DialogResult = MessageBox.Show("Are you sure you want to exit the program?", "VB.net AI asks:", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If Answer = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ButtonQB_Click(sender As Object, e As EventArgs) Handles ButtonQB.Click
        FormQB.Show()
        Me.Hide()
    End Sub
End Class