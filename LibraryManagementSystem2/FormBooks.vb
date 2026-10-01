Imports System.Data.OleDb

Public Class FormBooks

    Const CONN_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=LibraryDB.accdb"

    Private Sub FormBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Manage Books"
        LoadBooks()
    End Sub

    Private Sub LoadBooks()
        lstBooks.Items.Clear()
        Dim conn As New OleDbConnection(CONN_STRING)
        Dim cmd As New OleDbCommand("SELECT BookID, Title, Author, PublicationYear, Available FROM Books", conn)
        Try
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                lstBooks.Items.Add(reader("BookID") & ": " & reader("Title") & " by " & reader("Author"))
            End While
        Catch ex As Exception
            MsgBox("Error loading books: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtTitle.Text = "" Or txtAuthor.Text = "" Or txtYear.Text = "" Then
            MsgBox("Please fill in all fields.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If Not IsNumeric(txtYear.Text) Then
            MsgBox("Publication Year must be a number.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim conn As New OleDbConnection(CONN_STRING)
        Dim cmd As New OleDbCommand("INSERT INTO Books (Title, Author, PublicationYear, Available) VALUES (?, ?, ?, ?)", conn)
        cmd.Parameters.AddWithValue("?", txtTitle.Text)
        cmd.Parameters.AddWithValue("?", txtAuthor.Text)
        cmd.Parameters.AddWithValue("?", CInt(txtYear.Text))
        cmd.Parameters.AddWithValue("?", chkAvailable.Checked)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Book added successfully!", MsgBoxStyle.Information)
            LoadBooks()
            ClearFields()
        Catch ex As Exception
            MsgBox("Error adding book: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lstBooks.SelectedIndex = -1 Then
            MsgBox("Please select a book to update.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim bookID As Integer = CInt(lstBooks.SelectedItem.ToString().Split(":")(0))
        Dim conn As New OleDbConnection(CONN_STRING)
        Dim cmd As New OleDbCommand("UPDATE Books SET Title=?, Author=?, PublicationYear=?, Available=? WHERE BookID=?", conn)
        cmd.Parameters.AddWithValue("?", txtTitle.Text)
        cmd.Parameters.AddWithValue("?", txtAuthor.Text)
        cmd.Parameters.AddWithValue("?", CInt(txtYear.Text))
        cmd.Parameters.AddWithValue("?", chkAvailable.Checked)
        cmd.Parameters.AddWithValue("?", bookID)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Book updated successfully!", MsgBoxStyle.Information)
            LoadBooks()
            ClearFields()
        Catch ex As Exception
            MsgBox("Error updating book: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lstBooks.SelectedIndex = -1 Then
            MsgBox("Please select a book to delete.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim confirm As MsgBoxResult = MsgBox("Are you sure you want to delete this book?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question)
        If confirm = MsgBoxResult.Yes Then
            Dim bookID As Integer = CInt(lstBooks.SelectedItem.ToString().Split(":")(0))
            Dim conn As New OleDbConnection(CONN_STRING)
            Dim cmd As New OleDbCommand("DELETE FROM Books WHERE BookID=?", conn)
            cmd.Parameters.AddWithValue("?", bookID)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Book deleted successfully!", MsgBoxStyle.Information)
                LoadBooks()
                ClearFields()
            Catch ex As Exception
                MsgBox("Error deleting book: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub lstBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBooks.SelectedIndexChanged
        If lstBooks.SelectedIndex = -1 Then Exit Sub
        Dim bookID As Integer = CInt(lstBooks.SelectedItem.ToString().Split(":")(0))
        Dim conn As New OleDbConnection(CONN_STRING)
        Dim cmd As New OleDbCommand("SELECT * FROM Books WHERE BookID=?", conn)
        cmd.Parameters.AddWithValue("?", bookID)
        Try
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtTitle.Text = reader("Title").ToString()
                txtAuthor.Text = reader("Author").ToString()
                txtYear.Text = reader("PublicationYear").ToString()
                chkAvailable.Checked = CBool(reader("Available"))
            End If
        Catch ex As Exception
            MsgBox("Error loading book details: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ClearFields()
        txtTitle.Text = ""
        txtAuthor.Text = ""
        txtYear.Text = ""
        chkAvailable.Checked = False
    End Sub

End Class