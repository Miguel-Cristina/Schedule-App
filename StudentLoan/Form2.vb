Imports System.Data.OleDb
Public Class Form2
    Dim con As New OleDbConnection
    Dim con2 As New OleDbConnection
    Dim newID As New Integer
    Private Function getID()
        con2.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source= C:\CarDB\schedule.mdb"
        con2.Open()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter("SELECT MAX(ID) FROM Schedule", con2)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        con2.Close()
        newID = dt.Rows(0).Item(0)
        Return newID + 1
    End Function
    Private Sub insertData()
        If (title.Text IsNot "" And task.Text IsNot "" And subject.Text IsNot "") Then
            con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source= C:\CarDB\schedule.mdb"
            con.Open()
            Dim str As String
            str = "INSERT INTO Schedule VALUES (?, ?, ?, ?, ?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, con)
            cmd.Parameters.AddWithValue("@0", getID)
            cmd.Parameters.AddWithValue("@1", title.Text)
            cmd.Parameters.AddWithValue("@2", task.Text)
            cmd.Parameters.AddWithValue("@3", subject.Text)
            cmd.Parameters.AddWithValue("@4", dateP.Value.ToShortDateString)
            Try
                cmd.ExecuteNonQuery()
                If cmd.ExecuteNonQuery() > 0 Then
                    'MessageBox.Show("Success!!")
                End If
                cmd.Dispose()

            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try

            con.Close()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles submitB.Click
        insertData()
        Close()

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = My.Resources.closer
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.closer_on
    End Sub
End Class