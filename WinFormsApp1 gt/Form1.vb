Imports System.Reflection.Emit
Imports System.Xml.Schema
Imports Microsoft.VisualBasic.Devices


'''
''' Calculates and displays student fee information based on selected program, level, and session.
'''
''' Provides a user interface with dropdowns for program, level, and session selection.
''' Accepts student name input.
''' Applies discounts based on selected options.
''' Displays final fee calculation in a message box.
'''
''' Includes a "Clear" button to reset form fields.
'''
''' Dependencies:
''' - System.Reflection.Emit
''' - System.Xml.Schema
''' - Microsoft.VisualBasic.Devices
'''
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Private Sub ProgramDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Programdropdown.SelectedIndexChanged
    End Sub

    Private Sub LevelDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles leveldropdown.SelectedIndexChanged
    End Sub

    Private Sub SessionDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Sessiondropdown.SelectedIndexChanged
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblprgm.Click, lblLevel.Click, lblSession.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Btn1StuInfo_Click(sender As Object, e As EventArgs) Handles Btn1StuInfo.Click

        ' Declare variables for student information and fee calculation.
        Dim course, session As String
        Dim level As Integer
        Dim Discount As Decimal
        Dim StudentName As String = TBoxNameofStu.Text


        ' Retrieve selected values from dropdowns.
        course = Programdropdown.SelectedItem
        session = Sessiondropdown.SelectedItem
        level = leveldropdown.SelectedItem

        ' Validate input fields for completeness.
        If StudentName Is "" OrElse course Is Nothing OrElse session Is Nothing OrElse level = 0 Then
            MessageBox.Show("Please mae sure you enter your name and  select an option in each field.")
            Exit Sub
        End If



        ' Apply baseFees based on Course.
        Dim baseFee As Decimal
        Select Case course
            Case "BSc. Information Technology" : baseFee = 4000
            Case "BSc. Engineering" : baseFee = 4500
            Case "Bsc. Business Administration" : baseFee = 3500
        End Select



        ' Apply discounts based on session and level.
        Dim Discount1 As Decimal
        Select Case session
            Case "Morning" : Discount1 = 0.05
            Case "Evening" : Discount1 = 0.25
            Case "Weekend" : Discount1 = 0.3
        End Select


        Dim Discount2 As Decimal
        Select Case level
            Case 100 : Discount2 = 0.1
            Case 200 : Discount2 = 0.2
            Case 300 : Discount2 = 0.3
            Case 400 : Discount2 = 0.4
        End Select

        Discount = Discount1 + Discount2
        Dim finalFee = baseFee * (1 - Discount)


        ' Format and display student information and fee calculation in a message box.
        Dim message As String = String.Format(
    "Student Name: {0}{2}" & vbCrLf &
    "Program: {3}{2}" & vbCrLf &
    "Level: {1}{2}" & "Level Discount: {9}{2}" & vbCrLf &
    "Session: {4}s" & vbCrLf &
    "Session Discount: {8}{2}" & vbCrLf &
    "Total Discount: {7}{2}" & vbCrLf &
    "Base Fee: ₵{6:#,##0.00}{2}" &
    "Final Fee: ₵{5:#,##0.00}",
    StudentName, level, vbCrLf, course, session, finalFee, baseFee, Discount, Discount1, Discount2)



        MessageBox.Show(message, "Student Information")


    End Sub

    Private Sub lblstudName_Click(sender As Object, e As EventArgs) Handles lblstudName.Click

    End Sub

    Private Sub TBoxNameofStu_TextChanged(sender As Object, e As EventArgs) Handles TBoxNameofStu.TextChanged

    End Sub

    Private Sub BtnClr_Click(sender As Object, e As EventArgs) Handles BtnClr.Click
        TBoxNameofStu.Text = ""
        Programdropdown.SelectedIndex = -1
        Sessiondropdown.SelectedIndex = -1
        leveldropdown.SelectedIndex = -1
    End Sub


End Class
