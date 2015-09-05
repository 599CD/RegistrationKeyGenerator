Public Class Registration

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        If Len(txtKey1.Text) = 0 Then
            lbltssMainStatus.Text = "Please fill in 'Key1'"
        Else
            'txtKey2.Text = Int(txtKey1.Text * 3 / 2) + 1701
            txtKey2.Text = Calculate(Int(txtKey1.Text))
            lbltssMainStatus.Text = "The Key has calculated"
        End If

    End Sub

    Private Sub cmdCopy_Click(sender As Object, e As EventArgs) Handles cmdCopy.Click
        If Len(txtKey2.Text) = 0 Then
            lbltssMainStatus.Text = "There is nothing to copy"
        Else
            My.Computer.Clipboard.SetText(txtKey2.Text)
            lbltssMainStatus.Text = "The Key has been copied to the clipboard"
        End If
    End Sub

    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        txtKey1.Text = Int(Rnd() * 100000) + 100000
        txtKey2.Text = ""
    End Sub

    Private Function Calculate(Key1 As Integer) As Integer
        Calculate = Int(Key1 * 3 / 2) + 1701
    End Function
End Class
