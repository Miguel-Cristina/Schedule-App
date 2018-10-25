Imports System.Data.OleDb

Public Class Form1
    Dim con As New OleDbConnection
    Dim timeVariable As DateTime


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ScheduleDataSet.Schedule' table. You can move, or remove it, as needed.
        Me.ScheduleTableAdapter.Fill(Me.ScheduleDataSet.Schedule)
        Timer1.Enabled = True
        'nowLabel.Text = DateTime.Now
        Dim dateString As String = datePicker.Text
        getData()
        SendKeys.Send("%{DOWN}")

    End Sub
    Private Sub getData()
        ListView1.Clear()
        detailsL.ResetText()
        detailsL1.ResetText()
        subjectL.ResetText()
        Dim dateString As String
        dateString = MonthCalendar1.SelectionRange.Start.ToShortDateString
        con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source= C:\CarDB\schedule.mdb"
        con.Open()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT *from Schedule where Date like '%" & dateString & "%'", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        con.Close()
        Dim count As Integer = 0
        For Each DataGridRow In DataGridView1.Rows

            Dim curr As New DataGridViewRow
            curr = DataGridRow
            Try
                ListView1.Items.Add(curr.Cells(1).Value.ToString, 0)
                ListView1.Items(count).SubItems.Add(curr.Cells(2).Value.ToString)
                ListView1.Items(count).SubItems.Add(curr.Cells(3).Value.ToString)
            Catch ex As Exception

            End Try
            count = count + 1
        Next
    End Sub


    Private Sub datePicker_ValueChanged(sender As Object, e As EventArgs) Handles datePicker.ValueChanged
        Form2.dateP.Value = datePicker.Value
        Form2.Show()

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        getData()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        detailsL.Text = "Title: " + ListView1.FocusedItem.Text
        detailsL1.Text = "Task: " + ListView1.FocusedItem.SubItems.Item(1).Text
        subjectL.Text = "Subject: " + ListView1.FocusedItem.SubItems.Item(2).Text



    End Sub

    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim timeVariable As DateTime
        timeVariable = DateTime.Now
        ' nowLabel.Text = DateTime.Now
        nowLabel.Text = timeVariable
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.dateP.Value = datePicker.Value
        Form2.Show()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = My.Resources.add_enter
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.add_leave
    End Sub

    Private Sub closeB_Click(sender As Object, e As EventArgs) Handles closeB.Click
        Close()
    End Sub

    Private Sub closeB_MouseLeave(sender As Object, e As EventArgs) Handles closeB.MouseLeave
        closeB.Image = My.Resources.closer_on
    End Sub

    Private Sub closeB_MouseEnter(sender As Object, e As EventArgs) Handles closeB.MouseEnter
        closeB.Image = My.Resources.closer
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.K AndAlso e.Modifiers = Keys.Control Then
            Form3.Show()
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Process.Start("http://github.com/Miguel-Cristina/")
    End Sub
End Class
