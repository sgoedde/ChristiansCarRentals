'Stephanie Goedde
'eBusiness Technologies
'Christian's Car Rental/Chapter 2a
'2-6-12

Public Class frmRentals

    Private Shared AnInstance As frmRentals
    'allows only 1 instance of form in singleton design
    Public Shared ReadOnly Property Instance() As frmRentals
        Get
            If AnInstance Is Nothing Then
                AnInstance = New frmRentals
            End If
            Return AnInstance
        End Get
    End Property

    'closes form
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmRentals_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'releases instance of form
        AnInstance = Nothing
        'doesn't allow validation to cancel form's closing
        e.Cancel = False
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim intSelection As Integer
        Dim decDays As Decimal
        Dim decBegOd As Decimal
        Dim decEndOd As Decimal

        'removes any errors to check for current errors
        ErrorProvider1.Clear()

        'determines the selection of radio buttons
        If radBtnLuxury.Checked Then
            intSelection = Standard.SelectionType.Luxury
        ElseIf radBtnMid.Checked Then
            intSelection = Standard.SelectionType.Mid
        Else
            intSelection = Standard.SelectionType.Compact
        End If

        'checks if numeric values in textboxes for days, begin and end odometer
        'if numeric will parse, otherwise gives error message
        If Decimal.TryParse(txtBxDays.Text, decDays) Then
            If Decimal.TryParse(txtBxBegOd.Text, decBegOd) Then
                If Decimal.TryParse(txtBxEndOd.Text, decEndOd) Then
                    Try
                        'checks end odometer larger than begin odometer
                        If decEndOd > decBegOd Then
                            'determines checkboxes and sends data to business tier for calculations
                            If chkBxCorporate.Checked Then
                                Dim aDiscount As New Standard.DiscountAccounts(decDays, decBegOd, decEndOd, intSelection, chkBxCorporate.Checked, chkBxInsurance.Checked)
                                txtBxCost.Text = aDiscount.Cost.ToString("C2")
                            ElseIf chkBxInsurance.Checked Then
                                Dim aDiscount As New Standard.DiscountAccounts(decDays, decBegOd, decEndOd, intSelection, chkBxCorporate.Checked, chkBxInsurance.Checked)
                                txtBxCost.Text = aDiscount.Cost.ToString("C2")
                            Else
                                Dim aStandard As New Standard.Standard(decDays, decBegOd, decEndOd, intSelection, chkBxCorporate.Checked, chkBxInsurance.Checked)
                                txtBxCost.Text = aStandard.Cost.ToString("C2")
                            End If
                        Else
                            MessageBox.Show("Ending odometer must be larger then beginning odometer. Try again.", "Error!")
                            txtBxEndOd.Focus()
                            txtBxEndOd.SelectAll()
                        End If
                    Catch Err As ApplicationException
                        Select Case Err.Source
                            Case "Days"
                                ErrorProvider1.SetError(txtBxDays, Err.Message)
                                With txtBxDays
                                    .SelectAll()
                                    .Focus()
                                End With
                        End Select
                    End Try
                Else
                    MessageBox.Show("Ending odometer must be a numeric value. Try again.", "Error!")
                    txtBxEndOd.Focus()
                    txtBxEndOd.SelectAll()
                    ErrorProvider1.SetError(txtBxEndOd, "Ending odometer must be numeric.")
                End If
            Else
                MessageBox.Show("Beginning odometer must be a numeric value. Try again.", "Error!")
                txtBxBegOd.Focus()
                txtBxBegOd.SelectAll()
                ErrorProvider1.SetError(txtBxBegOd, "Beginning odometer must be numeric.")
            End If
        Else
            MessageBox.Show("Days rented must be a numeric value. Try again.", "Error!")
            txtBxDays.Focus()
            txtBxDays.SelectAll()
            ErrorProvider1.SetError(txtBxDays, "Days rented must be numeric.")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clears all textboxes and sets focus
        ErrorProvider1.Clear()

        txtBxName.Clear()
        txtBxAddress.Clear()
        txtBxPhone.Clear()
        txtBxLicense.Clear()
        txtBxCardType.Clear()
        txtBxCardNumber.Clear()
        txtBxDays.Clear()
        txtBxBegOd.Clear()
        txtBxEndOd.Clear()
        txtBxCost.Clear()
        txtBxName.Focus()

        radBtnCompact.Checked = True
        radBtnMid.Checked = False
        radBtnLuxury.Checked = False
        chkBxCorporate.Checked = False
        chkBxInsurance.Checked = False

    End Sub

    Private Sub txtBxLicense_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBxLicense.Validating
        'makes sure a value is entered in text box

        If txtBxLicense.Text = "" Then
            e.Cancel = True
            ErrorProvider1.SetError(txtBxLicense, "Required field.")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtBxDays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBxDays.TextChanged, txtBxEndOd.TextChanged, txtBxBegOd.TextChanged
        txtBxCost.Clear()
    End Sub
End Class
