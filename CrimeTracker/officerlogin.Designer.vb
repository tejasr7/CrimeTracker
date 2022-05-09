<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class officerlogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Btn_login = New System.Windows.Forms.Button()
        Me.Btn_back = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbx_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CrimeDBDataSet = New CrimeTracker.CrimeDBDataSet()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminTableAdapter = New CrimeTracker.CrimeDBDataSetTableAdapters.AdminTableAdapter()
        Me.TableAdapterManager = New CrimeTracker.CrimeDBDataSetTableAdapters.TableAdapterManager()
        Me.OfficerTableAdapter = New CrimeTracker.CrimeDBDataSetTableAdapters.OfficerTableAdapter()
        Me.txtbx_pass = New System.Windows.Forms.TextBox()
        CType(Me.CrimeDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_login
        '
        Me.Btn_login.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.Btn_login.Location = New System.Drawing.Point(255, 315)
        Me.Btn_login.Name = "Btn_login"
        Me.Btn_login.Size = New System.Drawing.Size(106, 45)
        Me.Btn_login.TabIndex = 56
        Me.Btn_login.Text = "Login"
        Me.Btn_login.UseVisualStyleBackColor = True
        '
        'Btn_back
        '
        Me.Btn_back.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.Btn_back.Location = New System.Drawing.Point(435, 315)
        Me.Btn_back.Name = "Btn_back"
        Me.Btn_back.Size = New System.Drawing.Size(106, 45)
        Me.Btn_back.TabIndex = 55
        Me.Btn_back.Text = "Back"
        Me.Btn_back.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(224, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 27)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Password"
        '
        'txtbx_id
        '
        Me.txtbx_id.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.txtbx_id.Location = New System.Drawing.Point(392, 189)
        Me.txtbx_id.Name = "txtbx_id"
        Me.txtbx_id.Size = New System.Drawing.Size(184, 35)
        Me.txtbx_id.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(291, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 40)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Officer Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(224, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 27)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Officer ID"
        '
        'CrimeDBDataSet
        '
        Me.CrimeDBDataSet.DataSetName = "CrimeDBDataSet"
        Me.CrimeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "Admin"
        Me.AdminBindingSource.DataSource = Me.CrimeDBDataSet
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Me.AdminTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CaseHistoryTableAdapter = Nothing
        Me.TableAdapterManager.CaseTableAdapter = Nothing
        Me.TableAdapterManager.EvidanceTableAdapter = Nothing
        Me.TableAdapterManager.OfficerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CrimeTracker.CrimeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OfficerTableAdapter
        '
        Me.OfficerTableAdapter.ClearBeforeFill = True
        '
        'txtbx_pass
        '
        Me.txtbx_pass.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.txtbx_pass.Location = New System.Drawing.Point(392, 233)
        Me.txtbx_pass.Name = "txtbx_pass"
        Me.txtbx_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbx_pass.Size = New System.Drawing.Size(184, 35)
        Me.txtbx_pass.TabIndex = 57
        Me.txtbx_pass.UseSystemPasswordChar = True
        '
        'officerlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 473)
        Me.Controls.Add(Me.txtbx_pass)
        Me.Controls.Add(Me.Btn_login)
        Me.Controls.Add(Me.Btn_back)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbx_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "officerlogin"
        Me.Text = "officerlogin"
        CType(Me.CrimeDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_login As Button
    Friend WithEvents Btn_back As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbx_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CrimeDBDataSet As CrimeDBDataSet
    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents AdminTableAdapter As CrimeDBDataSetTableAdapters.AdminTableAdapter
    Friend WithEvents TableAdapterManager As CrimeDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OfficerTableAdapter As CrimeDBDataSetTableAdapters.OfficerTableAdapter
    Friend WithEvents txtbx_pass As TextBox
End Class
