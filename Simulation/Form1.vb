Public Class Form1

   
    
    Private Sub btnup_Click(sender As Object, e As EventArgs)

       

    End Sub

    Private Sub btndown_Click(sender As Object, e As EventArgs)

       

    End Sub

    Private Sub upTimer_Tick(sender As Object, e As EventArgs)

        'Label.Location = New Point(Label.Location.X, Label.Location.Y - 1)
        ' If Label.Location.Y = 95 Then upTimer.Enabled = False

    End Sub

    Private Sub downTimer_Tick(sender As Object, e As EventArgs)

        ' Label.Location = New Point(Label.Location.X, Label.Location.Y + 1)
        'If Label.Location.Y = 225 Then downTimer.Enabled = False

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click

        'to close the app

        Dim returndialogresult As System.Windows.Forms.DialogResult
        Dim title As String = "Sure to exit"
        Dim message As String = "Do you want to exit?"

        returndialogresult = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If returndialogresult = Windows.Forms.DialogResult.Yes Then

            Me.Close()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblslimsoft.Click

    End Sub

    Private Sub slimTimer_Tick(sender As Object, e As EventArgs) Handles slimTimer.Tick

        lblslimsoft.Left = lblslimsoft.Left + 2

        If lblslimsoft.Left > Me.Width Then
            lblslimsoft.Left = 0
        End If

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Timer1.Enabled = True
        Label.Text = "First Floor"
        Label.ForeColor = Color.Green



        btn2.Enabled = True       
        btn3.Enabled = True
        Button3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True

        Button1.Enabled = False
        btn1.Enabled = False
        Button2.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label.Location = New Point(Label.Location.X, Label.Location.Y - 1)
        If Label.Location.Y = 210 Then Timer1.Enabled = False

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        Label.Location = New Point(Label.Location.X, Label.Location.Y - 1)
        If Label.Location.Y = 95 Then Timer5.Enabled = False

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click

        Timer5.Enabled = True
        Label.Text = "Fifth Floor"
        Label.ForeColor = Color.Green

        btn5.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True

        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False




    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click

        Timer4.Enabled = True
        Label.Text = "Fourth Floor"
        Label.ForeColor = Color.Green

        btn5.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True

        Button1.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False




    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label.Location = New Point(Label.Location.X, Label.Location.Y - 1)
        If Label.Location.Y = 130 Then Timer4.Enabled = False
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click

        Timer3.Enabled = True
        Label.Text = "Third Floor"
        Label.ForeColor = Color.Green

        btn4.Enabled = True
        btn5.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button5.Enabled = True

        btn3.Enabled = False
        Button1.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        Button4.Enabled = False




    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label.Location = New Point(Label.Location.X, Label.Location.Y - 1)
        If Label.Location.Y = 155 Then Timer3.Enabled = False
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        Timer2.Enabled = True
        Label.Text = "Second Floor"
        Label.ForeColor = Color.Green

        Button2.Enabled = True
        Button3.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True

        Button1.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label.Location = New Point(Label.Location.X, Label.Location.Y - 1)
        If Label.Location.Y = 187 Then Timer2.Enabled = False
    End Sub

    Private Sub Timerd1_Tick(sender As Object, e As EventArgs) Handles Timerd1.Tick
        Label.Location = New Point(Label.Location.X, Label.Location.Y + 1)
        If Label.Location.Y = 243 Then Timerd1.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timerd1.Enabled = True
        Label.Text = "Last Floor"
        Label.ForeColor = Color.RoyalBlue

        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True


        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False

    End Sub

    Private Sub Timerd2_Tick(sender As Object, e As EventArgs) Handles Timerd2.Tick
        Label.Location = New Point(Label.Location.X, Label.Location.Y + 1)
        If Label.Location.Y = 213 Then Timerd2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timerd2.Enabled = True
        Label.Text = "First Floor"
        Label.ForeColor = Color.RoyalBlue

        btn2.Enabled = True
        Button3.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True


        Button1.Enabled = False
        btn1.Enabled = False
        Button2.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Timer3d.Enabled = True
        Label.Text = "Second Floor"
        Label.ForeColor = Color.RoyalBlue

        Button2.Enabled = True
        Button3.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True


        Button1.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False

    End Sub

    Private Sub Timer3d_Tick(sender As Object, e As EventArgs) Handles Timer3d.Tick
        Label.Location = New Point(Label.Location.X, Label.Location.Y + 1)
        If Label.Location.Y = 190 Then Timer3d.Enabled = False
    End Sub

    Private Sub Timer3f_Tick(sender As Object, e As EventArgs) Handles Timer3f.Tick

        Label.Location = New Point(Label.Location.X, Label.Location.Y + 1)
        If Label.Location.Y = 167 Then Timer3f.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Timer3f.Enabled = True
        Label.Text = "Third Floor"
        Label.ForeColor = Color.RoyalBlue

        Button2.Enabled = True
        Button3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        Button5.Enabled = True

        Button1.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        Button4.Enabled = False


    End Sub

    Private Sub Timer4f_Tick(sender As Object, e As EventArgs) Handles Timer4f.Tick

        Label.Location = New Point(Label.Location.X, Label.Location.Y + 1)
        If Label.Location.Y = 137 Then Timer4f.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Timer4f.Enabled = True
        Label.Text = "Fourth Floor"
        Label.ForeColor = Color.RoyalBlue

        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        btn5.Enabled = True
        Button5.Enabled = True

        Button1.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    
    Private Sub Timerd3_Tick(sender As Object, e As EventArgs)

    End Sub
End Class
