<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rs2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rs1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbox1 = New System.Windows.Forms.TextBox()
        Me.txtbox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtboxanswer = New System.Windows.Forms.TextBox()
        Me.txtbox3 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnequal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 38)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 141)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 38)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "*"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(116, 141)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 38)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "/"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 199)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 38)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "\"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(116, 199)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(91, 38)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "^"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 253)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(195, 23)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Mod"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(12, 50)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(53, 13)
        Me.lbl1.TabIndex = 8
        Me.lbl1.Text = "Operators"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rs2, Me.rs1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(460, 436)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'rs2
        '
        Me.rs2.FillGradientColor = System.Drawing.Color.Transparent
        Me.rs2.Location = New System.Drawing.Point(230, 57)
        Me.rs2.Name = "rs2"
        Me.rs2.Size = New System.Drawing.Size(211, 221)
        '
        'rs1
        '
        Me.rs1.FillGradientColor = System.Drawing.Color.Transparent
        Me.rs1.Location = New System.Drawing.Point(5, 58)
        Me.rs1.Name = "rs1"
        Me.rs1.Size = New System.Drawing.Size(211, 221)
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(240, 50)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(53, 13)
        Me.lbl2.TabIndex = 10
        Me.lbl2.Text = "Operation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = " Operand 1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = " Operand 2:"
        '
        'txtbox1
        '
        Me.txtbox1.Location = New System.Drawing.Point(322, 88)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(100, 20)
        Me.txtbox1.TabIndex = 13
        Me.txtbox1.Text = "0"
        '
        'txtbox2
        '
        Me.txtbox2.Location = New System.Drawing.Point(322, 138)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(100, 20)
        Me.txtbox2.TabIndex = 14
        Me.txtbox2.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Result"
        '
        'txtboxanswer
        '
        Me.txtboxanswer.BackColor = System.Drawing.Color.LightGray
        Me.txtboxanswer.Location = New System.Drawing.Point(322, 224)
        Me.txtboxanswer.Name = "txtboxanswer"
        Me.txtboxanswer.Size = New System.Drawing.Size(100, 20)
        Me.txtboxanswer.TabIndex = 16
        '
        'txtbox3
        '
        Me.txtbox3.BackColor = System.Drawing.Color.LightGray
        Me.txtbox3.Location = New System.Drawing.Point(352, 112)
        Me.txtbox3.Name = "txtbox3"
        Me.txtbox3.Size = New System.Drawing.Size(33, 20)
        Me.txtbox3.TabIndex = 17
        Me.txtbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(230, 333)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "Clear"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(352, 333)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 19
        Me.Button9.Text = "Exit"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(116, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnequal
        '
        Me.btnequal.Location = New System.Drawing.Point(335, 180)
        Me.btnequal.Name = "btnequal"
        Me.btnequal.Size = New System.Drawing.Size(75, 23)
        Me.btnequal.TabIndex = 20
        Me.btnequal.Text = "="
        Me.btnequal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 436)
        Me.Controls.Add(Me.btnequal)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.txtbox3)
        Me.Controls.Add(Me.txtboxanswer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.txtbox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents rs1 As PowerPacks.RectangleShape
    Friend WithEvents rs2 As PowerPacks.RectangleShape
    Friend WithEvents lbl2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbox1 As TextBox
    Friend WithEvents txtbox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxanswer As TextBox
    Friend WithEvents txtbox3 As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnequal As Button
End Class
