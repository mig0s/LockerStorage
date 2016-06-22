<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddRent
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
        Me.components = New System.ComponentModel.Container()
        Me.txtDur = New System.Windows.Forms.TextBox()
        Me.txtLot = New System.Windows.Forms.TextBox()
        Me.txtAddr = New System.Windows.Forms.TextBox()
        Me.txtNric = New System.Windows.Forms.TextBox()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCont = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDB2DataSet = New WindowsApplication2.orderDB2DataSet()
        Me.CustomerTableAdapter = New WindowsApplication2.orderDB2DataSetTableAdapters.customerTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDB2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDur
        '
        Me.txtDur.Location = New System.Drawing.Point(122, 330)
        Me.txtDur.Name = "txtDur"
        Me.txtDur.Size = New System.Drawing.Size(196, 30)
        Me.txtDur.TabIndex = 87
        '
        'txtLot
        '
        Me.txtLot.Location = New System.Drawing.Point(122, 294)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(196, 30)
        Me.txtLot.TabIndex = 86
        '
        'txtAddr
        '
        Me.txtAddr.Location = New System.Drawing.Point(122, 150)
        Me.txtAddr.Name = "txtAddr"
        Me.txtAddr.Size = New System.Drawing.Size(196, 30)
        Me.txtAddr.TabIndex = 85
        '
        'txtNric
        '
        Me.txtNric.Location = New System.Drawing.Point(122, 114)
        Me.txtNric.Name = "txtNric"
        Me.txtNric.Size = New System.Drawing.Size(196, 30)
        Me.txtNric.TabIndex = 84
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(122, 222)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(196, 30)
        Me.txtDOB.TabIndex = 74
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(122, 258)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(196, 30)
        Me.txtEmail.TabIndex = 73
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 333)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 25)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "Duration:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(44, 297)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 25)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "Lot ID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 25)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 25)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "NRIC:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 25)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "DOB:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(47, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 25)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Email:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 25)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Contact:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(43, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 25)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "Name:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(76, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 25)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "ID:"
        '
        'txtCont
        '
        Me.txtCont.Location = New System.Drawing.Point(122, 186)
        Me.txtCont.Name = "txtCont"
        Me.txtCont.Size = New System.Drawing.Size(196, 30)
        Me.txtCont.TabIndex = 72
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(122, 78)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(196, 30)
        Me.txtName.TabIndex = 71
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(122, 42)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(196, 30)
        Me.txtID.TabIndex = 70
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 38)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(128, 366)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(148, 38)
        Me.btnSave.TabIndex = 67
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 28)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Add Rental Info"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.OrderDB2DataSet
        Me.BindingSource1.Position = 0
        '
        'OrderDB2DataSet
        '
        Me.OrderDB2DataSet.DataSetName = "orderDB2DataSet"
        Me.OrderDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'frmAddRent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 411)
        Me.Controls.Add(Me.txtDur)
        Me.Controls.Add(Me.txtLot)
        Me.Controls.Add(Me.txtAddr)
        Me.Controls.Add(Me.txtNric)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtCont)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAddRent"
        Me.Text = "frmAddRent"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDB2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDur As System.Windows.Forms.TextBox
    Friend WithEvents txtLot As System.Windows.Forms.TextBox
    Friend WithEvents txtAddr As System.Windows.Forms.TextBox
    Friend WithEvents txtNric As System.Windows.Forms.TextBox
    Friend WithEvents txtDOB As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCont As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents OrderDB2DataSet As WindowsApplication2.orderDB2DataSet
    Friend WithEvents CustomerTableAdapter As WindowsApplication2.orderDB2DataSetTableAdapters.customerTableAdapter
End Class
