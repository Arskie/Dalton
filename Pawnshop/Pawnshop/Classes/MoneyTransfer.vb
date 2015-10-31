﻿Public Class MoneyTransfer

    Private fillData As String = "tblMoneyTransfer"

#Region "Variables"
    Private _id As Integer
    Private _ref As String
    Private _date As Date
    Private _serviceType As String
    Private _transType As Integer = 0
    Private _client1 As Client
    Private _client2 As Client
    Private _amount As Double = 0
    Private _location As String
    Private _service As Double = 0
    Private _netAmount As Double = 0
    Private _encoderID As Integer
    Private _status As String
#End Region

#Region "Properties"
    Public Property ID As Integer
        Set(ByVal value As Integer)
            _id = value
        End Set
        Get
            Return _id
        End Get
    End Property

    Public Property ReferenceNumber As String
        Set(ByVal value As String)
            _ref = value
        End Set
        Get
            Return _ref
        End Get
    End Property

    Public Property TransactionDate As Date
        Set(ByVal value As Date)
            _date = value
        End Set
        Get
            Return _date
        End Get
    End Property

    Public Property ServiceType As String
        Get
            Return _serviceType
        End Get
        Set(ByVal value As String)
            _serviceType = value
        End Set
    End Property

    Public Property TransactionType As Integer
        Set(ByVal value As Integer)
            _transType = value
        End Set
        Get
            Return _transType
        End Get
    End Property

    Public Property Sender As Client
        Set(ByVal value As Client)
            _client1 = value
        End Set
        Get
            Return _client1
        End Get
    End Property

    Public Property Receiver As Client
        Set(ByVal value As Client)
            _client2 = value
        End Set
        Get
            Return _client2
        End Get
    End Property

    Public Property TransferAmount As Double
        Set(ByVal value As Double)
            _amount = value
        End Set
        Get
            Return _amount
        End Get
    End Property

    Public Property Location As String
        Get
            Return _location
        End Get
        Set(ByVal value As String)
            _location = value
        End Set
    End Property

    Public Property ServiceCharge As Double
        Set(ByVal value As Double)
            _service = value
        End Set
        Get
            Return _service
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

    Public Property Status As String
        Set(ByVal value As String)
            _status = value
        End Set
        Get
            Return _status
        End Get
    End Property
#End Region

#Region "Procedures and Functions"
    Public Sub LoadTransaction(ByVal id As Integer)
        Dim ds As DataSet, mySql As String
        mySql = "SELECT * FROM tblMoneyTransfer WHERE ID = " & id
        ds = LoadSQL(mySql)

        loadByRow(ds.Tables(0).Rows(0))
    End Sub

    Public Sub LoadTransactionByRow(ByVal dr As DataRow)
        loadByRow(dr)
    End Sub

    Private Sub loadByRow(ByVal dr As DataRow)
        With dr
            _transType = .Item("Transaction")
            _serviceType = .Item("ServiceType")
            Dim tmpClient As New Client
            tmpClient.LoadClient(.Item("SenderID"))
            _client1 = tmpClient
            tmpClient.LoadClient(.Item("ReceiverID"))
            _client2 = tmpClient
            _ref = .Item("RefNum")
            _amount = .Item("Amount")
            _location = .Item("location")
            _date = .Item("TransDate")
            _service = .Item("ServiceCharge")
            _netAmount = .Item("NetAmount")
            _encoderID = .Item("EncoderID")
            _status = .Item("Status")
        End With
    End Sub

    Public Sub Save()
        Dim mySql As String, ds As DataSet
        mySql = "SELECT * FROM " & fillData
        ds = LoadSQL(mySql, fillData)

        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables(fillData).NewRow
        With dsNewRow
            .Item("Transaction") = _transType
            .Item("ServiceType") = _serviceType
            .Item("TransDate") = _date
            .Item("SenderID") = _client1.ID
            .Item("SenderName") = String.Format("{0} {1}", _client1.FirstName, _client1.LastName)
            .Item("ReceiverID") = _client2.ID
            .Item("ReceiverName") = String.Format("{0} {1}", _client2.FirstName, _client2.LastName)
            .Item("RefNum") = _ref
            .Item("Amount") = _amount
            .Item("Location") = _location
            .Item("ServiceCharge") = _service
            .Item("NetAmount") = _netAmount
            .Item("Status") = _status
            .Item("EncoderID") = _encoderID
            .Item("SystemInfo") = Now
        End With
        ds.Tables(fillData).Rows.Add(dsNewRow)

        database.SaveEntry(ds, False)
    End Sub
#End Region
End Class