Public Class Addcase
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

    End Sub


    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub addcase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_submit_Click(sender As Object, e As EventArgs) Handles Btn_submit.Click
        If txtbx_caseId.Text = "" Then
            MessageBox.Show("Id is required",
                                "CITSP", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbx_caseId.Focus()
        Else
        End If
    End Sub
End Class
