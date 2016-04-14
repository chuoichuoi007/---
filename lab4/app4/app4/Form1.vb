

Public Class Form1
    Dim ch As Boolean = True
    Dim ch1 As Boolean = True
    Dim ch2 As Boolean = True
    Dim ch3 As Boolean = True
    Dim life As Integer = 5
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Top = Label1.Top + 5
        Label2.Top = Label2.Top + 5
        Label3.Top = Label3.Top + 5
        Label4.Top = Label4.Top + 5
        Label5.Top = Label5.Top + 5
        Label6.Top = Label6.Top + 5
        Label7.Top = Label7.Top + 5

        If Label1.Top > 236 Then
            Dim a As Integer = Val(Label8.Text.ToString) - 10
            Label8.Text = a.ToString
            Label1.Top = 0
            Dim random As New Random()
            Dim num As Integer = random.Next(97, 122)
            Label7.Text = Convert.ToChar(num).ToString
            life = life - 1
            Label10.Text = life.ToString
        End If
        If (Label2.Top > 236) Then
            Dim a As Integer = Val(Label8.Text.ToString) - 10
            Label8.Text = a.ToString
            Label2.Top = 0
            Dim random As New Random()
            Dim num As Integer = random.Next(97, 122)
            Label2.Text = Convert.ToChar(num).ToString
            life = life - 1
            Label10.Text = life.ToString
        End If
        If (Label3.Top > 236) Then
            Dim a As Integer = Val(Label8.Text.ToString) - 10
            Label8.Text = a.ToString
            Label3.Top = 0
            Dim random As New Random()
            Dim num As Integer = random.Next(97, 122)
            Label3.Text = Convert.ToChar(num).ToString
            life = life - 1
            Label10.Text = life.ToString
        End If
        If (Label4.Top > 236) Then
            Dim a As Integer = Val(Label8.Text.ToString) - 10
            Label8.Text = a.ToString
            Label4.Top = 0
            Dim random As New Random()
            Dim num As Integer = random.Next(97, 122)
            Label4.Text = Convert.ToChar(num).ToString
            life = life - 1
            Label10.Text = life.ToString
        End If
        If (Label5.Top > 236) Then
            Dim a As Integer = Val(Label8.Text.ToString) - 10
            Label8.Text = a.ToString
            Label5.Top = 0
            Dim random As New Random()
            Dim num As Integer = random.Next(97, 122)
            Label5.Text = Convert.ToChar(num).ToString
            life = life - 1
            Label10.Text = life.ToString
        End If
        If (Label6.Top > 236) Then
            Dim a As Integer = Val(Label8.Text.ToString) - 10
            Label8.Text = a.ToString
            Label6.Top = 0
            Dim random As New Random()
            Dim num As Integer = random.Next(97, 122)
            Label6.Text = Convert.ToChar(num).ToString
            life = life - 1
            Label10.Text = life.ToString
        End If
        If (Label7.Top > 236) Then
            Dim a As Integer = Val(Label8.Text.ToString) - 10
            Label8.Text = a.ToString
            Label7.Top = 0
            Dim random As New Random()
            Dim num As Integer = random.Next(97, 122)
            Label7.Text = Convert.ToChar(num).ToString
            life = life - 1
            Label10.Text = life.ToString
        End If
        Dim b As Integer = Val(Label8.Text.ToString)

        If (b = 100 And ch) Then
            Timer1.Interval = Timer1.Interval - 500
            Label9.Text = "Lever 2"
            ch = False
        End If
        If (b = 200 And ch1) Then
            Timer1.Interval = Timer1.Interval - 200
            Label9.Text = "Lever 3"
            ch1 = False
        End If
        If (b = 300 And ch2) Then
            Timer1.Interval = Timer1.Interval - 100
            Label9.Text = "Lever 4"
            ch2 = False
        End If
        If (b = 400 And ch3) Then
            Timer1.Interval = Timer1.Interval - 50
            Label9.Text = "Lever 5"
            ch3 = False
        End If
        If (b < 0 Or life <= 0) Then
            Timer1.Stop()
            Label10.Text = "0"
            MessageBox.Show(Me, "Gameover", vbInformation)
        End If
    End Sub



    Private Sub Form1_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 1000
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'set toa do
        Label1.Top = 0
        Label2.Top = 35
        Label3.Top = 12
        Label4.Top = 43
        Label5.Top = 67
        Label6.Top = 27
        Label7.Top = 18
        Label8.Text = "0"

        Dim random As New Random()
        Dim num As Integer = random.Next(97, 122)
        Label1.Text = Convert.ToChar(num).ToString
        num = random.Next(97, 122)
        Label2.Text = Convert.ToChar(num).ToString
        num = random.Next(97, 122)
        Label3.Text = Convert.ToChar(num).ToString
        num = random.Next(97, 122)
        Label4.Text = Convert.ToChar(num).ToString
        num = random.Next(97, 122)
        Label5.Text = Convert.ToChar(num).ToString
        num = random.Next(97, 122)
        Label6.Text = Convert.ToChar(num).ToString
        num = random.Next(97, 122)
        Label7.Text = Convert.ToChar(num).ToString
    End Sub



    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim checker As Boolean
        checker = True

        If (e.KeyChar = Label1.Text.ToString) Then
            Dim a As Integer = Val(Label8.Text.ToString) + 10
            If checker Then
                Label8.Text = a.ToString
            End If

            Label1.Top = 0
            Dim random As New Random()
            Dim num As Integer = random.Next(97, 122)
            Label1.Text = Convert.ToChar(num).ToString
            checker = False
        End If
        If (e.KeyChar = Label2.Text.ToString) Then
            Dim a As Integer = Val(Label8.Text.ToString) + 10
            If checker Then
                Label8.Text = a.ToString
            End If
            Label2.Top = 0
            Dim random As New Random()
            Dim num As Integer = random.Next(97, 122)
            Label2.Text = Convert.ToChar(num).ToString
            checker = False
        End If
        If (e.KeyChar = Label3.Text.ToString) Then
            Dim a As Integer = Val(Label8.Text.ToString) + 10
            If checker Then
                Label8.Text = a.ToString
            End If
            Label3.Top = 0
            Dim random As New Random()
            Dim num As Integer = random.Next(97, 122)
            Label3.Text = Convert.ToChar(num).ToString
            checker = False
        End If
        If (e.KeyChar = Label4.Text.ToString) Then
            Dim a As Integer = Val(Label8.Text.ToString) + 10
            If checker Then
                Label8.Text = a.ToString
            End If
            Label4.Top = 0
            Dim random As New Random()
            Dim num As Integer = random.Next(97, 122)
            Label4.Text = Convert.ToChar(num).ToString
            checker = False
        End If
        If (e.KeyChar = Label5.Text.ToString) Then
            Dim a As Integer = Val(Label8.Text.ToString) + 10
            If checker Then
                Label8.Text = a.ToString
            End If
            Label5.Top = 0
            Dim random As New Random()
            Dim num As Integer = random.Next(97, 122)
            Label5.Text = Convert.ToChar(num).ToString
            checker = False
        End If
        If (e.KeyChar = Label6.Text.ToString) Then
            Dim a As Integer = Val(Label8.Text.ToString) + 10
            If checker Then
                Label8.Text = a.ToString
            End If
            Label6.Top = 0
            Dim random As New Random()
            Dim num As Integer = random.Next(97, 122)
            Label6.Text = Convert.ToChar(num).ToString
            checker = False
        End If
        If (e.KeyChar = Label7.Text.ToString) Then
            Dim a As Integer = Val(Label8.Text.ToString) + 10
            If checker Then
                Label8.Text = a.ToString
            End If
            Label7.Top = 0
            Dim random As New Random()
            Dim num As Integer = random.Next(97, 122)
            Label7.Text = Convert.ToChar(num).ToString
            checker = False
        End If
    End Sub

End Class
