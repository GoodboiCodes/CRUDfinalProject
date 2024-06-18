<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
        cmbCategory = New ComboBox()
        txtID = New TextBox()
        btnSave = New Button()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        lblName = New Label()
        Label1 = New Label()
        Label5 = New Label()
        txtQuantity = New TextBox()
        txtUnitprice = New TextBox()
        txtName = New TextBox()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' cmbCategory
        ' 
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Hygene", "Beverage", "Non Perishable Foods", "Desserts", "Liquor"})
        cmbCategory.Location = New Point(12, 146)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(239, 23)
        cmbCategory.TabIndex = 3
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(12, 58)
        txtID.Name = "txtID"
        txtID.Size = New Size(239, 23)
        txtID.TabIndex = 1
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(54, 271)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 6
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 15)
        Label2.TabIndex = 16
        Label2.Text = "Quantity"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 17
        Label4.Text = "Unit Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 18
        Label3.Text = "Category"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(12, 84)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 19
        lblName.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 20
        Label1.Text = "Inventory ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(98, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 15)
        Label5.TabIndex = 21
        Label5.Text = "Add Item"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(12, 234)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(239, 23)
        txtQuantity.TabIndex = 5
        ' 
        ' txtUnitprice
        ' 
        txtUnitprice.Location = New Point(12, 190)
        txtUnitprice.Name = "txtUnitprice"
        txtUnitprice.Size = New Size(239, 23)
        txtUnitprice.TabIndex = 4
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(12, 102)
        txtName.Name = "txtName"
        txtName.Size = New Size(239, 23)
        txtName.TabIndex = 2
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(135, 271)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' frmAdd
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(263, 306)
        Controls.Add(cmbCategory)
        Controls.Add(txtID)
        Controls.Add(btnClear)
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
        Name = "frmAdd"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtUnitprice As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnClear As Button
End Class
