﻿Public Class PawnTicket

    Dim fillData As String = "tblPawn"
    Dim mySql As String = ""
    Dim ds As DataSet

#Region "Variables"
    Private _pawnid As Integer
    Private _pawnTicket As Integer
    Private _client As Client
    Private _loanDate As Date
    Private _matuDate As Date
    Private _expiryDate As Date
    Private _auctionDate As Date
    Private _itemType As String
    Private _catID As Integer
    Private _description As String
    Private _karat As String
    Private _grams As Double
    Private _appraisal As Double
    Private _principal As Double
    Private _interest As Double
    Private _netAmount As Double
    Private _evat As Double
    Private _appraiserID As Integer

    Private _oldTicket As Integer
    Private _orNum As Integer
    Private _orDate As Date
    Private _lessPrincipal As Double
    Private _daysOverDue As Double
    'Private _delayInt As Double
    Private _penalty As Double
    Private _serviceCharge As Double
    Private _renewDue As Double
    Private _redeemDue As Double
    Private _status As String

#End Region

#Region "Properties"
    Public ReadOnly Property PawnID As Integer
        Get
            Return _pawnid
        End Get
    End Property

    Public Property PawnTicket As Integer
        Set(ByVal value As Integer)
            _pawnTicket = value
        End Set
        Get
            Return _pawnTicket
        End Get
    End Property

    Public Property Pawner As Client
        Set(ByVal value As Client)
            _client = value
        End Set
        Get
            Return _client
        End Get
    End Property

    Public Property LoanDate As Date
        Set(ByVal value As Date)
            _loanDate = value
        End Set
        Get
            Return _loanDate
        End Get
    End Property

    Public Property MaturityDate As Date
        Set(ByVal value As Date)
            _matuDate = value
        End Set
        Get
            Return _matuDate
        End Get
    End Property

    Public Property ExpiryDate As Date
        Set(ByVal value As Date)
            _expiryDate = value
        End Set
        Get
            Return _expiryDate
        End Get
    End Property

    Public Property AuctionDate As Date
        Set(ByVal value As Date)
            _auctionDate = value
        End Set
        Get
            Return _auctionDate
        End Get
    End Property

    Public Property ItemType As String
        Set(ByVal value As String)
            _itemType = value
        End Set
        Get
            Return _itemType
        End Get
    End Property

    Public Property CategoryID As Integer
        Set(ByVal value As Integer)
            _catID = value
        End Set
        Get
            Return _catID
        End Get
    End Property

    Public Property Description As String
        Set(ByVal value As String)
            _description = value
        End Set
        Get
            Return _description
        End Get
    End Property

    Public Property Karat As String
        Set(ByVal value As String)
            _karat = value
        End Set
        Get
            Return _karat
        End Get
    End Property

    Public Property Grams As Double
        Set(ByVal value As Double)
            _grams = value
        End Set
        Get
            Return _grams
        End Get
    End Property

    Public Property Appraisal As Double
        Set(ByVal value As Double)
            _appraisal = value
        End Set
        Get
            Return _appraisal
        End Get
    End Property

    Public Property Principal As Double
        Set(ByVal value As Double)
            _principal = value
        End Set
        Get
            Return _principal
        End Get
    End Property

    Public Property Interest As Double
        Set(ByVal value As Double)
            _interest = value
        End Set
        Get
            Return _interest
        End Get
    End Property

    Public Property NetAmount As Double
        Set(ByVal value As Double)
            _netAmount = value
        End Set
        Get
            Return _netAmount
        End Get
    End Property

    Public Property EVAT As Double
        Set(ByVal value As Double)
            _evat = value
        End Set
        Get
            Return _evat
        End Get
    End Property

    Public Property AppraiserID As Integer
        Set(ByVal value As Integer)
            _appraiserID = value
        End Set
        Get
            Return _appraiserID
        End Get
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property

    Public Property OldTicket As Integer
        Set(ByVal value As Integer)
            _oldTicket = value
        End Set
        Get
            Return _oldTicket
        End Get
    End Property

    Public Property OfficialReceiptNumber As Integer
        Set(ByVal value As Integer)
            _orNum = value
        End Set
        Get
            Return _orNum
        End Get
    End Property

    Public Property OfficialReceiptDate As Date
        Set(ByVal value As Date)
            _orDate = value
        End Set
        Get
            If _orDate = #12:00:00 AM# Then
                _orDate = Nothing
            End If
            Return _orDate
        End Get
    End Property

    Public Property LessPrincipal As Double
        Set(ByVal value As Double)
            _lessPrincipal = value
        End Set
        Get
            Return _lessPrincipal
        End Get
    End Property

    Public Property DaysOverDue As Double
        Set(ByVal value As Double)
            _daysOverDue = value
        End Set
        Get
            Return _daysOverDue
        End Get
    End Property

    Private _earlyRedeem As Double
    ''' <summary>
    ''' Interest from Early Redemption
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property EarlyRedeem() As Double
        Get
            Return _earlyRedeem
        End Get
        Set(ByVal value As Double)
            _earlyRedeem = value
        End Set
    End Property


    Public Property Penalty As Double
        Set(ByVal value As Double)
            _penalty = value
        End Set
        Get
            Return _penalty
        End Get
    End Property

    Public Property ServiceCharge As Double
        Set(ByVal value As Double)
            _serviceCharge = value
        End Set
        Get
            Return _serviceCharge
        End Get
    End Property

    Public Property RenewDue As Double
        Set(ByVal value As Double)
            _renewDue = value
        End Set
        Get
            Return _renewDue
        End Get
    End Property

    Public Property RedeemDue As Double
        Set(ByVal value As Double)
            _redeemDue = value
        End Set
        Get
            Return _redeemDue
        End Get
    End Property

    Private _advanceInterest As Double
    Public Property AdvanceInterest() As Double
        Get
            Return _advanceInterest
        End Get
        Set(ByVal value As Double)
            _advanceInterest = value
        End Set
    End Property

    Private _pullOut As Date
    Public ReadOnly Property PullOutDate() As Date
        Get
            Return _pullOut
        End Get
    End Property


