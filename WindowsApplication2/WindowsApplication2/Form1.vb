Public Class Form1

    Private Sub btnNames_Click(sender As Object, e As EventArgs) Handles btnNames.Click
        Const intMAX_SUBSCRIPT As Integer = 4
        Dim strNames(intMAX_SUBSCRIPT) As String
        Dim intCount As Integer

        MessageBox.Show("I'm going to ask you to enter thr names " & " of five friends")

        For intCount = 0 To intMAX_SUBSCRIPT
            strNames(intCount) = InputBox("Enter a ")

        Next

        Lstgo.Items.Clear()

        For intCount = 0 To intMAX_SUBSCRIPT
            Lstgo.Items.Add(strNames(intCount))

        Next

    End Sub
End Class
