' Program:      Broadway Ticket Group Discount
' Author:       Mark Bulmer
' Date:         February 26, 2022
' Purpose:      This application computes the cost of bringing a group to a Broadway show.

Option Strict On

Public Class frmBroadwayTicket
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' The btnCalculate event handler calculates the group cost.

        ' Declaration Section
        Dim decSize As Decimal
        Dim decGroupCost As Decimal
        Dim decCostTotal As Decimal
        Dim decGroup1 As Decimal = 249D
        Dim decGroup2 As Decimal = 219D
        Dim decGroup3 As Decimal = 199D
        Dim decGroup4 As Decimal = 169D

        ' Did user enter a numeric value?
        If IsNumeric(txtSize.Text) Then
            decSize = Convert.ToDecimal(txtSize.Text)
            ' Is group size greater than zero
            If decSize > 0 And decSize < 100 Then
                ' Determine cost of group
                If radGroup1.Checked Then
                    decGroupCost = decGroup1
                ElseIf radGroup2.Checked Then
                    decGroupCost = decGroup2
                ElseIf radGroup3.Checked Then
                    decGroupCost = decGroup3
                ElseIf radGroup4.Checked Then
                    decGroupCost = decGroup4
                End If
                ' Calculate and display the cost 
                decCostTotal = decSize * decGroupCost
                lblCostTotal.Text = decCostTotal.ToString("C")
            Else
                ' Display error message if user entered a negative value, or one greater than 99.
                MsgBox("Please enter a number between 1 and 99.", , "Input Error")
                txtSize.Text = ""
                txtSize.Focus()
            End If
        Else
            ' Display error message if user entered a nonnumeric value.
            MsgBox("Nonnumeric value detected, please enter a number between 1 and 20.", , "Input Error")
            txtSize.Text = ""
            txtSize.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the Clear button. It 
        ' clears the group size text box and the cost label.

        txtSize.Clear()
        lblCostTotal.Text = ""
        radGroup1.Checked = True
        radGroup2.Checked = False
        radGroup3.Checked = False
        radGroup4.Checked = False
        txtSize.Focus()
    End Sub

    Private Sub frmConvention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded at the start of the 
        ' program. It sets the focus to the group size text box and
        ' clears the cost  label.

        txtSize.Focus()
        lblCostTotal.Text = ""
    End Sub

    Private Sub lblCost_Click(sender As Object, e As EventArgs) Handles lblCost.Click

    End Sub
End Class
