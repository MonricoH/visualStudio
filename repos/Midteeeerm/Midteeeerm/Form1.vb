Imports System.IO


Public Class Form1
    Dim prc, tpp, mdd As Double


    Private Sub cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb1.SelectedIndexChanged
        pb2.Image = Nothing
        pb1.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Brand\" & cb1.SelectedItem & ".png")
        If cb1.SelectedItem = "Toyota" Then
            cb2.Items.Clear()
            cb2.Text = ""
            cb2.Items.Add("RAV4")
            cb2.Items.Add("Camry")
            cb2.Items.Add("Fortuner")
            cb2.Items.Add("Hilux")
            ai.Text = 10
        ElseIf cb1.SelectedItem = "Honda" Then
            cb2.Items.Clear()
            cb2.Text = ""
            cb2.Items.Add("City")
            cb2.Items.Add("Jazz")
            cb2.Items.Add("CRV")
            cb2.Items.Add("Civic")
            ai.Text = 11
        ElseIf cb1.SelectedItem = "Kia" Then
            cb2.Items.Clear()
            cb2.Text = ""
            cb2.Items.Add("Stonic")
            cb2.Items.Add("Sportage")
            cb2.Items.Add("Selto")
            cb2.Items.Add("Forte")
            ai.Text = 8
        ElseIf cb1.SelectedItem = "Nissan" Then
            cb2.Items.Clear()
            cb2.Text = ""
            cb2.Items.Add("Terra")
            cb2.Items.Add("Sylphy")
            cb2.Items.Add("Almera")
            ai.Text = 9
        End If
    End Sub

    Private Sub cb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb2.SelectedIndexChanged
        pb2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\Cars\" & cb2.SelectedItem & ".png")
        If cb2.SelectedItem = "RAV4" Then
            prc = 1710000
        ElseIf cb2.SelectedItem = "Camry" Then
            prc = 2300000
        ElseIf cb2.SelectedItem = "Fortuner" Then
            prc = 1800000
        ElseIf cb2.SelectedItem = "Hilux" Then
            prc = 1980000
        ElseIf cb2.SelectedItem = "City" Then
            prc = 780000
        ElseIf cb2.SelectedItem = "Jazz" Then
            prc = 967000
        ElseIf cb2.SelectedItem = "CRV" Then
            prc = 2100000
        ElseIf cb2.SelectedItem = "Civic" Then
            prc = 1580000
        ElseIf cb2.SelectedItem = "Stonic" Then
            prc = 1940000
        ElseIf cb2.SelectedItem = "Sportage" Then
            prc = 1300000
        ElseIf cb2.SelectedItem = "Selto" Then
            prc = 1120000
        ElseIf cb2.SelectedItem = "Forte" Then
            prc = 1270000
        ElseIf cb2.SelectedItem = "Terra" Then
            prc = 1830000
        ElseIf cb2.SelectedItem = "Sylphy" Then
            prc = 670000
        ElseIf cb2.SelectedItem = "Almera" Then
            prc = 580000
        End If
        p.Text = prc
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tpp = (((Val(ai.Text) * 0.01) * prc) * Val(txtytp.Text)) + prc
        tp.Text = tpp
        mdd = tpp / (Val(txtytp.Text) * 12)
        md.Text = mdd
        MessageBox.Show("I hope you have been enjoying your " & cb2.SelectedItem)
    End Sub
End Class
