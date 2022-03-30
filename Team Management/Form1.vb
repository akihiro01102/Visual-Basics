Imports System.Data.SqlClient
Public Class formTeam

    Dim scommandDB As SqlCommand
    Dim stableteam As DataTable
    Dim sAdapterDB As SqlDataAdapter
    Dim teambindingsource As New BindingSource
    Dim sdsDB As DataSet
    Dim sqldb As String
    Dim connectionstring = "Data Source=LAPTOP-37EFJ6N7\SQLEXPRESS;Initial Catalog=NBA2016;Integrated Security=True"


    Private Sub FormTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayteam()
    End Sub

    Private Sub displayteam()
        Dim connectionTeam As New SqlConnection(connectionstring)
        sqldb = " Select Team, Location, Arena, Capacity, Opened, HeadCoach, Division, Conference, StartDate, Win, Loss
            From Team"
        connectionTeam.Open()
        sAdapterDB = New SqlDataAdapter(sqldb, connectionTeam)
        sdsDB = New DataSet
        sAdapterDB.Fill(sdsDB, "Team")
        stableteam = sdsDB.Tables("Team")
        teambindingsource.DataSource = stableteam
        dgvTeam.DataSource = teambindingsource
        BNavigatorTeam.BindingSource = teambindingsource
        txtTeam.DataBindings.Clear()
        txtCoach.DataBindings.Clear()
        txtConference.DataBindings.Clear()
        txtDivision.DataBindings.Clear()
        dPickerStart.DataBindings.Clear()
        txtLocation.DataBindings.Clear()
        txtArena.DataBindings.Clear()
        txtArenaCapacity.DataBindings.Clear()
        txtYearOpened.DataBindings.Clear()
        txtW.DataBindings.Clear()
        txtL.DataBindings.Clear()
        txtTeam.DataBindings.Add("text", teambindingsource, "team")
        txtCoach.DataBindings.Add("text", teambindingsource, "headcoach")
        txtConference.DataBindings.Add("text", teambindingsource, "Conference")
        txtDivision.DataBindings.Add("text", teambindingsource, "division")
        dPickerStart.DataBindings.Add("text", teambindingsource, "startdate")
        txtLocation.DataBindings.Add("text", teambindingsource, "location")
        txtArena.DataBindings.Add("text", teambindingsource, "arena")
        txtArenaCapacity.DataBindings.Add("text", teambindingsource, "capacity")
        txtYearOpened.DataBindings.Add("text", teambindingsource, "opened")
        txtW.DataBindings.Add("text", teambindingsource, "win")
        txtL.DataBindings.Add("text", teambindingsource, "loss")

        dgvTeam.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        connectionTeam.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim connectionUpdateTeam As New SqlConnection(connectionstring)

        'sqldb = "update team set headcoach='" & txtCoach.Text & "', conference='" & txtConference.Text & "' , division='" & txtDivision.Text & "', location='" & txtLocation.Text & "', arena='" & txtArena.Text & "', win='" & txtW.Text & "', loss='" & txtL.Text & "',  startdate='" & dPickerStart.Value & "' where team= '" & txtTeam.Text & "'"
        'connectionUpdateTeam.Open()
        'scommandDB = New SqlCommand(sqldb, connectionUpdateTeam)
        'Try
        '    scommandDB.ExecuteNonQuery()

        '    connectionUpdateTeam.Close()
        '    displayteam()

        'Catch ex As Exception

        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error")
        'End Try
        Dim connectionUpdateTeam As New SqlConnection(connectionstring)
        sqldb = "update team set headcoach='" & txtCoach.Text & "', conference='" & txtConference.Text & "' , division='" & txtDivision.Text & "', startdate='" & dPickerStart.Value & "',
        location='" & txtLocation.Text & "', arena='" & txtArena.Text & "', capacity='" & txtArenaCapacity.Text & "', opened='" & txtYearOpened.Text & "', 
        win='" & txtW.Text & "', loss='" & txtL.Text & "' where team= '" & txtTeam.Text & "'"
        connectionUpdateTeam.Open()
        scommandDB = New SqlCommand(sqldb, connectionUpdateTeam)
        Try
            scommandDB.ExecuteNonQuery()
            connectionUpdateTeam.Close()
            displayteam()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error")
        End Try

        Dim connectionUpdatefromDatagrid As New SqlConnection(connectionstring)



        Dim mteam

        Dim mlocation, marena, mdivision, mcapacity, mopened







        Dim norow = dgvTeam.RowCount

        For j = 0 To norow - 1

            dgvTeam.Rows(j).Selected = True

            mteam = dgvTeam.Rows(j).Cells("team").Value

            Try

                mlocation = dgvTeam.Rows(j).Cells("location").Value

            Catch

                mlocation = ""

            End Try



            Try

                marena = dgvTeam.Rows(j).Cells("arena").Value

            Catch ex As Exception

                marena = ""

            End Try

            Try

                mdivision = dgvTeam.Rows(j).Cells("division").Value

            Catch ex As Exception

                mdivision = ""

            End Try

            Try

                mcapacity = dgvTeam.Rows(j).Cells("capacity").Value

            Catch ex As Exception

                mcapacity = ""

            End Try

            Try

                mopened = dgvTeam.Rows(j).Cells("opened").Value

            Catch ex As Exception

                mopened = ""

            End Try

            sqldb = "update team set location= '" & mlocation & "', arena='" & marena & "',

            division = '" & mdivision & "', capacity= '" & mcapacity & "', opened = '" & mopened & "' where team='" & mteam & "'"

            connectionUpdatefromDatagrid.Open()

            scommandDB = New SqlCommand(sqldb, connectionUpdatefromDatagrid)

            sAdapterDB = New SqlDataAdapter(scommandDB)

            Try

                scommandDB.ExecuteNonQuery()

            Catch

                MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try

            connectionUpdatefromDatagrid.Close()



        Next





        displayteam()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim connectionAddTeam As New SqlConnection(connectionstring)
        sqldb = "insert team(team,headcoach,conference,division,startdate,location,arena,capacity,opened,win,loss) values('" & txtTeam.Text & "','" & txtCoach.Text & "','" & txtConference.Text & "' ,'" & txtDivision.Text & "' ,'" & dPickerStart.Value & "' ,'" & txtLocation.Text & "','" & txtArena.Text & "','" & txtArenaCapacity.Text & "','" & txtYearOpened.Text & "','" & txtW.Text & "','" & txtL.Text & "')"
        connectionAddTeam.Open()
        scommandDB = New SqlCommand(sqldb, connectionAddTeam)
        Try
            scommandDB.ExecuteNonQuery()
            connectionAddTeam.Close()
            displayteam()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error")
        End Try

        connectionAddTeam.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim connectiondeleteTeam As New SqlConnection(connectionstring)

        sqldb = "delete from  team where team= '" & txtTeam.Text & "'"
        connectiondeleteTeam.Open()

        scommandDB = New SqlCommand(sqldb, connectiondeleteTeam)
        Try

            Dim ch As DialogResult

            ch = MessageBox.Show("Are you sure you want to delete " & txtTeam.Text, "Purge Team", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ch = DialogResult.Yes Then

                scommandDB.ExecuteNonQuery()

                dgvTeam.Rows.RemoveAt(dgvTeam.CurrentRow.Index)

                ' displayteam()
            End If

            connectiondeleteTeam.Close()


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error")
        End Try
        connectiondeleteTeam.Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTeam.Clear()
        txtCoach.Clear()
        txtDivision.Clear()
        txtConference.Clear()
        txtLocation.Clear()
        txtArena.Clear()
        txtArenaCapacity.Clear()
        txtYearOpened.Clear()
        txtW.Clear()
        txtL.Clear()

        dPickerStart.Value = Today


    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        displayteam()
    End Sub



    Private Sub textboxTeamFind_TextChanged(sender As Object, e As EventArgs)


    End Sub



    Private Sub dgvTeam_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeam.CellContentDoubleClick

        Form2.Show()

        Form2.txtTeam.Text = txtTeam.Text
        Form2.txtCoach.Text = txtCoach.Text
        Form2.txtConference.Text = txtConference.Text
        Form2.txtDivision.Text = txtDivision.Text
        Form2.dPickerStart.Text = dPickerStart.Text
        Form2.txtLocation.Text = txtLocation.Text
        Form2.txtArena.Text = txtArena.Text
        Form2.txtArenaCapacity.Text = txtArenaCapacity.Text
        Form2.txtYearOpened.Text = txtYearOpened.Text
        Form2.txtW.Text = txtW.Text
        Form2.txtL.Text = txtL.Text

    End Sub

    Private Sub dgvTeam_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeam.CellDoubleClick


    End Sub

    Private Sub BNavigatorTeam_RefreshItems(sender As Object, e As EventArgs) Handles BNavigatorTeam.RefreshItems

    End Sub

    Private Sub dgvTeam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeam.CellContentClick

    End Sub

    Private Sub BindingNavigatorCountItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorCountItem.Click

    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click

    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click

    End Sub

    Private Sub BindingNavigatorSeparator_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSeparator.Click

    End Sub

    Private Sub BindingNavigatorPositionItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.Click

    End Sub

    Private Sub BindingNavigatorSeparator1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSeparator1.Click

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click

    End Sub

    Private Sub BindingNavigatorSeparator2_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSeparator2.Click

    End Sub

    Private Sub textboxTeamFind_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub textboxTeam_TextChanged(sender As Object, e As EventArgs) Handles txtTeam.TextChanged

    End Sub

    Private Sub textBoxCoach_TextChanged(sender As Object, e As EventArgs) Handles txtCoach.TextChanged

    End Sub

    Private Sub textBoxConference_TextChanged(sender As Object, e As EventArgs) Handles txtConference.TextChanged

    End Sub

    Private Sub textBoxDivision_TextChanged(sender As Object, e As EventArgs) Handles txtDivision.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub dPickerStart_ValueChanged(sender As Object, e As EventArgs) Handles dPickerStart.ValueChanged

    End Sub

    Private Sub WesternToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnWestern.Click

        Dim connectionchangeWestern As New SqlConnection(connectionstring)

        Dim mteam  'holds the value of team to be changed on each selected row



        If dgvTeam.SelectedRows.Count = 0 Then

            Exit Sub

        End If



        For i = dgvTeam.SelectedRows.Count - 1 To 0 Step -1



            mteam = dgvTeam.SelectedRows(i).Cells("team").Value.ToString ' transfer selected value of team

            sqldb = "update team set division='Southeast' where team = '" & mteam & "'"



            connectionchangeWestern.Open()

            scommandDB = New SqlCommand(sqldb, connectionchangeWestern)

            sAdapterDB = New SqlDataAdapter(scommandDB)

            Try



                scommandDB.ExecuteNonQuery()



            Catch

                MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try



            connectionchangeWestern.Close()



            ' dgvTeam.SelectedRows(i).Cells("conference").Value = "Western"



        Next i

        displayteam()



    End Sub

    Private Sub EasternToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EasternToolStripMenuItem.Click
        Dim connectionchangeEastern As New SqlConnection(connectionstring)



        Dim mteam 'holds the value of team to be changed on each selected row



        If dgvTeam.SelectedRows.Count = 0 Then

            Exit Sub

        End If



        For i = dgvTeam.SelectedRows.Count - 1 To 0 Step -1



            mteam = dgvTeam.SelectedRows(i).Cells("team").Value ' transfer selected value of team

            sqldb = "update team set Division='Atlantic' where team = '" & mteam & "'"





            connectionchangeEastern.Open()



            scommandDB = New SqlCommand(sqldb, connectionchangeEastern)

            sAdapterDB = New SqlDataAdapter(scommandDB)



            Try

                scommandDB.ExecuteNonQuery()



            Catch

                MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try



            connectionchangeEastern.Close()



        Next

        displayteam()
    End Sub

    Private Sub CentralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentralToolStripMenuItem.Click
        Dim connectionchangeEastern As New SqlConnection(connectionstring)



        Dim mteam 'holds the value of team to be changed on each selected row



        If dgvTeam.SelectedRows.Count = 0 Then

            Exit Sub

        End If



        For i = dgvTeam.SelectedRows.Count - 1 To 0 Step -1



            mteam = dgvTeam.SelectedRows(i).Cells("team").Value ' transfer selected value of team

            sqldb = "update team set Division='Central' where team = '" & mteam & "'"





            connectionchangeEastern.Open()



            scommandDB = New SqlCommand(sqldb, connectionchangeEastern)

            sAdapterDB = New SqlDataAdapter(scommandDB)



            Try

                scommandDB.ExecuteNonQuery()



            Catch

                MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try



            connectionchangeEastern.Close()



        Next

        displayteam()

    End Sub

    Private Sub SouthwestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SouthwestToolStripMenuItem.Click

        Dim connectionchangeEastern As New SqlConnection(connectionstring)



        Dim mteam 'holds the value of team to be changed on each selected row



        If dgvTeam.SelectedRows.Count = 0 Then

            Exit Sub

        End If



        For i = dgvTeam.SelectedRows.Count - 1 To 0 Step -1



            mteam = dgvTeam.SelectedRows(i).Cells("team").Value ' transfer selected value of team

            sqldb = "update team set Division='Southwest' where team = '" & mteam & "'"





            connectionchangeEastern.Open()



            scommandDB = New SqlCommand(sqldb, connectionchangeEastern)

            sAdapterDB = New SqlDataAdapter(scommandDB)



            Try

                scommandDB.ExecuteNonQuery()



            Catch

                MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try



            connectionchangeEastern.Close()



        Next

        displayteam()
    End Sub

    Private Sub NorthwestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NorthwestToolStripMenuItem.Click

        Dim connectionchangeEastern As New SqlConnection(connectionstring)



        Dim mteam 'holds the value of team to be changed on each selected row



        If dgvTeam.SelectedRows.Count = 0 Then

            Exit Sub

        End If



        For i = dgvTeam.SelectedRows.Count - 1 To 0 Step -1



            mteam = dgvTeam.SelectedRows(i).Cells("team").Value ' transfer selected value of team

            sqldb = "update team set Division='Northwest' where team = '" & mteam & "'"





            connectionchangeEastern.Open()



            scommandDB = New SqlCommand(sqldb, connectionchangeEastern)

            sAdapterDB = New SqlDataAdapter(scommandDB)



            Try

                scommandDB.ExecuteNonQuery()



            Catch

                MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try



            connectionchangeEastern.Close()



        Next

        displayteam()
    End Sub

    Private Sub PacificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacificToolStripMenuItem.Click
        Dim connectionchangeEastern As New SqlConnection(connectionstring)



        Dim mteam 'holds the value of team to be changed on each selected row



        If dgvTeam.SelectedRows.Count = 0 Then

            Exit Sub

        End If



        For i = dgvTeam.SelectedRows.Count - 1 To 0 Step -1



            mteam = dgvTeam.SelectedRows(i).Cells("team").Value ' transfer selected value of team

            sqldb = "update team set Division='Pacific' where team = '" & mteam & "'"





            connectionchangeEastern.Open()



            scommandDB = New SqlCommand(sqldb, connectionchangeEastern)

            sAdapterDB = New SqlDataAdapter(scommandDB)



            Try

                scommandDB.ExecuteNonQuery()



            Catch

                MessageBox.Show("Connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End Try



            connectionchangeEastern.Close()



        Next

        displayteam()

    End Sub
End Class
