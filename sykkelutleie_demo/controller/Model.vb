﻿Public Class Model
    'Private listofEquipment As List(Of Equipment)
    Property model As String
    Property price As Double
    Property producer As String
    Property category As String

    Private myData As New DataTable
    Private dao As New ModelDao

    ''' <summary>
    ''' Ny modellobject instans
    ''' </summary>
    ''' <remarks> New lager nytt objekt uti fra verdier som blir sendt til den</remarks>
    Public Sub New(model As String, price As Double, producer As String, category As String)
        Me.model = model
        Me.price = price
        Me.producer = producer
        Me.category = category
    End Sub

    Public Sub New()

    End Sub

    ''' <summary>
    ''' Ny Modell
    ''' </summary>
    ''' <remarks> Lager en ny modell utifra objektet som allerede er opprettet.
    ''' Det må lages et nytt objekt før createModel blir kjørt
    ''' Den returnerer msgbox hvis en ny modell ble laget</remarks>
    Public Sub createModel()
        dao.createModel(makeList())
    End Sub

    ''' <summary>
    ''' Endre modell
    ''' </summary>
    ''' <remarks>Msgbox returneres hvis endring blir utført </remarks>
    Public Sub editModel()
        dao.editModel(makeList())
    End Sub

    ''' <summary>
    ''' Modell søk
    ''' </summary>
    ''' <remarks>Fyller opp resultatliste(datagridView) med modeller</remarks>
    Public Function searchModel()
        myData = dao.searchModel(makeList())
        Return myData
    End Function

    Public Function selectAllModels()
        myData = dao.selectAllModels()
        Return myData
    End Function

    Public Function getModelById(frameNumber As String) As DataTable
        myData = dao.getModelById(frameNumber)
        Return myData
    End Function

    Public Function getModel() As String
        Return model
    End Function

    Public Function getPrice() As String
        If price = 0 Then
            Return ""
        Else
            Return price
        End If
    End Function

    Public Function getProducer() As String
        Return producer
    End Function

    Public Function getCategory() As String
        Return category
    End Function

    Private Function makeList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(getModel())
        list.Add(getPrice())
        list.Add(getProducer())
        list.Add(getCategory())
        Return list
    End Function
End Class
