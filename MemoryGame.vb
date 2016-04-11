Dim CurrentPair As Boolean
    Dim Random, currentPlayer, firstPick, secondPick As Byte
    Dim R, G, B As Integer
    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Initialize()
    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        resetBoard()
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Randomize()
        Random = CInt(Int(9 * Rnd()) + 1)
        If Random > 5 Then
            CurrentPlayer = 1
            MsgBox("Player 1 Goes First")
        Else
            CurrentPlayer = 2
            MsgBox("Player 2 Goes First")
        End If
        'CheckForWinner()
    End Sub
    Private Sub resetBoard()
        lblScore1.Text = "0"
        lblScore2.Text = "0"
        Random = 0
        firstPick = 0
        secondPick = 0
        Pic1.Image = Nothing
        Pic2.Image = Nothing
        Pic3.Image = Nothing
        Pic4.Image = Nothing
        Pic5.Image = Nothing
        Pic6.Image = Nothing
        Pic7.Image = Nothing
        Pic8.Image = Nothing
        Pic9.Image = Nothing
        Pic10.Image = Nothing
        Pic11.Image = Nothing
        Pic12.Image = Nothing
        Pic1.Enabled = True
        Pic2.Enabled = True
        Pic3.Enabled = True
        Pic4.Enabled = True
        Pic5.Enabled = True
        Pic6.Enabled = True
        Pic7.Enabled = True
        Pic8.Enabled = True
        Pic9.Enabled = True
        Pic10.Enabled = True
        Pic11.Enabled = True
        Pic12.Enabled = True
    End Sub
    Private Sub Initialize()
        lblScore1.Text = "0"
        lblScore2.Text = "0"
        CurrentPair = False
        Random = 0
        currentPlayer = 0
        firstPick = 0
        secondPick = 0
    End Sub
    Public Function CheckForMatch()
        Dim one, two As Byte
        If firstPick = 1 Or firstPick = 2 Then
            one = 1
        End If
        If secondPick = 1 Or secondPick = 2 Then
            two = 1
        End If
        If firstPick = 3 Or firstPick = 4 Then
            one = 2
        End If
        If secondPick = 3 Or secondPick = 4 Then
            two = 2
        End If
        If firstPick = 5 Or firstPick = 6 Then
            one = 3
        End If
        If secondPick = 5 Or secondPick = 6 Then
            two = 3
        End If
        If firstPick = 7 Or firstPick = 8 Then
            one = 4
        End If
        If secondPick = 7 Or secondPick = 8 Then
            two = 4
        End If
        If firstPick = 9 Or firstPick = 10 Then
            one = 5
        End If
        If secondPick = 9 Or secondPick = 10 Then
            two = 5
        End If
        If firstPick = 11 Or firstPick = 12 Then
            one = 6
        End If
        If secondPick = 11 Or secondPick = 12 Then
            two = 6
        End If
        If one = two Then
            firstPick = 0
            secondPick = 0
            CurrentPair = False
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub clearPictures()
        Select Case firstPick
            Case 1
                Pic1.Image = Nothing
                Pic1.Enabled = True
            Case 2
                Pic2.Image = Nothing
                Pic2.Enabled = True
            Case 3
                Pic3.Image = Nothing
                Pic3.Enabled = True
            Case 4
                Pic4.Image = Nothing
                Pic4.Enabled = True
            Case 5
                Pic5.Image = Nothing
                Pic5.Enabled = True
            Case 6
                Pic6.Image = Nothing
                Pic6.Enabled = True
            Case 7
                Pic7.Image = Nothing
                Pic7.Enabled = True
            Case 8
                Pic8.Image = Nothing
                Pic8.Enabled = True
            Case 9
                Pic9.Image = Nothing
                Pic9.Enabled = True
            Case 10
                Pic10.Image = Nothing
                Pic10.Enabled = True
            Case 11
                Pic11.Image = Nothing
                Pic11.Enabled = True
            Case 12
                Pic12.Image = Nothing
                Pic12.Enabled = True
        End Select
        Select Case secondPick
            Case 1
                Pic1.Image = Nothing
                Pic1.Enabled = True
            Case 2
                Pic2.Image = Nothing
                Pic2.Enabled = True
            Case 3
                Pic3.Image = Nothing
                Pic3.Enabled = True
            Case 4
                Pic4.Image = Nothing
                Pic4.Enabled = True
            Case 5
                Pic5.Image = Nothing
                Pic5.Enabled = True
            Case 6
                Pic6.Image = Nothing
                Pic6.Enabled = True
            Case 7
                Pic7.Image = Nothing
                Pic7.Enabled = True
            Case 8
                Pic8.Image = Nothing
                Pic8.Enabled = True
            Case 9
                Pic9.Image = Nothing
                Pic9.Enabled = True
            Case 10
                Pic10.Image = Nothing
                Pic10.Enabled = True
            Case 11
                Pic11.Image = Nothing
                Pic11.Enabled = True
            Case 12
                Pic12.Image = Nothing
                Pic12.Enabled = True
        End Select
        firstPick = 0
        secondPick = 0
        CurrentPair = False

    End Sub
    Private Sub Pic1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic1.Click
        Pic1.Image = Image.FromFile("C:\Users\stu304885\Documents\Visual Studio Projects\MatchingGame\bin\Matching1.jpg")
        Select Case currentPlayer
            Case 1
                If CurrentPair = True Then
                    secondPick = 1
                    If CheckForMatch() = True Then
                        lblScore1.Text += 1
                        Pic1.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic1.Enabled = False
                    CurrentPair = True
                    firstPick = 1
                End If
            Case 2
                If CurrentPair = True Then
                    secondPick = 1
                    If CheckForMatch() = True Then
                        lblScore2.Text += 1
                        Pic1.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic1.Enabled = False
                    CurrentPair = True
                    firstPick = 1
                End If
        End Select
    End Sub

    Private Sub Pic2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic2.Click
        Pic2.Image = Image.FromFile("C:\Users\stu304885\Documents\Visual Studio Projects\MatchingGame\bin\Matching1.jpg")
        Select Case currentPlayer
            Case 1
                If CurrentPair = True Then
                    secondPick = 2
                    If CheckForMatch() = True Then
                        lblScore1.Text += 1
                        Pic2.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic2.Enabled = False
                    CurrentPair = True
                    firstPick = 2
                End If
            Case 2
                If CurrentPair = True Then
                    secondPick = 2
                    If CheckForMatch() = True Then
                        lblScore2.Text += 1
                        Pic2.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic2.Enabled = False
                    CurrentPair = True
                    firstPick = 2
                End If
        End Select
    End Sub

    Private Sub Pic3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic3.Click
        Pic3.Image = Image.FromFile("C:\Users\stu304885\Documents\Visual Studio Projects\MatchingGame\bin\Matching2.jpg")
        Select Case currentPlayer
            Case 1
                If CurrentPair = True Then
                    secondPick = 3
                    If CheckForMatch() = True Then
                        lblScore1.Text += 1
                        Pic3.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic3.Enabled = False
                    CurrentPair = True
                    firstPick = 3
                End If
            Case 2
                If CurrentPair = True Then
                    secondPick = 3
                    If CheckForMatch() = True Then
                        lblScore2.Text += 1
                        Pic3.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic3.Enabled = False
                    CurrentPair = True
                    firstPick = 3
                End If
        End Select
    End Sub

    Private Sub Pic4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic4.Click
        Pic4.Image = Image.FromFile("C:\Users\stu304885\Documents\Visual Studio Projects\MatchingGame\bin\Matching2.jpg")
        Select Case currentPlayer
            Case 1
                If CurrentPair = True Then
                    secondPick = 4
                    If CheckForMatch() = True Then
                        lblScore1.Text += 1
                        Pic4.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic4.Enabled = False
                    CurrentPair = True
                    firstPick = 4
                End If
            Case 2
                If CurrentPair = True Then
                    secondPick = 4
                    If CheckForMatch() = True Then
                        lblScore2.Text += 1
                        Pic4.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic4.Enabled = False
                    CurrentPair = True
                    firstPick = 4
                End If
        End Select
    End Sub

    Private Sub Pic5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic5.Click
        Pic5.Image = Image.FromFile("C:\Users\stu304885\Documents\Visual Studio Projects\MatchingGame\bin\Matching3.jpg")
        Select Case currentPlayer
            Case 1
                If CurrentPair = True Then
                    secondPick = 5
                    If CheckForMatch() = True Then
                        lblScore1.Text += 1
                        Pic5.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic5.Enabled = False
                    CurrentPair = True
                    firstPick = 5
                End If
            Case 2
                If CurrentPair = True Then
                    secondPick = 5
                    If CheckForMatch() = True Then
                        lblScore2.Text += 1
                        Pic5.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic5.Enabled = False
                    CurrentPair = True
                    firstPick = 5
                End If
        End Select
    End Sub

    Private Sub Pic6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic6.Click
        Pic6.Image = Image.FromFile("C:\Users\stu304885\Documents\Visual Studio Projects\MatchingGame\bin\Matching3.jpg")
        Select Case currentPlayer
            Case 1
                If CurrentPair = True Then
                    secondPick = 6
                    If CheckForMatch() = True Then
                        lblScore1.Text += 1
                        Pic6.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic6.Enabled = False
                    CurrentPair = True
                    firstPick = 6
                End If
            Case 2
                If CurrentPair = True Then
                    secondPick = 6
                    If CheckForMatch() = True Then
                        lblScore2.Text += 1
                        Pic6.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic6.Enabled = False
                    CurrentPair = True
                    firstPick = 6
                End If
        End Select
    End Sub

    Private Sub Pic7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic7.Click
        Pic7.Image = Image.FromFile("C:\Users\stu304885\Documents\Visual Studio Projects\MatchingGame\bin\Matching4.jpg")
        Select Case currentPlayer
            Case 1
                If CurrentPair = True Then
                    secondPick = 7
                    If CheckForMatch() = True Then
                        lblScore1.Text += 1
                        Pic7.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic7.Enabled = False
                    CurrentPair = True
                    firstPick = 7
                End If
            Case 2
                If CurrentPair = True Then
                    secondPick = 7
                    If CheckForMatch() = True Then
                        lblScore2.Text += 1
                        Pic7.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic7.Enabled = False
                    CurrentPair = True
                    firstPick = 7
                End If
        End Select
    End Sub

    Private Sub Pic8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic8.Click
        Pic8.Image = Image.FromFile("C:\Users\stu304885\Documents\Visual Studio Projects\MatchingGame\bin\Matching4.jpg")
        Select Case currentPlayer
            Case 1
                If CurrentPair = True Then
                    secondPick = 8
                    If CheckForMatch() = True Then
                        lblScore1.Text += 1
                        Pic8.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic8.Enabled = False
                    CurrentPair = True
                    firstPick = 8
                End If
            Case 2
                If CurrentPair = True Then
                    secondPick = 8
                    If CheckForMatch() = True Then
                        lblScore2.Text += 1
                        Pic8.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic8.Enabled = False
                    CurrentPair = True
                    firstPick = 8
                End If
        End Select
    End Sub

    Private Sub Pic9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic9.Click
        Pic9.Image = Image.FromFile("C:\Users\stu304885\Documents\Visual Studio Projects\MatchingGame\bin\Matching5.jpg")
        Select Case currentPlayer
            Case 1
                If CurrentPair = True Then
                    secondPick = 9
                    If CheckForMatch() = True Then
                        lblScore1.Text += 1
                        Pic9.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic9.Enabled = False
                    CurrentPair = True
                    firstPick = 9
                End If
            Case 2
                If CurrentPair = True Then
                    secondPick = 9
                    If CheckForMatch() = True Then
                        lblScore2.Text += 1
                        Pic9.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic9.Enabled = False
                    CurrentPair = True
                    firstPick = 9
                End If
        End Select
    End Sub

    Private Sub Pic10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic10.Click
        Pic10.Image = Image.FromFile("C:\Users\stu304885\Documents\Visual Studio Projects\MatchingGame\bin\Matching5.jpg")
        Select Case currentPlayer
            Case 1
                If CurrentPair = True Then
                    secondPick = 10
                    If CheckForMatch() = True Then
                        lblScore1.Text += 1
                        Pic10.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic10.Enabled = False
                    CurrentPair = True
                    firstPick = 10
                End If
            Case 2
                If CurrentPair = True Then
                    secondPick = 10
                    If CheckForMatch() = True Then
                        lblScore2.Text += 1
                        Pic10.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic10.Enabled = False
                    CurrentPair = True
                    firstPick = 10
                End If
        End Select
    End Sub

    Private Sub Pic11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic11.Click
        Pic11.Image = Image.FromFile("C:\Users\stu304885\Documents\Visual Studio Projects\MatchingGame\bin\Matching6.jpg")
        Select Case currentPlayer
            Case 1
                If CurrentPair = True Then
                    secondPick = 11
                    If CheckForMatch() = True Then
                        lblScore1.Text += 1
                        Pic11.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic11.Enabled = False
                    CurrentPair = True
                    firstPick = 11
                End If
            Case 2
                If CurrentPair = True Then
                    secondPick = 11
                    If CheckForMatch() = True Then
                        lblScore2.Text += 1
                        Pic11.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic11.Enabled = False
                    CurrentPair = True
                    firstPick = 11
                End If
        End Select
    End Sub

    Private Sub Pic12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic12.Click
        Pic12.Image = Image.FromFile("C:\Users\stu304885\Documents\Visual Studio Projects\MatchingGame\bin\Matching6.jpg")
        Select Case currentPlayer
            Case 1
                If CurrentPair = True Then
                    secondPick = 12
                    If CheckForMatch() = True Then
                        lblScore1.Text += 1
                        Pic12.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic12.Enabled = False
                    CurrentPair = True
                    firstPick = 12
                End If
            Case 2
                If CurrentPair = True Then
                    secondPick = 12
                    If CheckForMatch() = True Then
                        lblScore2.Text += 1
                        Pic12.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & "'s Turn")
                        clearPictures()
                    End If
                Else
                    Pic12.Enabled = False
                    CurrentPair = True
                    firstPick = 12
                End If
        End Select
    End Sub

End Class
