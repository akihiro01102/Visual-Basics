Imports System.Data.SqlClient
Public Class Form2
    Dim scommandDB As SqlCommand
    Dim stableteam As DataTable
    Dim sAdapterDB As SqlDataAdapter
    Dim teambindingsource As New BindingSource
    Dim sdsDB As DataSet
    Dim sqldb As String
    Dim connectionstring = "Data Source=LAPTOP-37EFJ6N7\SQLEXPRESSInitial Catalog=NBA2016;Integrated Security=True"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim connectionUpdateTeam As New SqlConnection(connectionstring)
        sqldb = "update team set headcoach='" & txtCoach.Text & "', conference='" & txtConference.Text & "' , division='" & txtDivision.Text & "', startdate='" & dPickerStart.Value & "',
        location='" & txtLocation.Text & "', arena='" & txtArena.Text & "', capacity='" & txtArenaCapacity.Text & "', opened='" & txtYearOpened.Text & "', 
        win='" & txtW.Text & "', loss='" & txtL.Text & "' where team= '" & txtTeam.Text & "'"
        connectionUpdateTeam.Open()
        scommandDB = New SqlCommand(sqldb, connectionUpdateTeam)
        Try
            scommandDB.ExecuteNonQuery()
            connectionUpdateTeam.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "error")
        End Try
        Me.Close()
    End Sub
End Class