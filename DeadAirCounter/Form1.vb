Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Text = 10 Then
            FlashIcon(Me.Handle, FLASHW_STOP)
            Me.BackColor = SystemColors.Control
            Label1.Text = 1
        Else
            Label1.Text = Label1.Text + 1
            If Label1.Text = 10 Then
                FlashIcon(Me.Handle, FLASHW_ALL + FLASHW_TIMER)
                Me.BackColor = Color.Yellow
            End If
        End If
    End Sub
End Class
