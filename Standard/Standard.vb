
'Stephanie Goedde
'eBusiness Technologies
'Christian's Car Rental/Chapter 2a
'2-6-12

'sets radio buttons to integer values
Public Enum SelectionType
    Compact
    Mid
    Luxury
End Enum

Public Class Standard

    Protected decDays As Decimal
    Protected decBegMiles As Decimal
    Protected decEndMiles As Decimal
    Protected decCost As Decimal
    Protected decTotalMiles As Decimal
    Protected intSize As Integer
    Protected decSizeRate As Decimal
    Protected decMileageRate As Decimal
    Protected boolCorporate As Boolean
    Protected boolInsurance As Boolean

    Protected Const DEC_COMPACT_DAILY As Decimal = 26.95D
    Protected Const DEC_MID_DAILY As Decimal = 32.95D
    Protected Const DEC_LUXURY_DAILY As Decimal = 50.95D
    Protected Const DEC_COMPACT_MILEAGE As Decimal = 0.12D
    Protected Const DEC_MID_MILEAGE As Decimal = 0.15D
    Protected Const DEC_LUXURY_MILEAGE As Decimal = 0.2D
    Protected Const DEC_AVERAGE_MILEAGE As Decimal = 100D

    'constructor
    Sub New(ByVal decDays As Decimal, ByVal decBegMiles As Decimal, ByVal decEndMiles As Decimal, ByVal intSize As Integer, ByVal boolCorporate As Boolean, ByVal boolInsurance As Boolean)

        Me.Days = decDays
        Me.BegMiles = decBegMiles
        Me.EndMiles = decEndMiles
        Me.Size = intSize
        Me.BCorporate = boolCorporate
        Me.BInsurance = boolInsurance
        FindCost() 'calls main method to determine cost
    End Sub

    Protected Overridable Sub FindCost()
        Dim decAverageMileage As Decimal

        FindValues() 'calls method to set values per car type selected

        'calculates average miles traveled per day
        decAverageMileage = decTotalMiles / decDays

        'determines if average mileage above 100 and calculates accordingly
        If decAverageMileage < DEC_AVERAGE_MILEAGE Then
            decCost = decSizeRate * decDays
        Else
            decCost = (decSizeRate * decDays) + (decMileageRate * decTotalMiles)
        End If


    End Sub

    Protected Sub FindValues()

        'set proper variables according to car size chosen in gui
        Select Case intSize
            Case SelectionType.Compact
                decSizeRate = DEC_COMPACT_DAILY
                decMileageRate = DEC_COMPACT_MILEAGE
            Case SelectionType.Mid
                decSizeRate = DEC_MID_DAILY
                decMileageRate = DEC_MID_MILEAGE
            Case SelectionType.Luxury
                decSizeRate = DEC_LUXURY_DAILY
                decMileageRate = DEC_LUXURY_MILEAGE
        End Select

        'calculate total miles driven
        decTotalMiles = decEndMiles - decBegMiles

    End Sub

    Public Property Days() As Decimal
        Get
            Return decDays
        End Get
        Set(ByVal value As Decimal)
            'if less than 0 will throw exception and set focus to txtBxDays
            If value > 0 Then
                decDays = value
            Else
                Dim Ex As New ApplicationException("Number of days of must be greater than zero.")
                Ex.Source = "Days"
                Throw Ex
            End If
        End Set
    End Property

    Public Property BegMiles() As Decimal
        Get
            Return decBegMiles
        End Get
        Set(ByVal value As Decimal)
            decBegMiles = value
        End Set
    End Property

    Public Property EndMiles() As Decimal
        Get
            Return decEndMiles
        End Get
        Set(ByVal value As Decimal)
            decEndMiles = value
        End Set
    End Property

    Public Property Size() As Integer
        Get
            Return intSize
        End Get
        Set(ByVal value As Integer)
            intSize = value
        End Set
    End Property

    Public Property Cost() As Decimal
        Get
            Return decCost
        End Get
        Set(ByVal value As Decimal)
            decCost = value
        End Set
    End Property

    Public Property BCorporate As Boolean
        Get
            Return boolCorporate
        End Get
        Set(ByVal value As Boolean)
            boolCorporate = value
        End Set
    End Property

    Public Property BInsurance As Boolean
        Get
            Return boolInsurance
        End Get
        Set(ByVal value As Boolean)
            boolInsurance = value
        End Set
    End Property

End Class

