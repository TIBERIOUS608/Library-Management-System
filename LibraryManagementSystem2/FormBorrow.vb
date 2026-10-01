Imports System.Data.OleDb

Public Class FormBorrow

    Const CONN_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=LibraryDB.accdb"

    Private Sub FormBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Borrow/Return Books"
        LoadBooks()
        LoadMembers()
    End Sub

    Private Sub LoadBooks()
        cmbBooks.Items.Clear()
        Dim conn As New OleDbConnection(CONN_STRING)
        Dim cmd As New OleDbCommand("SELECT BookID, Title FROM Books WHERE Available = True", conn)
        Try
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbBooks.Items.Add(reader("BookID") & ": " & reader("Title"))
            End While
        Catch ex As Exception
            MsgBox("Error loading books: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
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

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        If cmbBooks.SelectedIndex = -1 Or cmbMembers.SelectedIndex = -1 Then
            MsgBox("Please select both a book and a member.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If dtpDue.Value <= dtpBorrow.Value Then
            MsgBox("Due date must be after borrow date.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim bookID As Integer = CInt(cmbBooks.SelectedItem.ToString().Split(":")(0))
        Dim memberID As Integer = CInt(cmbMembers.SelectedItem.ToString().Split(":")(0))
        Dim conn As New OleDbConnection(CONN_STRING)
        Try
            conn.Open()
            Dim cmdInsert As New OleDbCommand("INSERT INTO BorrowingRecords (BookID, MemberID, BorrowDate, DueDate, Returned) VALUES (?, ?, ?, ?, ?)", conn)
            cmdInsert.Parameters.AddWithValue("?", bookID)
            cmdInsert.Parameters.AddWithValue("?", memberID)
            cmdInsert.Parameters.AddWithValue("?", dtpBorrow.Value.Date)
            cmdInsert.Parameters.AddWithValue("?", dtpDue.Value.Date)
            cmdInsert.Parameters.AddWithValue("?", False)
            cmdInsert.ExecuteNonQuery()
            Dim cmdUpdate As New OleDbCommand("UPDATE Books SET Available = False WHERE BookID = ?", conn)
            cmdUpdate.Parameters.AddWithValue("?", bookID)
            cmdUpdate.ExecuteNonQuery()
            MsgBox("Book borrowed successfully!", MsgBoxStyle.Information)
            LoadBooks()
        Catch ex As Exception
            MsgBox("Error borrowing book: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If cmbBooks.SelectedIndex = -1 Then
            MsgBox("Please select a book to return.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim bookID As Integer = CInt(cmbBooks.SelectedItem.ToString().Split(":")(0))
        Dim conn As New OleDbConnection(CONN_STRING)
        Try
            conn.Open()
            Dim cmdUpdate As New OleDbCommand("UPDATE BorrowingRecords SET Returned = True WHERE BookID = ? AND Returned = False", conn)
            cmdUpdate.Parameters.AddWithValue("?", bookID)
            cmdUpdate.ExecuteNonQuery()
            Dim cmdBook As New OleDbCommand("UPDATE Books SET Available = True WHERE BookID = ?", conn)
            cmdBook.Parameters.AddWithValue("?", bookID)
            cmdBook.ExecuteNonQuery()
            MsgBox("Book returned successfully!", MsgBoxStyle.Information)
            LoadBooks()
        Catch ex As Exception
            MsgBox("Error returning book: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

End Class