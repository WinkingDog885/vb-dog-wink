    Dim Cents As Integer = 0
    Dim Penny As Integer = 0
    Dim Dime As Integer = 0
    Dim Nickel As Integer = 0
    Dim Quarter As Integer = 0
    Dim HDollar As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim strResults As String
        Cents = 100 - numCents.Value
        Do Until Cents = 0
            Calc()
        Loop
        strResults = "Half Dollars: " & HDollar & ControlChars.NewLine
        strResults &= "Quarters: " & Quarter & ControlChars.NewLine
        strResults &= "Dimes: " & Dime & ControlChars.NewLine
        strResults &= "Nickels: " & Nickel & ControlChars.NewLine
        strResults &= "Pennies: " & Penny & ControlChars.NewLine
        MessageBox.Show(strResults, "Change")
        Reset()
    End Sub

    Private Sub Calc()
        If Cents >= 50 Then
            Cents = Cents - 50
            HDollar = HDollar + 1
        ElseIf Cents >= 25 Then
            Cents = Cents - 25
            Quarter = Quarter + 1
        ElseIf Cents >= 10 Then
            Cents = Cents - 10
            Dime = Dime + 1
        ElseIf Cents >= 5 Then
            Cents = Cents - 5
            Nickel = Nickel + 1
        ElseIf Cents >= 1 Then
            Cents = Cents - 1
            Penny = Penny + 1
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub Reset()
        Penny = 0
        Nickel = 0
        Dime = 0
        Quarter = 0
        HDollar = 0
        numCents.Value = 0
        Cents = 0
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
