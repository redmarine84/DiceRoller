Public Class DiceRoll
    Private DiceRolls(20) As Integer
    Private index, index1, Coin, i As Integer
    Private random As New Random()
    Private rollTicks As Integer = 0
    Private finalRoll As Integer = 1
    Private FirstRun As Boolean
    Private DiceUsed As String = ""

    Private Sub DiceRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstRun = True
        rtxtRoll.Text = ""
        rTxtTotalRoll.Text = ""
    End Sub

    Private Sub rbtnClose_Click(sender As Object, e As EventArgs) Handles rbtnClose.Click
        Me.Close()
    End Sub

    Private CoinToss As String() = {"Heads", "Tails"}
    'For 1D4 Rolls
    Private d4rolls As String() = {"2", "4", "1", "3"}
    Private d4rolls1 As String() = {"3", "1", "4", "2"}
    'For 1D6 Rolls
    Private d6rolls As String() = {"2", "5", "1", "3", "6", "4"}
    Private d6rolls1 As String() = {"3", "6", "2", "4", "1", "5"}
    'For 1D8 Rolls
    Private d8rolls As String() = {"8", "2", "5", "3", "4", "1", "7", "6"}
    Private d8rolls1 As String() = {"2", "7", "6", "8", "4", "3", "1", "5"}
    'For 1D10 Rolls
    Private d10rolls As String() = {"6", "2", "5", "8", "10", "4", "1", "3", "9", "7"}
    Private d10rolls1 As String() = {"2", "4", "1", "3", "6", "9", "10", "7", "8", "5"}
    'For Percentile Rolls
    Private percentage As String() = {"5", "7", "6", "1", "8", "10", "2", "3", "4", "9"}
    Private percentage1 As String() = {"9", "10", "7", "4", "2", "6", "3", "1", "5", "8"}
    'For 1D20 and Advantage/Disadvantage Rolls
    Private d20rolls As String() = {"2", "5", "1", "8", "10", "15", "20", "16", "3", "4", "9", "19", "17", "12", "11", "7", "13", "6", "14", "18"}
    Private d20rolls1 As String() = {"4", "10", "15", "18", "1", "5", "2", "6", "13", "20", "19", "9", "7", "3", "12", "11", "17", "16", "14", "8"}

    Private Sub roll1d4Btn_Click(sender As Object, e As EventArgs) Handles roll1d4Btn.Click
        DiceUsed = "D4"
        Coin = random.Next(CoinToss.Length)
        If Coin = 0 Then
            tmrDice.Enabled = True
            FirstRun = False
            tmrDice.Start()
            index = random.Next(d4rolls.Length)

            rtxtRoll.ForeColor = Color.White
            rtxtRoll.Text = ""
            rTxtTotalRoll.Text = ""

            rtxtRoll.Text = d4rolls(index)
            finalRoll = d4rolls(index)
            If i <= 20 Then
                DiceRolls(i) = rtxtRoll.Text
                i += 1
            Else i = 0
            End If
            rtxtDiceRolled.Text = i
        Else
            tmrDice.Enabled = True
            FirstRun = False
            tmrDice.Start()
            index = random.Next(d4rolls1.Length)

            rtxtRoll.ForeColor = Color.White
            rtxtRoll.Text = ""
            rTxtTotalRoll.Text = ""

            rtxtRoll.Text = d4rolls1(index)
            finalRoll = d4rolls1(index)
            If i <= 20 Then
                DiceRolls(i) = rtxtRoll.Text
                i += 1
            Else i = 0
            End If
            rtxtDiceRolled.Text = i
        End If
        rollTicks = 0
    End Sub

    Private Sub roll1d6Btn_Click(sender As Object, e As EventArgs) Handles roll1d6Btn.Click
        DiceUsed = "D6"
        Coin = random.Next(CoinToss.Length)
        If Coin = 0 Then
            tmrDice.Enabled = True
            FirstRun = False
            tmrDice.Start()
            index = random.Next(d6rolls.Length)

            rtxtRoll.ForeColor = Color.White
            rtxtRoll.Text = ""
            rTxtTotalRoll.Text = ""

            rtxtRoll.Text = d6rolls(index)
            finalRoll = d6rolls(index)
            If i <= 20 Then
                DiceRolls(i) = d6rolls(index)
                i += 1
            Else i = 0
            End If
            rtxtDiceRolled.Text = i
        Else
            tmrDice.Enabled = True
            FirstRun = False
            tmrDice.Start()
            index = random.Next(d6rolls1.Length)

            rtxtRoll.ForeColor = Color.White
            rtxtRoll.Text = ""
            rTxtTotalRoll.Text = ""

            rtxtRoll.Text = d6rolls1(index)
            finalRoll = d6rolls1(index)
            If i <= 20 Then
                DiceRolls(i) = d6rolls1(index)
                i += 1
            Else i = 0
            End If
            rtxtDiceRolled.Text = i
        End If
        rollTicks = 0
    End Sub

    Private Sub roll1d8Btn_Click(sender As Object, e As EventArgs) Handles roll1d8Btn.Click
        DiceUsed = "D8"
        Coin = random.Next(CoinToss.Length)
        If Coin = 0 Then
            tmrDice.Enabled = True
            FirstRun = False
            tmrDice.Start()
            index = random.Next(d8rolls.Length)

            rtxtRoll.ForeColor = Color.White
            rtxtRoll.Text = ""
            rTxtTotalRoll.Text = ""

            rtxtRoll.Text = d8rolls(index)
            finalRoll = d8rolls(index)
            If i <= 20 Then
                DiceRolls(i) = rtxtRoll.Text
                i += 1
            Else i = 0
            End If
            rtxtDiceRolled.Text = i
        Else
            tmrDice.Enabled = True
            FirstRun = False
            tmrDice.Start()
            index = random.Next(d8rolls1.Length)

            rtxtRoll.ForeColor = Color.White
            rtxtRoll.Text = ""
            rTxtTotalRoll.Text = ""

            rtxtRoll.Text = d8rolls1(index)
            finalRoll = d8rolls1(index)
            If i <= 20 Then
                DiceRolls(i) = rtxtRoll.Text
                i += 1
            Else i = 0
            End If
            rtxtDiceRolled.Text = i
        End If
        rollTicks = 0
    End Sub

    Private Sub roll1d10Btn_Click(sender As Object, e As EventArgs) Handles roll1d10Btn.Click
        DiceUsed = "D10"
        Coin = random.Next(CoinToss.Length)
        If Coin = 0 Then
            tmrDice.Enabled = True
            FirstRun = False
            tmrDice.Start()
            index = random.Next(d10rolls.Length)

            rtxtRoll.ForeColor = Color.White
            rtxtRoll.Text = ""
            rTxtTotalRoll.Text = ""

            rtxtRoll.Text = d10rolls(index)
            finalRoll = d10rolls(index)
            If i <= 20 Then
                DiceRolls(i) = rtxtRoll.Text
                i += 1
            Else i = 0
            End If
            rtxtDiceRolled.Text = i
        Else
            tmrDice.Enabled = True
            FirstRun = False
            tmrDice.Start()
            index = random.Next(d10rolls1.Length)

            rtxtRoll.ForeColor = Color.White
            rtxtRoll.Text = ""
            rTxtTotalRoll.Text = ""

            rtxtRoll.Text = d10rolls1(index)
            finalRoll = d10rolls1(index)
            If i <= 20 Then
                DiceRolls(i) = rtxtRoll.Text
                i += 1
            Else i = 0
            End If
            rtxtDiceRolled.Text = i
        End If
        rollTicks = 0
    End Sub

    Private Sub rollPercentageBtn_Click(sender As Object, e As EventArgs) Handles rollPercentageBtn.Click
        DiceUsed = "Percentile"
        Coin = random.Next(CoinToss.Length)
        If Coin = 0 Then
            tmrDice.Enabled = True
            FirstRun = False
            tmrDice.Start()
            index = random.Next(percentage.Length)

            rtxtRoll.ForeColor = Color.White
            rtxtRoll.Text = ""
            rTxtTotalRoll.Text = ""

            rtxtRoll.Text = percentage(index)
            finalRoll = percentage(index)

            rtxtRoll.Text = (rtxtRoll.Text * 10).ToString + "%"
        Else
            tmrDice.Enabled = True
            FirstRun = False
            tmrDice.Start()
            index = random.Next(percentage1.Length)

            rtxtRoll.ForeColor = Color.White
            rtxtRoll.Text = ""
            rTxtTotalRoll.Text = ""

            rtxtRoll.Text = percentage1(index)
            finalRoll = percentage1(index)

            rtxtRoll.Text = (rtxtRoll.Text * 10).ToString + "%"
        End If
        i = 0
        rtxtDiceRolled.Text = i
        rollTicks = 0
    End Sub

    Private Sub roll1d20Btn_Click(sender As Object, e As EventArgs) Handles roll1d20Btn.Click
        DiceUsed = "D20"
        Coin = random.Next(CoinToss.Length)
        If Coin = 0 Then
            tmrDice.Enabled = True
            FirstRun = False
            tmrDice.Start()

            index = random.Next(d20rolls.Length)

            rtxtRoll.ForeColor = Color.White
            rtxtRoll.Text = ""
            rTxtTotalRoll.Text = ""

            rtxtRoll.Text = d20rolls(index)
            finalRoll = d20rolls(index)
            If rtxtRoll.Text = 20 Then
                rtxtRoll.ForeColor = Color.Green
                MessageBox.Show("Congratulations on the Crit!!! NAT 20!!!")
            End If
            If rtxtRoll.Text = 1 Then
                rtxtRoll.ForeColor = Color.Red
                MessageBox.Show("NAT 1. YOU FAILED!!!!")
            End If
            If i <= 20 Then
                DiceRolls(i) = rtxtRoll.Text
                i += 1
            Else i = 0
            End If
            rtxtDiceRolled.Text = i
            rollTicks = 0
        Else
            tmrDice.Enabled = True
            FirstRun = False
            tmrDice.Start()
            index = random.Next(d20rolls1.Length)

            rtxtRoll.ForeColor = Color.White
            rtxtRoll.Text = ""
            rTxtTotalRoll.Text = ""

            rtxtRoll.Text = d20rolls1(index)
            finalRoll = d20rolls1(index)
            If rtxtRoll.Text = 20 Then
                rtxtRoll.ForeColor = Color.Green
                MessageBox.Show("Congratulations on the Crit!!! NAT 20!!!")
            End If
            If rtxtRoll.Text = 1 Then
                rtxtRoll.ForeColor = Color.Red
                MessageBox.Show("NAT 1. YOU FAILED!!!!")
            End If
            If i <= 20 Then
                DiceRolls(i) = rtxtRoll.Text
                i += 1
            Else i = 0
            End If
            rtxtDiceRolled.Text = i
            rollTicks = 0
        End If
    End Sub

    Private Sub rollAdvantageBtn_Click(sender As Object, e As EventArgs) Handles rollAdvantageBtn.Click
        DiceUsed = "D20"
        index = random.Next(d20rolls.Length)
        index1 = random.Next(d20rolls1.Length)
        Dim Roll1, Roll2 As Integer

        rtxtRoll.ForeColor = Color.White
        rtxtRoll.Text = ""
        rTxtTotalRoll.Text = ""

        tmrDice.Enabled = True
        FirstRun = False
        tmrDice.Start()

        Roll1 = d20rolls(index)
        Roll2 = d20rolls1(index1)

        If Roll1 >= Roll2 Then
            rtxtRoll.Text = Roll1
            finalRoll = Roll1
        ElseIf Roll1 < Roll2 Then
            rtxtRoll.Text = Roll2
            finalRoll = Roll2
        End If

        If Roll1 = 20 Or Roll2 = 20 Then
            rtxtRoll.ForeColor = Color.Green
            MessageBox.Show("Congratulations on the Crit!!! NAT 20!!!")
        End If

        rollTicks = 0
        ReDim DiceRolls(20)
        i = 0
        rtxtDiceRolled.Text = i
    End Sub

    Private Sub rollDisadvantageBtn_Click(sender As Object, e As EventArgs) Handles rollDisadvantageBtn.Click
        DiceUsed = "D20"
        index = random.Next(d20rolls.Length)
        index1 = random.Next(d20rolls1.Length)
        Dim Roll1, Roll2 As Integer

        rtxtRoll.ForeColor = Color.White
        rtxtRoll.Text = ""
        rTxtTotalRoll.Text = ""

        tmrDice.Enabled = True
        FirstRun = False
        tmrDice.Start()

        Roll1 = d20rolls(index)
        Roll2 = d20rolls1(index1)

        If Roll1 >= Roll2 Then
            rtxtRoll.Text = Roll2
            finalRoll = Roll2
        ElseIf Roll1 < Roll2 Then
            rtxtRoll.Text = Roll1
            finalRoll = Roll1
        End If

        If Roll1 = 1 Or Roll2 = 1 Then
            rtxtRoll.ForeColor = Color.Red
            MessageBox.Show("NAT 1. YOU FAILED!!!!")
        End If

        rollTicks = 0
        ReDim DiceRolls(20)
        i = 0
        rtxtDiceRolled.Text = i
    End Sub

    Private Function GetDieFace(value As Integer, Dice As String) As Image
        Select Case Dice
            Case "D4"
                Select Case value
                    Case 1 : Return d4ImageList.Images.Item(0)
                    Case 2 : Return d4ImageList.Images.Item(1)
                    Case 3 : Return d4ImageList.Images.Item(2)
                    Case 4 : Return d4ImageList.Images.Item(3)
                End Select
            Case "D6"
                Select Case value
                    Case 1 : Return d6ImageList.Images.Item(0)
                    Case 2 : Return d6ImageList.Images.Item(1)
                    Case 3 : Return d6ImageList.Images.Item(2)
                    Case 4 : Return d6ImageList.Images.Item(3)
                    Case 5 : Return d6ImageList.Images.Item(4)
                    Case 6 : Return d6ImageList.Images.Item(5)
                End Select
            Case "D8"
                Select Case value
                    Case 1 : Return d8ImageList.Images.Item(0)
                    Case 2 : Return d8ImageList.Images.Item(1)
                    Case 3 : Return d8ImageList.Images.Item(2)
                    Case 4 : Return d8ImageList.Images.Item(3)
                    Case 5 : Return d8ImageList.Images.Item(4)
                    Case 6 : Return d8ImageList.Images.Item(5)
                    Case 7 : Return d8ImageList.Images.Item(6)
                    Case 8 : Return d8ImageList.Images.Item(7)
                End Select
            Case "D10"
                Select Case value
                    Case 1 : Return d10ImageList.Images.Item(0)
                    Case 2 : Return d10ImageList.Images.Item(1)
                    Case 3 : Return d10ImageList.Images.Item(2)
                    Case 4 : Return d10ImageList.Images.Item(3)
                    Case 5 : Return d10ImageList.Images.Item(4)
                    Case 6 : Return d10ImageList.Images.Item(5)
                    Case 7 : Return d10ImageList.Images.Item(6)
                    Case 8 : Return d10ImageList.Images.Item(7)
                    Case 9 : Return d10ImageList.Images.Item(8)
                    Case 10 : Return d10ImageList.Images.Item(9)
                End Select
            Case "Percentile"
                Select Case value
                    Case 1 : Return PercentileImageList.Images.Item(0)
                    Case 2 : Return PercentileImageList.Images.Item(1)
                    Case 3 : Return PercentileImageList.Images.Item(2)
                    Case 4 : Return PercentileImageList.Images.Item(3)
                    Case 5 : Return PercentileImageList.Images.Item(4)
                    Case 6 : Return PercentileImageList.Images.Item(5)
                    Case 7 : Return PercentileImageList.Images.Item(6)
                    Case 8 : Return PercentileImageList.Images.Item(7)
                    Case 9 : Return PercentileImageList.Images.Item(8)
                    Case 10 : Return PercentileImageList.Images.Item(9)
                End Select
            Case "D20"
                Select Case value
                    Case 1 : Return d20ImageList.Images.Item(0)
                    Case 2 : Return d20ImageList.Images.Item(1)
                    Case 3 : Return d20ImageList.Images.Item(2)
                    Case 4 : Return d20ImageList.Images.Item(3)
                    Case 5 : Return d20ImageList.Images.Item(4)
                    Case 6 : Return d20ImageList.Images.Item(5)
                    Case 7 : Return d20ImageList.Images.Item(6)
                    Case 8 : Return d20ImageList.Images.Item(7)
                    Case 9 : Return d20ImageList.Images.Item(8)
                    Case 10 : Return d20ImageList.Images.Item(9)
                    Case 11 : Return d20ImageList.Images.Item(10)
                    Case 12 : Return d20ImageList.Images.Item(11)
                    Case 13 : Return d20ImageList.Images.Item(12)
                    Case 14 : Return d20ImageList.Images.Item(13)
                    Case 15 : Return d20ImageList.Images.Item(14)
                    Case 16 : Return d20ImageList.Images.Item(15)
                    Case 17 : Return d20ImageList.Images.Item(16)
                    Case 18 : Return d20ImageList.Images.Item(17)
                    Case 19 : Return d20ImageList.Images.Item(18)
                    Case 20 : Return d20ImageList.Images.Item(19)
                End Select
        End Select
    End Function

    Private Sub TotalRoll()
        Dim total As Integer
        total = DiceRolls.Sum
        rTxtTotalRoll.Text = total
    End Sub

    Private Sub rbtnTotalRoll_Click(sender As Object, e As EventArgs) Handles rbtnTotalRoll.Click
        TotalRoll()
        ReDim DiceRolls(20)
        i = 0
    End Sub

    Private Sub tmrDice_Tick(sender As Object, e As EventArgs) Handles tmrDice.Tick
        If Not FirstRun Then
            rollTicks += 1

            ' Show changing values to simulate rolling
            If DiceUsed = "D4" Then
                If Coin = 0 Then rlabDice.Image = GetDieFace(random.Next(d4rolls.Length), DiceUsed)
                If Coin = 1 Then rlabDice.Image = GetDieFace(random.Next(d4rolls1.Length), DiceUsed)
            ElseIf DiceUsed = "D6" Then
                If Coin = 0 Then rlabDice.Image = GetDieFace(random.Next(d6rolls.Length), DiceUsed)
                If Coin = 1 Then rlabDice.Image = GetDieFace(random.Next(d6rolls1.Length), DiceUsed)
            ElseIf DiceUsed = "D8" Then
                If Coin = 0 Then rlabDice.Image = GetDieFace(random.Next(d8rolls.Length), DiceUsed)
                If Coin = 1 Then rlabDice.Image = GetDieFace(random.Next(d8rolls1.Length), DiceUsed)
            ElseIf DiceUsed = "D10" Then
                If Coin = 0 Then rlabDice.Image = GetDieFace(random.Next(d10rolls.Length), DiceUsed)
                If Coin = 1 Then rlabDice.Image = GetDieFace(random.Next(d10rolls1.Length), DiceUsed)
            ElseIf DiceUsed = "Percentile" Then
                If Coin = 0 Then rlabDice.Image = GetDieFace(random.Next(d10rolls.Length), DiceUsed)
                If Coin = 1 Then rlabDice.Image = GetDieFace(random.Next(d10rolls1.Length), DiceUsed)
            ElseIf DiceUsed = "D20" Then
                If Coin = 0 Then rlabDice.Image = GetDieFace(random.Next(d20rolls.Length), DiceUsed)
                If Coin = 1 Then rlabDice.Image = GetDieFace(random.Next(d20rolls1.Length), DiceUsed)
            End If
            rtxtRoll.Text = finalRoll.ToString()

            ' Gradually slow down
            If rollTicks < 10 Then
                tmrDice.Interval = 50
            ElseIf rollTicks < 18 Then
                tmrDice.Interval = 90
            ElseIf rollTicks < 24 Then
                tmrDice.Interval = 140
            Else
                tmrDice.Stop()
                tmrDice.Enabled = False
                If DiceUsed = "D4" Then
                    rlabDice.Image = GetDieFace(finalRoll, "D4")
                ElseIf DiceUsed = "D6" Then
                    rlabDice.Image = GetDieFace(finalRoll, "D6")
                ElseIf DiceUsed = "D8" Then
                    rlabDice.Image = GetDieFace(finalRoll, "D8")
                ElseIf DiceUsed = "D10" Then
                    rlabDice.Image = GetDieFace(finalRoll, "D10")
                ElseIf DiceUsed = "Percentile" Then
                    rlabDice.Image = GetDieFace(finalRoll, "Percentile")
                ElseIf DiceUsed = "D20" Then
                    rlabDice.Image = GetDieFace(finalRoll, "D20")
                End If
            End If
        End If
    End Sub
End Class