Public Class YXmain
    Dim a As Short

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        RichTextBox1.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        RichTextBox1.Hide()

    End Sub

    Private Sub RichTextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.Click

        If a = 1 Then
            MsgBox("做一个烦人的小妖精")
            a = a + 1
            RichTextBox1.Text = a
        Else : a = a + 2
            RichTextBox1.Text = a
        End If

    End Sub

    Private Sub RichTextBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox1.DoubleClick
        RichTextBox1.Text = Text

    End Sub

    Private Sub RichBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.SaveFile(".\CMD.bat", 3)
    End Sub

    Private Sub YXmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a = 1
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
        Button1.Show()
    End Sub

    Private Sub ProgressBar1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ProgressBar1.MouseWheel
        Button1.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Hide()
        Shell("CMD.bat")
        If a >= 12 Then
            End
        End If
    End Sub
End Class
