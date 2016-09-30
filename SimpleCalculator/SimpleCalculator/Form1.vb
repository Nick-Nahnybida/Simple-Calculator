
Public Class Form1


    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim dblResult As Double

        dblResult = CDbl(txtNumber1.Text) + CDbl(txtNumber2.Text)
        'Display the result
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Dim dblResult As Double

        dblResult = CDbl(txtNumber1.Text) - CDbl(txtNumber2.Text)
        'Display the result
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Dim dblResult As Double

        dblResult = CDbl(txtNumber1.Text) * CDbl(txtNumber2.Text)
        'Display the result
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Dim dblResult As Double

        dblResult = CDbl(txtNumber1.Text) / CDbl(txtNumber2.Text)
        'Display the result
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        Dim dblResult As Double

        dblResult = CDbl(txtNumber1.Text) ^ CDbl(txtNumber2.Text)
        'Display the result
        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMOD_Click(sender As Object, e As EventArgs) Handles btnMOD.Click
        Dim intResult As Integer

        intResult = CInt(txtNumber1.Text) Mod CInt(txtNumber2.Text)
        'Display the result
        lblResult.Text = CStr(intResult)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResult.Text = ""
    End Sub
End Class
