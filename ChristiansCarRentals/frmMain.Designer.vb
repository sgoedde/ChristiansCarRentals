<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCustomers1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnVehicles1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRentals1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctxtCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxtVehicles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxtRentals = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCustomers = New System.Windows.Forms.ToolStripButton()
        Me.btnVehicles = New System.Windows.Forms.ToolStripButton()
        Me.btnRentals = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatusFiller = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFile, Me.btnEdit, Me.btnWindow, Me.btnHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.btnWindow
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnFile
        '
        Me.btnFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExit})
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(40, 20)
        Me.btnFile.Text = "&File"
        '
        'btnExit
        '
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 22)
        Me.btnExit.Text = "E&xit"
        '
        'btnEdit
        '
        Me.btnEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCustomers1, Me.btnVehicles1, Me.btnRentals1})
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(41, 20)
        Me.btnEdit.Text = "&Edit"
        '
        'btnCustomers1
        '
        Me.btnCustomers1.Name = "btnCustomers1"
        Me.btnCustomers1.Size = New System.Drawing.Size(150, 22)
        Me.btnCustomers1.Text = "&Customers"
        '
        'btnVehicles1
        '
        Me.btnVehicles1.Name = "btnVehicles1"
        Me.btnVehicles1.Size = New System.Drawing.Size(150, 22)
        Me.btnVehicles1.Text = "&Vehicles"
        '
        'btnRentals1
        '
        Me.btnRentals1.Name = "btnRentals1"
        Me.btnRentals1.Size = New System.Drawing.Size(150, 22)
        Me.btnRentals1.Text = "&Rentals"
        '
        'btnWindow
        '
        Me.btnWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnHorizontal, Me.btnVertical, Me.btnCascade, Me.ToolStripSeparator1})
        Me.btnWindow.Name = "btnWindow"
        Me.btnWindow.Size = New System.Drawing.Size(66, 20)
        Me.btnWindow.Text = "&Window"
        '
        'btnHorizontal
        '
        Me.btnHorizontal.Name = "btnHorizontal"
        Me.btnHorizontal.Size = New System.Drawing.Size(171, 22)
        Me.btnHorizontal.Text = "Tile &Horizontal"
        '
        'btnVertical
        '
        Me.btnVertical.Name = "btnVertical"
        Me.btnVertical.Size = New System.Drawing.Size(171, 22)
        Me.btnVertical.Text = "Tile &Vertical"
        '
        'btnCascade
        '
        Me.btnCascade.Name = "btnCascade"
        Me.btnCascade.Size = New System.Drawing.Size(171, 22)
        Me.btnCascade.Text = "&Cascade"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(168, 6)
        '
        'btnHelp
        '
        Me.btnHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAbout})
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(45, 20)
        Me.btnHelp.Text = "&Help"
        '
        'btnAbout
        '
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(122, 22)
        Me.btnAbout.Text = "&About"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctxtCustomers, Me.ctxtVehicles, Me.ctxtRentals})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(151, 70)
        '
        'ctxtCustomers
        '
        Me.ctxtCustomers.Name = "ctxtCustomers"
        Me.ctxtCustomers.Size = New System.Drawing.Size(150, 22)
        Me.ctxtCustomers.Text = "Customers"
        '
        'ctxtVehicles
        '
        Me.ctxtVehicles.Name = "ctxtVehicles"
        Me.ctxtVehicles.Size = New System.Drawing.Size(150, 22)
        Me.ctxtVehicles.Text = "Vehicles"
        '
        'ctxtRentals
        '
        Me.ctxtRentals.Name = "ctxtRentals"
        Me.ctxtRentals.Size = New System.Drawing.Size(150, 22)
        Me.ctxtRentals.Text = "Rentals"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCustomers, Me.btnVehicles, Me.btnRentals})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(632, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCustomers
        '
        Me.btnCustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCustomers.Image = Global.ChristiansCarRentals.My.Resources.Resources.Pictures
        Me.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(23, 22)
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.ToolTipText = "Customers"
        '
        'btnVehicles
        '
        Me.btnVehicles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnVehicles.Image = Global.ChristiansCarRentals.My.Resources.Resources.Calculator
        Me.btnVehicles.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVehicles.Name = "btnVehicles"
        Me.btnVehicles.Size = New System.Drawing.Size(23, 22)
        Me.btnVehicles.Text = "Vehicles"
        '
        'btnRentals
        '
        Me.btnRentals.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRentals.Image = Global.ChristiansCarRentals.My.Resources.Resources.Folder_Back
        Me.btnRentals.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRentals.Name = "btnRentals"
        Me.btnRentals.Size = New System.Drawing.Size(23, 22)
        Me.btnRentals.Text = "Rentals"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatusFiller, Me.lblDate, Me.lblTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 544)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatusFiller
        '
        Me.lblStatusFiller.Name = "lblStatusFiller"
        Me.lblStatusFiller.Size = New System.Drawing.Size(617, 17)
        Me.lblStatusFiller.Spring = True
        '
        'lblDate
        '
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 17)
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 566)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Location = New System.Drawing.Point(0, 25)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Christian's Car Rental"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCustomers1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnVehicles1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRentals1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnWindow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCascade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ctxtCustomers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxtVehicles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxtRentals As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCustomers As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnVehicles As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRentals As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatusFiller As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
