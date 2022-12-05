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
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.cb2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ai = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.p = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtytp = New System.Windows.Forms.TextBox()
        Me.tp = New System.Windows.Forms.Label()
        Me.md = New System.Windows.Forms.Label()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb1
        '
        Me.cb1.BackColor = System.Drawing.SystemColors.GrayText
        Me.cb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb1.FormattingEnabled = True
        Me.cb1.Items.AddRange(New Object() {"Toyota", "Honda", "Kia", "Nissan"})
        Me.cb1.Location = New System.Drawing.Point(102, 78)
        Me.cb1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(160, 28)
        Me.cb1.TabIndex = 0
        '
        'cb2
        '
        Me.cb2.BackColor = System.Drawing.SystemColors.GrayText
        Me.cb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb2.FormattingEnabled = True
        Me.cb2.Location = New System.Drawing.Point(392, 78)
        Me.cb2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(160, 28)
        Me.cb2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label1.Location = New System.Drawing.Point(96, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Car Brand"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label2.Location = New System.Drawing.Point(386, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 34)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Car Model"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label3.Location = New System.Drawing.Point(54, 287)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Annual Interest :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label4.Location = New System.Drawing.Point(134, 310)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Price:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label5.Location = New System.Drawing.Point(65, 335)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Year(s) to Pay :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Aquamarine
        Me.Button1.Location = New System.Drawing.Point(392, 316)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 42)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Compute"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ai
        '
        Me.ai.BackColor = System.Drawing.Color.Aquamarine
        Me.ai.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ai.Location = New System.Drawing.Point(194, 292)
        Me.ai.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ai.Name = "ai"
        Me.ai.Size = New System.Drawing.Size(61, 17)
        Me.ai.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(260, 288)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 22)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "%"
        '
        'p
        '
        Me.p.BackColor = System.Drawing.Color.Aquamarine
        Me.p.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p.Location = New System.Drawing.Point(194, 316)
        Me.p.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(113, 17)
        Me.p.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label6.Location = New System.Drawing.Point(89, 358)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Total Price :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label7.Location = New System.Drawing.Point(68, 381)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 23)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Monthly Dues:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtytp
        '
        Me.txtytp.BackColor = System.Drawing.SystemColors.GrayText
        Me.txtytp.Location = New System.Drawing.Point(194, 341)
        Me.txtytp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtytp.Name = "txtytp"
        Me.txtytp.Size = New System.Drawing.Size(113, 20)
        Me.txtytp.TabIndex = 18
        '
        'tp
        '
        Me.tp.BackColor = System.Drawing.Color.Aquamarine
        Me.tp.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp.Location = New System.Drawing.Point(194, 365)
        Me.tp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.tp.Name = "tp"
        Me.tp.Size = New System.Drawing.Size(113, 17)
        Me.tp.TabIndex = 19
        '
        'md
        '
        Me.md.BackColor = System.Drawing.Color.Aquamarine
        Me.md.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.md.Location = New System.Drawing.Point(194, 388)
        Me.md.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.md.Name = "md"
        Me.md.Size = New System.Drawing.Size(113, 17)
        Me.md.TabIndex = 20
        '
        'pb2
        '
        Me.pb2.Location = New System.Drawing.Point(392, 112)
        Me.pb2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(160, 140)
        Me.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb2.TabIndex = 5
        Me.pb2.TabStop = False
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(102, 112)
        Me.pb1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(160, 140)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 4
        Me.pb1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(653, 436)
        Me.Controls.Add(Me.md)
        Me.Controls.Add(Me.tp)
        Me.Controls.Add(Me.txtytp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.p)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ai)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pb2)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.cb1)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb1 As ComboBox
    Friend WithEvents cb2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents pb2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ai As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents p As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtytp As TextBox
    Friend WithEvents tp As Label
    Friend WithEvents md As Label
End Class
