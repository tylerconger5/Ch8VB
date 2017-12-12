Public Class Form1

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Dim strName As String
        lstGo.Items.Clear()

        For Each strName In lstGo
            lstGo.Items.Add(strName)
        Next

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstGo.Add(txtName.Text)
        txtName.Clear()
        txtName.Focus()


    End Sub
End Class
