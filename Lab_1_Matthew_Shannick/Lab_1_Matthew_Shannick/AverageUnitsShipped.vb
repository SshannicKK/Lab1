'Name: Matthew Shannick'
'Date: January 21, 2020'
'Document: Lab 1 '
'Purpose: This program will track number of orders shipped over 7 days,
'         when the final day is entered the form will give the average
'         of units shipped using the past 7 days entered

Option Strict On
Public Class frmAverageUnitsShipped

    'validating global variable for day
    Dim day As Integer = 1
    Dim averageUnitsShipped As Double
    Dim totalUnitsShipped As Integer
    Dim dailyUnitsShipped As Integer
    Const DaysInAWeek As Integer = 8
    Const MIN_UNITS_SHIPPED As Integer = 0
    Const MAX_UNITS_SHIPPED As Integer = 5000

    'The Exit Button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This will close the form
        Me.Close()
    End Sub

    'The Reset Button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'This will clear the form allowing the user to enter in new data
        txtNumberOfUnitsShipped.Clear()
        txtPastDayShipments.Clear()
        lblAverageOutput.Text = String.Empty

        'This will reenable the enter button and input textbox
        txtNumberOfUnitsShipped.Enabled = True
        btnEnter.Enabled = True

        'Resets Day to one
        lblDayNumber.Text = "Day " & day
        day = 1

        'sets foucused on input text box
        txtNumberOfUnitsShipped.Focus()
        'resets the average back to zero
        averageUnitsShipped = 0
        'resets the total back to zero
        totalUnitsShipped = 0
    End Sub

    'The Enter Button
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'When the user enters a number and hits enter, it will get validated and
        'moved down into the past day shipments for storage
        'until Day 7 when it will calculate the average

        'starting a if statement to validate the user entry
        If Integer.TryParse(txtNumberOfUnitsShipped.Text, dailyUnitsShipped) Then

            'Validating if the users enteer is between 0 and 5000
            If (dailyUnitsShipped > MIN_UNITS_SHIPPED And dailyUnitsShipped < MAX_UNITS_SHIPPED) Then

                'adds the shiments for the day to the total number
                totalUnitsShipped += dailyUnitsShipped

                'prints the user input into past days textbox and resets it to a new line
                txtPastDayShipments.Text &= dailyUnitsShipped & vbCrLf

                'Changes Day lable to increase with counter
                lblDayNumber.Text = "Day " & day

                'Clears textbox for next day input
                txtNumberOfUnitsShipped.Clear()

                'increases the day coounter by 1
                day += 1

                'When day reaches 7 the average is calculated and dsplayed
                If day = DaysInAWeek Then

                    'Calculate and output the average units shipped
                    averageUnitsShipped = totalUnitsShipped / (DaysInAWeek - 1)
                    'the console will display the average with 2 decimal places
                    lblAverageOutput.Text = "Average Units shiped: " & Math.Round(averageUnitsShipped, 2)

                    'disables input text box and enter button so user can access them and focus is set to the reset button
                    txtNumberOfUnitsShipped.Enabled = False
                    btnEnter.Enabled = False
                    btnReset.Focus()


                End If
            Else
                'If the user entry is not between 0 and 5000 this message will be displayed
                MessageBox.Show("Please only enter a value between " & MIN_UNITS_SHIPPED & " and " & MAX_UNITS_SHIPPED)
            End If
        Else
                'If the user enters non numeric data then this message will be shown
                MessageBox.Show("Please Enter a numeric value")


        End If


    End Sub
End Class
