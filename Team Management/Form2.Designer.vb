<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtL = New System.Windows.Forms.TextBox()
        Me.txtW = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtYearOpened = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtArenaCapacity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtArena = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dPickerStart = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDivision = New System.Windows.Forms.TextBox()
        Me.txtConference = New System.Windows.Forms.TextBox()
        Me.txtCoach = New System.Windows.Forms.TextBox()
        Me.txtTeam = New System.Windows.Forms.TextBox()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.Size = New System.Drawing.Size(1094, 25)
        Me.BindingNavigator1.TabIndex = 47
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripButton1.Text = "Save/Exit"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label11.Location = New System.Drawing.Point(924, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "Loss"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Location = New System.Drawing.Point(818, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Win"
        '
        'txtL
        '
        Me.txtL.Location = New System.Drawing.Point(924, 149)
        Me.txtL.Name = "txtL"
        Me.txtL.Size = New System.Drawing.Size(82, 20)
        Me.txtL.TabIndex = 67
        '
        'txtW
        '
        Me.txtW.Location = New System.Drawing.Point(818, 150)
        Me.txtW.Name = "txtW"
        Me.txtW.Size = New System.Drawing.Size(84, 20)
        Me.txtW.TabIndex = 66
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(627, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Year Opened"
        '
        'txtYearOpened
        '
        Me.txtYearOpened.Location = New System.Drawing.Point(628, 149)
        Me.txtYearOpened.Name = "txtYearOpened"
        Me.txtYearOpened.Size = New System.Drawing.Size(177, 20)
        Me.txtYearOpened.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(443, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Arena Capacity"
        '
        'txtArenaCapacity
        '
        Me.txtArenaCapacity.Location = New System.Drawing.Point(444, 150)
        Me.txtArenaCapacity.Name = "txtArenaCapacity"
        Me.txtArenaCapacity.Size = New System.Drawing.Size(177, 20)
        Me.txtArenaCapacity.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(240, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Arena"
        '
        'txtArena
        '
        Me.txtArena.Location = New System.Drawing.Point(240, 149)
        Me.txtArena.Name = "txtArena"
        Me.txtArena.Size = New System.Drawing.Size(197, 20)
        Me.txtArena.TabIndex = 60
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(77, 150)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(156, 20)
        Me.txtLocation.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(77, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Location"
        '
        'dPickerStart
        '
        Me.dPickerStart.Location = New System.Drawing.Point(818, 93)
        Me.dPickerStart.Name = "dPickerStart"
        Me.dPickerStart.Size = New System.Drawing.Size(200, 20)
        Me.dPickerStart.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(815, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Date Start"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(624, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Division"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(440, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Conference"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(236, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Head Coach"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(77, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Team "
        '
        'txtDivision
        '
        Me.txtDivision.Location = New System.Drawing.Point(627, 93)
        Me.txtDivision.Name = "txtDivision"
        Me.txtDivision.Size = New System.Drawing.Size(178, 20)
        Me.txtDivision.TabIndex = 51
        '
        'txtConference
        '
        Me.txtConference.Location = New System.Drawing.Point(443, 93)
        Me.txtConference.Name = "txtConference"
        Me.txtConference.Size = New System.Drawing.Size(178, 20)
        Me.txtConference.TabIndex = 50
        '
        'txtCoach
        '
        Me.txtCoach.Location = New System.Drawing.Point(239, 93)
        Me.txtCoach.Name = "txtCoach"
        Me.txtCoach.Size = New System.Drawing.Size(198, 20)
        Me.txtCoach.TabIndex = 49
        '
        'txtTeam
        '
        Me.txtTeam.Location = New System.Drawing.Point(77, 93)
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(156, 20)
        Me.txtTeam.TabIndex = 48
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 246)
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
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Name = "Form2"
        Me.Text = "Team Management"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtL As TextBox
    Friend WithEvents txtW As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtYearOpened As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtArenaCapacity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtArena As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dPickerStart As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDivision As TextBox
    Friend WithEvents txtConference As TextBox
    Friend WithEvents txtCoach As TextBox
    Friend WithEvents txtTeam As TextBox
End Class
