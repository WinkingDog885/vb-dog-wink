  Dim StudentNumber As Single = 0
    Private Sub btnScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScore.Click
        Dim objEnterScore As New frmEnterScore
        objEnterScore.ShowDialog()

        Do Until objEnterScore.txtStudentName.Text = ""
            Dim lblScore As New ListViewItem(objEnterScore.txtStudentName.Text)
            StudentNumber = 1 + StudentNumber
            lblScore.SubItems.Add(Format$(objEnterScore.numScore.Value))
            lstScoreData.Items.Add(lblScore)
            objEnterScore.ShowDialog()

        Loop

    End Sub

    Private Sub frmScoreData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstScoreData.Items.Clear()
    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        Dim intIndex, intListCount As Integer
        Dim sngTotalScore As Double = 0
        Dim sngScore As Double = 0
        Dim sngScoreAverage As Single
        Dim strResults As String, strScore As String

        intListCount = Convert.ToInt32(lstScoreData.Items.Count)
        For intIndex = 0 To intListCount - 1
            strScore = lstScoreData.Items(intIndex).SubItems(1).Text
            sngScore = Convert.ToString(strScore)
            sngTotalScore += strScore
            sngScoreAverage = (sngTotalScore / StudentNumber)

        Next
        strResults = "Total Students: " & (StudentNumber) & ControlChars.NewLine
        strResults &= "Total Average Score: " & Format$((sngScoreAverage / 100), "P") & ControlChars.NewLine
        MessageBox.Show(strResults, "Score Totals")
    End Sub
End Class

--------------------------------------------------------------------------------------------------------------------------------------


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmEnterScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtStudentName.Text = ""
        numScore.Value = 0
    End Sub
End Class
