'MIS 322
'Colin McDonald 
'LAP 3
'04/30/19


Option Explicit On : Option Strict On
Public Class MatchNumForm
    Private Sub playButton_Click(sender As Object,
                e As EventArgs) Handles playButton.Click
        'Handle PlayButton Actions

        Dim rng As New Random()
        Dim luckyNum, randomNum As Integer
        Dim winnings, paymentAmount, taxRate As Double
        Dim paymentPlan As String

        'Handle error for luckyNum conversion and check whether
        'it is in the 1-3 range
        Try
            luckyNum = Convert.ToInt32(luckyNumberTextBox.Text)
            If luckyNum < 1 Or luckyNum > 3 Then
                MessageBox.Show("The player number must be between " &
                                "1 and 3 (inclusive)", "Number Range Error")
                Exit Sub
            End If
        Catch fe As FormatException
            MessageBox.Show("Pleae enter a whole integer",
                             "Number Format Error")
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Unexpected Error")
            Exit Sub
        End Try

        'Check for an empty box in payment plan
        If paymentPlanTextBox.Text = "" Then
            MessageBox.Show("Please enter a payment plan", "Text Box Fulfillment Error")
            Exit Sub
        End If

        'Assign the paymentPlan Text Box to the paymentPlan variable
        paymentPlan = paymentPlanTextBox.Text.ToUpper

        'Here we are going to check if payment plan is either of the 
        'options available, if not then we will throw an error.
        If Not paymentPlan = "LUMP SUM" And
           Not paymentPlan = "20-YEAR SPREAD" Then
            MessageBox.Show("The payment plan must be either Lump Sum " &
                            "or 20-year Spread", "Payment Plan Selection Error")
            Exit Sub
        End If

        'Assign Random numbers 1-3 and 1-2,000,000 to the appropriate variables
        randomNum = rng.Next(1, 4)
        winnings = rng.Next(1, 2000001)

        'Here's where the magic happens, if randomNum and luckyNum are not equal
        'Show the losers message
        If Not randomNum = luckyNum Then
            resultTextBox.Text =
                "The random number was " & randomNum & vbNewLine
            resultTextBox.Text &=
                "You Lost your bet."
        Else
            'Check if lump sum or 20 year spread
            If paymentPlan = "LUMP SUM" Then
                paymentAmount = winnings / 2
            Else
                paymentAmount = winnings / 20
            End If

            'check which tax bracket we are in
            If paymentAmount > 500000 Then
                taxRate = 0.4
            ElseIf paymentAmount > 300000 Then
                taxRate = 0.3
            ElseIf paymentAmount > 100000 Then
                taxRate = 0.25
            ElseIf paymentAmount > 10000 Then
                taxRate = 0.1
            Else
                taxRate = 0
            End If

            'post results to the result text box
            resultTextBox.Text =
               "The random number was " & randomNum & " You WON!" & vbNewLine
            resultTextBox.Text &=
                "Your winnings are " & winnings.ToString("C2") & vbNewLine
            resultTextBox.Text &=
               "Your payment amount is " & paymentPlan.ToString() & vbNewLine
            resultTextBox.Text &=
                "Your payment amount is " & paymentAmount.ToString("C2") & vbNewLine
            resultTextBox.Text &=
                "Your tax rate is " & taxRate.ToString("P2")


        End If


    End Sub '------------------------------------------------------------------------------
End Class
