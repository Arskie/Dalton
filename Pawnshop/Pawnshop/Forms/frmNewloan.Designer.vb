﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewloan
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
        Me.grpPawner = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtPawner = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpItem = New System.Windows.Forms.GroupBox()
        Me.cboKarat = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGrams = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboItemtype = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpTicket = New System.Windows.Forms.GroupBox()
        Me.txtNticket = New System.Windows.Forms.TextBox()
        Me.lblNticket = New System.Windows.Forms.Label()
        Me.Auction = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Expiry = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Maturity = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LoanDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.grpReceipt = New System.Windows.Forms.GroupBox()
        Me.txtless = New System.Windows.Forms.TextBox()
        Me.lblLess = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtRedeemDue = New System.Windows.Forms.TextBox()
        Me.lblRedeemDue = New System.Windows.Forms.Label()
        Me.txtAppraisal2 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Receiptdate = New System.Windows.Forms.DateTimePicker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtRenewDue = New System.Windows.Forms.TextBox()
        Me.lblRenewDue = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtinterest = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtOverDue = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblTranstype = New System.Windows.Forms.Label()
        Me.btnLess = New System.Windows.Forms.Button()
        Me.grpAmount = New System.Windows.Forms.GroupBox()
        Me.txtNet = New System.Windows.Forms.TextBox()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.txtAppraisal = New System.Windows.Forms.TextBox()
        Me.lblAppraisal = New System.Windows.Forms.Label()
        Me.grpPawner.SuspendLayout()
        Me.grpItem.SuspendLayout()
        Me.grpTicket.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpReceipt.SuspendLayout()
        Me.grpAmount.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPawner
        '
        Me.grpPawner.Controls.Add(Me.TextBox7)
        Me.grpPawner.Controls.Add(Me.Label16)
        Me.grpPawner.Controls.Add(Me.TextBox5)
        Me.grpPawner.Controls.Add(Me.Label15)
        Me.grpPawner.Controls.Add(Me.txtAddress)
        Me.grpPawner.Controls.Add(Me.Label3)
        Me.grpPawner.Controls.Add(Me.btnSearch)
        Me.grpPawner.Controls.Add(Me.txtPawner)
        Me.grpPawner.Controls.Add(Me.Label2)
        Me.grpPawner.Location = New System.Drawing.Point(12, 66)
        Me.grpPawner.Name = "grpPawner"
        Me.grpPawner.Size = New System.Drawing.Size(479, 181)
        Me.grpPawner.TabIndex = 4
        Me.grpPawner.TabStop = False
        Me.grpPawner.Text = "Pawner's Information"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(141, 140)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(250, 22)
        Me.TextBox7.TabIndex = 18
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 143)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 16)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Contact Number:"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(142, 109)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(250, 22)
        Me.TextBox5.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 16)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Birthdate:"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(142, 39)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(250, 66)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Text = "Eskie Cirrus James Maquilang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Full Address:"
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(398, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtPawner
        '
        Me.txtPawner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPawner.Location = New System.Drawing.Point(142, 13)
        Me.txtPawner.Name = "txtPawner"
        Me.txtPawner.ReadOnly = True
        Me.txtPawner.Size = New System.Drawing.Size(250, 22)
        Me.txtPawner.TabIndex = 1
        Me.txtPawner.Text = "Eskie Cirrus James Maquilang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'grpItem
        '
        Me.grpItem.Controls.Add(Me.cboKarat)
        Me.grpItem.Controls.Add(Me.Label7)
        Me.grpItem.Controls.Add(Me.txtGrams)
        Me.grpItem.Controls.Add(Me.Label4)
        Me.grpItem.Controls.Add(Me.cboCategory)
        Me.grpItem.Controls.Add(Me.Label6)
        Me.grpItem.Controls.Add(Me.cboItemtype)
        Me.grpItem.Controls.Add(Me.Label5)
        Me.grpItem.Controls.Add(Me.txtDesc)
        Me.grpItem.Controls.Add(Me.Label1)
        Me.grpItem.Location = New System.Drawing.Point(12, 247)
        Me.grpItem.Name = "grpItem"
        Me.grpItem.Size = New System.Drawing.Size(479, 176)
        Me.grpItem.TabIndex = 5
        Me.grpItem.TabStop = False
        Me.grpItem.Text = "Pawned Item Information"
        '
        'cboKarat
        '
        Me.cboKarat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKarat.Enabled = False
        Me.cboKarat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboKarat.FormattingEnabled = True
        Me.cboKarat.Items.AddRange(New Object() {"10", "12", "14", "16", "18", "20", "21", "22", "24"})
        Me.cboKarat.Location = New System.Drawing.Point(142, 139)
        Me.cboKarat.Name = "cboKarat"
        Me.cboKarat.Size = New System.Drawing.Size(124, 21)
        Me.cboKarat.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Karat:"
        '
        'txtGrams
        '
        Me.txtGrams.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrams.Location = New System.Drawing.Point(142, 115)
        Me.txtGrams.Name = "txtGrams"
        Me.txtGrams.ReadOnly = True
        Me.txtGrams.Size = New System.Drawing.Size(124, 22)
        Me.txtGrams.TabIndex = 22
        Me.txtGrams.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Grams:"
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.Enabled = False
        Me.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(142, 91)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(124, 21)
        Me.cboCategory.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Category:"
        '
        'cboItemtype
        '
        Me.cboItemtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItemtype.Enabled = False
        Me.cboItemtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboItemtype.FormattingEnabled = True
        Me.cboItemtype.Items.AddRange(New Object() {"APP", "CEL", "JWL", "BIG"})
        Me.cboItemtype.Location = New System.Drawing.Point(142, 68)
        Me.cboItemtype.Name = "cboItemtype"
        Me.cboItemtype.Size = New System.Drawing.Size(124, 21)
        Me.cboItemtype.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Item Type:"
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(142, 18)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.Size = New System.Drawing.Size(331, 48)
        Me.txtDesc.TabIndex = 3
        Me.txtDesc.Text = "AAAAAAAAAAAAAAAAAAAAAAAAA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Description:"
        '
        'grpTicket
        '
        Me.grpTicket.Controls.Add(Me.txtNticket)
        Me.grpTicket.Controls.Add(Me.lblNticket)
        Me.grpTicket.Controls.Add(Me.Auction)
        Me.grpTicket.Controls.Add(Me.Label10)
        Me.grpTicket.Controls.Add(Me.Expiry)
        Me.grpTicket.Controls.Add(Me.Label9)
        Me.grpTicket.Controls.Add(Me.Maturity)
        Me.grpTicket.Controls.Add(Me.Label8)
        Me.grpTicket.Controls.Add(Me.LoanDate)
        Me.grpTicket.Controls.Add(Me.Label11)
        Me.grpTicket.Controls.Add(Me.TextBox4)
        Me.grpTicket.Controls.Add(Me.Label12)
        Me.grpTicket.Location = New System.Drawing.Point(508, 66)
        Me.grpTicket.Name = "grpTicket"
        Me.grpTicket.Size = New System.Drawing.Size(265, 179)
        Me.grpTicket.TabIndex = 6
        Me.grpTicket.TabStop = False
        Me.grpTicket.Text = "Ticket Information"
        '
        'txtNticket
        '
        Me.txtNticket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNticket.Location = New System.Drawing.Point(133, 41)
        Me.txtNticket.Name = "txtNticket"
        Me.txtNticket.ReadOnly = True
        Me.txtNticket.Size = New System.Drawing.Size(113, 22)
        Me.txtNticket.TabIndex = 47
        '
        'lblNticket
        '
        Me.lblNticket.AutoSize = True
        Me.lblNticket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNticket.Location = New System.Drawing.Point(5, 44)
        Me.lblNticket.Name = "lblNticket"
        Me.lblNticket.Size = New System.Drawing.Size(89, 16)
        Me.lblNticket.TabIndex = 46
        Me.lblNticket.Text = "New Ticket:"
        '
        'Auction
        '
        Me.Auction.Enabled = False
        Me.Auction.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Auction.Location = New System.Drawing.Point(133, 134)
        Me.Auction.Name = "Auction"
        Me.Auction.Size = New System.Drawing.Size(113, 20)
        Me.Auction.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Auction Date:"
        '
        'Expiry
        '
        Me.Expiry.Enabled = False
        Me.Expiry.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Expiry.Location = New System.Drawing.Point(133, 112)
        Me.Expiry.Name = "Expiry"
        Me.Expiry.Size = New System.Drawing.Size(113, 20)
        Me.Expiry.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Expiry Date:"
        '
        'Maturity
        '
        Me.Maturity.Enabled = False
        Me.Maturity.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Maturity.Location = New System.Drawing.Point(133, 89)
        Me.Maturity.Name = "Maturity"
        Me.Maturity.Size = New System.Drawing.Size(113, 20)
        Me.Maturity.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Maturity Date:"
        '
        'LoanDate
        '
        Me.LoanDate.Enabled = False
        Me.LoanDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.LoanDate.Location = New System.Drawing.Point(133, 67)
        Me.LoanDate.Name = "LoanDate"
        Me.LoanDate.Size = New System.Drawing.Size(113, 20)
        Me.LoanDate.TabIndex = 26
        Me.LoanDate.Value = New Date(2015, 10, 15, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 16)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Loan Date:"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(133, 18)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(113, 22)
        Me.TextBox4.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 16)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Ticket No."
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox10)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Location = New System.Drawing.Point(508, 349)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(265, 74)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Appraiser"
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(9, 35)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(237, 22)
        Me.TextBox10.TabIndex = 1
        Me.TextBox10.Text = "Eskie Cirrus James Maquilang"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 16)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Appraise by:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(92, 432)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(74, 35)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(172, 432)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(74, 35)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnVoid
        '
        Me.btnVoid.Enabled = False
        Me.btnVoid.Location = New System.Drawing.Point(12, 432)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(74, 35)
        Me.btnVoid.TabIndex = 10
        Me.btnVoid.Text = "&Void"
        Me.btnVoid.UseVisualStyleBackColor = True
        '
        'grpReceipt
        '
        Me.grpReceipt.Controls.Add(Me.txtless)
        Me.grpReceipt.Controls.Add(Me.lblLess)
        Me.grpReceipt.Controls.Add(Me.TextBox1)
        Me.grpReceipt.Controls.Add(Me.Label18)
        Me.grpReceipt.Controls.Add(Me.txtRedeemDue)
        Me.grpReceipt.Controls.Add(Me.lblRedeemDue)
        Me.grpReceipt.Controls.Add(Me.txtAppraisal2)
        Me.grpReceipt.Controls.Add(Me.Label21)
        Me.grpReceipt.Controls.Add(Me.Receiptdate)
        Me.grpReceipt.Controls.Add(Me.TextBox3)
        Me.grpReceipt.Controls.Add(Me.txtRenewDue)
        Me.grpReceipt.Controls.Add(Me.lblRenewDue)
        Me.grpReceipt.Controls.Add(Me.TextBox8)
        Me.grpReceipt.Controls.Add(Me.Label23)
        Me.grpReceipt.Controls.Add(Me.TextBox9)
        Me.grpReceipt.Controls.Add(Me.Label24)
        Me.grpReceipt.Controls.Add(Me.txtinterest)
        Me.grpReceipt.Controls.Add(Me.Label25)
        Me.grpReceipt.Controls.Add(Me.txtOverDue)
        Me.grpReceipt.Controls.Add(Me.Label26)
        Me.grpReceipt.Controls.Add(Me.Label28)
        Me.grpReceipt.Controls.Add(Me.Label29)
        Me.grpReceipt.Location = New System.Drawing.Point(779, 66)
        Me.grpReceipt.Name = "grpReceipt"
        Me.grpReceipt.Size = New System.Drawing.Size(311, 357)
        Me.grpReceipt.TabIndex = 13
        Me.grpReceipt.TabStop = False
        Me.grpReceipt.Text = "Receipt Information"
        Me.grpReceipt.Visible = False
        '
        'txtless
        '
        Me.txtless.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtless.Location = New System.Drawing.Point(132, 89)
        Me.txtless.Name = "txtless"
        Me.txtless.ReadOnly = True
        Me.txtless.Size = New System.Drawing.Size(113, 22)
        Me.txtless.TabIndex = 53
        Me.txtless.Visible = False
        '
        'lblLess
        '
        Me.lblLess.AutoSize = True
        Me.lblLess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLess.Location = New System.Drawing.Point(5, 91)
        Me.lblLess.Name = "lblLess"
        Me.lblLess.Size = New System.Drawing.Size(106, 16)
        Me.lblLess.TabIndex = 54
        Me.lblLess.Text = "Less Principal"
        Me.lblLess.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(134, 212)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(113, 22)
        Me.TextBox1.TabIndex = 51
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 215)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 16)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Penalty:"
        '
        'txtRedeemDue
        '
        Me.txtRedeemDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRedeemDue.Location = New System.Drawing.Point(134, 313)
        Me.txtRedeemDue.Name = "txtRedeemDue"
        Me.txtRedeemDue.ReadOnly = True
        Me.txtRedeemDue.Size = New System.Drawing.Size(113, 22)
        Me.txtRedeemDue.TabIndex = 49
        Me.txtRedeemDue.Visible = False
        '
        'lblRedeemDue
        '
        Me.lblRedeemDue.AutoSize = True
        Me.lblRedeemDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRedeemDue.Location = New System.Drawing.Point(7, 316)
        Me.lblRedeemDue.Name = "lblRedeemDue"
        Me.lblRedeemDue.Size = New System.Drawing.Size(103, 16)
        Me.lblRedeemDue.TabIndex = 50
        Me.lblRedeemDue.Text = "Redeem Due:"
        Me.lblRedeemDue.Visible = False
        '
        'txtAppraisal2
        '
        Me.txtAppraisal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppraisal2.Location = New System.Drawing.Point(132, 65)
        Me.txtAppraisal2.Name = "txtAppraisal2"
        Me.txtAppraisal2.ReadOnly = True
        Me.txtAppraisal2.Size = New System.Drawing.Size(113, 22)
        Me.txtAppraisal2.TabIndex = 47
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(5, 66)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 16)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "Appraisal:"
        '
        'Receiptdate
        '
        Me.Receiptdate.Enabled = False
        Me.Receiptdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Receiptdate.Location = New System.Drawing.Point(132, 42)
        Me.Receiptdate.Name = "Receiptdate"
        Me.Receiptdate.Size = New System.Drawing.Size(113, 20)
        Me.Receiptdate.TabIndex = 46
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(132, 17)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(113, 22)
        Me.TextBox3.TabIndex = 43
        '
        'txtRenewDue
        '
        Me.txtRenewDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRenewDue.Location = New System.Drawing.Point(134, 288)
        Me.txtRenewDue.Name = "txtRenewDue"
        Me.txtRenewDue.ReadOnly = True
        Me.txtRenewDue.Size = New System.Drawing.Size(113, 22)
        Me.txtRenewDue.TabIndex = 41
        Me.txtRenewDue.Visible = False
        '
        'lblRenewDue
        '
        Me.lblRenewDue.AutoSize = True
        Me.lblRenewDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenewDue.Location = New System.Drawing.Point(7, 291)
        Me.lblRenewDue.Name = "lblRenewDue"
        Me.lblRenewDue.Size = New System.Drawing.Size(91, 16)
        Me.lblRenewDue.TabIndex = 42
        Me.lblRenewDue.Text = "Renew Due:"
        Me.lblRenewDue.Visible = False
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(134, 262)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(113, 22)
        Me.TextBox8.TabIndex = 39
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(7, 265)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 16)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "E-Vat:"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(134, 238)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(113, 22)
        Me.TextBox9.TabIndex = 37
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(7, 241)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(119, 16)
        Me.Label24.TabIndex = 38
        Me.Label24.Text = "Service Charge:"
        '
        'txtinterest
        '
        Me.txtinterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinterest.Location = New System.Drawing.Point(134, 187)
        Me.txtinterest.Name = "txtinterest"
        Me.txtinterest.ReadOnly = True
        Me.txtinterest.Size = New System.Drawing.Size(113, 22)
        Me.txtinterest.TabIndex = 35
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(7, 188)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(126, 16)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "Delayed Interest:"
        '
        'txtOverDue
        '
        Me.txtOverDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOverDue.Location = New System.Drawing.Point(134, 162)
        Me.txtOverDue.Name = "txtOverDue"
        Me.txtOverDue.ReadOnly = True
        Me.txtOverDue.Size = New System.Drawing.Size(113, 22)
        Me.txtOverDue.TabIndex = 33
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(7, 163)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(117, 16)
        Me.Label26.TabIndex = 34
        Me.Label26.Text = "Days Over Due:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(5, 41)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(103, 16)
        Me.Label28.TabIndex = 27
        Me.Label28.Text = "Receipt Date:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(5, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(90, 16)
        Me.Label29.TabIndex = 17
        Me.Label29.Text = "Receipt No:"
        '
        'lblTranstype
        '
        Me.lblTranstype.AutoSize = True
        Me.lblTranstype.Font = New System.Drawing.Font("Segoe UI", 26.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTranstype.ForeColor = System.Drawing.Color.Red
        Me.lblTranstype.Location = New System.Drawing.Point(12, 9)
        Me.lblTranstype.Name = "lblTranstype"
        Me.lblTranstype.Size = New System.Drawing.Size(210, 47)
        Me.lblTranstype.TabIndex = 14
        Me.lblTranstype.Text = "NEW LOAN"
        '
        'btnLess
        '
        Me.btnLess.Location = New System.Drawing.Point(508, 429)
        Me.btnLess.Name = "btnLess"
        Me.btnLess.Size = New System.Drawing.Size(102, 35)
        Me.btnLess.TabIndex = 15
        Me.btnLess.Text = "&Less Principal"
        Me.btnLess.UseVisualStyleBackColor = True
        Me.btnLess.Visible = False
        '
        'grpAmount
        '
        Me.grpAmount.Controls.Add(Me.txtNet)
        Me.grpAmount.Controls.Add(Me.lblNet)
        Me.grpAmount.Controls.Add(Me.txtPrincipal)
        Me.grpAmount.Controls.Add(Me.lblPrincipal)
        Me.grpAmount.Controls.Add(Me.txtAppraisal)
        Me.grpAmount.Controls.Add(Me.lblAppraisal)
        Me.grpAmount.Location = New System.Drawing.Point(508, 245)
        Me.grpAmount.Name = "grpAmount"
        Me.grpAmount.Size = New System.Drawing.Size(265, 106)
        Me.grpAmount.TabIndex = 16
        Me.grpAmount.TabStop = False
        Me.grpAmount.Text = "Amount"
        '
        'txtNet
        '
        Me.txtNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNet.Location = New System.Drawing.Point(138, 69)
        Me.txtNet.Name = "txtNet"
        Me.txtNet.ReadOnly = True
        Me.txtNet.Size = New System.Drawing.Size(113, 22)
        Me.txtNet.TabIndex = 47
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.Location = New System.Drawing.Point(11, 72)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(91, 16)
        Me.lblNet.TabIndex = 48
        Me.lblNet.Text = "Net Amount:"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrincipal.Location = New System.Drawing.Point(139, 43)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.ReadOnly = True
        Me.txtPrincipal.Size = New System.Drawing.Size(113, 22)
        Me.txtPrincipal.TabIndex = 45
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrincipal.Location = New System.Drawing.Point(12, 46)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(73, 16)
        Me.lblPrincipal.TabIndex = 46
        Me.lblPrincipal.Text = "Principal:"
        '
        'txtAppraisal
        '
        Me.txtAppraisal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppraisal.Location = New System.Drawing.Point(139, 18)
        Me.txtAppraisal.Name = "txtAppraisal"
        Me.txtAppraisal.ReadOnly = True
        Me.txtAppraisal.Size = New System.Drawing.Size(113, 22)
        Me.txtAppraisal.TabIndex = 43
        '
        'lblAppraisal
        '
        Me.lblAppraisal.AutoSize = True
        Me.lblAppraisal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppraisal.Location = New System.Drawing.Point(12, 21)
        Me.lblAppraisal.Name = "lblAppraisal"
        Me.lblAppraisal.Size = New System.Drawing.Size(79, 16)
        Me.lblAppraisal.TabIndex = 44
        Me.lblAppraisal.Text = "Appraisal:"
        '
        'frmNewloan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 494)
        Me.Controls.Add(Me.grpAmount)
        Me.Controls.Add(Me.btnLess)
        Me.Controls.Add(Me.lblTranstype)
        Me.Controls.Add(Me.grpReceipt)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grpTicket)
        Me.Controls.Add(Me.grpItem)
        Me.Controls.Add(Me.grpPawner)
        Me.Name = "frmNewloan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Loan"
        Me.grpPawner.ResumeLayout(False)
        Me.grpPawner.PerformLayout()
        Me.grpItem.ResumeLayout(False)
        Me.grpItem.PerformLayout()
        Me.grpTicket.ResumeLayout(False)
        Me.grpTicket.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grpReceipt.ResumeLayout(False)
        Me.grpReceipt.PerformLayout()
        Me.grpAmount.ResumeLayout(False)
        Me.grpAmount.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpPawner As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtPawner As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpItem As System.Windows.Forms.GroupBox
    Friend WithEvents cboKarat As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGrams As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboItemtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpTicket As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Auction As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Expiry As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Maturity As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents LoanDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnVoid As System.Windows.Forms.Button
    Friend WithEvents txtNticket As System.Windows.Forms.TextBox
    Friend WithEvents lblNticket As System.Windows.Forms.Label
    Friend WithEvents grpReceipt As System.Windows.Forms.GroupBox
    Friend WithEvents txtless As System.Windows.Forms.TextBox
    Friend WithEvents lblLess As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtRedeemDue As System.Windows.Forms.TextBox
    Friend WithEvents lblRedeemDue As System.Windows.Forms.Label
    Friend WithEvents txtAppraisal2 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Receiptdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRenewDue As System.Windows.Forms.TextBox
    Friend WithEvents lblRenewDue As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtinterest As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtOverDue As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblTranstype As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnLess As System.Windows.Forms.Button
    Friend WithEvents grpAmount As System.Windows.Forms.GroupBox
    Friend WithEvents txtNet As System.Windows.Forms.TextBox
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents txtPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents lblPrincipal As System.Windows.Forms.Label
    Friend WithEvents txtAppraisal As System.Windows.Forms.TextBox
    Friend WithEvents lblAppraisal As System.Windows.Forms.Label
End Class
