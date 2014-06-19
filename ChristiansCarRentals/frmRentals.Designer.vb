<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentals
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblLicense = New System.Windows.Forms.Label()
        Me.lblCardType = New System.Windows.Forms.Label()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.txtBxName = New System.Windows.Forms.TextBox()
        Me.txtBxAddress = New System.Windows.Forms.TextBox()
        Me.txtBxPhone = New System.Windows.Forms.TextBox()
        Me.txtBxLicense = New System.Windows.Forms.TextBox()
        Me.txtBxCardType = New System.Windows.Forms.TextBox()
        Me.txtBxCardNumber = New System.Windows.Forms.TextBox()
        Me.grpBxSize = New System.Windows.Forms.GroupBox()
        Me.radBtnLuxury = New System.Windows.Forms.RadioButton()
        Me.radBtnMid = New System.Windows.Forms.RadioButton()
        Me.radBtnCompact = New System.Windows.Forms.RadioButton()
        Me.grpBxAccounts = New System.Windows.Forms.GroupBox()
        Me.chkBxInsurance = New System.Windows.Forms.CheckBox()
        Me.chkBxCorporate = New System.Windows.Forms.CheckBox()
        Me.grpBxDaysMileage = New System.Windows.Forms.GroupBox()
        Me.txtBxEndOd = New System.Windows.Forms.TextBox()
        Me.txtBxBegOd = New System.Windows.Forms.TextBox()
        Me.txtBxDays = New System.Windows.Forms.TextBox()
        Me.lblEndOd = New System.Windows.Forms.Label()
        Me.lblBegOd = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtBxCost = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpBxSize.SuspendLayout()
        Me.grpBxAccounts.SuspendLayout()
        Me.grpBxDaysMileage.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(258, 385)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Clo&se"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(76, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "&Name:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(66, 44)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "&Address:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(33, 70)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(81, 13)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "P&hone Number:"
        '
        'lblLicense
        '
        Me.lblLicense.AutoSize = True
        Me.lblLicense.Location = New System.Drawing.Point(67, 90)
        Me.lblLicense.Name = "lblLicense"
        Me.lblLicense.Size = New System.Drawing.Size(47, 13)
        Me.lblLicense.TabIndex = 6
        Me.lblLicense.Text = "Lic&ense:"
        '
        'lblCardType
        '
        Me.lblCardType.AutoSize = True
        Me.lblCardType.Location = New System.Drawing.Point(25, 114)
        Me.lblCardType.Name = "lblCardType"
        Me.lblCardType.Size = New System.Drawing.Size(89, 13)
        Me.lblCardType.TabIndex = 8
        Me.lblCardType.Text = "Credit Card &Type:"
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Location = New System.Drawing.Point(12, 140)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(102, 13)
        Me.lblCardNumber.TabIndex = 10
        Me.lblCardNumber.Text = "Credit Card &Number:"
        '
        'txtBxName
        '
        Me.txtBxName.Location = New System.Drawing.Point(120, 12)
        Me.txtBxName.Name = "txtBxName"
        Me.txtBxName.Size = New System.Drawing.Size(100, 20)
        Me.txtBxName.TabIndex = 1
        '
        'txtBxAddress
        '
        Me.txtBxAddress.Location = New System.Drawing.Point(120, 37)
        Me.txtBxAddress.Name = "txtBxAddress"
        Me.txtBxAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtBxAddress.TabIndex = 3
        '
        'txtBxPhone
        '
        Me.txtBxPhone.Location = New System.Drawing.Point(120, 63)
        Me.txtBxPhone.Name = "txtBxPhone"
        Me.txtBxPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtBxPhone.TabIndex = 5
        '
        'txtBxLicense
        '
        Me.txtBxLicense.Location = New System.Drawing.Point(120, 87)
        Me.txtBxLicense.Name = "txtBxLicense"
        Me.txtBxLicense.Size = New System.Drawing.Size(100, 20)
        Me.txtBxLicense.TabIndex = 7
        '
        'txtBxCardType
        '
        Me.txtBxCardType.Location = New System.Drawing.Point(120, 111)
        Me.txtBxCardType.Name = "txtBxCardType"
        Me.txtBxCardType.Size = New System.Drawing.Size(100, 20)
        Me.txtBxCardType.TabIndex = 9
        '
        'txtBxCardNumber
        '
        Me.txtBxCardNumber.Location = New System.Drawing.Point(120, 137)
        Me.txtBxCardNumber.Name = "txtBxCardNumber"
        Me.txtBxCardNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtBxCardNumber.TabIndex = 11
        '
        'grpBxSize
        '
        Me.grpBxSize.Controls.Add(Me.radBtnLuxury)
        Me.grpBxSize.Controls.Add(Me.radBtnMid)
        Me.grpBxSize.Controls.Add(Me.radBtnCompact)
        Me.grpBxSize.Location = New System.Drawing.Point(249, 7)
        Me.grpBxSize.Name = "grpBxSize"
        Me.grpBxSize.Size = New System.Drawing.Size(117, 82)
        Me.grpBxSize.TabIndex = 12
        Me.grpBxSize.TabStop = False
        Me.grpBxSize.Text = "Size"
        '
        'radBtnLuxury
        '
        Me.radBtnLuxury.AutoSize = True
        Me.radBtnLuxury.Location = New System.Drawing.Point(28, 59)
        Me.radBtnLuxury.Name = "radBtnLuxury"
        Me.radBtnLuxury.Size = New System.Drawing.Size(56, 17)
        Me.radBtnLuxury.TabIndex = 2
        Me.radBtnLuxury.TabStop = True
        Me.radBtnLuxury.Text = "Lu&xury"
        Me.radBtnLuxury.UseVisualStyleBackColor = True
        '
        'radBtnMid
        '
        Me.radBtnMid.AutoSize = True
        Me.radBtnMid.Location = New System.Drawing.Point(28, 35)
        Me.radBtnMid.Name = "radBtnMid"
        Me.radBtnMid.Size = New System.Drawing.Size(63, 17)
        Me.radBtnMid.TabIndex = 1
        Me.radBtnMid.TabStop = True
        Me.radBtnMid.Text = "&Mid-size"
        Me.radBtnMid.UseVisualStyleBackColor = True
        '
        'radBtnCompact
        '
        Me.radBtnCompact.AutoSize = True
        Me.radBtnCompact.Checked = True
        Me.radBtnCompact.Location = New System.Drawing.Point(28, 12)
        Me.radBtnCompact.Name = "radBtnCompact"
        Me.radBtnCompact.Size = New System.Drawing.Size(67, 17)
        Me.radBtnCompact.TabIndex = 0
        Me.radBtnCompact.TabStop = True
        Me.radBtnCompact.Text = "Com&pact"
        Me.radBtnCompact.UseVisualStyleBackColor = True
        '
        'grpBxAccounts
        '
        Me.grpBxAccounts.Controls.Add(Me.chkBxInsurance)
        Me.grpBxAccounts.Controls.Add(Me.chkBxCorporate)
        Me.grpBxAccounts.Location = New System.Drawing.Point(249, 95)
        Me.grpBxAccounts.Name = "grpBxAccounts"
        Me.grpBxAccounts.Size = New System.Drawing.Size(117, 83)
        Me.grpBxAccounts.TabIndex = 13
        Me.grpBxAccounts.TabStop = False
        Me.grpBxAccounts.Text = "Accounts"
        '
        'chkBxInsurance
        '
        Me.chkBxInsurance.AutoSize = True
        Me.chkBxInsurance.Location = New System.Drawing.Point(23, 51)
        Me.chkBxInsurance.Name = "chkBxInsurance"
        Me.chkBxInsurance.Size = New System.Drawing.Size(73, 17)
        Me.chkBxInsurance.TabIndex = 1
        Me.chkBxInsurance.Text = "&Insurance"
        Me.chkBxInsurance.UseVisualStyleBackColor = True
        '
        'chkBxCorporate
        '
        Me.chkBxCorporate.AutoSize = True
        Me.chkBxCorporate.Location = New System.Drawing.Point(24, 28)
        Me.chkBxCorporate.Name = "chkBxCorporate"
        Me.chkBxCorporate.Size = New System.Drawing.Size(72, 17)
        Me.chkBxCorporate.TabIndex = 0
        Me.chkBxCorporate.Text = "Co&rporate"
        Me.chkBxCorporate.UseVisualStyleBackColor = True
        '
        'grpBxDaysMileage
        '
        Me.grpBxDaysMileage.Controls.Add(Me.txtBxEndOd)
        Me.grpBxDaysMileage.Controls.Add(Me.txtBxBegOd)
        Me.grpBxDaysMileage.Controls.Add(Me.txtBxDays)
        Me.grpBxDaysMileage.Controls.Add(Me.lblEndOd)
        Me.grpBxDaysMileage.Controls.Add(Me.lblBegOd)
        Me.grpBxDaysMileage.Controls.Add(Me.lblDays)
        Me.grpBxDaysMileage.Location = New System.Drawing.Point(79, 196)
        Me.grpBxDaysMileage.Name = "grpBxDaysMileage"
        Me.grpBxDaysMileage.Size = New System.Drawing.Size(218, 109)
        Me.grpBxDaysMileage.TabIndex = 14
        Me.grpBxDaysMileage.TabStop = False
        Me.grpBxDaysMileage.Text = "Days and Mileage"
        '
        'txtBxEndOd
        '
        Me.txtBxEndOd.Location = New System.Drawing.Point(132, 76)
        Me.txtBxEndOd.Name = "txtBxEndOd"
        Me.txtBxEndOd.Size = New System.Drawing.Size(67, 20)
        Me.txtBxEndOd.TabIndex = 5
        '
        'txtBxBegOd
        '
        Me.txtBxBegOd.Location = New System.Drawing.Point(132, 51)
        Me.txtBxBegOd.Name = "txtBxBegOd"
        Me.txtBxBegOd.Size = New System.Drawing.Size(67, 20)
        Me.txtBxBegOd.TabIndex = 4
        '
        'txtBxDays
        '
        Me.txtBxDays.Location = New System.Drawing.Point(132, 25)
        Me.txtBxDays.Name = "txtBxDays"
        Me.txtBxDays.Size = New System.Drawing.Size(67, 20)
        Me.txtBxDays.TabIndex = 3
        '
        'lblEndOd
        '
        Me.lblEndOd.AutoSize = True
        Me.lblEndOd.Location = New System.Drawing.Point(34, 79)
        Me.lblEndOd.Name = "lblEndOd"
        Me.lblEndOd.Size = New System.Drawing.Size(92, 13)
        Me.lblEndOd.TabIndex = 2
        Me.lblEndOd.Text = "Endin&g Odometer:"
        '
        'lblBegOd
        '
        Me.lblBegOd.AutoSize = True
        Me.lblBegOd.Location = New System.Drawing.Point(20, 54)
        Me.lblBegOd.Name = "lblBegOd"
        Me.lblBegOd.Size = New System.Drawing.Size(106, 13)
        Me.lblBegOd.TabIndex = 1
        Me.lblBegOd.Text = "&Beginning Odometer:"
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(54, 28)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(72, 13)
        Me.lblDays.TabIndex = 0
        Me.lblDays.Text = "Da&ys Rented:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(79, 334)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(89, 15)
        Me.lblCost.TabIndex = 15
        Me.lblCost.Text = "Amount Due:"
        '
        'txtBxCost
        '
        Me.txtBxCost.Location = New System.Drawing.Point(174, 333)
        Me.txtBxCost.Name = "txtBxCost"
        Me.txtBxCost.ReadOnly = True
        Me.txtBxCost.Size = New System.Drawing.Size(100, 20)
        Me.txtBxCost.TabIndex = 16
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(48, 385)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 17
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(155, 385)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmRentals
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(402, 437)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtBxCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.grpBxDaysMileage)
        Me.Controls.Add(Me.grpBxAccounts)
        Me.Controls.Add(Me.grpBxSize)
        Me.Controls.Add(Me.txtBxCardNumber)
        Me.Controls.Add(Me.txtBxCardType)
        Me.Controls.Add(Me.txtBxLicense)
        Me.Controls.Add(Me.txtBxPhone)
        Me.Controls.Add(Me.txtBxAddress)
        Me.Controls.Add(Me.txtBxName)
        Me.Controls.Add(Me.lblCardNumber)
        Me.Controls.Add(Me.lblCardType)
        Me.Controls.Add(Me.lblLicense)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmRentals"
        Me.Text = "Rentals"
        Me.grpBxSize.ResumeLayout(False)
        Me.grpBxSize.PerformLayout()
        Me.grpBxAccounts.ResumeLayout(False)
        Me.grpBxAccounts.PerformLayout()
        Me.grpBxDaysMileage.ResumeLayout(False)
        Me.grpBxDaysMileage.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblLicense As System.Windows.Forms.Label
    Friend WithEvents lblCardType As System.Windows.Forms.Label
    Friend WithEvents lblCardNumber As System.Windows.Forms.Label
    Friend WithEvents txtBxName As System.Windows.Forms.TextBox
    Friend WithEvents txtBxAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtBxPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtBxLicense As System.Windows.Forms.TextBox
    Friend WithEvents txtBxCardType As System.Windows.Forms.TextBox
    Friend WithEvents txtBxCardNumber As System.Windows.Forms.TextBox
    Friend WithEvents grpBxSize As System.Windows.Forms.GroupBox
    Friend WithEvents radBtnLuxury As System.Windows.Forms.RadioButton
    Friend WithEvents radBtnMid As System.Windows.Forms.RadioButton
    Friend WithEvents radBtnCompact As System.Windows.Forms.RadioButton
    Friend WithEvents grpBxAccounts As System.Windows.Forms.GroupBox
    Friend WithEvents chkBxInsurance As System.Windows.Forms.CheckBox
    Friend WithEvents chkBxCorporate As System.Windows.Forms.CheckBox
    Friend WithEvents grpBxDaysMileage As System.Windows.Forms.GroupBox
    Friend WithEvents txtBxEndOd As System.Windows.Forms.TextBox
    Friend WithEvents txtBxBegOd As System.Windows.Forms.TextBox
    Friend WithEvents txtBxDays As System.Windows.Forms.TextBox
    Friend WithEvents lblEndOd As System.Windows.Forms.Label
    Friend WithEvents lblBegOd As System.Windows.Forms.Label
    Friend WithEvents lblDays As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents txtBxCost As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
