﻿Public Class frmInsuranceList

    Private Sub frmInsuranceList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearFields()
        LoadInsurance()
    End Sub

    Private Sub LoadInsurance()
        Dim mySql As String = "SELECT * FROM tblInsurance WHERE Status LIKE 'A' ORDER BY TRANSDATE DESC"
        Dim ds As DataSet = LoadSQL(mySql)

        For Each ins In ds.Tables(0).Rows
            Dim loadInsu As New Insurance
            loadInsu.LoadByRow(ins)
            AddItem(loadInsu)
        Next
    End Sub

    Private Sub AddItem(ByVal ins As Insurance)
        Dim lv As ListViewItem = lvInsurance.Items.Add(ins.COInumber)
        lv.SubItems.Add(ins.TransactionDate)
        lv.SubItems.Add(ins.ClientName)
        lv.SubItems.Add(ins.ValidDate)
        lv.SubItems.Add(ins.TicketNum)
        lv.Tag = ins.ID
        If ins.Status = "V" Then lv.BackColor = Color.LightGray
    End Sub

    Private Sub ClearFields()
        txtSearch.Text = ""
        lvInsurance.Items.Clear()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If Not lvInsurance.SelectedItems.Count > 0 Then Exit Sub

        Dim idx As Integer = lvInsurance.FocusedItem.Tag
        frmInsurance.LoadInsurance(idx)

        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then Exit Sub

        Dim mySql As String = "SELECT * FROM tblInsurance WHERE "
        If IsNumeric(txtSearch.Text) Then mySql &= "COINO = " & txtSearch.Text & " OR "
        mySql &= String.Format("LOWER(CLIENTNAME) LIKE LOWER('%{0}%')", txtSearch.Text)

        Console.WriteLine(mySql)
        Dim ds As DataSet = LoadSQL(mySql)
        lvInsurance.Items.Clear()
        For Each ins In ds.Tables(0).Rows
            Dim loadInsu As New Insurance
            loadInsu.LoadByRow(ins)
            AddItem(loadInsu)
        Next

        MsgBox(ds.Tables(0).Rows.Count & " item found.", MsgBoxStyle.Information)
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If isEnter(e) Then
            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub lvInsurance_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvInsurance.DoubleClick
        btnView.PerformClick()
    End Sub
End Class