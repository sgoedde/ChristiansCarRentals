<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehicles
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblCarSizes = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblMileageRate = New System.Windows.Forms.Label()
        Me.cmbBoxCarSizes = New System.Windows.Forms.ComboBox()
        Me.txtBxPrice = New System.Windows.Forms.TextBox()
        Me.txtBxMileageRate = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(263, 115)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblCarSizes
        '
        Me.lblCarSizes.AutoSize = True
        Me.lblCarSizes.Location = New System.Drawing.Point(66, 34)
        Me.lblCarSizes.Name = "lblCarSizes"
        Me.lblCarSizes.Size = New System.Drawing.Size(54, 13)
        Me.lblCarSizes.TabIndex = 1
        Me.lblCarSizes.Text = "Car Sizes:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(66, 61)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(59, 13)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Daily Rate:"
        '
        'lblMileageRate
        '
        Me.lblMileageRate.AutoSize = True
        Me.lblMileageRate.Location = New System.Drawing.Point(66, 87)
        Me.lblMileageRate.Name = "lblMileageRate"
        Me.lblMileageRate.Size = New System.Drawing.Size(73, 13)
        Me.lblMileageRate.TabIndex = 3
        Me.lblMileageRate.Text = "Mileage Rate:"
        '
        'cmbBoxCarSizes
        '
        Me.cmbBoxCarSizes.FormattingEnabled = True
        Me.cmbBoxCarSizes.Location = New System.Drawing.Point(160, 31)
        Me.cmbBoxCarSizes.Name = "cmbBoxCarSizes"
        Me.cmbBoxCarSizes.Size = New System.Drawing.Size(121, 21)
        Me.cmbBoxCarSizes.TabIndex = 4
        '
        'txtBxPrice
        '
        Me.txtBxPrice.Location = New System.Drawing.Point(160, 58)
        Me.txtBxPrice.Name = "txtBxPrice"
        Me.txtBxPrice.ReadOnly = True
        Me.txtBxPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtBxPrice.TabIndex = 5
        '
        'txtBxMileageRate
        '
        Me.txtBxMileageRate.Location = New System.Drawing.Point(160, 84)
        Me.txtBxMileageRate.Name = "txtBxMileageRate"
        Me.txtBxMileageRate.ReadOnly = True
        Me.txtBxMileageRate.Size = New System.Drawing.Size(121, 20)
        Me.txtBxMileageRate.TabIndex = 6
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtBxMileageRate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCarSizes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPrice)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblMileageRate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbBoxCarSizes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtBxPrice)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(387, 305)
        Me.SplitContainer1.SplitterDistance = 152
        Me.SplitContainer1.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(387, 149)
        Me.DataGridView1.TabIndex = 0
        '
        'frmVehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 305)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmVehicles"
        Me.Text = "Vehicles"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblCarSizes As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblMileageRate As System.Windows.Forms.Label
    Friend WithEvents cmbBoxCarSizes As System.Windows.Forms.ComboBox
    Friend WithEvents txtBxPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtBxMileageRate As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
