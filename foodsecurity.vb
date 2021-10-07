' *****************************************************************
' Team Number: 49
' Team Member 1 Details: Rambaran, HR (221103747)
' Team Member 2 Details: Sekhina, HS (220021136)
' Team Member 3 Details: Muhomba, E (220058719)
' Team Member 4 Details: Moraka, BV (221076954)
' Practical: Team Project
' Class name: foodsecurity
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off



<Serializable()> Public Class foodsecurity
    Inherits Factorofpoverty

    'attributes

    Private _numofpeopleundernourished As Integer
    Private _hasaccesstoland As Boolean
    Private _hasstablemeal As Boolean
    Private _numfamilymember As Integer

    Public Sub New(nameoffactor As String, poplationofcountry As Integer, nameofcountry As String)

        MyBase.New(nameoffactor, poplationofcountry, nameofcountry)
        nameoffactor = "foodsecurity"

    End Sub



    'property methods


    'property method to set and retrieve the number of people undernourished 
    Public Property numofpeopleundernourished As Integer
        Get
            Return _numofpeopleundernourished
        End Get
        Set(value As Integer)
            _numofpeopleundernourished = value
        End Set
    End Property


    'property method to set the numoffamilymembers and retrieve the number of family members
    Public Property numoffamilymembers As Integer
        Get
            Return _numfamilymember
        End Get
        Set(value As Integer)
            _numfamilymember = value
        End Set
    End Property


    'property method to set the land ownership status and retrieve the land ownership status
    Public Property hasaccesstoland As Boolean
        Get
            Return _hasaccesstoland
        End Get
        Set(value As Boolean)
            _hasaccesstoland = value
        End Set
    End Property

    'property method set access to meal and retrieve access to meals
    Public Property hasstablemeal As Boolean
        Get
            Return _hasstablemeal
        End Get
        Set(value As Boolean)
            _hasstablemeal = value
        End Set
    End Property


    'function to determine the percentage  of people  who are undernourished
    Public Function determinepercpopulationundernourished() As Double

        Dim percentage As Double

        percentage = (_numofpeopleundernourished / _populationofcountry) * 100

        Return percentage

    End Function


    'overrding the solution method in the base class
    Public Overrides Function offersolution() As String

        Dim status As String = " "

        If (determinepercpopulationundernourished() < 50) Then
            status = "provide food parcels to people"
        Else
            status = "nourishment  meets standards"
        End If

        If (_hasstablemeal = False) Then
            status = "UN should supply food"
        Else
            status = "more NGO should fundraise to support families"
        End If

        Return status

    End Function


    'overriding the display method

    Public Overloads Function display() As String

        Dim tempfoodsecurity As String = " "

        tempfoodsecurity &= MyBase.display() & Environment.NewLine

        tempfoodsecurity &= "number of people undernourished:" & _numofpeopleundernourished & Environment.NewLine
        If (_hasstablemeal = True) Then
            tempfoodsecurity &= "has stable meal:" & "true" & Environment.NewLine
        Else
            tempfoodsecurity &= "has stable meal:" & "false" & Environment.NewLine
        End If

        If (_hasaccesstoland = True) Then
            tempfoodsecurity &= "Has access to land:" & "true" & Environment.NewLine
        Else
            tempfoodsecurity &= "Has access to land:" & "false" & Environment.NewLine
        End If

        tempfoodsecurity &= "Number of family member:" & _numfamilymember & Environment.NewLine

        tempfoodsecurity &= "percentage of undernourished people:" & CStr(determinepercpopulationundernourished()) & "%" & Environment.NewLine


        Return tempfoodsecurity

    End Function



End Class
