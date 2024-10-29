Public Class FormEvaluation
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

    Private Sub FormEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            LabelEval.Text = "Knowledge Base + Content (4/5): The chatbot contains a high level of knowledge to help beginners understand the VB.NET language. However, it could be expanded to also assist seasoned programmers, though this is not part of the goal for the project. 

Accuracy + Response Quality (4.5/5): The chatbot accurately responds to a variety of questions, effectively addressing user queries with relevant information. Its answers are generally precise and tailored to beginner-level understanding, making it a reliable resource for learning foundational VB.NET concepts.

User Interface (4.5/5): The chatbot’s user interface is designed to be straightforward and visually accessible, with clean aesthetics that don’t distract from the content. While it may benefit from some enhancements in design features, I found the interface to be clear and functional for its purpose.

User Experience (4/5): In terms of user experience, the chatbot is intuitive to use, with responses delivered quickly and in an organised manner. The interactions flow smoothly, making it easy for users to navigate between questions and find relevant information.

Engagement + Teaching Approach (4/5): Finally, the chatbot does a good job of creating a conversational, supportive environment for learning. Although it doesn’t fully simulate human interaction, its responses feel approachable and designed to be helpful. "
        Else
            LabelEval.Text = "Knowledge Base + Content (4/5): The chatbot demonstrates solid foundational knowledge of VB.NET, perfectly pitched for beginners. The explanations are clear and well-structured, avoiding overwhelming technical jargon. However, I noticed it could benefit from more intermediate-level content - things like design patterns, optimization techniques, and advanced debugging concepts. That said, since the primary goal is beginner education, this isn't a significant drawback.

Accuracy + Response Quality (4.5/5): The AI chatbot has been programmed to respond with highly accurate responses. The responses include clear explanations of key concepts, including responses with clear syntax and useful code snippets. 

User Interface (4.5/5): From a technical standpoint, the interface implementation is clean and efficient. The response times are quick, and the text formatting is consistent and readable. While some might argue for more bells and whistles, I actually appreciate the minimalist approach - it keeps the focus on learning. The code snippets are well-formatted and follow good practices, making them easy to understand and replicate.

User Experience (4/5): The interaction flow is smooth and intuitive. One small suggestion would be to implement a feature that allows users to easily reference previous code examples within the same session. The current implementation, while functional, could be enhanced with better session management.

Engagement + Teaching Approach (4/5): The conversational tone strikes a good balance between professional and approachable. It's evident that careful thought went into crafting responses that provide maximal information. However, it could provide more guidance in encouraging students to learn, and leading them to the answer. 
"
        End If
    End Sub
End Class