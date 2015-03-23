
Public Class Model

    Private model As String
    Private price As String
    Private producer As String
    Private category As String
    Dim anySqlQuery As New DBUtility
    Dim sqlstring As String

    Public Sub New(ByVal m As String, ByVal pri As String, ByVal pro As String, ByVal c As String)

        model = m
        price = pri
        producer = pro
        category = c

    End Sub
    Public Sub createModel()

        sqlstring = "INSERT INTO modell (modell, pris, produsent, kategori) VALUES ('" & GetModel() & "','" & GetPrice() & "','" & GetProducer() & "','" & GetCategory() & "')"

        anySqlQuery.updateQuery(sqlstring)

        StorageWorker.oModell.Clear()
        StorageWorker.oPrice.Clear()
        StorageWorker.oProducer.Clear()
        StorageWorker.oCategory.Clear()
        StorageWorker.eModell.Clear()
        StorageWorker.ePris.Clear()
        StorageWorker.eProd.Clear()
        StorageWorker.eCat.Clear()

    End Sub
    Public Sub changeModel()
        sqlstring = "UPDATE modell SET pris ='" & GetPrice() & "', produsent ='" & GetProducer() & "', kategori ='" & GetCategory() & "' WHERE modell = '" & GetModel() & "'"

        anySqlQuery.updateQuery(sqlstring)
        StorageWorker.eModell.Clear()
        StorageWorker.ePris.Clear()
        StorageWorker.eProd.Clear()
        StorageWorker.eCat.Clear()
        StorageWorker.eModell.ReadOnly = True
        StorageWorker.ePris.ReadOnly = True
        StorageWorker.eProd.ReadOnly = True
        StorageWorker.eCat.ReadOnly = True
    End Sub

    Public Sub sokModell()
        Dim myData As New DataTable
        sqlstring = "SELECT modell, pris, produsent, kategori FROM modell WHERE (modell LIKE '%" & GetModel() & "%') AND (pris LIKE '%" & GetPrice() & "%') AND (kategori LIKE '%" & GetCategory() & "%')"
        myData = anySqlQuery.selectQuery(sqlstring)
        StorageWorker.DataGridView2.DataSource = myData
        StorageWorker.oModell.Clear()
        StorageWorker.oPrice.Clear()
        StorageWorker.oProducer.Clear()
        StorageWorker.oCategory.Clear()
        StorageWorker.eModell.Clear()
        StorageWorker.ePris.Clear()
        StorageWorker.eProd.Clear()
        StorageWorker.eCat.Clear()
    End Sub

    Public Sub deleteModell()
        anySqlQuery.updateQuery("DELETE FROM modell WHERE modell = '" & GetModel() & "'")
        StorageWorker.eModell.Clear()
        StorageWorker.ePris.Clear()
        StorageWorker.eProd.Clear()
        StorageWorker.eCat.Clear()
    End Sub

    Public Function GetModel()
        Return model
    End Function

    Public Sub SetModel(ByVal m As String)

    End Sub

    Public Function GetPrice()
        Return price
    End Function

    Public Sub SetPrice(ByVal pri As String)

    End Sub
    Public Function GetProducer()
        Return producer
    End Function

    Public Sub SetProducer(ByVal pro As String)

    End Sub
    Public Function GetCategory()
        Return category
    End Function

    Public Sub SetCategory(ByVal c As String)

    End Sub

End Class

