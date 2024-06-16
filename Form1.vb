Public Class Form1
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        frmAdd.ShowDialog()
    End Sub

    Sub loadData()
        Dim lines As String() = IO.File.ReadAllLines("data.txt")
        Dim dt As New DataTable()
        dt.Columns.Add("Inventory ID")
        dt.Columns.Add("Name")
        dt.Columns.Add("Category")
        dt.Columns.Add("Unit Price (₱)", GetType(Decimal))
        dt.Columns.Add("Quantity in Stock", GetType(Integer))
        dt.Columns.Add("Inventory Value (₱)", GetType(Decimal))

        For Each line As String In lines
            Dim data As String() = line.Split(","c)
            If data.Length = 5 Then
                Dim unitPrice As Decimal
                Dim quantity As Integer

                If Decimal.TryParse(data(3), unitPrice) AndAlso Integer.TryParse(data(4), quantity) Then
                    Dim inventoryValue As Decimal = unitPrice * quantity
                    dt.Rows.Add(data(0), data(1), data(2), unitPrice, quantity, inventoryValue)
                End If
            End If
        Next

        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        frmEdit.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        frmDelete.ShowDialog()
    End Sub
End Class
