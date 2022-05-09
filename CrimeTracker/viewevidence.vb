Public Class viewevidence
    Private Sub EvidanceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EvidanceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EvidanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CrimeDBDataSet)

    End Sub

    Private Sub viewevidence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CrimeDBDataSet.Evidance' table. You can move, or remove it, as needed.
        Me.EvidanceTableAdapter.Fill(Me.CrimeDBDataSet.Evidance)

    End Sub
End Class