<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class officerModule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(officerModule))
        Me.txt_name = New System.Windows.Forms.Label()
        Me.txt_officer_id = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_post = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_mobile = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AddCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddOfficerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCaseOfficerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PredictResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ViewSuspectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEvidenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCaseHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_name
        '
        Me.txt_name.AutoSize = True
        Me.txt_name.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(140, 162)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(64, 27)
        Me.txt_name.TabIndex = 60
        Me.txt_name.Text = "name"
        '
        'txt_officer_id
        '
        Me.txt_officer_id.AutoSize = True
        Me.txt_officer_id.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_officer_id.Location = New System.Drawing.Point(140, 117)
        Me.txt_officer_id.Name = "txt_officer_id"
        Me.txt_officer_id.Size = New System.Drawing.Size(30, 27)
        Me.txt_officer_id.TabIndex = 59
        Me.txt_officer_id.Text = "id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 27)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Name :-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 40)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Officer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 27)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = " ID :-"
        '
        'txt_post
        '
        Me.txt_post.AutoSize = True
        Me.txt_post.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_post.Location = New System.Drawing.Point(140, 282)
        Me.txt_post.Name = "txt_post"
        Me.txt_post.Size = New System.Drawing.Size(52, 27)
        Me.txt_post.TabIndex = 64
        Me.txt_post.Text = "post"
        '
        'txt_address
        '
        Me.txt_address.AutoSize = True
        Me.txt_address.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(140, 222)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(47, 27)
        Me.txt_address.TabIndex = 63
        Me.txt_address.Text = "add"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 27)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "post"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 27)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = " address"
        '
        'txt_mobile
        '
        Me.txt_mobile.AutoSize = True
        Me.txt_mobile.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mobile.Location = New System.Drawing.Point(140, 338)
        Me.txt_mobile.Name = "txt_mobile"
        Me.txt_mobile.Size = New System.Drawing.Size(77, 27)
        Me.txt_mobile.TabIndex = 66
        Me.txt_mobile.Text = "mobile"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(41, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 27)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "mobile"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 67
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(84, 22)
        Me.ToolStripButton1.Text = "Dashboard"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCaseToolStripMenuItem, Me.AddOfficerToolStripMenuItem, Me.AddCaseOfficerToolStripMenuItem})
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripButton2.Text = "Add"
        '
        'AddCaseToolStripMenuItem
        '
        Me.AddCaseToolStripMenuItem.Name = "AddCaseToolStripMenuItem"
        Me.AddCaseToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AddCaseToolStripMenuItem.Text = "Add Case"
        '
        'AddOfficerToolStripMenuItem
        '
        Me.AddOfficerToolStripMenuItem.Name = "AddOfficerToolStripMenuItem"
        Me.AddOfficerToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AddOfficerToolStripMenuItem.Text = "Add Officer"
        '
        'AddCaseOfficerToolStripMenuItem
        '
        Me.AddCaseOfficerToolStripMenuItem.Name = "AddCaseOfficerToolStripMenuItem"
        Me.AddCaseOfficerToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AddCaseOfficerToolStripMenuItem.Text = "Add Case Officer"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PredictResultToolStripMenuItem, Me.AddResultToolStripMenuItem})
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripButton3.Text = "Result"
        '
        'PredictResultToolStripMenuItem
        '
        Me.PredictResultToolStripMenuItem.Name = "PredictResultToolStripMenuItem"
        Me.PredictResultToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PredictResultToolStripMenuItem.Text = "Predict Result"
        '
        'AddResultToolStripMenuItem
        '
        Me.AddResultToolStripMenuItem.Name = "AddResultToolStripMenuItem"
        Me.AddResultToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.AddResultToolStripMenuItem.Text = "Add Result"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewSuspectToolStripMenuItem, Me.ViewEvidenceToolStripMenuItem, Me.ViewCaseHistoryToolStripMenuItem})
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripButton4.Text = "View"
        '
        'ViewSuspectToolStripMenuItem
        '
        Me.ViewSuspectToolStripMenuItem.Name = "ViewSuspectToolStripMenuItem"
        Me.ViewSuspectToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ViewSuspectToolStripMenuItem.Text = "View Suspect"
        '
        'ViewEvidenceToolStripMenuItem
        '
        Me.ViewEvidenceToolStripMenuItem.Name = "ViewEvidenceToolStripMenuItem"
        Me.ViewEvidenceToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ViewEvidenceToolStripMenuItem.Text = "View Evidence"
        '
        'ViewCaseHistoryToolStripMenuItem
        '
        Me.ViewCaseHistoryToolStripMenuItem.Name = "ViewCaseHistoryToolStripMenuItem"
        Me.ViewCaseHistoryToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ViewCaseHistoryToolStripMenuItem.Text = "View Case History"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripButton5.Text = "Logout"
        '
        'officerModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txt_mobile)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_post)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_officer_id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "officerModule"
        Me.Text = "officerModule"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_name As Label
    Friend WithEvents txt_officer_id As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_post As Label
    Friend WithEvents txt_address As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_mobile As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripDropDownButton
    Friend WithEvents AddCaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddOfficerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCaseOfficerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As ToolStripDropDownButton
    Friend WithEvents PredictResultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddResultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton4 As ToolStripDropDownButton
    Friend WithEvents ViewSuspectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewEvidenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCaseHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As ToolStripButton
End Class
