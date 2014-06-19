'Stephanie Goedde
'eBusiness Technologies
'Christian's Car Rental/Chapter 2a
'2-6-12

Public Class DiscountAccounts
    Inherits Standard

    Private Const DEC_CORPORATE_DISCOUNT As Decimal = 0.95D
    Private Const DEC_INSURANCE_DISCOUNT As Decimal = 0.9D

    Public Sub New(ByVal decDays As Decimal, ByVal decBegMiles As Decimal, ByVal decEndMiles As Decimal, ByVal intSize As Integer, ByVal boolCorporate As Boolean, ByVal boolInsurance As Boolean)
        MyBase.New(decDays, decBegMiles, decEndMiles, intSize, boolCorporate, boolInsurance)

    End Sub

    Protected Overrides Sub FindCost()
        Dim decAverageMileage As Decimal

        'calls inherited method to get values per car type
        MyBase.FindValues()

        'finds average miles traveled per day
        decAverageMileage = decTotalMiles / decDays

        'determines if corporate or insurance boxes checked and calculates discount accordingly
        If boolInsurance = True And boolCorporate = False Then
            If decAverageMileage < DEC_AVERAGE_MILEAGE Then
                decCost = (decSizeRate * DEC_INSURANCE_DISCOUNT) * decDays
            Else
                decCost = ((decSizeRate * DEC_INSURANCE_DISCOUNT) * decDays) + (decMileageRate * decTotalMiles)
            End If
        ElseIf boolInsurance = False And boolCorporate = True Then
            decCost = (decSizeRate * decDays) * DEC_CORPORATE_DISCOUNT
        Else
            decCost = ((decSizeRate * DEC_INSURANCE_DISCOUNT) * decDays) * DEC_CORPORATE_DISCOUNT
        End If

    End Sub
End Class
