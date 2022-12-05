<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calcu
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
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.btndot = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btnequal = New System.Windows.Forms.Button()
        Me.btnplus = New System.Windows.Forms.Button()
        Me.btnminus = New System.Windows.Forms.Button()
        Me.btntimes = New System.Windows.Forms.Button()
        Me.btndevide = New System.Windows.Forms.Button()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt2
        '
        Me.txt2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.ForeColor = System.Drawing.Color.Black
        Me.txt2.Location = New System.Drawing.Point(34, 23)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(344, 55)
        Me.txt2.TabIndex = 18
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.ForeColor = System.Drawing.Color.Black
        Me.txt1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt1.Location = New System.Drawing.Point(34, 23)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(344, 55)
        Me.txt1.TabIndex = 19
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(22, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 51)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(94, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 51)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(166, 274)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 51)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(22, 217)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(66, 51)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "6"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(94, 217)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(66, 51)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(166, 217)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(66, 51)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "4"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(22, 160)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(66, 51)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "9"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(94, 160)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(66, 51)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(166, 160)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(66, 51)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "7"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(22, 331)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(66, 51)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "0"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'btndot
        '
        Me.btndot.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndot.Location = New System.Drawing.Point(94, 331)
        Me.btndot.Name = "btndot"
        Me.btndot.Size = New System.Drawing.Size(66, 51)
        Me.btndot.TabIndex = 10
        Me.btndot.Text = "."
        Me.btndot.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(166, 331)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(66, 51)
        Me.Button12.TabIndex = 11
        Me.Button12.Text = "C"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(403, 450)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(265, 194)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(128, 198)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(15, 148)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(228, 243)
        '
        'btnequal
        '
        Me.btnequal.BackColor = System.Drawing.Color.Red
        Me.btnequal.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnequal.Location = New System.Drawing.Point(270, 331)
        Me.btnequal.Name = "btnequal"
        Me.btnequal.Size = New System.Drawing.Size(120, 51)
        Me.btnequal.TabIndex = 13
        Me.btnequal.Text = "="
        Me.btnequal.UseVisualStyleBackColor = False
        '
        'btnplus
        '
        Me.btnplus.BackColor = System.Drawing.Color.Red
        Me.btnplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnplus.Location = New System.Drawing.Point(270, 260)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.Size = New System.Drawing.Size(57, 51)
        Me.btnplus.TabIndex = 14
        Me.btnplus.Text = "+"
        Me.btnplus.UseVisualStyleBackColor = False
        '
        'btnminus
        '
        Me.btnminus.BackColor = System.Drawing.Color.Red
        Me.btnminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminus.Location = New System.Drawing.Point(333, 260)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(57, 51)
        Me.btnminus.TabIndex = 15
        Me.btnminus.Text = "-"
        Me.btnminus.UseVisualStyleBackColor = False
        '
        'btntimes
        '
        Me.btntimes.BackColor = System.Drawing.Color.Red
        Me.btntimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntimes.Location = New System.Drawing.Point(270, 203)
        Me.btntimes.Name = "btntimes"
        Me.btntimes.Size = New System.Drawing.Size(57, 51)
        Me.btntimes.TabIndex = 16
        Me.btntimes.Text = "*"
        Me.btntimes.UseVisualStyleBackColor = False
        '
        'btndevide
        '
        Me.btndevide.BackColor = System.Drawing.Color.Red
        Me.btndevide.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndevide.Location = New System.Drawing.Point(333, 203)
        Me.btndevide.Name = "btndevide"
        Me.btndevide.Size = New System.Drawing.Size(57, 51)
        Me.btndevide.TabIndex = 17
        Me.btndevide.Text = "/"
        Me.btndevide.UseVisualStyleBackColor = False
        '
        'txt3
        '
        Me.txt3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.ForeColor = System.Drawing.Color.Black
        Me.txt3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt3.Location = New System.Drawing.Point(15, 23)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(23, 55)
        Me.txt3.TabIndex = 20
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Calcu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(403, 450)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.btndevide)
        Me.Controls.Add(Me.btntimes)
        Me.Controls.Add(Me.btnminus)
        Me.Controls.Add(Me.btnplus)
        Me.Controls.Add(Me.btnequal)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.btndot)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Calcu"
        Me.Text = "Calculator"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents btndot As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents btnequal As Button
    Friend WithEvents btnplus As Button
    Friend WithEvents btnminus As Button
    Friend WithEvents btntimes As Button
    Friend WithEvents btndevide As Button
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt3 As TextBox
End Class
