Imports System.Math
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Roots of Quadratic Equation"
        Label2.Text = "A : "
        Label3.Text = "B : "
        Label4.Text = "C : "
        Button1.Text = "Generate Roots"
        Label5.Text = " "
        Label6.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = TextBox1.Text
        Dim b As Integer = TextBox2.Text
        Dim c As Integer = TextBox3.Text
        Dim nroot As String
        Dim r1 As Decimal
        Dim r2 As Decimal
        Dim r = ((b ^ 2) - (4 * a * c))
        MsgBox(r)

        If r > 0 Then
            nroot = "2 Different Roots"
            r1 = ((-b + Math.Sqrt(r)) \ (2 * a))
            r2 = ((-b - Math.Sqrt(r)) \ (2 * a))
            Label5.Text = nroot
            Label6.Text = "Root1 : " & r1 & " Root 2 : " & r2
        ElseIf r = 0 Then
            r1 = ((-b + Math.Sqrt(r)) \ (2 * a))
            nroot = "Equal Roots"
            Label5.Text = nroot
            Label6.Text = "Root1 and Root 2 : " & r1
        Else
            nroot = "Imaginary Roots"
            Label5.Text = nroot
            Label6.Text = " "
        End If
    End Sub
End Class
