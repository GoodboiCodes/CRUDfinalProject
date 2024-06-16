Public Class frmAdd

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim studentData = txtID.Text & "," & txtName.Text & "," & cmbCategory.Text & "," & txtUnitprice.Text & "," & txtQuantity.Text
        My.Computer.FileSystem.WriteAllText("data.txt", studentData & Environment.NewLine, True)
        MessageBox.Show("Item added successfully!")
        Form1.loadData()
    End Sub
End Class