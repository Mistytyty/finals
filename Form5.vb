Public Class Form5
    Private endTime As DateTime

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        endTime = DateTime.Now.AddMinutes(20)
        Button1.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim remainingTime As TimeSpan = endTime.Subtract(DateTime.Now)

        Label1.Text = String.Format("{0:00}:{1:00}:{2:00}", remainingTime.Hours, remainingTime.Minutes, remainingTime.Seconds)

        If remainingTime <= TimeSpan.Zero Then
            Timer1.Stop()
            MessageBox.Show("Times up!")
            Me.Hide()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()

        Module1.Level1Score = 0

        RichTextBox1.Text = "Question 1: The line System.out.println(""Hello, world!""); in the code prints the string ""Hello, world!"" to the console. True or False?"
        GroupBox1.Visible = True
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Button1.Visible = False
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            Module1.Level1Score += 1
        End If

        RichTextBox1.Text = "Question 2: The line int number = 10; declares an integer variable named number and initializes it with the value 10. True or False?"
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Button2.Visible = False
        Button3.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton1.Checked = True Then
            Module1.Level1Score += 1
        End If

        RichTextBox1.Text = "Question 3: The line String message = ""Hello, Java!""; declares a string variable named message and initializes it with the value ""Hello, Java!"". True or False?"

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Button3.Visible = False
        Button4.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If RadioButton1.Checked = True Then
            Module1.Level1Score += 1
        End If

        RichTextBox1.Text = "Question 4: The line System.out.println(message); prints the value of the message variable to the console. True or False?"

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Button4.Visible = False
        Button5.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If RadioButton1.Checked = True Then
            Module1.Level1Score += 1
        End If

        RichTextBox1.Text = "Question 5: The line System.out.println(""The number is: "" + number); prints the concatenated string ""The number is: "" followed by the value of the number variable to the console. True or False?"

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Button5.Visible = False
        Button6.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If RadioButton2.Checked = True Then
            Module1.Level1Score += 1
        End If

        RichTextBox1.Text = "Question 6: The code in the IfElseExample class checks if the value of the number variable is less than 10. If it is, it prints ""Number is less than 10"" to the console. True or False?"

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Button6.Visible = False
        Button8.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If RadioButton1.Checked = True Then
            Module1.Level1Score += 1
        End If

        RichTextBox1.Text = "Question 7: The code in the ForLoopExample class prints the value of the i variable along with the string ""Count is: "" to the console five times. True or False?"

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Button8.Visible = False
        Button9.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If RadioButton1.Checked = True Then
            Module1.Level1Score += 1
        End If

        RichTextBox1.Text = "Question 8: The code in the WhileLoopExample class prints the value of the count variable along with the string ""Count is: "" to the console five times. True or False?"

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Button9.Visible = False
        Button10.Visible = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If RadioButton1.Checked = True Then
            Module1.Level1Score += 1
        End If

        RichTextBox1.Text = "Question 9: The System.out.println() statement is used to print information to the console in Java. True or False?"

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Button10.Visible = False
        Button11.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If RadioButton1.Checked = True Then
            Module1.Level1Score += 1
        End If

        RichTextBox1.Text = "Question 10: The main() method is the entry point of a Java application and is mandatory in a Java program. True or False?"

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Button11.Visible = False
        Button12.Visible = True


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If RadioButton1.Checked = True Then
            Module1.Level1Score += 1
        End If

        RichTextBox1.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        If Module1.Level1Score > 6 Then
            Dim result As DialogResult = MessageBox.Show("You have completed LEVEL 1." & vbCrLf & "Do you want to proceed with LEVEL 2?" & vbCrLf & "TESTING 1 Score: " & Module1.Level1Score, "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Form6.Show()
                Me.Hide()
            Else
                Form3.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("You FAILED LEVEL 1.")
            Module1.Level1Score = 0
            Form3.Show()
            Me.Hide()
        End If

        Button12.Visible = False
        Button1.Visible = True
    End Sub
End Class