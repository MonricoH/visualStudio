Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim op1 As Double
        Dim op2 As Double
        Dim result As Double

        op1 = Val(txtbox1.Text)
        op2 = Val(txtbox2.Text)



        txtbox3.Text = "+"
        btnequal.Text = result











    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim op1 As Double
        Dim op2 As Double
        Dim result As Double

        op1 = Val(txtbox1.Text)
        op2 = Val(txtbox2.Text)
        result = op1 - op2

        txtbox3.Text = "-"
        txtboxanswer.Text = result

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim op1 As Double
        Dim op2 As Double
        Dim result As Double

        op1 = Val(txtbox1.Text)
        op2 = Val(txtbox2.Text)
        result = op1 * op2

        txtbox3.Text = "*"
        txtboxanswer.Text = result
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim op1 As Double
        Dim op2 As Double
        Dim result As Double

        op1 = Val(txtbox1.Text)
        op2 = Val(txtbox2.Text)
        result = op1 / op2

        txtbox3.Text = "/"
        txtboxanswer.Text = result
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim op1 As Double
        Dim op2 As Double
        Dim result As Double

        op1 = Val(txtbox1.Text)
        op2 = Val(txtbox2.Text)
        result = op1 ^ op2

        txtbox3.Text = "^"
        txtboxanswer.Text = result
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim op1 As Double
        Dim op2 As Double
        Dim result As Double

        op1 = Val(txtbox1.Text)
        op2 = Val(txtbox2.Text)
        result = op1 Mod op2

        txtbox3.Text = "MOD"
        txtboxanswer.Text = result
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtbox1.Clear()
        txtbox2.Clear()
        txtbox3.Clear()
       
     




    End Sub

    Private Sub txtboxanswer_TextChanged(sender As Object, e As EventArgs) Handles txtboxanswer.TextChanged

    End Sub
End Class
