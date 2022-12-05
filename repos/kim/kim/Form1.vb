Imports System.IO

Public Class Form1
    Dim prccc, tppppp, mdd As Double

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        PictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Cars\" & ComboBox2.SelectedItem & ".png")
        If ComboBox2.SelectedItem = "RAV4" Then
            prccc = 1710000
        ElseIf ComboBox2.SelectedItem = "Camry" Then
            prccc = 2300000
        ElseIf ComboBox2.SelectedItem = "Fortuner" Then
            prccc = 1800000
        ElseIf ComboBox2.SelectedItem = "Hilux" Then
            prccc = 1980000
        ElseIf ComboBox2.SelectedItem = "City" Then
            prccc = 780000
        ElseIf ComboBox2.SelectedItem = "Jazz" Then
            prccc = 967000
        ElseIf ComboBox2.SelectedItem = "CRV" Then
            prccc = 2100000
        ElseIf ComboBox2.SelectedItem = "Civic" Then
            prccc = 1580000
        ElseIf ComboBox2.SelectedItem = "Stonic" Then
            prccc = 1940000
        ElseIf ComboBox2.SelectedItem = "Sportage" Then
            prccc = 1300000
        ElseIf ComboBox2.SelectedItem = "Selto" Then
            prccc = 1120000
        ElseIf ComboBox2.SelectedItem = "Forte" Then
            prccc = 1270000
        ElseIf ComboBox2.SelectedItem = "Terra" Then
            prccc = 1830000
        ElseIf ComboBox2.SelectedItem = "Sylphy" Then
            prccc = 670000
        ElseIf ComboBox2.SelectedItem = "Almera" Then
            prccc = 580000
        End If
        p.Text = prccc
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        PictureBox2.Image = Nothing
        PictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Brand\" & ComboBox1.SelectedItem & ".png")
        If ComboBox1.SelectedItem = "Toyota" Then
            ComboBox2.Items.Clear()
            ComboBox2.Text = ""
            ComboBox2.Items.Add("RAV4")
            ComboBox2.Items.Add("Camry")
            ComboBox2.Items.Add("Fortuner")
            ComboBox2.Items.Add("Hilux")
            Label3.Text = 10
        ElseIf ComboBox1.SelectedItem = "Honda" Then
            ComboBox2.Items.Clear()
            ComboBox2.Text = ""
            ComboBox2.Items.Add("City")
            ComboBox2.Items.Add("Jazz")
            ComboBox2.Items.Add("CRV")
            ComboBox2.Items.Add("Civic")
            Label3.Text = 11
        ElseIf ComboBox1.SelectedItem = "Kia" Then
            ComboBox2.Items.Clear()
            ComboBox2.Text = ""
            ComboBox2.Items.Add("Stonic")
            ComboBox2.Items.Add("Sportage")
            ComboBox2.Items.Add("Selto")
            ComboBox2.Items.Add("Forte")
            Label3.Text = 8
        ElseIf ComboBox1.SelectedItem = "Nissan" Then
            ComboBox2.Items.Clear()
            ComboBox2.Text = ""
            ComboBox2.Items.Add("Terra")
            ComboBox2.Items.Add("Sylphy")
            ComboBox2.Items.Add("Almera")
            Label3.Text = 9
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tppppp = (((Val(Label3.Text) * 0.01) * prccc) * Val(txtytp.Text)) + prccc
        tp.Text = tppppp
        mdd = prccc / (Val(txtytp.Text) * 12)
        md.Text = mdd
        MessageBox.Show("Thankyou Come Again Have fun with your: " & ComboBox2.SelectedItem)
    End Sub
End Class
