<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.subject = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateP = New System.Windows.Forms.DateTimePicker()
        Me.task = New System.Windows.Forms.TextBox()
        Me.title = New System.Windows.Forms.TextBox()
        Me.submitB = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.subject)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dateP)
        Me.Panel1.Controls.Add(Me.task)
        Me.Panel1.Controls.Add(Me.title)
        Me.Panel1.Controls.Add(Me.submitB)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(178, 253)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentLoan.My.Resources.Resources.closer_on
        Me.PictureBox1.Location = New System.Drawing.Point(160, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(153, 241)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(63, 38)
        Me.Panel2.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(23, 10)
        Me.DataGridView1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Subject:"
        '
        'subject
        '
        Me.subject.Location = New System.Drawing.Point(3, 158)
        Me.subject.Name = "subject"
        Me.subject.Size = New System.Drawing.Size(170, 20)
        Me.subject.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Task:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Title:"
        '
        'dateP
        '
        Me.dateP.Location = New System.Drawing.Point(3, 198)
        Me.dateP.Name = "dateP"
        Me.dateP.Size = New System.Drawing.Size(170, 20)
        Me.dateP.TabIndex = 3
        '
        'task
        '
        Me.task.Location = New System.Drawing.Point(3, 71)
        Me.task.Multiline = True
        Me.task.Name = "task"
        Me.task.Size = New System.Drawing.Size(170, 65)
        Me.task.TabIndex = 2
        '
        'title
        '
        Me.title.Location = New System.Drawing.Point(3, 29)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(170, 20)
        Me.title.TabIndex = 1
        '
        'submitB
        '
        Me.submitB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.submitB.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitB.Location = New System.Drawing.Point(52, 224)
        Me.submitB.Name = "submitB"
        Me.submitB.Size = New System.Drawing.Size(71, 24)
        Me.submitB.TabIndex = 0
        Me.submitB.Text = "Submit"
        Me.submitB.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(178, 253)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dateP As DateTimePicker
    Friend WithEvents task As TextBox
    Friend WithEvents title As TextBox
    Friend WithEvents submitB As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents subject As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
