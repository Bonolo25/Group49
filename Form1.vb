' *****************************************************************
' Team Number: 49
' Team Member 1 Details: Rambaran, HR (221103747)
' Team Member 2 Details: Sekhina, HS (220021136)
' Team Member 3 Details: Muhomba, E (220058719)
' Team Member 4 Details: Moraka, BV (221076954)
' Practical: Team Project
' Class name: Form1
' *****************************************************************

Option Explicit On
Option Infer Off
Option Strict On

'importing the library to work with file streams 

Imports System.IO

'importing the library to convert data to binary and vice-versa

Imports System.Runtime.Serialization.Formatters.Binary

Public Class Form1


    Private factorsofpoverty() As Factorofpoverty 'variable to store factors of poverty
    Private numfactors As Integer 'variable to store the number of factors 
    Private numcountries As Integer 'variable to store the number of countries
    Private nameofcountry As String   'variable to store the name of the country

    Private myfileobj As FileStream 'variable to store file objects
    Private mybinaryformatter As BinaryFormatter 'variable to convert data from binary and from binary to data 



    Private Sub Btnsetup_Click(sender As Object, e As EventArgs) Handles Btnsetup.Click


        MsgBox("WELCOME")

        Dim iscontinue As Boolean = True 'variable to control try blocks
        Dim counter As Integer = 0

        Dim populationofcountry As Integer 'variable to store population of each block
        While (iscontinue = True) 'while loop will run until user inputs correct data
            Try
                numcountries = CInt(InputBox("please enter the number of countries you would like to capture data for"))
                numfactors = CInt(InputBox("how many factors would you like to capture data for?"))

                While (counter < 1)
                    If (numfactors <= 0) Then
                        MsgBox("factors cannot be less than 1")
                        numfactors = CInt(InputBox("how many factors would you like to capture data for,for each country?"))
                        counter -= 1
                    ElseIf (numfactors > 2) Then
                        MsgBox("program handles a maximum of 2 factors of poverty")
                        numfactors = CInt(InputBox("how many factors would you like to capture data for?"))
                        counter -= 1
                    Else
                        counter += 1
                    End If
                End While
                iscontinue = False 'while loop exits if the correct data is input
            Catch entryexp As Exception
                MsgBox("only enter integer values")
                iscontinue = True 'while loop continues to run if incorrect data is provided 
            End Try
        End While



        ReDim Preserve factorsofpoverty(numfactors) 'resizing the factor array 





        Dim choice As Integer
        For c As Integer = 1 To numcountries
            nameofcountry = InputBox("please enter the name of country" & " " & c)
            populationofcountry = CInt(InputBox("please enter the population of  country" & "" & c))
            For f As Integer = 1 To numfactors
                choice = CInt(InputBox("please select the factor of poverty you would like to work with" & Environment.NewLine & "1 for employment" & Environment.NewLine & "2 for food security" & Environment.NewLine))
                Select Case choice
                    Case 1
                        Dim nameoffactor As String = "EMPLOYMENT"
                        Dim employment As Employment
                        employment = New Employment(nameoffactor, populationofcountry, nameofcountry) 'instatiating the employment object
                        employment.salary = CInt(InputBox("please enter the average salary for the country"))
                        employment.numofpeopleuEmployed = CInt(InputBox("please enter the number of people unemployed in the country"))
                        employment.numofpeopleEmployed = CInt(InputBox("please enter the number of people employed in the country"))
                        employment.minimumwage = CInt(InputBox("please enter the minimum wage as stipulated by the UN"))
                        employment.haseducation = CBool(InputBox("state whether the majority of the country is educated" & "1 for true" & " " & "0 for false"))
                        employment.calcpercentageunemployed()
                        employment.calcpercentangeemployed()
                        employment.determinesalarystandardratio()

                        factorsofpoverty(f) = employment 'upcasting employment into factor of poverty

                    Case 2

                        Dim nameoffactor As String = "food security"
                        Dim foodsecurity As foodsecurity
                        foodsecurity = New foodsecurity(nameoffactor, populationofcountry, nameofcountry) 'instatianting the food security object
                        foodsecurity.hasstablemeal = CBool(InputBox("does families  have access to a meal:" & "1 for true and 0 for false"))
                        foodsecurity.numoffamilymembers = CInt(InputBox("please enter the average  number of family members in the country"))
                        foodsecurity.numofpeopleundernourished = CInt(InputBox("Enter the number of undernourished people in the country"))
                        foodsecurity.determinepercpopulationundernourished()
                        foodsecurity.determinemealstability()

                        factorsofpoverty(f) = foodsecurity 'upcasting foodsecurity into the  factorofpoverty  object

                End Select

                factorsofpoverty(f).offersolution() 'polymorphism

                'Downcasting and displaying
                Dim objEmployment As Employment  'variable to store employment object
                objEmployment = TryCast(factorsofpoverty(f), Employment) 'downcast object of type base class into employment type
                If Not (objEmployment Is Nothing) Then  'check whether the object is not a null pointer
                    txtdisplay.Text &= objEmployment.display() & Environment.NewLine
                End If

                Dim objFoodSecurity As foodsecurity 'variable to store the food security obj
                objFoodSecurity = TryCast(factorsofpoverty(f), foodsecurity) 'downcast obj of type factorofpoverty into foody
                If Not (objFoodSecurity Is Nothing) Then 'check whether the variable is not a null pointer 
                    txtdisplay.Text &= objFoodSecurity.display() & Environment.NewLine
                End If
            Next
        Next

    End Sub



    'saving objects to the file
    Private Sub Btnsavetofile_Click(sender As Object, e As EventArgs) Handles Btnsavetofile.Click


        myfileobj = New FileStream("group49.txt", FileMode.Create, FileAccess.Write) ' opening the file obj
        mybinaryformatter = New BinaryFormatter() 'allocate memory for the binary formater obj
        For f As Integer = 1 To numfactors
            mybinaryformatter.Serialize(myfileobj, factorsofpoverty(f)) 'convert from data to binary
        Next

        myfileobj.Close() 'closing the file obj

    End Sub


    'sub to read data from file
    Private Sub Btnreadfromfile_Click(sender As Object, e As EventArgs) Handles Btnreadfromfile.Click


        txtdisplay.Clear()

        myfileobj = New FileStream("group49.txt", FileMode.Open, FileAccess.Read) 'opening the file obj

        mybinaryformatter = New BinaryFormatter()

        While myfileobj.Position < myfileobj.Length
            Dim _factorofpoverty As Factorofpoverty
            _factorofpoverty = DirectCast(mybinaryformatter.Deserialize(myfileobj), Factorofpoverty)

            'Downcasting and displaying
            Dim objEmployment As Employment
            objEmployment = TryCast(_factorofpoverty, Employment)
            If Not (objEmployment Is Nothing) Then
                txtdisplay.Text &= objEmployment.display() & Environment.NewLine
            End If

            Dim objFoodSecurity As foodsecurity
            objFoodSecurity = TryCast(_factorofpoverty, foodsecurity)
            If Not (objFoodSecurity Is Nothing) Then
                txtdisplay.Text &= objFoodSecurity.display() & Environment.NewLine
            End If
        End While

        myfileobj.Close() ' closing the file object 

    End Sub
End Class
