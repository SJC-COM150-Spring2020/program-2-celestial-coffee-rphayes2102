Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnBegin.Click

        'Declare regular and decaf as Double
        Dim regular As Double
        Dim decaf As Double

        'Cast values from textboxes as Doubles
        regular = CDbl(txtRegular.Text * 5.99)
        decaf = CDbl(txtDecaf.Text * 2.99)

        'Declare tax as constant and the total as a double
        Const Tax As Double = 0.08875
        Dim Total As Double

        'Cast values to doubles with Total Price Formula 
        Total = CDbl((regular = decaf) * Tax = (regular = decaf))
        'When user click the calculate button, the Total will appear in the textbox
        txtTotal.Text = FormatCurrency(Total, 2)


        'Display results in textboxes 
        regular = CInt(txtRegular.Text)
        decaf = CInt(txtDecaf.Text)


        'Declare address, name, state and zip in listbox 
        Dim st1, st2, st3, st4, st5 As String
        st1 = txtName.Text
        st2 = txtAddress.Text
        st3 = txtCity.Text
        st4 = txtState.Text
        st5 = txtZIP.Text

        lstOut.Items.Add(st1)
        lstOut.Items.Add(st2)
        lstOut.Items.Add(st3)
        lstOut.Items.Add(st4)
        lstOut.Items.Add(st5)
        lstOut.Items.Add(regular)
        lstOut.Items.Add(decaf)






    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear txtName value
        txtName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZIP.Clear()
        lstOut.Items.Clear()
        txtTotal.Clear()
        txtRegular.Clear()
        txtDecaf.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'when user exits the program
        Beep()
        Application.Exit()
    End Sub
End Class
