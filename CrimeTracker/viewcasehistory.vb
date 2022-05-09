Public Class viewcasehistory
    Private Sub CaseHistoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CaseHistoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CaseHistoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CrimeDBDataSet)

    End Sub

    Private Sub viewcasehistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CrimeDBDataSet.CaseHistory' table. You can move, or remove it, as needed.
        Me.CaseHistoryTableAdapter.Fill(Me.CrimeDBDataSet.CaseHistory)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class