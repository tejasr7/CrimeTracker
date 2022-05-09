Public Class addcasehistory
    Private Sub CaseBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CaseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CrimeDBDataSet)

    End Sub

    Private Sub addcasehistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CrimeDBDataSet.Admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.CrimeDBDataSet.Admin)
        'TODO: This line of code loads data into the 'CrimeDBDataSet._Case' table. You can move, or remove it, as needed.
        Me.CaseTableAdapter.Fill(Me.CrimeDBDataSet._Case)

    End Sub

    Private Sub AdminDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)

    End Sub
End Class