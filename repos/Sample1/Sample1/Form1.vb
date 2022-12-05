Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim op1 As Double
        Dim op2 As Double
        Dim result As Double

        op1 = Val(txt1.Text)
        op2 = Val(txt2.Text)
        result = op1 + op2


        lblanswer.Text = result





    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n1, n2 As Integer

        n1 = Val(txt1.Text)
        n2 = Val(txt2.Text)
        lblanswer.Text = n1 / n2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n1, n2 As Integer

        n1 = Val(txt1.Text)
        n2 = Val(txt2.Text)
        lblanswer.Text = n1 - n2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim n1, n2 As Integer

        n1 = Val(txt1.Text)
        n2 = Val(txt2.Text)
        lblanswer.Text = n1 * n2
    End Sub
End Class
