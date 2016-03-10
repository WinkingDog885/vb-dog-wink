 Dim Word As String
    Dim WordLength As Integer
    Dim Char1 As String
    Dim Char2 As String
    Dim Char3 As String
    Dim Char4 As String
    Dim Char5 As String
    Dim Char6 As String
    Dim gameStarted As Boolean = False
    Dim RightTries As Integer
    Dim WrongTries As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearLetters()
        hideCharacterLength()
    End Sub
    Public Sub drawHanger()
        Dim pnt As Graphics
        pnt = Me.CreateGraphics
        Dim Pencil As New Pen(Color.Black, 2)
        pnt.DrawLine(Pencil, 46, 434, 115, 394)
        pnt.DrawLine(Pencil, 115, 394, 184, 434)
        pnt.DrawLine(Pencil, 115, 394, 115, 220)
        pnt.DrawLine(Pencil, 115, 220, 250, 220)
        pnt.DrawLine(Pencil, 250, 220, 250, 250)
    End Sub
    Public Sub resetGame()
        lblWrongGuesses.Text = ""
        Dim pnt As Graphics
        pnt = Me.CreateGraphics
        pnt.Clear(Color.Gainsboro)
        btnPlay.Visible = True
    End Sub
    Public Sub ClearLetters()
        Letter1.Text = ""
        Letter2.Text = ""
        Letter3.Text = ""
        Letter4.Text = ""
        Letter5.Text = ""
        Letter6.Text = ""
    End Sub
    Public Sub CheckForWinner()
        If RightTries = WordLength Then
            MsgBox("You Won!")
            resetGame()
        End If
    End Sub
    Public Sub StartDrawingWhenLosing(ByVal Trys As Integer)
        Dim pnt As Graphics
        pnt = Me.CreateGraphics
        Dim Pencil As New Pen(Color.Black, 2)
        If Trys = 1 Then
            pnt.DrawEllipse(Pencil, 228, 250, 40, 40)
        ElseIf Trys = 2 Then
            pnt.DrawLine(Pencil, 248, 290, 248, 370)
        ElseIf Trys = 3 Then
            pnt.DrawLine(Pencil, 248, 315, 213, 293)
        ElseIf Trys = 4 Then
            pnt.DrawLine(Pencil, 248, 315, 283, 293)
        ElseIf Trys = 5 Then
            pnt.DrawLine(Pencil, 248, 369, 213, 391)
        ElseIf Trys = 6 Then
            pnt.DrawLine(Pencil, 248, 369, 283, 391)
            TextBox1.Clear()
            Try
                Letter1.Text = Char1
                Letter2.Text = Char2
                Letter3.Text = Char3
                Letter4.Text = Char4
                Letter5.Text = Char5
                Letter6.Text = Char6
            Catch ex As Exception
            End Try
            MsgBox("You Lost")
            resetGame()
        End If
    End Sub
    Public Sub AssignLetters()
        If WordLength = 2 Then
            Char1 = Word.Chars(0).ToString.ToUpper
            Char2 = Word.Chars(1).ToString.ToUpper
        ElseIf WordLength = 3 Then
            Char1 = Word.Chars(0).ToString.ToUpper
            Char2 = Word.Chars(1).ToString.ToUpper
            Char3 = Word.Chars(2).ToString.ToUpper
        ElseIf WordLength = 4 Then
            Char1 = Word.Chars(0).ToString.ToUpper
            Char2 = Word.Chars(1).ToString.ToUpper
            Char3 = Word.Chars(2).ToString.ToUpper
            Char4 = Word.Chars(3).ToString.ToUpper
        ElseIf WordLength = 5 Then
            Char1 = Word.Chars(0).ToString.ToUpper
            Char2 = Word.Chars(1).ToString.ToUpper
            Char3 = Word.Chars(2).ToString.ToUpper
            Char4 = Word.Chars(3).ToString.ToUpper
            Char5 = Word.Chars(4).ToString.ToUpper
        ElseIf WordLength = 6 Then
            Char1 = Word.Chars(0).ToString.ToUpper
            Char2 = Word.Chars(1).ToString.ToUpper
            Char3 = Word.Chars(2).ToString.ToUpper
            Char4 = Word.Chars(3).ToString.ToUpper
            Char5 = Word.Chars(4).ToString.ToUpper
            Char6 = Word.Chars(5).ToString.ToUpper
        End If
    End Sub
    Public Sub HideCharacterLength()
        Line1.Visible = False
        Line2.Visible = False
        Line3.Visible = False
        Line4.Visible = False
        Line5.Visible = False
        Line6.Visible = False
    End Sub
    Public Sub ShowLength(ByVal VisibleLines As Integer)
        HideCharacterLength()
        If VisibleLines = 1 Then
            Line1.Visible = True
        ElseIf VisibleLines = 2 Then
            Line1.Visible = True
            Line2.Visible = True
        ElseIf VisibleLines = 3 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
        ElseIf VisibleLines = 4 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
            Line4.Visible = True
        ElseIf VisibleLines = 5 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
            Line4.Visible = True
            Line5.Visible = True
        ElseIf VisibleLines = 6 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
            Line4.Visible = True
            Line5.Visible = True
            Line6.Visible = True
        End If
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Char1 = ""
        Char2 = ""
        Char3 = ""
        Char4 = ""
        Char5 = ""
        Char6 = ""
        drawHanger()
        Dim Number As Integer
        Randomize()
        Number = Int(Rnd() * ListBox1.Items.Count - 1) + 1
        Word = ListBox1.Items(Number)
        WordLength = Word.Length
        ShowLength(Word.Length)
        ClearLetters()
        AssignLetters()
        TextBox1.Focus()
        RightTries = 0
        WrongTries = 0
        lblWrongGuesses.Text = "Wrong Guesses: "
        gameStarted = True
        btnPlay.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If gameStarted = True Then
            If TextBox1.Text = "" Then
            Else
                If TextBox1.Text.ToUpper = Char1 And Letter1.Text = "" And Char1 <> "" Then
                    Letter1.Text = Char1
                    RightTries += 1
                    CheckForWinner()
                ElseIf TextBox1.Text.ToUpper = Char2 And Letter2.Text = "" And Char2 <> "" Then
                    Letter2.Text = Char2
                    RightTries += 1
                    CheckForWinner()
                ElseIf TextBox1.Text.ToUpper = Char3 And Letter1.Text = "" And Char3 <> "" Then
                    Letter3.Text = Char3
                    RightTries += 1
                    CheckForWinner()
                ElseIf TextBox1.Text.ToUpper = Char4 And Letter4.Text = "" And Char4 <> "" Then
                    Letter4.Text = Char4
                    RightTries += 1
                    CheckForWinner()
                ElseIf TextBox1.Text.ToUpper = Char5 And Letter5.Text = "" And Char5 <> "" Then
                    Letter5.Text = Char5
                    RightTries += 1
                    CheckForWinner()
                ElseIf TextBox1.Text.ToUpper = Char6 And Letter6.Text = "" And Char6 <> "" Then
                    Letter6.Text = Char6
                    RightTries += 1
                    CheckForWinner()
                Else
                    WrongTries += 1
                    StartDrawingWhenLosing(WrongTries)
                    lblWrongGuesses.Text = lblWrongGuesses.Text & " " & TextBox1.Text

                End If
            End If
        Else
        End If
        TextBox1.Text = ""
    End Sub

    Private Sub lblWrongGuesses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblWrongGuesses.Click

    End Sub
End Class
