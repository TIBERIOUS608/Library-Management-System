Imports System.Data.OleDb

Public Class FormMembers

    Const CONN_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=LibraryDB.accdb"

    Private Sub FormMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Manage Members"
        LoadMembers()
    End Sub

    Private Sub LoadMembers()
        cmbMembers.Items.Clear()
        Dim conn As New OleDbConnection(CONN_STRING)
        Dim cmd As New OleDbCommand("SELECT MemberID, Name FROM Members", conn)
        Try
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbMembers.Items.Add(reader("MemberID") & ": " & reader("Name"))
            End While
        Catch ex As Exception
            MsgBox("Error loading members: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnAddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click
        If txtName.Text = "" Or txtEmail.Text = "" Then
            MsgBox("Please fill in all fields.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim conn As New OleDbConnection(CONN_STRING)
        Dim cmd As New OleDbCommand("INSERT INTO Members (Name, Email, JoinDate) VALUES (?, ?, ?)", conn)
        cmd.Parameters.AddWithValue("?", txtName.Text)
        cmd.Parameters.AddWithValue("?", txtEmail.Text)
        cmd.Parameters.AddWithValue("?", dtpJoinDate.Value.Date)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Member added successfully!", MsgBoxStyle.Information)
            LoadMembers()
            ClearFields()
        Catch ex As Exception
            MsgBox("Error adding member: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ClearFields()
        txtName.Text = ""
        txtEmail.Text = ""
        dtpJoinDate.Value = DateTime.Now
    End Sub

End Class