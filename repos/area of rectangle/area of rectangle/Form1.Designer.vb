<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reccctangggle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblheader = New System.Windows.Forms.Label()
        Me.lbllenght = New System.Windows.Forms.Label()
        Me.lblwidht = New System.Windows.Forms.Label()
        Me.lblarea = New System.Windows.Forms.Label()
        Me.txtlenght = New System.Windows.Forms.TextBox()
        Me.txtwidgt = New System.Windows.Forms.TextBox()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.lblanswer = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblleng2 = New System.Windows.Forms.Label()
        Me.lblwidth2 = New System.Windows.Forms.Label()
        Me.tlttool = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.Location = New System.Drawing.Point(275, 51)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(213, 25)
        Me.lblheader.TabIndex = 0
        Me.lblheader.Text = "Area of a rectangle"
        '
        'lbllenght
        '
        Me.lbllenght.AutoSize = True
        Me.lbllenght.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllenght.Location = New System.Drawing.Point(78, 154)
        Me.lbllenght.Name = "lbllenght"
        Me.lbllenght.Size = New System.Drawing.Size(48, 16)
        Me.lbllenght.TabIndex = 1
        Me.lbllenght.Text = "Length"
        '
        'lblwidht
        '
        Me.lblwidht.AutoSize = True
        Me.lblwidht.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwidht.Location = New System.Drawing.Point(78, 232)
        Me.lblwidht.Name = "lblwidht"
        Me.lblwidht.Size = New System.Drawing.Size(42, 16)
        Me.lblwidht.TabIndex = 2
        Me.lblwidht.Text = "Width"
        '
        'lblarea
        '
        Me.lblarea.AutoSize = True
        Me.lblarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblarea.Location = New System.Drawing.Point(78, 393)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(41, 16)
        Me.lblarea.TabIndex = 3
        Me.lblarea.Text = "Area"
        '
        'txtlenght
        '
        Me.txtlenght.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlenght.Location = New System.Drawing.Point(167, 148)
        Me.txtlenght.Name = "txtlenght"
        Me.txtlenght.Size = New System.Drawing.Size(100, 22)
        Me.txtlenght.TabIndex = 4
        Me.tlttool.SetToolTip(Me.txtlenght, "Enter Value")
        '
        'txtwidgt
        '
        Me.txtwidgt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwidgt.Location = New System.Drawing.Point(167, 226)
        Me.txtwidgt.Name = "txtwidgt"
        Me.txtwidgt.Size = New System.Drawing.Size(100, 22)
        Me.txtwidgt.TabIndex = 5
        Me.tlttool.SetToolTip(Me.txtwidgt, "Enter Value")
        '
        'btncalculate
        '
        Me.btncalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculate.Location = New System.Drawing.Point(167, 274)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(100, 47)
        Me.btncalculate.TabIndex = 6
        Me.btncalculate.Text = "Calculate"
        Me.tlttool.SetToolTip(Me.btncalculate, "press to calculate of the rectangle")
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'lblanswer
        '
        Me.lblanswer.AutoSize = True
        Me.lblanswer.Location = New System.Drawing.Point(167, 393)
        Me.lblanswer.Name = "lblanswer"
        Me.lblanswer.Size = New System.Drawing.Size(0, 13)
        Me.lblanswer.TabIndex = 7
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 450)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.FillColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(382, 139)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(350, 199)
        '
        'lblleng2
        '
        Me.lblleng2.AutoSize = True
        Me.lblleng2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblleng2.Location = New System.Drawing.Point(522, 335)
        Me.lblleng2.Name = "lblleng2"
        Me.lblleng2.Size = New System.Drawing.Size(36, 13)
        Me.lblleng2.TabIndex = 9
        Me.lblleng2.Text = "lenght"
        '
        'lblwidth2
        '
        Me.lblwidth2.AutoSize = True
        Me.lblwidth2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwidth2.Location = New System.Drawing.Point(716, 226)
        Me.lblwidth2.Name = "lblwidth2"
        Me.lblwidth2.Size = New System.Drawing.Size(32, 13)
        Me.lblwidth2.TabIndex = 10
        Me.lblwidth2.Text = "width"
        '
        'tlttool
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 42)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "L"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 42)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "W"
        '
        'reccctangggle
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblwidth2)
        Me.Controls.Add(Me.lblleng2)
        Me.Controls.Add(Me.lblanswer)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.txtwidgt)
        Me.Controls.Add(Me.txtlenght)
        Me.Controls.Add(Me.lblarea)
        Me.Controls.Add(Me.lblwidht)
        Me.Controls.Add(Me.lbllenght)
        Me.Controls.Add(Me.lblheader)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "reccctangggle"
        Me.Text = "Area of a rectangle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblheader As Label
    Friend WithEvents lbllenght As Label
    Friend WithEvents lblwidht As Label
    Friend WithEvents lblarea As Label
    Friend WithEvents txtlenght As TextBox
    Friend WithEvents txtwidgt As TextBox
    Friend WithEvents btncalculate As Button
    Friend WithEvents lblanswer As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents lblleng2 As Label
    Friend WithEvents lblwidth2 As Label
    Friend WithEvents tlttool As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
