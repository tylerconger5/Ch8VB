Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ' Create anarry to hold five lottery numbers.
        Const intMax_SUBSCRIPT As Integer = 4
        Dim intNumbers(intMax_SUBSCRIPT) As Integer
        Dim intCount As Integer

        Dim rand As New Random

        For intCount = 0 To intMax_SUBSCRIPT
            intNumbers(intCount) = rand.Next(100)

        Next

        lblFirst.Text = intNumbers(0).ToString()
        lblSecond.Text = intNumbers(1).ToString()
        lblThrid.Text = intNumbers(2).ToString()
        lblFourth.Text = intNumbers(3).ToString()
        lblFifth.Text = intNumbers(4).ToString()




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
