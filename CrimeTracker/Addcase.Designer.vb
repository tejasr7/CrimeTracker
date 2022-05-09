<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addcase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Addcase))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AddCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddOfficerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PredictResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddResultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ViewSuspectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEvidenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCaseHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbx_caseId = New System.Windows.Forms.TextBox()
        Me.txtbx_case_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbx_officerId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbx_note = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_submit = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 0
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
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCaseToolStripMenuItem, Me.AddOfficerToolStripMenuItem})
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripButton2.Text = "Add"
        '
        'AddCaseToolStripMenuItem
        '
        Me.AddCaseToolStripMenuItem.Name = "AddCaseToolStripMenuItem"
        Me.AddCaseToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AddCaseToolStripMenuItem.Text = "Add Case"
        '
        'AddOfficerToolStripMenuItem
        '
        Me.AddOfficerToolStripMenuItem.Name = "AddOfficerToolStripMenuItem"
        Me.AddOfficerToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AddOfficerToolStripMenuItem.Text = "Add Officer"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add Case"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(206, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Case ID"
        '
        'txtbx_caseId
        '
        Me.txtbx_caseId.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.txtbx_caseId.Location = New System.Drawing.Point(374, 89)
        Me.txtbx_caseId.Name = "txtbx_caseId"
        Me.txtbx_caseId.Size = New System.Drawing.Size(184, 35)
        Me.txtbx_caseId.TabIndex = 3
        '
        'txtbx_case_name
        '
        Me.txtbx_case_name.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.txtbx_case_name.Location = New System.Drawing.Point(374, 140)
        Me.txtbx_case_name.Name = "txtbx_case_name"
        Me.txtbx_case_name.Size = New System.Drawing.Size(184, 35)
        Me.txtbx_case_name.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Case Name"
        '
        'txtbx_officerId
        '
        Me.txtbx_officerId.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.txtbx_officerId.Location = New System.Drawing.Point(374, 190)
        Me.txtbx_officerId.Name = "txtbx_officerId"
        Me.txtbx_officerId.Size = New System.Drawing.Size(184, 35)
        Me.txtbx_officerId.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(206, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Officer ID"
        '
        'txtbx_note
        '
        Me.txtbx_note.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.txtbx_note.Location = New System.Drawing.Point(374, 253)
        Me.txtbx_note.Multiline = True
        Me.txtbx_note.Name = "txtbx_note"
        Me.txtbx_note.Size = New System.Drawing.Size(184, 93)
        Me.txtbx_note.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(206, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 27)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Note"
        '
        'Btn_submit
        '
        Me.Btn_submit.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.Btn_submit.Location = New System.Drawing.Point(332, 377)
        Me.Btn_submit.Name = "Btn_submit"
        Me.Btn_submit.Size = New System.Drawing.Size(106, 45)
        Me.Btn_submit.TabIndex = 12
        Me.Btn_submit.Text = "Submit"
        Me.Btn_submit.UseVisualStyleBackColor = True
        '
        'Addcase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 473)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Btn_submit)
        Me.Controls.Add(Me.txtbx_note)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbx_officerId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbx_case_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbx_caseId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Addcase"
        Me.Text = "S"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripDropDownButton
    Friend WithEvents ToolStripButton3 As ToolStripDropDownButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbx_caseId As TextBox
    Friend WithEvents txtbx_case_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbx_officerId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbx_note As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_submit As Button
    Friend WithEvents AddCaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddOfficerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PredictResultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddResultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton4 As ToolStripDropDownButton
    Friend WithEvents ViewSuspectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewEvidenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCaseHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As ToolStripButton
End Class
