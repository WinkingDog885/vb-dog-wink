
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim objAddition As New frmAdditionPage
        objAddition.ShowDialog()
        Do Until objAddition.txtName.Text = ""
            Dim lblData As New ListViewItem(objAddition.txtName.Text)
            lblData.SubItems.Add(objAddition.numHours.Value)
            lblData.SubItems.Add(Format$(objAddition.numPay.Value, "Currency"))
            lstPayData.Items.Add(lblData)
            objAddition.ShowDialog()
        Loop
    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        Dim intIndex, intListCount As Integer
        Dim sngTotalSales As Single = 0
        Dim sngTotalWorkerPay As Single = 0
        Dim strPayRate As Single
        Dim sngHours As Single
        Dim strResults As String, strHours As String

        intListCount = Convert.ToInt32(lstPayData.Items.Count)
        For intIndex = 0 To intListCount - 1
            strHours = lstPayData.Items(intIndex).SubItems(1).Text
            strPayRate = lstPayData.Items(intIndex).SubItems(2).Text
            strHours = strHours.Replace("$", "0")
            sngHours = Convert.ToString(strHours)
            sngTotalSales += sngHours
            sngTotalWorkerPay += sngHours * strPayRate
        Next
        strResults = "Total Hours Worked: " & (sngTotalSales) & ControlChars.NewLine
        strResults &= "Total Worker Pay: " & Format$(sngTotalWorkerPay, "Currency")
        MessageBox.Show(strResults, "Total Hours Paid")

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstPayData.Items.Clear()
    End Sub
    
    ----------------------------------------------------------------------------------------------------------------------------------
    
        Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub frmAdditionPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtName.Text = ""
        numHours.Value = 0
        numPay.Value = 0
    End Sub
    
