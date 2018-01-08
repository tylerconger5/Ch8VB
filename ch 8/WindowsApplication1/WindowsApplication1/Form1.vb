Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim intRow, intCol As Integer

        Const intMAX_ROW As Integer = 5
        Const intMAX_COL As Integer = 3

        Dim decPrices(,) = {{450D, 450D, 450D, 450D},
                            {425D, 425D, 425D, 425D},
                            {400D, 400D, 400D, 400D},
                            {375D, 375D, 375D, 375D},
                            {375D, 375D, 375D, 375D},
                            {350D, 350D, 350D, 350D}}
        Try
            intRow = CInt(txtRow.Text)
            intCol = CInt(txtCol.Text)

            If intRow >= 0 And intRow <= intMAX_ROW Then
                If intCol >= 0 And intCol <= intMAX_COL Then
                    lblPrice.Text = decPrices(intRow, intCol).ToString("c")
                Else
                    MessageBox.Show("Column must be 0 throught " &
                                    intMAX_COL.ToString())
                End If
            Else
                MessageBox.Show("Row must be 0 through " &
                                intMAX_ROW.ToString())
            End If

        Catch
            MessageBox.Show("Row and Column msut be integers.")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click

    End Sub
End Class
