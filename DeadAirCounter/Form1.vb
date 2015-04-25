Public Class Form1
    Dim countdown As Integer
    Dim pretty As String
    Dim mode As String = "dead air"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If mode = "timer" Then
            If countdown > 0 Then
                countdown = countdown - 1
                pretty = countdown Mod 60
                If pretty.Length < 2 Then
                    pretty = countdown \ 60 & ":0" & pretty
                Else
                    pretty = countdown \ 60 & ":" & pretty
                End If
                If countdown = 10 Then
                    Me.BackColor = Color.Yellow
                ElseIf countdown = 0 Then
                    Me.BackColor = Color.Red
                    FlashIcon(Me.Handle, FLASHW_ALL + FLASHW_TIMER)
                End If
                Label1.Text = pretty
            End If
        ElseIf mode = "dead air" Then
            If countdown = 10 Then
                FlashIcon(Me.Handle, FLASHW_STOP)
                Me.BackColor = SystemColors.Control
                countdown = 1
            Else
                countdown = countdown + 1
                If countdown = 10 Then
                    FlashIcon(Me.Handle, FLASHW_ALL + FLASHW_TIMER)
                    Me.BackColor = Color.Yellow
                End If
            End If
            Label1.Text = countdown
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If mode = "dead air" Then
            mode = "timer"
            Me.Text = "HOLD THE LINE!"
            countdown = 120
            Label1.Text = "2:00"
            Button1.Text = "Dead Air"
            FlashIcon(Me.Handle, FLASHW_STOP)
            Me.BackColor = SystemColors.Control
        ElseIf mode = "timer" Then
            mode = "dead air"
            Me.Text = "DeadAirCounter"
            countdown = 0
            Label1.Text = 0
            Button1.Text = "On Hold"
            FlashIcon(Me.Handle, FLASHW_STOP)
            Me.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If mode = "timer" Then
            Label1.Text = "2:00"
            countdown = 120
            FlashIcon(Me.Handle, FLASHW_STOP)
            Me.BackColor = SystemColors.Control
        ElseIf mode = "dead air" Then
            Label1.Text = 0
            countdown = 0
            FlashIcon(Me.Handle, FLASHW_STOP)
            Me.BackColor = SystemColors.Control
        End If
    End Sub
End Class
