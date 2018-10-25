Public Class Form3
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://github.com/Miguel-Cristina?tab=repositories")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stringColor As String = colorbox.Text
        Dim newColor As New Color
        newColor = Color.FromName(stringColor)
        Form1.ListView1.BackColor = newColor
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim stringExibition As String = exibox.Text
        Dim newView As New View
        If exibox.Text = "Details" Then
            newView = View.Details
        ElseIf exibox.Text = "LargeIcon" Then
            newView = View.LargeIcon
        ElseIf exibox.Text = "List" Then
            newView = View.List
        ElseIf exibox.Text = "SmallIcon" Then
            newView = View.SmallIcon
        ElseIf exibox.Text = "Tile" Then
            newView = View.Tile
        End If
        Form1.ListView1.View = newView
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If imagebox.Text = "Dinosaur" Then
            Form1.ImageList1.Images.Add(My.Resources.dina)
            Form1.ImageList1.Images.RemoveAt(0)
        End If
        If imagebox.Text = "Girl" Then
            Form1.ImageList1.Images.Add(My.Resources.girl)
            Form1.ImageList1.Images.RemoveAt(0)
        End If
        If imagebox.Text = "Trump" Then
            Form1.ImageList1.Images.Add(My.Resources.trump)
            Form1.ImageList1.Images.RemoveAt(0)
        End If
        If imagebox.Text = "Car" Then
            Form1.ImageList1.Images.Add(My.Resources.car)
            Form1.ImageList1.Images.RemoveAt(0)
        End If
        If imagebox.Text = "Task" Then
            Form1.ImageList1.Images.Add(My.Resources.icon)
            Form1.ImageList1.Images.RemoveAt(0)
        End If

    End Sub


End Class