<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
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
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim StreetLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim Inv_IDLabel As System.Windows.Forms.Label
        Dim Drivers_LicenseLabel As System.Windows.Forms.Label
        Dim RentalDateLabel As System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.Inv_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Drivers_LicenseTextBox = New System.Windows.Forms.TextBox()
        Me.RentalDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LastNameComboBox = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblRecordPosition = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtBxFirstName = New System.Windows.Forms.TextBox()
        Me.btnAddSave = New System.Windows.Forms.Button()
        Me.btnDeleteCancel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtBxPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        StreetLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        Inv_IDLabel = New System.Windows.Forms.Label()
        Drivers_LicenseLabel = New System.Windows.Forms.Label()
        RentalDateLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(70, 22)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 0
        LastNameLabel.Text = "Last Name:"
        '
        'StreetLabel
        '
        StreetLabel.AutoSize = True
        StreetLabel.Location = New System.Drawing.Point(70, 101)
        StreetLabel.Name = "StreetLabel"
        StreetLabel.Size = New System.Drawing.Size(38, 13)
        StreetLabel.TabIndex = 6
        StreetLabel.Text = "Street:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(70, 127)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 8
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(70, 153)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 10
        StateLabel.Text = "State:"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(70, 179)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(25, 13)
        ZipLabel.TabIndex = 12
        ZipLabel.Text = "Zip:"
        '
        'Inv_IDLabel
        '
        Inv_IDLabel.AutoSize = True
        Inv_IDLabel.Location = New System.Drawing.Point(70, 205)
        Inv_IDLabel.Name = "Inv_IDLabel"
        Inv_IDLabel.Size = New System.Drawing.Size(59, 13)
        Inv_IDLabel.TabIndex = 14
        Inv_IDLabel.Text = "Vehicle ID:"
        '
        'Drivers_LicenseLabel
        '
        Drivers_LicenseLabel.AutoSize = True
        Drivers_LicenseLabel.Location = New System.Drawing.Point(70, 231)
        Drivers_LicenseLabel.Name = "Drivers_LicenseLabel"
        Drivers_LicenseLabel.Size = New System.Drawing.Size(83, 13)
        Drivers_LicenseLabel.TabIndex = 16
        Drivers_LicenseLabel.Text = "Drivers License:"
        '
        'RentalDateLabel
        '
        RentalDateLabel.AutoSize = True
        RentalDateLabel.Location = New System.Drawing.Point(70, 258)
        RentalDateLabel.Name = "RentalDateLabel"
        RentalDateLabel.Size = New System.Drawing.Size(67, 13)
        RentalDateLabel.TabIndex = 18
        RentalDateLabel.Text = "Rental Date:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(364, 322)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(159, 98)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.ReadOnly = True
        Me.StreetTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StreetTextBox.TabIndex = 7
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(159, 124)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.ReadOnly = True
        Me.CityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CityTextBox.TabIndex = 9
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(159, 150)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.ReadOnly = True
        Me.StateTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StateTextBox.TabIndex = 11
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(159, 176)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.ReadOnly = True
        Me.ZipTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ZipTextBox.TabIndex = 13
        '
        'Inv_IDTextBox
        '
        Me.Inv_IDTextBox.Location = New System.Drawing.Point(159, 202)
        Me.Inv_IDTextBox.Name = "Inv_IDTextBox"
        Me.Inv_IDTextBox.ReadOnly = True
        Me.Inv_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Inv_IDTextBox.TabIndex = 15
        '
        'Drivers_LicenseTextBox
        '
        Me.Drivers_LicenseTextBox.Location = New System.Drawing.Point(159, 228)
        Me.Drivers_LicenseTextBox.Name = "Drivers_LicenseTextBox"
        Me.Drivers_LicenseTextBox.ReadOnly = True
        Me.Drivers_LicenseTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Drivers_LicenseTextBox.TabIndex = 17
        '
        'RentalDateDateTimePicker
        '
        Me.RentalDateDateTimePicker.Location = New System.Drawing.Point(159, 254)
        Me.RentalDateDateTimePicker.Name = "RentalDateDateTimePicker"
        Me.RentalDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.RentalDateDateTimePicker.TabIndex = 19
        '
        'LastNameComboBox
        '
        Me.LastNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LastNameComboBox.FormattingEnabled = True
        Me.LastNameComboBox.Location = New System.Drawing.Point(159, 19)
        Me.LastNameComboBox.Name = "LastNameComboBox"
        Me.LastNameComboBox.Size = New System.Drawing.Size(200, 21)
        Me.LastNameComboBox.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblRecordPosition, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 370)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(474, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblRecordPosition
        '
        Me.lblRecordPosition.Name = "lblRecordPosition"
        Me.lblRecordPosition.Size = New System.Drawing.Size(33, 17)
        Me.lblRecordPosition.Text = "Test"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(70, 49)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name:"
        '
        'txtBxFirstName
        '
        Me.txtBxFirstName.Location = New System.Drawing.Point(159, 46)
        Me.txtBxFirstName.Name = "txtBxFirstName"
        Me.txtBxFirstName.ReadOnly = True
        Me.txtBxFirstName.Size = New System.Drawing.Size(200, 20)
        Me.txtBxFirstName.TabIndex = 3
        '
        'btnAddSave
        '
        Me.btnAddSave.Location = New System.Drawing.Point(40, 322)
        Me.btnAddSave.Name = "btnAddSave"
        Me.btnAddSave.Size = New System.Drawing.Size(75, 23)
        Me.btnAddSave.TabIndex = 20
        Me.btnAddSave.Text = "&Add"
        Me.btnAddSave.UseVisualStyleBackColor = True
        '
        'btnDeleteCancel
        '
        Me.btnDeleteCancel.Location = New System.Drawing.Point(142, 322)
        Me.btnDeleteCancel.Name = "btnDeleteCancel"
        Me.btnDeleteCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteCancel.TabIndex = 21
        Me.btnDeleteCancel.Text = "&Delete"
        Me.btnDeleteCancel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(249, 322)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'txtBxPhone
        '
        Me.txtBxPhone.Location = New System.Drawing.Point(159, 72)
        Me.txtBxPhone.Name = "txtBxPhone"
        Me.txtBxPhone.ReadOnly = True
        Me.txtBxPhone.Size = New System.Drawing.Size(200, 20)
        Me.txtBxPhone.TabIndex = 5
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(70, 75)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(41, 13)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone:"
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 392)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtBxPhone)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDeleteCancel)
        Me.Controls.Add(Me.btnAddSave)
        Me.Controls.Add(Me.txtBxFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.LastNameComboBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(StreetLabel)
        Me.Controls.Add(Me.StreetTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(ZipLabel)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Inv_IDLabel)
        Me.Controls.Add(Me.Inv_IDTextBox)
        Me.Controls.Add(Drivers_LicenseLabel)
        Me.Controls.Add(Me.Drivers_LicenseTextBox)
        Me.Controls.Add(RentalDateLabel)
        Me.Controls.Add(Me.RentalDateDateTimePicker)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmCustomers"
        Me.Text = "Customers"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents StreetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Inv_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Drivers_LicenseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RentalDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LastNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblRecordPosition As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtBxFirstName As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnAddSave As System.Windows.Forms.Button
    Friend WithEvents btnDeleteCancel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents txtBxPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
End Class
