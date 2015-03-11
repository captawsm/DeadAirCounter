Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Text = 10 Then
            Label1.Text = 1
        Else
            Label1.Text = Label1.Text + 1
        End If
    End Sub
End Class
