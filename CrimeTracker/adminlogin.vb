
Imports System.Data.SqlClient
Public Class adminlogin
    'Public AuthAdmin As String


    Private Sub AdminBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AdminBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CrimeDBDataSet)

    End Sub

    Private Sub adminlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CrimeDBDataSet.Admin' table. You can move, or remove it, as needed.
        Me.AdminTableAdapter.Fill(Me.CrimeDBDataSet.Admin)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtbx_id.Text = "" Then
            'MsgBox("id is required", MsgBoxStyle.Critical)
            MessageBox.Show("Id is required",
                                "CITSP", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbx_id.Focus()
        ElseIf txtbx_password.Text = "" Then
            'MsgBox("password is required", MsgBoxStyle.Critical)
            MessageBox.Show("Password is required",
                                "CITSP", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtbx_password.Focus()
        Else
            If isAuthenticated() = True Then
                Dim adminModule As New adminmodule()
                adminModule.ShowDialog()
                'adminModule = Nothing

                'MsgBox(AuthAdmin)

                Me.Show()
                Me.txtbx_id.Select()
            End If


        End If
        '''''''''''''''''''''''''''''
        'If Not String.IsNullOrEmpty(txtbx_password.Text) Then

        'Dim SQL As String = String.Empty
        'Sql &= "SELECT * FROM Admin "
        'Sql &= "WHERE id = '" & txtbx_id.Text & "' "
        'Sql &= "AND password = '" & txtbx_password.Text & "' "

        'Dim AdminData As DataTable = ExecuteSQL(SQL)

        'If AdminData.Rows.Count > 0 Then
        'txtbx_id.Clear()
        'txtbx_password.Clear()
        '
        'Me.Hide()

        'Dim adminModule As New adminmodule()
        'adminmodule.ShowDialog()
        'adminmodule = Nothing

        'Me.Show()
        'Me.txtbx_id.Select()

        'Else
        'MsgBox("The id or password", MsgBoxStyle.Critical)
        'txtbx_id.Focus()
        'txtbx_id.SelectAll()
        'End If

        'Else
        'MsgBox("Please Enter id and password", MsgBoxStyle.Critical)
        'End If
    End Sub

    Private Function isAuthenticated() As Boolean
        ' Clear existing records
        If CrimeDBDataSet IsNot Nothing Then
            CrimeDBDataSet.Clear()
        End If

        Try
            Dim SQL As String = String.Empty
            SQL &= "SELECT * FROM Admin "
            SQL &= "WHERE id = '" & txtbx_id.Text & "' "
            SQL &= "AND password = '" & txtbx_password.Text & "' "

            Dim AdminData As DataTable = ExecuteSQL(SQL)
            'Dim zero = 0

            ' get the id of the admin
            'AuthAdmin = txtbx_id.Text

            If AdminData.Rows.Count > 0 Then

                'for testing
                currentAdminId = txtbx_id.Text

                txtbx_id.Clear()
                txtbx_password.Clear()

                Me.Hide()

                'Dim adminModule As New adminmodule()
                'adminmodule.ShowDialog()
                'adminmodule = Nothing

                'MsgBox(AuthAdmin)

                'Me.Show()
                'Me.txtbx_id.Select()
                Return True

            Else
                'MsgBox("The id or password is incorrect", MsgBoxStyle.Critical)
                MessageBox.Show("The id or password is incorrect",
                                "CITSP", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtbx_id.Focus()
                txtbx_id.SelectAll()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return False
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        main.Show()
    End Sub

    Private Sub txtbx_id_TextChanged(sender As Object, e As EventArgs) Handles txtbx_id.TextChanged

    End Sub

    Private Sub txtbx_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbx_id.KeyPress
        Dim Ch As Char = e.KeyChar
        If Not Char.IsDigit(Ch) AndAlso Asc(Ch) <> 8 Then
            e.Handled = True
        End If
    End Sub
End Class