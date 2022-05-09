Public Class main
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        adminlogin.Show()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        officerlogin.ShowDialog()
    End Sub

    Private Sub main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try

            'If MessageBox.Show("Are you sure you want to quit the application?",
            '                  "CITSP",
            'MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            'MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            'e.Cancel = True
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class