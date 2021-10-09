' *****************************************************************
' Team Number: 49
' Team Member 1 Details: Rambaran, HR (221103747)
' Team Member 2 Details: Sekhina, HS (220021136)
' Team Member 3 Details: Muhomba, E (220058719)
' Team Member 4 Details: Moraka, BV (221076954)
' Practical: Team Project
' Class name: Employment
' *****************************************************************

Option Explicit On
Option Infer Off
Option Strict On




<Serializable()> Public Class Employment
    Inherits Factorofpoverty


    'attributes 

    Private _minimumwage As Integer
    Private _salary As Integer
    Private _numofpeopleEmployed As Integer
    Private _numpeoplueEmployed As Integer
    Private _haseducation As Boolean


    'contstructor
    Public Sub New(nameoffactor As String, populationofcountry As Integer, nameofcountry As String)


        MyBase.New(nameoffactor, populationofcountry, nameofcountry)
        nameoffactor = "Employment"

    End Sub





    'property methods


    'property method to set and retrieve the minimum wage
    Public Property minimumwage As Integer
        Get
            Return _minimumwage
        End Get
        Set(value As Integer)
            _minimumwage = value
        End Set
    End Property


    'property method to set and retrieve education status
    Public Property haseducation As Boolean
        Get
            Return _haseducation
        End Get
        Set(value As Boolean)
            _haseducation = value
        End Set
    End Property




    'property method to set and retrieve the salary 
    Public Property salary As Integer
        Get
            Return _salary
        End Get
        Set(value As Integer)
            _salary = value
        End Set
    End Property



    'property method to set and retrieve the number of people who are employed 
    Public Property numofpeopleEmployed() As Integer
        Get
            Return _numofpeopleEmployed
        End Get
        Set(value As Integer)
            _numofpeopleEmployed = value
        End Set
    End Property


    'property method to set and retrieve the number of people who are unemployed 

    Public Property numofpeopleuEmployed() As Integer
        Get
            Return _numpeoplueEmployed
        End Get
        Set(value As Integer)
            _numpeoplueEmployed = value
        End Set
    End Property


    'function to calculate the percentage of the population that is unemployed

    Public Function calcpercentageunemployed() As Double

        Dim percentage As Double

        percentage = (numofpeopleuEmployed / _populationofcountry) * 100

        Return percentage

    End Function


    'function to calculate the percentage of the population that is employed

    Public Function calcpercentangeemployed() As Double


        Dim percentage As Double

        percentage = (numofpeopleEmployed / _populationofcountry) * 100
        Return percentage

    End Function


    'function to determine if an employee is getting paid according to the UN standards 

    Public Function determinesalarystandardratio() As String

        Dim status As String

        Dim isstandard As Boolean = False

        If (_salary < minimumwage) Then
            isstandard = False
        Else
            isstandard = True
        End If


        If (isstandard = False) Then
            status = "The employee should be paid above the minimum wage"
        Else
            status = "WAGE STANDARDS MET"
        End If

        Return status

    End Function


    'overriding the offer solution method in the base class

    Public Overrides Function offersolution() As String

        Dim status As String = " "

        'resolving unemployment issue
        If (calcpercentageunemployed() < 50) Then
            status = "more jobs should be created"
        Else
            status = "The country has a stable number of people employed"
        End If

        Return status

    End Function


    Public Overloads Function display() As String

        Dim tempemployment As String = " "

        tempemployment &= MyBase.display() & Environment.NewLine

        tempemployment &= "average salary:$" & _salary & Environment.NewLine
        tempemployment &= "minimum wage:$" & _minimumwage & Environment.NewLine
        tempemployment &= "number of people employed:" & _numofpeopleEmployed & Environment.NewLine
        tempemployment &= "number of people unemployed:" & _numpeoplueEmployed & Environment.NewLine
        If haseducation = True Then
            tempemployment &= "has Education:" & "TRUE" & Environment.NewLine
        Else
            tempemployment &= "has Education:" & "FALSE" & Environment.NewLine
        End If
        tempemployment &= "minimum wage:" & CStr(determinesalarystandardratio()) & Environment.NewLine
        tempemployment &= "percentage of people employed:" & CStr(calcpercentangeemployed()) & "%" & Environment.NewLine
        tempemployment &= "percentage of people unemployed:" & CStr(calcpercentageunemployed()) & "%" & Environment.NewLine

        Return tempemployment

    End Function



End Class
