Public Class officerlogin
    ' Private Sub OfficerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    'Me.Validate()
    ''Me.OfficerBindingSource.EndEdit()
    'Me.TableAdapterManager.UpdateAll(Me.CrimeDBDataSet)
    'End Sub

    Private Sub officerlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.OfficerTableAdapter.Fill(Me.CrimeDBDataSet.Officer)
    End Sub

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        If txtbx_id.Text = "" Then
            MsgBox("id is required", MsgBoxStyle.Critical)
            txtbx_id.Focus()
        ElseIf txtbx_pass.Text = "" Then
            MsgBox("password is required", MsgBoxStyle.Critical)
            txtbx_pass.Focus()
        Else
            If isAuthenticated() = True Then
                Dim officerModule As New officerModule()
                officerModule.ShowDialog()


                Me.Show()
                Me.txtbx_id.Select()
                Me.txtbx_pass.Select()
            End If

        End If
    End Sub

    Private Function isAuthenticated() As Boolean
        Try
            Dim SQL As String = String.Empty
            SQL &= "SELECT * FROM Officer "
            SQL &= "WHERE officerId = '" & txtbx_id.Text & "' "
            SQL &= "AND password = '" & txtbx_pass.Text & "' "

            Dim OfficerData As DataTable = ExecuteSQL(SQL)

            If OfficerData.Rows.Count > 0 Then

                Officer.ID = txtbx_id.Text

                txtbx_id.Clear()
                txtbx_pass.Clear()

                Me.Hide()
                Me.Close()
                Return True
            Else
                MsgBox("The id or password is incorrect", MsgBoxStyle.Critical)
                txtbx_id.Focus()
                txtbx_id.SelectAll()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Private Sub Btn_back_Click(sender As Object, e As EventArgs) Handles Btn_back.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub txtbx_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbx_id.KeyPress
        Dim Ch As Char = e.KeyChar
        If Not Char.IsDigit(Ch) AndAlso Asc(Ch) <> 8 Then
            e.Handled = True
        End If
    End Sub
End Class