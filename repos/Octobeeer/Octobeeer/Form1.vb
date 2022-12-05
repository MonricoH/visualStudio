Public Class Form1



    Sub FindMax(ByVal Num1 As Integer, ByVal Num2 As Integer)
        Dim result As Integer
        If Num1 > Num2 Then
            result = Num1
        Else
            result = Num2
        End If
        Label1.Text = "The maxi:" & result.ToString


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        FindMax(Val(Num1.Text), Val(Num1.Text))

    End Sub
End Class
