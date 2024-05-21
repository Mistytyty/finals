Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = My.Resources.review1
        RichTextBox1.Text = "System.out.println(Hello, world!);: This line prints the string Hello, world! to the console. System.out is an object that represents the standard output stream, and println is a method of this object used to print a string followed by a newline.
                            "
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = My.Resources.review2
        RichTextBox1.Text = "Explanation:
        int number = 10;: Declares an integer variable named number and initializes it with the value 10.
        String message = Hello, Java!;: Declares a string variable named message and initializes it with the value Hello, Java!.
        System.out.println(message);: Prints the value of the message variable to the console.
        System.out.println(The number is:  + number);: Prints the concatenated string The number is:  followed by the value of the number variable to the console."
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = My.Resources.review3
        RichTextBox1.Text = "Explanation:
        if (number < 10) { ... } else { ... }: Checks if the value of the number variable is less than 10. If it is, the code inside the curly braces after if is executed. Otherwise, the code inside the curly braces after else is executed.
        In this example, since number is 20, the condition number < 10 evaluates to false, so the code inside the else block is executed, printing Number is greater than or equal to 10 to the console."
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = My.Resources.review4
        RichTextBox1.Text = "Explanation:
        for (int i = 1; i <= 5; i++) { ... }: Initializes a variable i to 1, executes the loop body as long as i is less than or equal to 5, and increments i by 1 after each iteration.
        Inside the loop body, the value of i is printed along with the string Count Is: ."
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox1.Image = My.Resources.review5
        RichTextBox1.Text = "Explanation:
        while (count <= 5) { ... }: Executes the loop body as long as the condition count <= 5 is true.
        Inside the loop body, the value of count is printed along with the string Count Is: . Then, count is incremented by 1. "
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Module1.Level1 = True
        Form3.Show()
        Me.Hide()
    End Sub
End Class