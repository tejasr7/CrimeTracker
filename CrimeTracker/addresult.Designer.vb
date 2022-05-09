<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addresult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addresult))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.Button1.Location = New System.Drawing.Point(344, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 45)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 40)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Add Result"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 27)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Case ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 18.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(356, 182)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(175, 35)
        Me.ComboBox1.TabIndex = 43
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 44
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
        'addresult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 473)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "addresult"
        Me.Text = "addresult"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
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
