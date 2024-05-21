Public Class Form6
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = My.Resources.lesson2_1
        RichTextBox1.Text = "Checking Even or Odd Number
        This example checks whether a given number is even or odd.
        It uses the modulo operator % to determine if the number is divisible by 2.
        If the remainder is 0, the number is even; otherwise, it is odd.
        The if-else statement is used to print the appropriate message based on the condition."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = My.Resources.lesson2_2
        RichTextBox1.Text = " Checking Grade Based on Marks
        This example determines the grade based on the marks obtained by a student.
        It uses multiple if-else if statements to evaluate different ranges of marks and assign grades accordingly.
        Grades are assigned based on typical grading criteria, such as A for marks above 90, B for marks between 80 and 90, etc."
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = My.Resources.lesson2_3
        RichTextBox1.Text = "Checking Leap Year
        This example checks whether a given year is a leap year or not.
        It uses a combination of logical operators (&& and ||) to evaluate the conditions for leap years.
        Leap years are those that are divisible by 400 or divisible by 4 but not divisible by 100.
        The if-else statement is used to print the appropriate message based on whether the year is a leap year or not."
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = My.Resources.lesson2_4
        RichTextBox1.Text = "The variable day is initialized to the value 1.
        The switch-case statement evaluates the value of day. 
        Inside the switch block, there are two cases:
        Case 1: If the value of day is 1, it prints ""Monday"" to the console.
        Case 2: If the value of day is 2, it prints ""Tuesday"".
        There's a default case: If day does not match either case 1 or case 2, it prints ""Invalid day"".
"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox1.Image = My.Resources.lesson2_5
        RichTextBox1.Text = "It begins by checking if number is greater than 0. If true, it prints the message ""number Is positive.""
        If number is not greater than 0, it proceeds to the else if statement, where it checks if number is less than 0. If true, it prints the message ""number Is negative.""
        If neither of the above conditions is met, it executes the else block, printing the message ""number Is zero.""
        Each condition is mutually exclusive, ensuring that only one message is printed based on the value of number."

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Module1.Level2 = True
        Form3.Show()
        Me.Hide()
    End Sub
End Class