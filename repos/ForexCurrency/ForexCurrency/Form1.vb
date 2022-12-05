Imports System.IO

Public Class Form1
    Dim a, b, c, d As Double
    Dim j As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cb1.SelectedIndex = 0 Then
            a = 0.02065
        ElseIf cb1.SelectedIndex = 1 Then
            a = 0.160081
        ElseIf cb1.SelectedIndex = 2 Then
            a = 0.027571
        ElseIf cb1.SelectedIndex = 3 Then
            a = 1.537119
        ElseIf cb1.SelectedIndex = 4 Then
            a = 3.805697
        ElseIf cb1.SelectedIndex = 5 Then
            a = 0.075831
        ElseIf cb1.SelectedIndex = 6 Then
            a = 1.0
        ElseIf cb1.SelectedIndex = 7 Then
            a = 0.015963
        ElseIf cb1.SelectedIndex = 8 Then
            a = 2.154607
        ElseIf cb1.SelectedIndex = 8 Then
            a = 0.017654


        End If




        If cb2.SelectedIndex = 0 Then
            b = 0.02065
            j = "USD"
        ElseIf cb2.SelectedIndex = 1 Then
            b = 0.160081
            j = "HKD"
        ElseIf cb2.SelectedIndex = 2 Then
            b = 0.027571
            j = "CAD"
        ElseIf cb2.SelectedIndex = 3 Then
            b = 1.537119
            j = "INR"
        ElseIf cb2.SelectedIndex = 4 Then
            b = 3.805697
            j = "LKR"
        ElseIf cb2.SelectedIndex = 5 Then
            b = 0.075831
            j = "AED"
        ElseIf cb2.SelectedIndex = 6 Then
            b = 1.0
            j = "PHP"
        ElseIf cb2.SelectedIndex = 7 Then
            b = 0.015963
            j = "GBP"
        ElseIf cb2.SelectedIndex = 8 Then
            b = 2.154607
            j = "JPY"
        ElseIf cb2.SelectedIndex = 8 Then
            b = 0.017654
            j = "EUR"
        End If


        If tb1.Text = "" Then
            MessageBox.Show("Please Input Amount")
            Application.Restart()
        End If





        Button2.Enabled = True
        c = tb1.Text
        d = c / a
        Label2.Text = d * b

        Label3.Text = j






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Restart()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb1.Items.Add("US DOLLAR")
        cb1.Items.Add("HKG DOLLAR")
        cb1.Items.Add("CND DOLLAR")
        cb1.Items.Add("IND RUPEE")
        cb1.Items.Add("SRL RUPEE")
        cb1.Items.Add("UAE DINAR")
        cb1.Items.Add("PHP PESO")
        cb1.Items.Add("UK POUND")
        cb1.Items.Add("JPN YEN")
        cb1.Items.Add("EURO")

        cb2.Items.Add("US DOLLAR")
        cb2.Items.Add("HKG DOLLAR")
        cb2.Items.Add("CND DOLLAR")
        cb2.Items.Add("IND RUPEE")
        cb2.Items.Add("SRL RUPEE")
        cb2.Items.Add("UAE DINAR")
        cb2.Items.Add("PHP PESO")
        cb2.Items.Add("UK POUND")
        cb2.Items.Add("JPN YEN")
        cb2.Items.Add("EURO")

        Button2.Enabled = False

    End Sub

    Private Sub cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb1.SelectedIndexChanged

        PictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory & "\flags\flag" & cb1.SelectedIndex & ".gif")


    End Sub

    Private Sub cb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb2.SelectedIndexChanged

        PictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory & "\flags\flag" & cb2.SelectedIndex & ".gif")
    End Sub
End Class
