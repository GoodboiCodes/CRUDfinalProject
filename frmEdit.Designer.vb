<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Label4 = New Label()
        Label3 = New Label()
        lblName = New Label()
        txtUnitprice = New TextBox()
        txtName = New TextBox()
        Label5 = New Label()
        btnSave = New Button()
        txtID = New TextBox()
        Label1 = New Label()
        txtQuantity = New TextBox()
        Label2 = New Label()
        cmbCategory = New ComboBox()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 6
        Label4.Text = "Unit Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 7
        Label3.Text = "Category"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(12, 89)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 8
        lblName.Text = "Name"
        ' 
        ' txtUnitprice
        ' 
        txtUnitprice.Location = New Point(12, 195)
        txtUnitprice.Name = "txtUnitprice"
        txtUnitprice.Size = New Size(239, 23)
        txtUnitprice.TabIndex = 4
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(12, 107)
        txtName.Name = "txtName"
        txtName.Size = New Size(239, 23)
        txtName.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(102, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 15)
        Label5.TabIndex = 9
        Label5.Text = "Edit Item"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(52, 285)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 6
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(12, 63)
        txtID.Name = "txtID"
        txtID.Size = New Size(239, 23)
        txtID.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 9
        Label1.Text = "Inventory ID"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(12, 239)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(239, 23)
        txtQuantity.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 221)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 15)
        Label2.TabIndex = 6
        Label2.Text = "Quantity"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Hygene", "Beverage", "Non Perishable Foods", "Desserts", "Liquor"})
        cmbCategory.Location = New Point(12, 151)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(239, 23)
        cmbCategory.TabIndex = 3
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(133, 285)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' frmEdit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(263, 320)
        Controls.Add(btnClear)
        Controls.Add(cmbCategory)
        Controls.Add(txtID)
        Controls.Add(btnSave)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Controls.Add(txtQuantity)
        Controls.Add(txtUnitprice)
        Controls.Add(txtName)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmEdit"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtUnitprice As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents btnClear As Button
End Class
