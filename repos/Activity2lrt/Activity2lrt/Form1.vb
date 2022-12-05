Public Class Form1
    Public a, b, c, d, g, f As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cbf.SelectedIndex = 0 Then
            a = 200
        ElseIf cbf.SelectedIndex = 1 Then
            a = 180
        ElseIf cbf.SelectedIndex = 2 Then
            a = 160
        ElseIf cbf.SelectedIndex = 3 Then
            a = 140
        ElseIf cbf.SelectedIndex = 4 Then
            a = 120
        ElseIf cbf.SelectedIndex = 5 Then
            a = 100
        ElseIf cbf.SelectedIndex = 6 Then
            a = 80
        ElseIf cbf.SelectedIndex = 7 Then
            a = 60
        ElseIf cbf.SelectedIndex = 8 Then
            a = 40
        ElseIf cbf.SelectedIndex = 9 Then
            a = 20
        ElseIf cbf.SelectedIndex = 10 Then
            a = 0
        End If


        If cbt.SelectedIndex = 0 Then
            b = 200
        ElseIf cbt.SelectedIndex = 1 Then
            b = 180
        ElseIf cbt.SelectedIndex = 2 Then
            b = 160
        ElseIf cbt.SelectedIndex = 3 Then
            b = 140
        ElseIf cbt.SelectedIndex = 4 Then
            b = 120
        ElseIf cbt.SelectedIndex = 5 Then
            b = 100
        ElseIf cbt.SelectedIndex = 6 Then
            b = 80
        ElseIf cbt.SelectedIndex = 7 Then
            b = 60
        ElseIf cbt.SelectedIndex = 8 Then
            b = 40
        ElseIf cbt.SelectedIndex = 9 Then
            b = 20
        ElseIf cbt.SelectedIndex = 10 Then
            b = 0
        End If


        If cbd.SelectedIndex = 0 Then
            d = 0
        ElseIf cbd.SelectedIndex = 1 Then
            d = 0.1
        ElseIf cbd.SelectedIndex = 2 Then
            d = 0.15
        ElseIf cbd.SelectedIndex = 3 Then
            d = 0.2
        ElseIf cbd.SelectedIndex = 4 Then
            d = 0.5
        End If

        If cbf.Text = cbt.Text And a = b Then
            MessageBox.Show("Invalid Input", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblo.Text = ""
            lbld.Text = ""
            lblg.Text = ""
            lbldis.Text = ""
            lbln.Text = ""
            cbd.Text = ""
            cbf.Text = ""
            cbt.Text = ""
        ElseIf a > b Then
            c = a - b
            f = c * d
            g = c - f
            lblo.Text = cbf.Text
            lbld.Text = cbt.Text
            lbldis.Text = f
            lbln.Text = g
            lblg.Text = c
        ElseIf b > a Then
            c = b - a
            f = c * d
            g = c - f
            lblo.Text = cbf.Text
            lbld.Text = cbt.Text
            lbldis.Text = f
            lbln.Text = g
            lblg.Text = c
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbf.Items.Add("Dagupan City")
        cbf.Items.Add("Urdaneta City")
        cbf.Items.Add("Rosales")
        cbf.Items.Add("Paniqui")
        cbf.Items.Add("Moncada")
        cbf.Items.Add("Tarlac City")
        cbf.Items.Add("Concepcion")
        cbf.Items.Add("Capas ")
        cbf.Items.Add("Bamban")
        cbf.Items.Add("Mabalacat City")
        cbf.Items.Add("Angeles City")

        cbt.Items.Add("Dagupan City")
        cbt.Items.Add("Urdaneta City")
        cbt.Items.Add("Rosales")
        cbt.Items.Add("Paniqui")
        cbt.Items.Add("Moncada")
        cbt.Items.Add("Tarlac City")
        cbt.Items.Add("Concepcion")
        cbt.Items.Add("Capas ")
        cbt.Items.Add("Bamban")
        cbt.Items.Add("Mabalacat City")
        cbt.Items.Add("Angeles City")

        cbd.Items.Add("No Discount")
        cbd.Items.Add("Goverment Employee(10%)")
        cbd.Items.Add("Student(15%)")
        cbd.Items.Add("Senior Citizen(20%)")
        cbd.Items.Add("Children(50%)")
    End Sub
End Class
