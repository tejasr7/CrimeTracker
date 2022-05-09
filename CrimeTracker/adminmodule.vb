Public Class adminmodule
    'Private admin = adminlogin.AuthAdmin

    Private Sub getAdminDetails()

        Dim SQL As String = String.Empty
        SQL = ("SELECT id, name " &
                 "FROM admin " &
                 "WHERE id='" & currentAdminId & "' ")

        'SQLServerConnection.runQuery("SELECT id, name")
        Dim AdminData As DataTable = ExecuteSQL(Sql)
        ExecuteSQL(SQL)

        For Each i As Object In AdminData.Rows
            currentAdminName = i.Item("name")
            'txt_admin_id.Text = i.Item("id") & vbCrLf
            'txt_admin_name.Text = i.Item("name") & vbCrLf
            txt_admin_id.Text = currentAdminId
            txt_admin_name.Text = currentAdminName
        Next

        ' Do not delete this 
        '''' This is also working
        'SQLServerConnection.runQuery("SELECT id, name " &
        '                           "FROM admin " &
        '                        "WHERE id='" & currentAdminId & "' ")

        'For Each i As Object In SQLServerConnection.SQLDS.Tables(0).Rows
        'currentAdminName = i.Item("name")
        ''txt_admin_id.Text = i.Item("id") & vbCrLf
        ''txt_admin_name.Text = i.Item("name") & vbCrLf
        'txt_admin_id.Text = currentAdminId
        'txt_admin_name.Text = currentAdminName

        'Next
        '''''''
    End Sub

    Private Sub adminmodule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MsgBox(adminlogin.AuthAdmin)
        getAdminDetails()
        'txt_admin_id.Text = adminlogin.AuthAdmin
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        currentAdminId = " "

        Me.Hide()
        main.ShowDialog()

    End Sub

    Private Sub AddCaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCaseToolStripMenuItem.Click
        Me.Hide()
        addcase.ShowDialog()
    End Sub
End Class