Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        'TextBox1.Text = TextBox1.Text + 15'

        If CheckBox1.Checked = True Then

            TextBox1.Text = Val(TextBox1.Text) + 15
        Else
            TextBox1.Text = Val(TextBox1.Text) - 15
        End If




    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then

            TextBox1.Text = Val(TextBox1.Text) + 20
        Else
            TextBox1.Text = Val(TextBox1.Text) - 20
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then

            TextBox1.Text = Val(TextBox1.Text) + 150
        Else
            TextBox1.Text = Val(TextBox1.Text) - 150
        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then

            TextBox1.Text = Val(TextBox1.Text) + 25
        Else
            TextBox1.Text = Val(TextBox1.Text) - 25
        End If

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then

            TextBox1.Text = Val(TextBox1.Text) + 10
        Else
            TextBox1.Text = Val(TextBox1.Text) - 10
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
            Me.BackColor = Color.Red
        ElseIf RadioButton2.Checked = True Then
            Me.BackColor = Color.Blue
        ElseIf RadioButton3.Checked = True Then
            Me.BackColor = Color.Green

        Else
            Me.BackColor = Color.Yellow



        End If





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RadioButton1.Checked = False
        Me.BackColor = Color.White


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Sorted = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("APPLE")
        ComboBox1.Items.Add("banana")
        ComboBox1.Items.Add("mango")
        ComboBox1.Items.Add("grapes")
        ComboBox1.Items.Add("orange")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'TextBox2.Text = ComboBox1.Text

        TextBox2.Text = ComboBox1.SelectedIndex

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
