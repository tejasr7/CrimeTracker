<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewcasehistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewcasehistory))
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrimeDBDataSet = New CrimeTracker.CrimeDBDataSet()
        Me.CaseHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CaseHistoryTableAdapter = New CrimeTracker.CrimeDBDataSetTableAdapters.CaseHistoryTableAdapter()
        Me.TableAdapterManager = New CrimeTracker.CrimeDBDataSetTableAdapters.TableAdapterManager()
        Me.CaseHistoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CaseHistoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CaseHistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.CrimeDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaseHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaseHistoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CaseHistoryBindingNavigator.SuspendLayout()
        CType(Me.CaseHistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 66
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 40)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "View Case History"
        '
        'CrimeDBDataSet
        '
        Me.CrimeDBDataSet.DataSetName = "CrimeDBDataSet"
        Me.CrimeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CaseHistoryBindingSource
        '
        Me.CaseHistoryBindingSource.DataMember = "CaseHistory"
        Me.CaseHistoryBindingSource.DataSource = Me.CrimeDBDataSet
        '
        'CaseHistoryTableAdapter
        '
        Me.CaseHistoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CaseHistoryTableAdapter = Me.CaseHistoryTableAdapter
        Me.TableAdapterManager.CaseTableAdapter = Nothing
        Me.TableAdapterManager.EvidanceTableAdapter = Nothing
        Me.TableAdapterManager.OfficerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CrimeTracker.CrimeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CaseHistoryBindingNavigator
        '
        Me.CaseHistoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CaseHistoryBindingNavigator.BindingSource = Me.CaseHistoryBindingSource
        Me.CaseHistoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CaseHistoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CaseHistoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CaseHistoryBindingNavigatorSaveItem})
        Me.CaseHistoryBindingNavigator.Location = New System.Drawing.Point(0, 25)
        Me.CaseHistoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CaseHistoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CaseHistoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CaseHistoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CaseHistoryBindingNavigator.Name = "CaseHistoryBindingNavigator"
        Me.CaseHistoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CaseHistoryBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.CaseHistoryBindingNavigator.TabIndex = 67
        Me.CaseHistoryBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CaseHistoryBindingNavigatorSaveItem
        '
        Me.CaseHistoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CaseHistoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("CaseHistoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CaseHistoryBindingNavigatorSaveItem.Name = "CaseHistoryBindingNavigatorSaveItem"
        Me.CaseHistoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CaseHistoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CaseHistoryDataGridView
        '
        Me.CaseHistoryDataGridView.AutoGenerateColumns = False
        Me.CaseHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CaseHistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CaseHistoryDataGridView.DataSource = Me.CaseHistoryBindingSource
        Me.CaseHistoryDataGridView.Location = New System.Drawing.Point(12, 120)
        Me.CaseHistoryDataGridView.Name = "CaseHistoryDataGridView"
        Me.CaseHistoryDataGridView.Size = New System.Drawing.Size(764, 318)
        Me.CaseHistoryDataGridView.TabIndex = 67
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CaseId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CaseId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OfficerId"
        Me.DataGridViewTextBoxColumn2.HeaderText = "OfficerId"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "History"
        Me.DataGridViewTextBoxColumn3.HeaderText = "History"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'viewcasehistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CaseHistoryDataGridView)
        Me.Controls.Add(Me.CaseHistoryBindingNavigator)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "viewcasehistory"
        Me.Text = "viewcasehistory"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.CrimeDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaseHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaseHistoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CaseHistoryBindingNavigator.ResumeLayout(False)
        Me.CaseHistoryBindingNavigator.PerformLayout()
        CType(Me.CaseHistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents Label1 As Label
    Friend WithEvents CrimeDBDataSet As CrimeDBDataSet
    Friend WithEvents CaseHistoryBindingSource As BindingSource
    Friend WithEvents CaseHistoryTableAdapter As CrimeDBDataSetTableAdapters.CaseHistoryTableAdapter
    Friend WithEvents TableAdapterManager As CrimeDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CaseHistoryBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CaseHistoryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CaseHistoryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
