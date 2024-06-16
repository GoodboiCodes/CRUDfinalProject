Public Class frmEdit

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim filePath As String = "data.txt"
        Dim lines As List(Of String) = My.Computer.FileSystem.ReadAllText(filePath).Split(New String() {Environment.NewLine}, StringSplitOptions.None).ToList()
        Dim updated As Boolean = False
        Dim inventoryID As String = txtID.Text
        Dim newInventoryData As String = inventoryID & "," & txtName.Text & "," & cmbCategory.Text & "," & txtUnitPrice.Text & "," & txtQuantity.Text

        ' Update the existing record if found
        For i As Integer = 0 To lines.Count - 1
            Dim data As String() = lines(i).Split(","c)
            If data(0) = inventoryID Then
                lines(i) = newInventoryData
                updated = True
                Exit For
            End If
        Next

        ' If not updated, add a new record
        If Not updated Then
            lines.Add(newInventoryData)
        End If

        ' Write the updated list back to the file
        My.Computer.FileSystem.WriteAllText(filePath, String.Join(Environment.NewLine, lines), False)

        If updated Then
            MessageBox.Show("Inventory record updated successfully!")
        Else
            MessageBox.Show("New inventory record added successfully!")
        End If

        Form1.loadData()
    End Sub

End Class