Public Class frmDelete
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim filePath As String = "data.txt"
        Dim lines As List(Of String) = My.Computer.FileSystem.ReadAllText(filePath).Split(New String() {Environment.NewLine}, StringSplitOptions.None).ToList()
        Dim deleted As Boolean = False
        Dim studentID As String = txtID.Text

        For i As Integer = lines.Count - 1 To 0 Step -1
            Dim data As String() = lines(i).Split(",")
            If data.Length > 0 AndAlso data(0) = studentID Then
                lines.RemoveAt(i)
                deleted = True
            End If
        Next

        If deleted Then
            My.Computer.FileSystem.WriteAllText(filePath, String.Join(Environment.NewLine, lines), False)
            MessageBox.Show("Selected student record(s) deleted successfully!")
        Else
            MessageBox.Show("No record found with the given ID.")
        End If

        Form1.loadData()
    End Sub


End Class