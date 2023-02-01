Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Form1.user_name
        Label2.Text = "Contact no." & Form1.phone_number
        Label3.Text = "Address :" & Form1.adress
        Label4.Text = "Email Address:" & Form1.email
        Label6.Text = "Date of Birth :  " & Form1.dob
        Label7.Text = "Gender        :   " & Form1.gender
        Label8.Text = "Nationality   :   " & Form1.nationality
        Label14.Text = Form1.course
        Label15.Text = Form1.yop
        Label16.Text = Form1.institute
        Label17.Text = Form1.grade
    End Sub


End Class