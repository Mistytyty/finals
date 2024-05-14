Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Dim usernames As New ArrayList()
    Dim passwords As New ArrayList()

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged


        ProgressBar1.Maximum = 12

        If TextBox2.Text.Contains("A") Or TextBox2.Text.Contains("B") Or TextBox2.Text.Contains("C") Or TextBox2.Text.Contains("D") Then
            If TextBox2.Text.Length <= 12 Then
                ProgressBar1.Value = TextBox2.Text.Length
            Else
                ProgressBar1.Value = ProgressBar1.Maximum
            End If
        Else
            If TextBox2.Text.Length <= 12 Then
                ProgressBar1.Value = TextBox2.Text.Length
            Else
                ProgressBar1.Value = ProgressBar1.Maximum
            End If
        End If


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox2.Text = TextBox3.Text And ProgressBar1.Value > 11 Then
            ' Passwords match, add username and password to the ArrayLists
            usernames.Add(TextBox1.Text)
            passwords.Add(TextBox2.Text)
            MessageBox.Show("User registered successfully!")

            ' Show Form2 and pass the ArrayLists
            Dim form2Instance As New Form2(usernames, passwords)
            form2Instance.Show()

            Me.Hide()

        Else

            MessageBox.Show("Credentials ERROR")
        End If

    End Sub
    ' Function to retrieve usernames ArrayList
    Public Function GetUsernames() As ArrayList
        Return usernames
    End Function

    ' Function to retrieve passwords ArrayList
    Public Function GetPasswords() As ArrayList
        Return passwords
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = True
            TextBox3.UseSystemPasswordChar = True
            CheckBox1.Text = "show"
        ElseIf Not CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
            TextBox3.UseSystemPasswordChar = False
            CheckBox1.Text = "hide"
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
        TextBox3.UseSystemPasswordChar = True
    End Sub
End Class
