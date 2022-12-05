Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txt1.Text = "1" Then
            lbl1.Text = "Thankyou for buying coke"
        End If
        If txt1.Text = "2" Then
            lbl1.Text = "Thankyou for buying Burger"
        End If
        If txt1.Text = "3" Then
            lbl1.Text = "Thankyou for buying fried"
        End If
        If txt1.Text = "4" Then
            lbl1.Text = "Come again"
        End If

    End Sub
End Class
