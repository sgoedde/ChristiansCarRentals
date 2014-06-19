'Stephanie Goedde
'eBusiness Technologies
'Christian's Car Rentals/Chapter 5a
'3-8-12

Public Class CustomerData
    Private ACustomerTableAdapter As CarsSQLSrvrDataSetTableAdapters.CustomerTableAdapter
    Private ACustomerDataSet As CarsSQLSrvrDataSet
    Private AVehicleTableAdapter As CarsSQLSrvrDataSetTableAdapters.VehicleTableAdapter
    Private ACarSizeTableAdapter As CarsSQLSrvrDataSetTableAdapters.CarSizeTableAdapter

    'fill and return the data set
    Public Function GetCustomerDataSet() As CarsSQLSrvrDataSet
        Try
            ACustomerTableAdapter = New CarsSQLSrvrDataSetTableAdapters.CustomerTableAdapter
            ACustomerDataSet = New CarsSQLSrvrDataSet
            AVehicleTableAdapter = New CarsSQLSrvrDataSetTableAdapters.VehicleTableAdapter
            ACarSizeTableAdapter = New CarsSQLSrvrDataSetTableAdapters.CarSizeTableAdapter

            ACustomerTableAdapter.Fill(ACustomerDataSet.Customer)
            AVehicleTableAdapter.Fill(ACustomerDataSet.Vehicle)
            ACarSizeTableAdapter.Fill(ACustomerDataSet.CarSize)

            Return ACustomerDataSet

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Update(ByVal ADataSet As CarsSQLSrvrDataSet) As Boolean
        Try
            ACustomerTableAdapter.Update(ADataSet)

            Return True
        Catch ex As Exception
            Return False
            Throw ex
        End Try
    End Function

End Class
