Imports System.Reflection.Emit

Public Class Form3

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Module1.Level1 = True And Module1.Level1Score > 6 Then
            Form6.Show()
            Me.Hide()
        Else
            MessageBox.Show("FINISH THE LEVEL 1 TO ACCESS LEVEL 2")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Module1.Level1 = True Then
            Form5.Show()
            Me.Hide()
        Else
            MessageBox.Show("FINISH THE LEVEL 1 (BASIC JAVA) TO ACCESS TESTING 1")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Module1.Level2 = True And Module1.Level1Score > 6 Then
            Form7.Show()
            Me.Hide()
        Else
            MessageBox.Show("FINISH THE LEVEL 2 (JAVA IF AND MULTIPLE IF OR CASE) TO ACCESS TESTING 2")
        End If
    End Sub
End Class