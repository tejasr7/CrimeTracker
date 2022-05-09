Public Class officerModule

    Private Sub getOfficerDetails()

        Dim SQL As String = String.Empty
        SQL = ("SELECT officerId, name, mobile, address, post, image " &
                 "FROM Officer " &
                 "WHERE officerId='" & Officer.ID & "' ")

        'SQLServerConnection.runQuery("SELECT id, name")
        Dim OfficerData As DataTable = ExecuteSQL(SQL)
        ExecuteSQL(SQL)

        For Each i As Object In OfficerData.Rows
            Officer.Name = i.Item("name")
            Officer.Mobile = i.Item("mobile")
            Officer.address = i.Item("address")
            Officer.post = i.Item("post")
            'txt_admin_id.Text = i.Item("id") & vbCrLf
            'txt_admin_name.Text = i.Item("name") & vbCrLf
            txt_officer_id.Text = Officer.ID
            txt_name.Text = Officer.Name
            txt_mobile.Text = Officer.Mobile
            txt_address.Text = Officer.address
            txt_post.Text = Officer.post

        Next
    End Sub
    Private Sub officerModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txt_officer_id.Text = Officer.ID
        getOfficerDetails()
    End Sub
End Class