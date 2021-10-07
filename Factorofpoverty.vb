' *****************************************************************
' Team Number: 49
' Team Member 1 Details: Rambaran, HR (221103747)
' Team Member 2 Details: Sekhina, HS (220021136)
' Team Member 3 Details: Muhomba, E (220058719)
' Team Member 4 Details: Moraka, BV (221076954)
' Practical: Team Project
' Class name: Factorofpoverty
' *****************************************************************

Option Explicit On
Option Strict On
Option Infer Off


<Serializable()> Public MustInherit Class Factorofpoverty


    'attributes 

    Protected _nameofcountry As String
    Protected _populationofcountry As Integer
    Protected _nameoffactor As String
    Protected people() As Integer



    Public Sub New(nameoffactor As String, populationofcountry As Integer, nameofcountry As String)
        _nameoffactor = nameoffactor
        _nameofcountry = nameofcountry
        _populationofcountry = populationofcountry



    End Sub


    'property methods 

    Public Property nameofcountry As String
        Get
            Return _nameofcountry
        End Get
        Set(value As String)
            _nameofcountry = value
        End Set
    End Property

    Public Property populationofcountry As Integer
        Get
            Return _populationofcountry
        End Get
        Set(value As Integer)
            _populationofcountry = value
        End Set
    End Property



    Public Property nameoffactor As String
        Get
            Return _nameoffactor
        End Get
        Set(value As String)
            _nameoffactor = value
        End Set
    End Property


    'polymorphic method


    Public MustOverride Function offersolution() As String


    Public Function display() As String

        Dim tempfactpoverty As String = " "

        tempfactpoverty &= "name of country:" & _nameofcountry & Environment.NewLine
        tempfactpoverty &= "population of country:" & _populationofcountry & Environment.NewLine
        tempfactpoverty &= "Poverty factor:" & _nameoffactor & Environment.NewLine
        tempfactpoverty &= "solution to problem:" & CStr(offersolution()) & Environment.NewLine

        Return tempfactpoverty


    End Function



End Class
