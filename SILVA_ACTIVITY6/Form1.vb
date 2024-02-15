Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtFirstNum.Text = "" Or txtSecondNum.Text = "" Then
            MessageBox.Show("Please complete the enrty first!")
        Else
            Try
                Dim a, b As Integer
                a = txtFirstNum.Text
                b = txtSecondNum.Text
                lblResult.Text = a / b
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
End Class
