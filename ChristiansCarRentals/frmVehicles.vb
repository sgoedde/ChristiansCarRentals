'Stephanie Goedde
'eBusiness Technologies
'Christian's Car Rentals/Chapter 4a
'2-27-12

Public Class frmVehicles

    Private ADataTier As CustomerData.CustomerData
    Private ACarsDataSet As CustomerData.CarsSQLSrvrDataSet
    Private VehicleBindingSource As BindingSource
    Private CarSizeBindingSource As BindingSource

    Private Shared AnInstance As frmVehicles
    'allows only 1 instance of form in singleton design
    Public Shared ReadOnly Property Instance() As frmVehicles
        Get
            If AnInstance Is Nothing Then
                AnInstance = New frmVehicles
            End If
            Return AnInstance
        End Get
    End Property

    'closes form
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'releases instance of form
    Private Sub frmVehicles_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        AnInstance = Nothing
    End Sub

    Private Sub frmVehicles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'setup data for combo box and text boxes

        Try
            ADataTier = New CustomerData.CustomerData
            ACarsDataSet = ADataTier.GetCustomerDataSet

            'set up CarSizes binding source
            CarSizeBindingSource = New BindingSource
            With CarSizeBindingSource
                .DataSource = ACarsDataSet
                .DataMember = "CarSize"
                .Sort = "SizeCode"
            End With

            'bind form controls
            With cmbBoxCarSizes
                .DataSource = CarSizeBindingSource
                .DisplayMember = "Size"
                .ValueMember = "SizeCode"
                .DataBindings.Add("text", CarSizeBindingSource, "Size", False, DataSourceUpdateMode.Never)
            End With

            txtBxPrice.DataBindings.Add("text", CarSizeBindingSource, "DailyRate", False, DataSourceUpdateMode.Never)
            txtBxMileageRate.DataBindings.Add("text", CarSizeBindingSource, "MileageRate", False, DataSourceUpdateMode.Never)

            'clear initial contents
            cmbBoxCarSizes.SelectedIndex = -1
            txtBxPrice.Clear()
            txtBxMileageRate.Clear()

            'setup vehicle binding source
            VehicleBindingSource = New BindingSource
            With VehicleBindingSource
                .DataSource = ACarsDataSet
                .DataMember = "Vehicle"
            End With

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbBoxCarSizes_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBoxCarSizes.SelectionChangeCommitted
        'retrieve the sales info for the grid

        Dim strSize As String

        Static GridInitializedBoolean As Boolean = False

        'retrieve the size of the selection in combo box
        strSize = cmbBoxCarSizes.SelectedValue.ToString

        'initialize grid binding
        If Not GridInitializedBoolean Then
            'bind and format grid
            DataGridView1.DataSource = VehicleBindingSource
            SetUpGridColumns()
            GridInitializedBoolean = True
        End If

        VehicleBindingSource.Filter = "CarSize = '" & strSize & "'"
    End Sub

    Private Sub SetUpGridColumns()
        'set up the columns for the grid

        Try
            With DataGridView1
                .Columns!Inv_ID.Visible = False
                .Columns!CarSize.Visible = False
                .Columns!Manuf_Name.HeaderText = "Manufacturer"
                .Columns!Model.HeaderText = "Model"
            End With
        Catch ex As Exception
            MessageBox.Show("Error setting up the grid. " & ex.Message)
        End Try
    End Sub

    Private Sub txtBxPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'clear initial contents
        cmbBoxCarSizes.SelectedIndex = -1
        txtBxPrice.Clear()
        txtBxMileageRate.Clear()
    End Sub
End Class