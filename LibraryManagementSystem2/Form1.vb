Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class Form1

    Const CONN_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=LibraryDB.accdb"

    Enum BookStatus
        Available = 1
        Borrowed = 2
    End Enum

    ' Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Library Management System"
        radLight.Checked = True
    End Sub

    ' Navigation Buttons
    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        Dim frm As New FormBooks
        frm.Show()
    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        Dim frm As New FormMembers
        frm.Show()
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        Dim frm As New FormBorrow
        frm.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim ppd As New PrintPreviewDialog()
        ppd.Document = PrintDocument1
        ppd.ShowDialog()
    End Sub

    ' Theme RadioButtons
    Private Sub radLight_CheckedChanged(sender As Object, e As EventArgs) Handles radLight.CheckedChanged
        If radLight.Checked Then
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub radDark_CheckedChanged(sender As Object, e As EventArgs) Handles radDark.CheckedChanged
        If radDark.Checked Then
            Me.BackColor = Color.Gray
        End If
    End Sub

    ' Custom Color Button
    Private Sub btnCustomColor_Click(sender As Object, e As EventArgs) Handles btnCustomColor.Click
        If ColorDialog1.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            Me.BackColor = ColorDialog1.Color
        End If
    End Sub

    ' Print Report
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 12)
        Dim y As Integer = 100
        e.Graphics.DrawString("Overdue Books Report", New Font("Arial", 14, FontStyle.Bold), Brushes.Black, 100, 50)
        Dim conn As New OleDbConnection(CONN_STRING)
        Dim cmd As New OleDbCommand("SELECT Books.Title, Members.Name, BorrowingRecords.DueDate FROM (BorrowingRecords INNER JOIN Books ON BorrowingRecords.BookID = Books.BookID) INNER JOIN Members ON BorrowingRecords.MemberID = Members.MemberID WHERE BorrowingRecords.Returned = 0 AND BorrowingRecords.DueDate < #" & DateTime.Now.ToString("MM/dd/yyyy") & "#", conn)
        Try
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                e.Graphics.DrawString(reader("Title") & " | " & reader("Name") & " | " & reader("DueDate"), font, Brushes.Black, 100, y)
                y += 20
            End While
        Catch ex As Exception
            MsgBox("Report error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            conn.Close()
        End Try
    End Sub

End Class