﻿Public Class BikeDao
    Private dbutil As New DBUtility
    Private table As New DataTable

    Public Sub createBike(list As List(Of String))
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlCreateBike)
    End Sub

    Public Sub editBike(list As List(Of String))
        populateList(list)
        dbutil.paramQuery(SQLRes.sqlEditBike)
    End Sub

    Public Sub deleteBike(framenumber As String)
        dbutil.addParametersToQuery("@framenumber", framenumber)
        dbutil.paramQuery(SQLRes.sqlDeleteBike)
    End Sub

    Public Function searchBike(list As List(Of String)) As DataTable
        Dim newList() As String = prepareForSearch(list)
        Dim i As Integer
        For i = 0 To newList.Length - 1
            list(i) = newList(i)
        Next
        populateList(list)
        table = dbutil.paramQuery(SQLRes.searchBike)
        Return table
    End Function

    Public Function getModelName(framenumber As String) As DataTable
        dbutil.addParametersToQuery("@framenumber", framenumber)
        table = dbutil.paramQuery(SQLRes.sqlGetModelName)
        Return table
    End Function

    Public Function selectAllBikes() As DataTable
        table = dbutil.paramQuery(SQLRes.sqlSelectAllBikes)
        Return table
    End Function

    Private Sub populateList(list As List(Of String))
        With dbutil
            .addParametersToQuery("@framenumber", list(0))
            .addParametersToQuery("@status", list(1))
            .addParametersToQuery("@location", list(2))
            .addParametersToQuery("@placeOfOrigin", list(3))
            .addParametersToQuery("@brakes", list(4))
            .addParametersToQuery("@tires", list(5))
            .addParametersToQuery("@frame", list(6))
            .addParametersToQuery("@gear", list(7))
            .addParametersToQuery("@model", list(8))
        End With
    End Sub

    Private Function prepareForSearch(inputList As List(Of String)) As String()
        Dim i As Integer
        Dim listItemLength As Integer
        Dim list(inputList.Count - 1) As String
        For i = 0 To inputList.Count - 1
            If String.IsNullOrEmpty(inputList(i)) Or inputList(i) = Nothing Then
                list(i) = String.Format("%{0}%", inputList(i))
            Else
                listItemLength = inputList(i).Length
                list(i) = String.Format("%{0," & listItemLength & "}%", inputList(i))
            End If
        Next
        Return list
    End Function

    'SKAL BRUKES I BIKE
    'Private Function makeList() As List(Of String)
    '    Dim list As New List(Of String)
    '    list.Add(getFrameNumber())
    '    list.Add(getStatus())
    '    list.Add(getLocation())
    '    list.Add(getPlaceOfOrigins())
    '    list.Add(brakes)
    '    list.Add(getTires())
    '    list.Add(getFrame())
    '    list.Add(getGear())
    '    list.Add(model.getModel())
    '    Return list
    'End Function
End Class
