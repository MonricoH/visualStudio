Public Class Calcu

    Public a As Integer
    Public b As Double
    Dim resultt As Double



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt1.Text = txt1.Text + "1"



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt1.Text = txt1.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt1.Text = txt1.Text + "3"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txt1.Text = txt1.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt1.Text = txt1.Text + "5"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txt1.Text = txt1.Text + "6"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txt1.Text = txt1.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txt1.Text = txt1.Text + "8"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txt1.Text = txt1.Text + "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        txt1.Text = txt1.Text + "0"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        a = 1
        txt2.Text = txt1.Text
        txt3.Text = "+"
        btnplus.Enabled = False
        btnminus.Enabled = False
        btndevide.Enabled = False
        btntimes.Enabled = False
        btndot.Enabled = True
        btnequal.Enabled = True
        txt1.Text = ""
    End Sub

    Private Sub btnequal_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        If a = 1 Then
            b = Val(txt1.Text) + Val(txt2.Text)
        ElseIf a = 2 Then
            b = Val(txt2.Text) - Val(txt1.Text)
        ElseIf a = 3 Then
            b = Val(txt2.Text) * Val(txt1.Text)
        ElseIf a = 4 Then
            b = Val(txt2.Text) / Val(txt1.Text)
        ElseIf a = 0 Then
            b = b

        End If
        a = 0
        txt2.Text = b
        btnplus.Enabled = true
        btnminus.Enabled = True
        btndevide.Enabled = True
        btntimes.Enabled = True
        btndot.Enabled = True
        txt1.Text = Val(txt2.Text)
        btnequal.Enabled = False

    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        a = 2
        txt2.Text = b
        txt3.Text = "-"
        txt2.Text = Val(txt1.Text)
        txt1.Text = ""
        btnminus.Enabled = False
        btnplus.Enabled = False
        btndevide.Enabled = False
        btntimes.Enabled = False
        btndot.Enabled = True
        btnequal.Enabled = True
    End Sub

    Private Sub btndot_Click(sender As Object, e As EventArgs) Handles btndot.Click
        txt1.Text = txt1.Text + "."
        btndot.Enabled = False
    End Sub

    Private Sub Calcu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnequal.Enabled = False
    End Sub

    Private Sub btndevide_Click(sender As Object, e As EventArgs) Handles btndevide.Click

        a = 4
        txt2.Text = txt1.Text
        txt3.Text = "/"
        btnminus.Enabled = False
        btnplus.Enabled = False
        btndevide.Enabled = False
        btntimes.Enabled = False
        btndot.Enabled = True
        btnequal.Enabled = True
        txt1.Text = ""


    End Sub

    Private Sub btntimes_Click(sender As Object, e As EventArgs) Handles btntimes.Click

        a = 3
        txt2.Text = txt1.Text
        txt3.Text = "*"
        btnminus.Enabled = False
        btnplus.Enabled = False
        btndevide.Enabled = False
        btntimes.Enabled = False
        btndot.Enabled = True
        btnequal.Enabled = True
        txt1.Text = ""

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txt3.Clear()
        txt2.Clear()
        txt1.Clear()
    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub
End Class
