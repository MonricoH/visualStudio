Public Class reccctangggle
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblwidht.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblheader.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblarea.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtlenght.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtwidgt.TextChanged

    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        Dim lenght As Single
        Dim widht As Single
        Dim area As Double

        lenght = Val(txtlenght.Text)
        widht = Val(txtwidgt.Text)

        area = lenght * widht
        lblanswer.Text = area & " m²"





    End Sub

    Private Sub lbllenght_Click(sender As Object, e As EventArgs) Handles lbllenght.Click

    End Sub

    Private Sub reccctangggle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles tlttool.Popup

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