#End Region

#Region "Procedures and Functions"
    Public Sub SaveTicket(Optional ByVal isNew As Boolean = True)
        Dim fillData As String = "tblPawn"
        Dim ds As DataSet, mySql As String = "SELECT * FROM " & fillData
        If Not isNew Then mySql &= " WHERE PawnID = " & _pawnid
        ds = LoadSQL(mySql, fillData)

        Dim dsNewRow As DataRow
        If isNew Then
            dsNewRow = ds.Tables(fillData).NewRow
            With dsNewRow
                .Item("PawnTicket") = _pawnTicket
                .Item("ClientID") = Pawner.ID
                .Item("LoanDate") = _loanDate
                .Item("MatuDate") = _matuDate
                .Item("ExpiryDate") = _expiryDate
                .Item("AuctionDate") = _auctionDate
                .Item("ItemType") = _itemType
                .Item("CatID") = _catID
                .Item("Description") = _description
                .Item("Karat") = _karat
                .Item("Grams") = _grams
                .Item("Appraisal") = _appraisal
                .Item("Principal") = _principal
                .Item("Interest") = _interest
                .Item("NetAmount") = _netAmount
                .Item("Evat") = _evat
                .Item("AppraiserID") = _appraiserID
                .Item("OldTicket") = _oldTicket
                .Item("ORNum") = _orNum
                .Item("ORDate") = _orDate
                .Item("LessPrincipal") = _lessPrincipal
                .Item("DaysOverDue") = _daysOverDue
                '.Item("DelayInt") = _delayInt
                .Item("Penalty") = _penalty
                .Item("ServiceCharge") = _serviceCharge
                .Item("RenewDue") = _renewDue
                .Item("RedeemDue") = _redeemDue
                .Item("Status") = _status
                .Item("SystemInfo") = Now
                .Item("EncoderID") = UserID
                .Item("AdvInt") = _advanceInterest
                .Item("EarlyRedeem") = _earlyRedeem
            End With
            ds.Tables(fillData).Rows.Add(dsNewRow)
        Else
            With ds.Tables(fillData).Rows(0)
                .Item("PawnTicket") = _pawnTicket
                .Item("ClientID") = Pawner.ID
                .Item("LoanDate") = _loanDate
                .Item("MatuDate") = _matuDate
                .Item("ExpiryDate") = _expiryDate
                .Item("AuctionDate") = _auctionDate
                .Item("ItemType") = _itemType
                .Item("CatID") = _catID
                .Item("Description") = _description
                .Item("Karat") = _karat
                .Item("Grams") = _grams
                .Item("Appraisal") = _appraisal
                .Item("Principal") = _principal
                .Item("Interest") = _interest
                .Item("NetAmount") = _netAmount
                .Item("Evat") = _evat
                .Item("AppraiserID") = _appraiserID
                .Item("OldTicket") = _oldTicket
                .Item("ORNum") = _orNum
                .Item("ORDate") = _orDate
                .Item("LessPrincipal") = _lessPrincipal
                .Item("DaysOverDue") = _daysOverDue
                '.Item("DelayInt") = _delayInt
                .Item("Penalty") = _penalty
                .Item("ServiceCharge") = _serviceCharge
                .Item("RenewDue") = _renewDue
                .Item("RedeemDue") = _redeemDue
                .Item("Status") = _status
                .Item("SystemInfo") = Now
                .Item("EncoderID") = UserID
                .Item("AdvInt") = _advanceInterest
                .Item("EarlyRedeem") = _earlyRedeem
            End With
        End If

        database.SaveEntry(ds, isNew)
    End Sub

    Public Sub LoadTicket(ByVal id As Integer, Optional ByVal col As String = "PAWNID")
        Dim mySql As String = "SELECT * FROM tblpawn WHERE " & col & " = " & id
        Dim ds As DataSet = LoadSQL(mySql)

        With ds.Tables(0).Rows(0)
            _pawnid = .Item("PawnID")
            _pawnTicket = .Item("PawnTicket")
            Dim tmpClient As New Client
            tmpClient.LoadClient(.Item("ClientID"))
            _client = tmpClient
            _loanDate = .Item("LoanDate")
            _matuDate = .Item("MatuDate")
            _expiryDate = .Item("ExpiryDate")
            _auctionDate = .Item("AuctionDate")
            _itemType = .Item("ItemType")
            _catID = .Item("CatID")
            _description = IIf(IsDBNull(.Item("Description")), "", .Item("Description"))
            _karat = .Item("Karat")
            _grams = .Item("Grams")
            _appraisal = .Item("Appraisal")
            _principal = .Item("Principal")
            _interest = .Item("Interest")
            _netAmount = .Item("NetAmount")
            _evat = .Item("Evat")
            _appraiserID = .Item("AppraiserID")
            _oldTicket = .Item("OldTicket")
            _orNum = .Item("ORNum")
            _orDate = .Item("ORDate")
            _lessPrincipal = .Item("LessPrincipal")
            _daysOverDue = .Item("DaysOverDue")
            '_delayInt = .Item("DelayInt")
            _penalty = .Item("Penalty")
            _serviceCharge = .Item("ServiceCharge")
            _renewDue = .Item("RenewDue")
            _redeemDue = .Item("RedeemDue")
            _status = .Item("Status")
            _advanceInterest = .Item("AdvInt")
            _earlyRedeem = .Item("EarlyRedeem")
            If Not IsDBNull(.Item("PullOut")) Then _pullOut = .Item("PullOut")
        End With
    End Sub

    Public Sub LoadTicketInReader(reader As IDataReader)
        With reader
            _pawnid = .Item("PawnID")
            _pawnTicket = .Item("PawnTicket")
            Dim tmpClient As New Client
            tmpClient.LoadClient(.Item("ClientID"))
            _client = tmpClient
            _loanDate = .Item("LoanDate")
            _matuDate = .Item("MatuDate")
            _expiryDate = .Item("ExpiryDate")
            _auctionDate = .Item("AuctionDate")
            _itemType = .Item("ItemType")
            _catID = .Item("CatID")
            If Not IsDBNull(.Item("Description")) Then _description = .Item("Description")
            _karat = .Item("Karat")
            _grams = .Item("Grams")
            _appraisal = .Item("Appraisal")
            _principal = .Item("Principal")
            _interest = .Item("Interest")
            _netAmount = .Item("NetAmount")
            _evat = .Item("Evat")
            _appraiserID = .Item("AppraiserID")
            _oldTicket = .Item("OldTicket")
            _orNum = .Item("ORNum")
            _orDate = .Item("ORDate")
            _lessPrincipal = .Item("LessPrincipal")
            _daysOverDue = .Item("DaysOverDue")
            '_delayInt = .Item("DelayInt")
            _penalty = .Item("Penalty")
            _serviceCharge = .Item("ServiceCharge")
            _renewDue = .Item("RenewDue")
            _redeemDue = .Item("RedeemDue")
            _status = .Item("Status")
            _advanceInterest = .Item("AdvInt")
            _earlyRedeem = .Item("EarlyRedeem")
            If Not IsDBNull(.Item("PullOut")) Then _pullOut = .Item("PullOut")
        End With
    End Sub

    Public Sub LoadTicketInRow(ByVal dr As DataRow)
        With dr
            _pawnid = .Item("PawnID")
            _pawnTicket = .Item("PawnTicket")
            Dim tmpClient As New Client
            tmpClient.LoadClient(.Item("ClientID"))
            _client = tmpClient
            _loanDate = .Item("LoanDate")
            _matuDate = .Item("MatuDate")
            _expiryDate = .Item("ExpiryDate")
            _auctionDate = .Item("AuctionDate")
            _itemType = .Item("ItemType")
            _catID = .Item("CatID")
            If Not IsDBNull(.Item("Description")) Then _description = .Item("Description")
            _karat = .Item("Karat")
            _grams = .Item("Grams")
            _appraisal = .Item("Appraisal")
            _principal = .Item("Principal")
            _interest = .Item("Interest")
            _netAmount = .Item("NetAmount")
            _evat = .Item("Evat")
            _appraiserID = .Item("AppraiserID")
            _oldTicket = .Item("OldTicket")
            _orNum = .Item("ORNum")
            _orDate = .Item("ORDate")
            _lessPrincipal = .Item("LessPrincipal")
            _daysOverDue = .Item("DaysOverDue")
            '_delayInt = .Item("DelayInt")
            _penalty = .Item("Penalty")
            _serviceCharge = .Item("ServiceCharge")
            _renewDue = .Item("RenewDue")
            _redeemDue = .Item("RedeemDue")
            _status = .Item("Status")
            _advanceInterest = .Item("AdvInt")
            _earlyRedeem = .Item("EarlyRedeem")
            If Not IsDBNull(.Item("PullOut")) Then _pullOut = .Item("PullOut")
        End With
    End Sub

    Public Sub ChangeStatus(ByVal str As String)
        mySql = "SELECT * FROM " & fillData & " WHERE PawnID = " & _pawnid
        ds = LoadSQL(mySql, fillData)

        Console.WriteLine("PawnID: " & Me._pawnid)
        Console.WriteLine("PawnTicket: " & Me._pawnTicket)
        Console.WriteLine("Client: " & Me._client.FirstName)
        Console.WriteLine("Status: " & Me._status)

        ds.Tables(0).Rows(0).Item("status") = str
        database.SaveEntry(ds, False)
    End Sub

    Public Sub VoidCancelTicket()
        Try
            Dim curStatus As String = _status

            If _status = "L" Then
                ChangeStatus("V")
                RemoveJournal("PT# " & _pawnTicket)
                Exit Sub
            End If

            If _status <> "X" Then
                ChangeStatus("V")
            End If

            If _oldTicket <> 0 Then
                'Has Old PawnTicket
                mySql = "SELECT * FROM " & fillData & " WHERE PawnTicket = " & _oldTicket
                ds = New DataSet
                ds = LoadSQL(mySql, fillData)
                Dim st As String
                If ds.Tables(fillData).Rows.Count = 0 Then
                    ChangeStatus("L")
                    RemoveJournal("PT# " & _pawnTicket)
                    Exit Sub
                Else
                    If IsDBNull(ds.Tables(0).Rows(0).Item("OldTicket")) Or ds.Tables(0).Rows(0).Item("OldTicket") = 0 Then
                        st = "L"
                    Else
                        st = "R"
                    End If
                End If

                ds.Tables(fillData).Rows(0).Item("Status") = st
                With ds.Tables(fillData).Rows(0)
                    .Item("OrNum") = 0
                    .Item("OrDate") = New Date
                    .Item("DAYSOVERDUE") = 0
                    .Item("DelayINT") = 0
                    .Item("Penalty") = 0
                    .Item("ServiceCharge") = 0
                    .Item("RenewDue") = 0
                    .Item("RedeemDue") = 0
                    .Item("AdvInt") = 0
                End With
                database.SaveEntry(ds, False)
                RemoveJournal("PT# " & _oldTicket)
            Else
                ChangeStatus("L")
                RemoveJournal("PT# " & _pawnTicket)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "VOID TRANSACTION")
        End Try
    End Sub

    Public Sub RedeemTicket()
        ChangeStatus(0) 'Inactive
    End Sub

    Public Sub RenewTicket()
        ChangeStatus(0) 'Inactive
    End Sub

    Public Sub PullOut(ByVal dt As Date)
        ChangeStatus("W")

        mySql = "SELECT * FROM " & fillData & _
            " WHERE PawnID = " & _pawnid
        Dim ds As DataSet = LoadSQL(mySql, fillData)
        ds.Tables(fillData).Rows(0).Item("PullOut") = dt
        database.SaveEntry(ds, False)
    End Sub

#End Region
End Class
