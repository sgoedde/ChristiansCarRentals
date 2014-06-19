'Stephanie Goedde
'eBusiness Technologies
'Christian's Car Rental/Chapter 2a
'2-6-12

Public Class frmMain

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'closes application
        Me.Close()
    End Sub

    Private Sub btnCustomers1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomers1.Click, btnCustomers.Click, ctxtCustomers.Click
        'creates an instance of the customer form
        Dim AfrmCustomers As frmCustomers = frmCustomers.Instance
        'displays customer form
        With AfrmCustomers
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnVehicles1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVehicles1.Click, btnVehicles.Click, ctxtVehicles.Click
        'creates an instance of the vehicle form
        Dim AfrmVehicles As frmVehicles = frmVehicles.Instance
        'displays vehicle form
        With AfrmVehicles
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnRentals1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRentals1.Click, btnRentals.Click, ctxtRentals.Click
        'creates an instance of the rental form
        Dim AfrmRentals As frmRentals = frmRentals.Instance
        'displays rental form
        With AfrmRentals
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnHorizontal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHorizontal.Click
        'display open windows horizontally
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub btnVertical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVertical.Click
        'display open windows vertically
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub btnCascade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCascade.Click
        'display open windows in cascade
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        'displays about box
        Dim AfrmAbout As New frmAbout
        AfrmAbout.ShowDialog()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'gets correct date and time when form loads
        lblDate.Text = Now.ToShortDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    'continually updates date and time
    '    lblDate.Text = Now.ToShortDateString
    '    lblTime.Text = Now.ToLongTimeString
    'End Sub
End Class
