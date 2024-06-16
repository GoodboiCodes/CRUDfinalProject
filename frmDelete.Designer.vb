<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelete
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnDelete = New Button()
        Label1 = New Label()
        txtID = New TextBox()
        SuspendLayout()
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(84, 56)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 11
        Label1.Text = "Inventory ID"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(12, 27)
        txtID.Name = "txtID"
        txtID.Size = New Size(239, 23)
        txtID.TabIndex = 6
        ' 
        ' frmDelete
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(263, 91)
        Controls.Add(btnDelete)
        Controls.Add(Label1)
        Controls.Add(txtID)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmDelete"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmDelete"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
End Class
