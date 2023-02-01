Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Public user_name As String
    Public age As Byte
    Public gender As Char
    Public dob As Date
    Public phone_number As Long
    Public email As String
    Public nationality As String
    Public adress As String
    Public course As String
    Public institute As String
    Public yop As Date
    Public grade As Integer

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        gender = RadioButton1.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        gender = RadioButton2.Text
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        gender = RadioButton3.Text
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        user_name = TextBox1.Text

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox10.Text = "Name:" & user_name & vbNewLine & "Age : " & age & vbNewLine & "Gender:" & gender & vbNewLine & "DOB" & dob & vbNewLine & "Phone no" & phone_number & vbNewLine & "Email :" & email & vbNewLine & "Nationality :" & nationality & vbNewLine & "Address :" & adress & vbNewLine & "Course :" & course & vbNewLine & "Institute:" & institute & vbNewLine & "Year of Passing:" & yop & vbNewLine & "Grade:" & grade
        Label16.Text = "Name:" & user_name
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        age = TextBox2.Text
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        dob = DateTimePicker1.Value

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        phone_number = TextBox4.Text
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        email = TextBox5.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        nationality = TextBox3.Text
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        adress = TextBox6.Text
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        course = TextBox8.Text
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        institute = TextBox7.Text
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        yop = DateTimePicker2.Value
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        grade = TextBox9.Text
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Me.Hide()
        Form2.Show()

    End Sub


End Class


