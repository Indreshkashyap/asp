﻿Imports System.Data.OleDb
Partial Class Default9
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As OleDbConnection = New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0;Data Source=h:\root\home\indresh-001\www\boyshostel\Database91.accdb")
        con.Open()
        Dim acess As String = "insert into student_complaint(name,branch,semester,roomno,complaints) values( ' " & TextBox9.Text & "', ' " & DropDownList1.Text & " ' , '" & DropDownList2.Text & " ' ,'" & TextBox3.Text & " ' , ' " & TextBox8.Text & " ' )"
        Dim cmd As OleDbCommand = New OleDbCommand(acess, con)
        cmd.ExecuteNonQuery()
        con.Close()

        TextBox9.Text = ""
        DropDownList1.Text = ""
        DropDownList2.Text = ""
        TextBox3.Text = ""
        TextBox8.Text = ""
    End Sub
End Class
