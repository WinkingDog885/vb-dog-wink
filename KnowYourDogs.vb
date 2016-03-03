
    'Chapter 7 : Know Your Doggos Quiz
    'Programmer: Alex Barba
    'Date      : 2/25/16
    'Purpose   : Make a simple Visual Basic Quiz asking
    '            Users to identify different dog breeds
    '            and having their scores displayed after
    '            answering all of the Questions.
    Dim gshrSolution As Short() = {3, 0, 1, 2, 3, 3, 0}
    Dim gshrAnswers As Short() = {-1, -1, -1, -1, -1, -1, -1}
    Dim gshrCurrentQuestion As Short = 0
    Dim gstrQuestions As String(,) = { _
    {"English Springer Spaniel", "Akita", "Husky", "Bearded Collie", "dog051.jpg"}, _
    {"Pug", "Whippet", "Fox Terrier", "English Setter", "dog50.jpg"}, _
    {"Chow Chow", "Beagle", "Labrador Retriever", "FoxHound", "dog068.jpg"}, _
    {"Great Dane", "Dachsund", "Samoyed", "Newfoundland", "dog044.jpg"}, _
    {"Samoyed", "Pekingese", "English Setter", "Pomeranian", "dog088.jpg"}, _
    {"Old English Sheepdog", "Saluki", "Rottwieler", "Poodle", "dog074.jpg"}, _
    {"Collie", "Boston Terrier", "Bichon Frise", "Akita", "dog007.jpg"}}


    Private Sub DisplayQuestion(ByVal shrQuestion As Short)
        Dim shrIndex As Short

        'Check if user clicked Previous on first Question

        If shrQuestion < 0 Then
            MessageBox.Show("You are already at the First Question.", "Know Your Dogs Quiz")
            gshrCurrentQuestion = 0
            Exit Sub
        End If

        'Store user's answer in gshrAnswers array
        Select Case True
            Case radAnswer1.Checked
                gshrAnswers(gshrCurrentQuestion) = 0
                radAnswer1.Checked = False
            Case radAnswer2.Checked
                gshrAnswers(gshrCurrentQuestion) = 1
                radAnswer2.Checked = False
            Case radAnswer3.Checked
                gshrAnswers(gshrCurrentQuestion) = 2
                radAnswer3.Checked = False
            Case radAnswer4.Checked
                gshrAnswers(gshrCurrentQuestion) = 3
                radAnswer4.Checked = False
        End Select
        If shrQuestion > gstrQuestions.GetUpperBound(0) Then

            If MessageBox.Show("You have answered the Last Question. Would you like to display the Final Results?" _
            & ControlChars.NewLine & ControlChars.NewLine _
            & "Click No to Return.", "End of Quiz", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
            MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                If QuizResult() Then
                    MessageBox.Show("Congratulations! You Passed!", "Know Your Dogs Quiz")
                Else
                    MessageBox.Show("Sorry, you did not pass the quiz", "Know Your Dogs Quiz")
                End If
                Me.Close()
            Else
                gshrCurrentQuestion = Convert.ToInt16(gstrQuestions.GetUpperBound(0))
            End If
            Exit Sub
        End If

        'Update controls on next questions

        For shrIndex = 0 To 3
            grpAnswer.Controls(shrIndex).Text = gstrQuestions(shrQuestion, shrIndex)
        Next
        picQuestion.Image = Image.FromFile(gstrQuestions(shrQuestion, 4))
        stbQuestions.Panels(0).Text = "Question " & shrQuestion + 1 & " of " & gstrQuestions.GetUpperBound(0) + 1

        Select Case gshrAnswers(shrQuestion)
            Case 0
                radAnswer1.Checked = 0
            Case 1
                radAnswer2.Checked = 0
            Case 2
                radAnswer3.Checked = 0
            Case 3
                radAnswer4.Checked = 0
        End Select

        gshrCurrentQuestion = shrQuestion

    End Sub

    Private Function QuizResult() As Boolean

        Dim shrIndex As Short
        For shrIndex = 0 To 6
            If gshrSolution(shrIndex) <> gshrAnswers(shrIndex) Then
                Return False
            End If

        Next
        QuizResult = True

    End Function
    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close() 'Exit Application
    End Sub

    Private Sub mnuFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFont.Click
        fodQuestion.Font = radAnswer1.Font

        If fodQuestion.ShowDialog() = DialogResult.OK Then
            radAnswer1.Font = fodQuestion.Font
            radAnswer2.Font = fodQuestion.Font
            radAnswer3.Font = fodQuestion.Font
            radAnswer4.Font = fodQuestion.Font
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisplayQuestion(0)
    End Sub

    Private Sub mnuFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFirst.Click
        DisplayQuestion(0)
    End Sub

    Private Sub mnuLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLast.Click
        DisplayQuestion(Convert.ToInt16(gstrQuestions.GetUpperBound(0)))
    End Sub

    Private Sub mnuNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNext.Click
        DisplayQuestion(gshrCurrentQuestion + Convert.ToInt16(1))
    End Sub

    Private Sub mnuPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrevious.Click
        DisplayQuestion(gshrCurrentQuestion - Convert.ToInt16(1))
    End Sub

    Private Sub cmuPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmuPrevious.Click
        mnuPrevious.PerformClick()
    End Sub

    Private Sub cmuNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmuNext.Click
        mnuNext.PerformClick()
    End Sub

    Private Sub cmuFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmuFont.Click
        mnuFont.PerformClick()
    End Sub

    Private Sub cmuFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmuFinish.Click
        DisplayQuestion(Convert.ToInt16(gstrQuestions.GetUpperBound(0) + 1))
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        mnuExit.PerformClick()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        mnuNext.PerformClick()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        mnuPrevious.PerformClick()
    End Sub
End Class
