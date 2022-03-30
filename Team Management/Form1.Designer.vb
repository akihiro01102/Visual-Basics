<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTeam
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTeam))
        Me.dgvTeam = New System.Windows.Forms.DataGridView()
        Me.BNavigatorTeam = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnClear = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnWestern = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasternToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CentralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SouthwestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NorthwestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtTeam = New System.Windows.Forms.TextBox()
        Me.txtCoach = New System.Windows.Forms.TextBox()
        Me.txtConference = New System.Windows.Forms.TextBox()
        Me.txtDivision = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dPickerStart = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtArena = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtArenaCapacity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtYearOpened = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtW = New System.Windows.Forms.TextBox()
        Me.txtL = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgvTeam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BNavigatorTeam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BNavigatorTeam.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTeam
        '
        Me.dgvTeam.AllowUserToAddRows = False
        Me.dgvTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeam.Location = New System.Drawing.Point(12, 28)
        Me.dgvTeam.Name = "dgvTeam"
        Me.dgvTeam.Size = New System.Drawing.Size(1030, 281)
        Me.dgvTeam.TabIndex = 0
        '
        'BNavigatorTeam
        '
        Me.BNavigatorTeam.AddNewItem = Nothing
        Me.BNavigatorTeam.CountItem = Me.BindingNavigatorCountItem
        Me.BNavigatorTeam.DeleteItem = Nothing
        Me.BNavigatorTeam.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.btnClear, Me.btnRefresh, Me.btnSave, Me.btnAdd, Me.btnDelete, Me.ToolStripDropDownButton1})
        Me.BNavigatorTeam.Location = New System.Drawing.Point(0, 0)
        Me.BNavigatorTeam.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BNavigatorTeam.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BNavigatorTeam.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BNavigatorTeam.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BNavigatorTeam.Name = "BNavigatorTeam"
        Me.BNavigatorTeam.PositionItem = Me.BindingNavigatorPositionItem
        Me.BNavigatorTeam.Size = New System.Drawing.Size(1054, 25)
        Me.BNavigatorTeam.TabIndex = 1
        Me.BNavigatorTeam.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnClear
        '
        Me.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(38, 22)
        Me.btnClear.Text = "Clear"
        Me.btnClear.ToolTipText = "Clear Fields"
        '
        'btnRefresh
        '
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(50, 22)
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.ToolTipText = "Reload changes made"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 22)
        Me.btnSave.Text = "Save Changes"
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(60, 22)
        Me.btnAdd.Text = "Add New"
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(44, 22)
        Me.btnDelete.Text = "Delete"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnWestern, Me.EasternToolStripMenuItem, Me.CentralToolStripMenuItem, Me.SouthwestToolStripMenuItem, Me.NorthwestToolStripMenuItem, Me.PacificToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripDropDownButton1.Text = "Change Division"
        '
        'btnWestern
        '
        Me.btnWestern.Name = "btnWestern"
        Me.btnWestern.Size = New System.Drawing.Size(180, 22)
        Me.btnWestern.Text = "Southeast"
        '
        'EasternToolStripMenuItem
        '
        Me.EasternToolStripMenuItem.Name = "EasternToolStripMenuItem"
        Me.EasternToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EasternToolStripMenuItem.Text = "Atlantic"
        '
        'CentralToolStripMenuItem
        '
        Me.CentralToolStripMenuItem.Name = "CentralToolStripMenuItem"
        Me.CentralToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CentralToolStripMenuItem.Text = "Central"
        '
        'SouthwestToolStripMenuItem
        '
        Me.SouthwestToolStripMenuItem.Name = "SouthwestToolStripMenuItem"
        Me.SouthwestToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SouthwestToolStripMenuItem.Text = "Southwest"
        '
        'NorthwestToolStripMenuItem
        '
        Me.NorthwestToolStripMenuItem.Name = "NorthwestToolStripMenuItem"
        Me.NorthwestToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NorthwestToolStripMenuItem.Text = "Northwest"
        '
        'PacificToolStripMenuItem
        '
        Me.PacificToolStripMenuItem.Name = "PacificToolStripMenuItem"
        Me.PacificToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PacificToolStripMenuItem.Text = "Pacific"
        '
        'txtTeam
        '
        Me.txtTeam.Location = New System.Drawing.Point(12, 337)
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(156, 20)
        Me.txtTeam.TabIndex = 2
        '
        'txtCoach
        '
        Me.txtCoach.Location = New System.Drawing.Point(174, 337)
        Me.txtCoach.Name = "txtCoach"
        Me.txtCoach.Size = New System.Drawing.Size(198, 20)
        Me.txtCoach.TabIndex = 3
        '
        'txtConference
        '
        Me.txtConference.Location = New System.Drawing.Point(378, 337)
        Me.txtConference.Name = "txtConference"
        Me.txtConference.Size = New System.Drawing.Size(178, 20)
        Me.txtConference.TabIndex = 4
        '
        'txtDivision
        '
        Me.txtDivision.Location = New System.Drawing.Point(562, 337)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Size = New System.Drawing.Size(178, 20)
        Me.txtDivision.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(12, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Team "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(171, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Head Coach"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(375, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Conference"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(559, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Division"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(750, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Date Start"
        '
        'dPickerStart
        '
        Me.dPickerStart.Location = New System.Drawing.Point(753, 337)
        Me.dPickerStart.Name = "dPickerStart"
        Me.dPickerStart.Size = New System.Drawing.Size(200, 20)
        Me.dPickerStart.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(12, 378)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Location"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(12, 394)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(156, 20)
        Me.txtLocation.TabIndex = 14
        '
        'txtArena
        '
        Me.txtArena.Location = New System.Drawing.Point(175, 393)
        Me.txtArena.Name = "txtArena"
        Me.txtArena.Size = New System.Drawing.Size(197, 20)
        Me.txtArena.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(175, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Arena"
        '
        'txtArenaCapacity
        '
        Me.txtArenaCapacity.Location = New System.Drawing.Point(379, 394)
        Me.txtArenaCapacity.Name = "txtArenaCapacity"
        Me.txtArenaCapacity.Size = New System.Drawing.Size(177, 20)
        Me.txtArenaCapacity.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(378, 377)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Arena Capacity"
        '
        'txtYearOpened
        '
        Me.txtYearOpened.Location = New System.Drawing.Point(563, 393)
        Me.txtYearOpened.Name = "txtYearOpened"
        Me.txtYearOpened.Size = New System.Drawing.Size(177, 20)
        Me.txtYearOpened.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(562, 377)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Year Opened"
        '
        'txtW
        '
        Me.txtW.Location = New System.Drawing.Point(753, 394)
        Me.txtW.Name = "txtW"
        Me.txtW.Size = New System.Drawing.Size(84, 20)
        Me.txtW.TabIndex = 21
        '
        'txtL
        '
        Me.txtL.Location = New System.Drawing.Point(859, 393)
        Me.txtL.Name = "txtL"
        Me.txtL.Size = New System.Drawing.Size(82, 20)
        Me.txtL.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Location = New System.Drawing.Point(753, 377)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Win"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label11.Location = New System.Drawing.Point(859, 377)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Loss"
        '
        'formTeam
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 439)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtL)
        Me.Controls.Add(Me.txtW)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtYearOpened)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtArenaCapacity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtArena)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dPickerStart)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDivision)
        Me.Controls.Add(Me.txtConference)
        Me.Controls.Add(Me.txtCoach)
        Me.Controls.Add(Me.txtTeam)
        Me.Controls.Add(Me.BNavigatorTeam)
        Me.Controls.Add(Me.dgvTeam)
        Me.Name = "formTeam"
        Me.Text = "Nba Teams Management"
        CType(Me.dgvTeam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BNavigatorTeam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BNavigatorTeam.ResumeLayout(False)
        Me.BNavigatorTeam.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTeam As DataGridView
    Friend WithEvents BNavigatorTeam As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents txtTeam As TextBox
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents txtCoach As TextBox
    Friend WithEvents txtConference As TextBox
    Friend WithEvents txtDivision As TextBox
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnClear As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRefresh As ToolStripButton
    Friend WithEvents Label5 As Label
    Friend WithEvents dPickerStart As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtArena As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtArenaCapacity As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtYearOpened As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtW As TextBox
    Friend WithEvents txtL As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents btnWestern As ToolStripMenuItem
    Friend WithEvents EasternToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CentralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SouthwestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NorthwestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacificToolStripMenuItem As ToolStripMenuItem
End Class
