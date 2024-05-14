
Public Class Form2

    Private usernames As ArrayList
    Private passwords As ArrayList

    ' Constructor to receive ArrayLists from Form1
    Public Sub New(ByVal usernamesList As ArrayList, ByVal passwordsList As ArrayList)
        InitializeComponent()
        usernames = usernamesList
        passwords = passwordsList
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Check if username and password match
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If usernames.Contains(username) AndAlso passwords.Contains(password) Then
            MessageBox.Show("Login successful!")
            Me.Hide()
            Form3.Show()

        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.UseSystemPasswordChar = True
    End Sub
End Class