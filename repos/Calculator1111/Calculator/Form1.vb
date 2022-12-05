Public Class Form1
    Public a As Integer
    Public b As Double

    Private Sub bnt1_Click(sender As Object, e As EventArgs) Handles bnt1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub bnt2_Click(sender As Object, e As EventArgs) Handles bnt2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub bnt3_Click(sender As Object, e As EventArgs) Handles bnt3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub bnt4_Click(sender As Object, e As EventArgs) Handles bnt4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub bnt5_Click(sender As Object, e As EventArgs) Handles bnt5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub bnt6_Click(sender As Object, e As EventArgs) Handles bnt6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub bnt7_Click(sender As Object, e As EventArgs) Handles bnt7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub bnt8_Click(sender As Object, e As EventArgs) Handles bnt8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub bnt9_Click(sender As Object, e As EventArgs) Handles bnt9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub bnt0_Click(sender As Object, e As EventArgs) Handles bnt0.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub bntp_Click(sender As Object, e As EventArgs) Handles bntp.Click
        a = 1
        Label2.Text = TextBox1.Text
        Label1.Text = "+"
        bnts.Enabled = False
        bntp.Enabled = False
        bntd.Enabled = False
        bntm.Enabled = False
        bntdot.Enabled = True
        bnte.Enabled = True
        bntexpo.Enabled = False
        bntmod.Enabled = False
        TextBox1.Text = ""
    End Sub

    Private Sub bnte_Click(sender As Object, e As EventArgs) Handles bnte.Click
        If a = 1 Then
            b = Val(TextBox1.Text) + Val(Label2.Text)
        ElseIf a = 2 Then
            b = Val(Label2.Text) - Val(TextBox1.Text)
        ElseIf a = 3 Then
            b = Val(Label2.Text) * Val(TextBox1.Text)
        ElseIf a = 4 Then
            b = Val(Label2.Text) / Val(TextBox1.Text)
        ElseIf a = 5 Then
            b = Val(Label2.Text) Mod Val(TextBox1.Text)
        ElseIf a = 6 Then
            b = Val(Label2.Text) ^ Val(TextBox1.Text)
        ElseIf a = 0 Then
            b = b
        End If
        a = 0
        Label2.Text = b
        bntp.Enabled = True
        bnts.Enabled = True
        bntd.Enabled = True
        bntm.Enabled = True
        bntdot.Enabled = True
        bntexpo.Enabled = True
        bntmod.Enabled = True
        TextBox1.Text = Val(Label2.Text)
        bnte.Enabled = False
    End Sub

    Private Sub bnts_Click(sender As Object, e As EventArgs) Handles bnts.Click
        a = 2
        Label2.Text = b
        Label1.Text = "-"
        Label2.Text = Val(TextBox1.Text)
        TextBox1.Text = ""
        bnts.Enabled = False
        bntp.Enabled = False
        bntd.Enabled = False
        bntm.Enabled = False
        bntdot.Enabled = True
        bntexpo.Enabled = False
        bntmod.Enabled = False
        bnte.Enabled = True
    End Sub

    Private Sub bntdot_Click(sender As Object, e As EventArgs) Handles bntdot.Click
        TextBox1.Text = TextBox1.Text + "."
        bntdot.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bnte.Enabled = False
    End Sub

    Private Sub bntm_Click(sender As Object, e As EventArgs) Handles bntm.Click
        a = 3
        Label2.Text = TextBox1.Text
        Label1.Text = "*"
        bnts.Enabled = False
        bntp.Enabled = False
        bntd.Enabled = False
        bntm.Enabled = False
        bntdot.Enabled = True
        bnte.Enabled = True
        bntexpo.Enabled = False
        bntmod.Enabled = False
        TextBox1.Text = ""
    End Sub

    Private Sub bntd_Click(sender As Object, e As EventArgs) Handles bntd.Click
        a = 4
        Label2.Text = TextBox1.Text
        Label1.Text = "/"
        bnts.Enabled = False
        bntp.Enabled = False
        bntd.Enabled = False
        bntm.Enabled = False
        bntdot.Enabled = True
        bnte.Enabled = True
        bntexpo.Enabled = False
        bntmod.Enabled = False
        TextBox1.Text = ""
    End Sub

    Private Sub bntcc_Click(sender As Object, e As EventArgs) Handles bntcc.Click
        TextBox1.Text = ""
        Label1.Text = ""
        Label2.Text = ""
        bnte.Enabled = False
        bntp.Enabled = True
        bnts.Enabled = True
        bntd.Enabled = True
        bntm.Enabled = True
        bntdot.Enabled = True
        bntexpo.Enabled = True
        bntmod.Enabled = True
    End Sub



    Private Sub bntc_Click(sender As Object, e As EventArgs) Handles bntc.Click
        TextBox1.Text = ""
        Label1.Text = ""
        Label2.Text = ""
        bnte.Enabled = False
        bntp.Enabled = True
        bnts.Enabled = True
        bntd.Enabled = True
        bntm.Enabled = True
        bntdot.Enabled = True
    End Sub

    Private Sub bntmod_Click(sender As Object, e As EventArgs) Handles bntmod.Click
        a = 5
        Label2.Text = TextBox1.Text
        Label1.Text = "%"
        bnts.Enabled = False
        bntp.Enabled = False
        bntd.Enabled = False
        bntm.Enabled = False
        bntdot.Enabled = True
        bnte.Enabled = True
        bntexpo.Enabled = False
        bntmod.Enabled = False
        TextBox1.Text = ""
    End Sub

    Private Sub bntexpo_Click(sender As Object, e As EventArgs) Handles bntexpo.Click
        a = 6
        Label2.Text = TextBox1.Text
        Label1.Text = "^"
        bnts.Enabled = False
        bntp.Enabled = False
        bntd.Enabled = False
        bntm.Enabled = False
        bntdot.Enabled = True
        bnte.Enabled = True
        bntexpo.Enabled = False
        bntmod.Enabled = False
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
