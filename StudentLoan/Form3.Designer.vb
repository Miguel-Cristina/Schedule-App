<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.nowLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.subjectL = New System.Windows.Forms.Label()
        Me.detailsL1 = New System.Windows.Forms.Label()
        Me.detailsL = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.colorbox = New System.Windows.Forms.ComboBox()
        Me.imagebox = New System.Windows.Forms.ComboBox()
        Me.exibox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.closeB = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.closeB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Congrats!! You just discovered a great way to costumize Schedule"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(363, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "I'll give you the chance to change whatever you want!"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(519, 46)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(106, 17)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Tag = ""
        Me.LinkLabel1.Text = "-Miguel Cristina"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.exibox)
        Me.Panel1.Controls.Add(Me.imagebox)
        Me.Panel1.Controls.Add(Me.colorbox)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Controls.Add(Me.closeB)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.datePicker)
        Me.Panel1.Controls.Add(Me.nowLabel)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(654, 349)
        Me.Panel1.TabIndex = 3
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(14, 0)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(362, 228)
        Me.ListView1.TabIndex = 14
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(397, 103)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(394, 276)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "New task:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(394, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Choose date:"
        '
        'datePicker
        '
        Me.datePicker.Location = New System.Drawing.Point(397, 303)
        Me.datePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(202, 23)
        Me.datePicker.TabIndex = 17
        '
        'nowLabel
        '
        Me.nowLabel.AutoSize = True
        Me.nowLabel.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nowLabel.Location = New System.Drawing.Point(393, 32)
        Me.nowLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nowLabel.Name = "nowLabel"
        Me.nowLabel.Size = New System.Drawing.Size(92, 22)
        Me.nowLabel.TabIndex = 16
        Me.nowLabel.Text = "hh:mm:ss"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(129, 122)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(156, 5)
        Me.DataGridView1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.subjectL)
        Me.Panel2.Controls.Add(Me.detailsL1)
        Me.Panel2.Controls.Add(Me.detailsL)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(14, 234)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 114)
        Me.Panel2.TabIndex = 21
        '
        'subjectL
        '
        Me.subjectL.AutoEllipsis = True
        Me.subjectL.AutoSize = True
        Me.subjectL.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectL.Location = New System.Drawing.Point(10, 90)
        Me.subjectL.MaximumSize = New System.Drawing.Size(300, 15)
        Me.subjectL.Name = "subjectL"
        Me.subjectL.Size = New System.Drawing.Size(0, 15)
        Me.subjectL.TabIndex = 3
        '
        'detailsL1
        '
        Me.detailsL1.AutoEllipsis = True
        Me.detailsL1.AutoSize = True
        Me.detailsL1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsL1.Location = New System.Drawing.Point(10, 41)
        Me.detailsL1.MaximumSize = New System.Drawing.Size(300, 70)
        Me.detailsL1.Name = "detailsL1"
        Me.detailsL1.Size = New System.Drawing.Size(0, 16)
        Me.detailsL1.TabIndex = 2
        '
        'detailsL
        '
        Me.detailsL.AutoEllipsis = True
        Me.detailsL.AutoSize = True
        Me.detailsL.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detailsL.Location = New System.Drawing.Point(10, 16)
        Me.detailsL.MaximumSize = New System.Drawing.Size(300, 15)
        Me.detailsL.Name = "detailsL"
        Me.detailsL.Size = New System.Drawing.Size(0, 15)
        Me.detailsL.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Details:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(40, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Color"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(40, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Images"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(40, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Exibition"
        '
        'colorbox
        '
        Me.colorbox.FormattingEnabled = True
        Me.colorbox.Items.AddRange(New Object() {"Black", "White", "Green", "Red", "Yellow", "Cyan", "AliceBlue", "AntiqueWhite", "Aqua", "DeepSkyBlue", "GhostWhite", "SeaShell", "Pink", "PowderBlue", "WhiteSmoke", "Teal", "SteelBlue"})
        Me.colorbox.Location = New System.Drawing.Point(107, 24)
        Me.colorbox.Name = "colorbox"
        Me.colorbox.Size = New System.Drawing.Size(121, 25)
        Me.colorbox.TabIndex = 27
        '
        'imagebox
        '
        Me.imagebox.FormattingEnabled = True
        Me.imagebox.Items.AddRange(New Object() {"Task", "Dinosaur", "Car", "Girl", "Trump"})
        Me.imagebox.Location = New System.Drawing.Point(107, 57)
        Me.imagebox.Name = "imagebox"
        Me.imagebox.Size = New System.Drawing.Size(121, 25)
        Me.imagebox.TabIndex = 28
        '
        'exibox
        '
        Me.exibox.FormattingEnabled = True
        Me.exibox.Items.AddRange(New Object() {"LargeIcon", "Details", "Tile", "SmallIcon", "List"})
        Me.exibox.Location = New System.Drawing.Point(107, 92)
        Me.exibox.Name = "exibox"
        Me.exibox.Size = New System.Drawing.Size(121, 25)
        Me.exibox.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(234, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(234, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Go"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(234, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Go"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'closeB
        '
        Me.closeB.Image = Global.StudentLoan.My.Resources.Resources.closer_on
        Me.closeB.Location = New System.Drawing.Point(630, 4)
        Me.closeB.Name = "closeB"
        Me.closeB.Size = New System.Drawing.Size(10, 23)
        Me.closeB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeB.TabIndex = 23
        Me.closeB.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentLoan.My.Resources.Resources.add_leave
        Me.PictureBox1.Location = New System.Drawing.Point(604, 303)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 440)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form3"
        Me.Text = "Options"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.closeB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeB As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents nowLabel As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents subjectL As Label
    Friend WithEvents detailsL1 As Label
    Friend WithEvents detailsL As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents exibox As ComboBox
    Friend WithEvents imagebox As ComboBox
    Friend WithEvents colorbox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
