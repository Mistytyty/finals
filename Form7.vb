Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form7

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox4.Checked = False
            CheckBox4.Checked = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub

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

        Module1.Level2Score = 0

        RichTextBox1.Text = "Question 1:  What keyword is used to initiate an if statement in Java?"
        GroupBox1.Visible = True
        CheckBox1.Text = "A) if"
        CheckBox2.Text = "B) when"
        CheckBox3.Text = "C) check"
        CheckBox4.Text = "D) switch"

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False

        Button1.Visible = False
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True Then
            Module1.Level2Score += 1
        End If

        RichTextBox1.Text = "Question 2: In Java, what keyword is used to execute a block of code if the condition in an if statement is false?"

        CheckBox1.Text = "A) elseif"
        CheckBox2.Text = "B) else"
        CheckBox3.Text = "C) otherwise"
        CheckBox4.Text = "D) or"

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False

        Button2.Visible = False
        Button3.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CheckBox2.Checked = True Then
            Module1.Level2Score += 1
        End If

        RichTextBox1.Text = "Question 3: How many conditions can be tested using multiple if statements in Java?"

        CheckBox1.Text = "A) One"
        CheckBox2.Text = "B) Two or more"
        CheckBox3.Text = "C) Three"
        CheckBox4.Text = "D) None"

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False

        Button3.Visible = False
        Button4.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CheckBox2.Checked = True Then
            Module1.Level2Score += 1
        End If

        RichTextBox1.Text = "Question 4: What is the main difference between if-else-if ladder and switch-case in Java?"

        CheckBox1.Text = "A) Sequential evaluation"
        CheckBox2.Text = "B) Single condition"
        CheckBox3.Text = "C) Integer-only"
        CheckBox4.Text = "D) Efficiency"

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False

        Button4.Visible = False
        Button5.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If CheckBox1.Checked = True Then
            Module1.Level2Score += 1
        End If

        RichTextBox1.Text = "Question 5: Which keyword is used to initiate a switch statement in Java?"

        CheckBox1.Text = "A) case"
        CheckBox2.Text = "B) choose"
        CheckBox3.Text = "C) switch"
        CheckBox4.Text = "D) select"

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False

        Button5.Visible = False
        Button6.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If CheckBox3.Checked = True Then
            Module1.Level2Score += 1
        End If

        RichTextBox1.Text = "Question 6: What happens if the break statement is omitted in a switch-case statement in Java?"

        CheckBox1.Text = "A) Error"
        CheckBox2.Text = "B) Exception"
        CheckBox3.Text = "C) Fallthrough"
        CheckBox4.Text = "D) Loop"

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False

        Button6.Visible = False
        Button8.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If CheckBox3.Checked = True Then
            Module1.Level2Score += 1
        End If

        RichTextBox1.Text = "Question 7: In a switch-case statement in Java, which data types are supported for the switch expression?"

        CheckBox1.Text = "A) int, long, float, double"
        CheckBox2.Text = "B) char, String, int, enum"
        CheckBox3.Text = "C)  boolean, int, double, String"
        CheckBox4.Text = "D) All data types are supported"

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False

        Button8.Visible = False
        Button9.Visible = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If CheckBox2.Checked = True Then
            Module1.Level2Score += 1
        End If

        RichTextBox1.Text = "Question 8: What will be the output of the following code snippet?

   ```java
   int x = 5;
   int y = 10;
   if (x > y) {
       System.out.println(""x is greater than y"");
   } else {
       System.out.println(""x is less than or equal to y"");
   }
   ```"

        CheckBox1.Text = "A) x is greater than y"
        CheckBox2.Text = "B) x is less than y"
        CheckBox3.Text = "C) x is less than or equal to y"
        CheckBox4.Text = "D) x is greater than or equal to y"

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False

        Button9.Visible = False
        Button10.Visible = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If CheckBox3.Checked = True Then
            Module1.Level2Score += 1
        End If

        RichTextBox1.Text = "Question 9: Which statement is true regarding conditionals in Java?"

        CheckBox1.Text = "A) Boolean requirement"
        CheckBox2.Text = "B) Primitive type flexibility"
        CheckBox3.Text = "C) Data type inclusivity"
        CheckBox4.Text = "D) Integer necessity"

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False

        Button10.Visible = False
        Button11.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If CheckBox1.Checked = True Then
            Module1.Level2Score += 1
        End If

        RichTextBox1.Text = "Question 10: When should a switch-case statement be preferred over multiple if-else statements in Java?"

        CheckBox1.Text = "A) Multi-condition scenarios"
        CheckBox2.Text = "B) Unique condition values"
        CheckBox3.Text = "C) Interconnected conditions"
        CheckBox4.Text = "D) Floating-point comparisons"

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False

        Button11.Visible = False
        Button12.Visible = True


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If CheckBox2.Checked = True Then
            Module1.Level2Score += 1
        End If

        RichTextBox1.Text = ""

        CheckBox1.Text = ""
        CheckBox2.Text = ""
        CheckBox3.Text = ""
        CheckBox4.Text = ""

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False

        If Module1.Level2Score > 6 Then
            Dim result As DialogResult = MessageBox.Show("You have completed LEVEL 2." & vbCrLf & "Do you want to proceed with LEVEL 3?" & vbCrLf & "TESTING 2 Score: " & Module1.Level2Score, "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Form6.Show()
                Me.Hide()
            Else
                Form3.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("You FAILED LEVEL 2.")
            Module1.Level2Score = 0
            Form3.Show()
            Me.Hide()
        End If

        Button12.Visible = False
        Button1.Visible = True
    End Sub

End Class