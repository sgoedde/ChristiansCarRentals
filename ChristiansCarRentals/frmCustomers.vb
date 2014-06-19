'Stephanie Goedde
'eBusiness Technologies
'Christian's Car Rentals/Chapter 5a
'3-8-12

Public Class frmCustomers

    Private ACustomerDataSet As CustomerData.CarsSQLSrvrDataSet
    Private WithEvents ABindingSource As BindingSource
    Private CustomerData As CustomerData.CustomerData

    Private boolAdd As Boolean = False
    Private boolEdit As Boolean = False
    Private intPrevIndex As Integer

    Private Shared AnInstance As frmCustomers
    'allows only 1 instance of form in singleton design
    Public Shared ReadOnly Property Instance() As frmCustomers
        Get
            If AnInstance Is Nothing Then
                AnInstance = New frmCustomers
            End If
            Return AnInstance
        End Get
    End Property

    'closes form
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'releases instance of form
    Private Sub frmCustomers_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        AnInstance = Nothing
    End Sub

    'retrieve data from data tier and bind controls
    Private Sub frmCustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'setup and fill data set
            CustomerData = New CustomerData.CustomerData
            ACustomerDataSet = CustomerData.GetCustomerDataSet()

            'setup the binding source
            ABindingSource = New BindingSource
            With ABindingSource
                .DataSource = ACustomerDataSet
                .DataMember = "Customer"
                .Sort = "LName"
                'get correct count of rows in data set
                .MoveLast()
                .MoveFirst()
            End With

            'bind the controls
            With LastNameComboBox
                .DataSource = ABindingSource
                .DisplayMember = "LName"
                .DataBindings.Add("text", ABindingSource, "LName", False, DataSourceUpdateMode.Never)
            End With

            txtBxFirstName.DataBindings.Add("text", ABindingSource, "FName", False, DataSourceUpdateMode.OnValidation)
            txtBxPhone.DataBindings.Add("text", ABindingSource, "Phone", False, DataSourceUpdateMode.OnValidation)
            StreetTextBox.DataBindings.Add("text", ABindingSource, "Street", False, DataSourceUpdateMode.OnValidation)
            CityTextBox.DataBindings.Add("text", ABindingSource, "City", False, DataSourceUpdateMode.OnValidation)
            StateTextBox.DataBindings.Add("text", ABindingSource, "State", False, DataSourceUpdateMode.OnValidation)
            ZipTextBox.DataBindings.Add("text", ABindingSource, "Zip", False, DataSourceUpdateMode.OnValidation)
            Inv_IDTextBox.DataBindings.Add("text", ABindingSource, "Inv_ID", False, DataSourceUpdateMode.OnValidation)
            Drivers_LicenseTextBox.DataBindings.Add("text", ABindingSource, "Drivers_License", False, DataSourceUpdateMode.OnValidation)
            RentalDateDateTimePicker.DataBindings.Add("text", ABindingSource, "RentalDate", False, DataSourceUpdateMode.OnValidation)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'find record position and display in status label
    Private Sub ABindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ABindingSource.PositionChanged
        With ABindingSource
            lblRecordPosition.Text = "Record " & (.Position + 1).ToString() & " of " & .Count.ToString()
        End With
    End Sub

    'lock or unlock controls
    Private Sub SetControlsReadOnly(ByVal valueBoolean As Boolean)
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is TextBox Then
                DirectCast(ctl, TextBox).ReadOnly = valueBoolean
            End If
        Next
    End Sub

    'setup buttons for add or edit
    Private Sub SetButtonForEdit()
        btnAddSave.Text = "&Save"
        btnDeleteCancel.Text = "&Cancel"
        btnEdit.Enabled = False
        If boolAdd Then
            ToolStripStatusLabel1.Text = "Adding"
        Else
            ToolStripStatusLabel1.Text = "Editing"
        End If

    End Sub

    'reset buttons after add or edit
    Private Sub ResetButtonAfterEdit()
        btnAddSave.Text = "&Add"
        btnDeleteCancel.Text = "&Delete"
        btnEdit.Enabled = True
        ToolStripStatusLabel1.Text = String.Empty
    End Sub

    Private Sub SetComboBoxBinding()
        With LastNameComboBox
            If (boolAdd Or boolEdit) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With
    End Sub

    Private Sub LastNameComboBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If (boolAdd Or boolEdit) And (e.KeyData = Keys.Escape) Then
            btnDeleteCancel_Click(sender, e)
        End If
    End Sub

    Private Sub btnAddSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSave.Click
        If btnAddSave.Text = "&Add" Then
            With ABindingSource
                .EndEdit()
                .AddNew()
            End With

            boolAdd = True
            SetComboBoxBinding()
            LastNameComboBox.Focus()
            SetControlsReadOnly(False)
            SetButtonForEdit()
            If LastNameComboBox.SelectedIndex <> -1 Then
                intPrevIndex = LastNameComboBox.Items.Count - 1
            Else
                intPrevIndex = 0
            End If
        Else
            Try
                ABindingSource.EndEdit()
                CustomerData.Update(ACustomerDataSet)
                ToolStripStatusLabel1.Text = "Record Saved"
                boolAdd = False
                boolEdit = False
                SetControlsReadOnly(True)
                ResetButtonAfterEdit()
                SetComboBoxBinding()
                LastNameComboBox.SelectedIndex = intPrevIndex
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDeleteCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteCancel.Click
        Dim drDelete As DialogResult

        Try
            If btnDeleteCancel.Text = "&Delete" Then
                drDelete = MessageBox.Show("Delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If drDelete = Windows.Forms.DialogResult.Yes Then
                    ABindingSource.RemoveCurrent()
                    CustomerData.Update(ACustomerDataSet)
                    ToolStripStatusLabel1.Text = "Record Deleted"
                End If
            Else
                If boolAdd Then
                    intPrevIndex -= 1
                End If
                ABindingSource.CancelEdit()
                boolAdd = False
                boolEdit = False
                SetControlsReadOnly(True)
                ResetButtonAfterEdit()
                LastNameComboBox.SelectedIndex = intPrevIndex
            End If
        Catch ex As Exception
            Dim strMessage As String
            strMessage = "Unable to complete the delete/cancel operation: " & ex.Message
            MessageBox.Show(strMessage, "Delete/Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        boolEdit = True
        SetControlsReadOnly(False)
        SetButtonForEdit()
        intPrevIndex = LastNameComboBox.SelectedIndex
        SetComboBoxBinding()

    End Sub

End Class