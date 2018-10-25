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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.nowLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ScheduleDataSet = New StudentLoan.scheduleDataSet()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.subjectL = New System.Windows.Forms.Label()
        Me.detailsL1 = New System.Windows.Forms.Label()
        Me.detailsL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ScheduleTableAdapter = New StudentLoan.scheduleDataSetTableAdapters.ScheduleTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.closeB = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.closeB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.closeB)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.datePicker)
        Me.Panel1.Controls.Add(Me.nowLabel)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 348)
        Me.Panel1.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(-1, -1)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(362, 228)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "if_edit_3218.png")
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(382, 102)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(379, 275)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "New task:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(379, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Choose date:"
        '
        'datePicker
        '
        Me.datePicker.Location = New System.Drawing.Point(382, 302)
        Me.datePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(202, 20)
        Me.datePicker.TabIndex = 3
        '
        'nowLabel
        '
        Me.nowLabel.AutoSize = True
        Me.nowLabel.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nowLabel.Location = New System.Drawing.Point(378, 31)
        Me.nowLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nowLabel.Name = "nowLabel"
        Me.nowLabel.Size = New System.Drawing.Size(92, 22)
        Me.nowLabel.TabIndex = 2
        Me.nowLabel.Text = "hh:mm:ss"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.TaskDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ScheduleBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(114, 121)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(156, 5)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'TaskDataGridViewTextBoxColumn
        '
        Me.TaskDataGridViewTextBoxColumn.DataPropertyName = "Task"
        Me.TaskDataGridViewTextBoxColumn.HeaderText = "Task"
        Me.TaskDataGridViewTextBoxColumn.Name = "TaskDataGridViewTextBoxColumn"
        Me.TaskDataGridViewTextBoxColumn.Width = 300
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        '
        'ScheduleBindingSource
        '
        Me.ScheduleBindingSource.DataMember = "Schedule"
        Me.ScheduleBindingSource.DataSource = Me.ScheduleDataSet
        '
        'ScheduleDataSet
        '
        Me.ScheduleDataSet.DataSetName = "scheduleDataSet"
        Me.ScheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.subjectL)
        Me.Panel2.Controls.Add(Me.detailsL1)
        Me.Panel2.Controls.Add(Me.detailsL)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(-1, 233)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 114)
        Me.Panel2.TabIndex = 8
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Details:"
        '
        'ScheduleTableAdapter
        '
        Me.ScheduleTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'closeB
        '
        Me.closeB.Image = Global.StudentLoan.My.Resources.Resources.closer_on
        Me.closeB.Location = New System.Drawing.Point(615, 3)
        Me.closeB.Name = "closeB"
        Me.closeB.Size = New System.Drawing.Size(10, 23)
        Me.closeB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeB.TabIndex = 13
        Me.closeB.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StudentLoan.My.Resources.Resources.add_leave
        Me.PictureBox1.Location = New System.Drawing.Point(589, 302)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(608, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 6)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Miguel C"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 348)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.closeB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents nowLabel As Label
    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents ScheduleDataSet As scheduleDataSet
    Friend WithEvents ScheduleBindingSource As BindingSource
    Friend WithEvents ScheduleTableAdapter As scheduleDataSetTableAdapters.ScheduleTableAdapter
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaskDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel2 As Panel
    Friend WithEvents detailsL As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents detailsL1 As Label
    Friend WithEvents subjectL As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents closeB As PictureBox
    Friend WithEvents Label4 As Label
End Class
