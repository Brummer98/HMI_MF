Imports System.Data.SqlClient
Imports System.Timers
Imports AdvancedHMIControls
Imports MfgControl.AdvancedHMI.Drivers

Public Class MainForm
    Inherits System.Windows.Forms.Form
    ' New variables
    Private myTagName As String
    Private myTagValue As Int32
    Private loopVar As Int32
    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private resultDB As String
    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    '***************************************************************
    '* .NET does not close hidden forms, so do it here
    '* to make sure forms are disposed and drivers close
    '***************************************************************
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim index As Integer
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
    End Sub

    Private Sub TimerReadData(ByVal source As Object, ByVal e As ElapsedEventArgs)

        Dim sConnection As String = "Initial Catalog=TagTableFactory;" &
            "Data Source=.\sqlexpress;Integrated Security=true;"
        Using Con As New SqlConnection(sConnection)
            Con.Open()

            'read data from database
            Using Com As New SqlCommand("Select TagValue From Tags", Con)
                Using RDR = Com.ExecuteReader()
                    If RDR.HasRows Then
                        Do While RDR.Read
                            resultDB = RDR.Item("TagValue").ToString()
                            'MsgBox(resultDB)
                            'kbiTag.Text = resultDB
                        Loop
                    End If
                End Using
            End Using

            Con.Close()

        End Using

        Try
            'Write new data to PLC
            EthernetIPforCLXCom1.Write(kbiTag.PLCAddressWriteValue.PLCAddress, kbiTag.Text)
        Catch ex As Exception
            'System.Windows.Forms.MessageBox.Show("Failed to write value - " & ex.Message)
        End Try

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim timer As Timer = New Timer()
        timer.Interval = 100
        AddHandler timer.Elapsed, AddressOf TimerReadData
        timer.AutoReset = True
        timer.Enabled = True

    End Sub

    Private Sub insertData()
        kbiTag.Text = resultDB
    End Sub


    Private Sub btnSendTagData_Click(sender As Object, e As EventArgs) Handles btnSendTagData.Click
        ' Set vars to values
        myTagName = DPMTag.PLCAddressText
        myTagValue = DPMTag.Value
        ' create sql command to send data to database

        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=TagTableFactory;" &
        "Data Source=.\sqlexpress;Integrated Security=true;")

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "INSERT INTO Tags (TagName, TagValue) VALUES ('" & myTagName & "', '" & myTagValue & "')"

        'Open the connection.
        myConn.Open()

        'Read the command.
        myReader = myCmd.ExecuteReader()

        MsgBox("Data succesfully send to DB")

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub btnUpdateTag_Click(sender As Object, e As EventArgs) Handles btnUpdateTag.Click
        ' Set vars to values
        myTagName = DPMTag.PLCAddressText
        myTagValue = DPMTag.Value
        ' create sql command to send data to database

        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=TagTableFactory;" &
        "Data Source=.\sqlexpress;Integrated Security=true;")

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "UPDATE Tags SET tagName = ('" & myTagName & "'), tagValue = ('" & myTagValue & "') 
        WHERE tagName = ('" & myTagName & "')"

        'Open the connection.
        myConn.Open()

        'Read the command.
        myReader = myCmd.ExecuteReader()

        MsgBox("Data succesfully send to DB")

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub btnRetrieveData_Click(sender As Object, e As EventArgs) Handles btnRetrieveData.Click
        'Create a Connection object.
        myConn = New SqlConnection("Initial Catalog=TagTableFactory;" &
        "Data Source=.\sqlexpress;Integrated Security=true;")

        'Create a Command object.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT TagName, TagValue FROM Tags"

        'Open the connection.
        myConn.Open()

        'Read the command.
        myReader = myCmd.ExecuteReader()

        'Concatenate the query result into a string.
        Do While myReader.Read()
            results = results & myReader.GetString(0) & vbTab &
            myReader.GetString(1) & vbLf
        Loop

        'Display results.
        'MsgBox(results)
        lblDB.Text = results

        'Close the reader and the database connection.
        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub MainForm_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        insertData()
    End Sub
End Class
