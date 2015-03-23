
Public Class Model

    Private model As String
    Private price As String
    Private producer As String
    Private category As String
    Dim anySqlQuery As New DBUtility
    Dim sqlstring As String
    Dim svar As String
    ''' <summary>
    ''' Ny modellobject instans
    ''' </summary>
    ''' <param name="m"></param>
    ''' <param name="pri"></param>
    ''' <param name="pro"></param>
    ''' <param name="c"></param>
    ''' <remarks> New lager nytt objekt uti fra verdier som blir sendt til den</remarks>
    Public Sub New(ByVal m As String, ByVal pri As String, ByVal pro As String, ByVal c As String)

        model = m
        price = pri
        producer = pro
        category = c

    End Sub
    ''' <summary>
    ''' Ny Modell
    ''' </summary>
    ''' <remarks> Lager en ny modell utifra objektet som allerede er opprettet.
    ''' Det må lages et nytt objekt før createModel blir kjørt
    ''' Den returnerer msgbox hvis en ny modell ble laget</remarks>
    Public Sub createModel()

        sqlstring = "INSERT INTO modell (modell, pris, produsent, kategori) VALUES ('" & getModel() & "','" & getPrice() & "','" & getProducer() & "','" & getCategory() & "')"

        svar = anySqlQuery.updateQuery(sqlstring)

        If svar = "True" Then
            MsgBox("Modellnavn: " & getModel() & " er opprettet")
        End If

    End Sub
    ''' <summary>
    ''' Endre modell
    ''' </summary>
    ''' <remarks>Msgbox returneres hvis endring blir utført </remarks>
    Public Sub changeModel()
        sqlstring = "UPDATE modell SET pris ='" & getPrice() & "', produsent ='" & getProducer() & "', kategori ='" & getCategory() & "' WHERE modell = '" & getModel() & "'"

        svar = anySqlQuery.updateQuery(sqlstring)

        If svar = True Then
            MsgBox("Modellnavn: " & getModel() & " er endret")
        End If

    End Sub
    ''' <summary>
    ''' Modell søk
    ''' </summary>
    ''' <remarks>Fyller opp resultatliste(datagridView) med modeller</remarks>
    Public Sub sokModell()

        Dim myData As New DataTable

        sqlstring = "SELECT modell, pris, produsent, kategori FROM modell WHERE (modell LIKE '%" & getModel() & "%') AND (pris LIKE '%" & getPrice() & "%') AND (produsent LIKE '%" & getProducer() & "%') AND (kategori LIKE '%" & getCategory() & "%')"

        myData = anySqlQuery.selectQuery(sqlstring)

        StorageWorker.dtgvModel.DataSource = myData

    End Sub
    ''' <summary>
    ''' Slette Modell
    ''' </summary>
    ''' <remarks>Sletter modeller og returnerer msgbox hvis det blir utført</remarks>
    Public Sub deleteModell()
        svar = anySqlQuery.updateQuery("DELETE FROM modell WHERE modell = '" & getModel() & "'")

        If svar = "True" Then
            MsgBox("Modell med navn: " & getModel() & " er slettet")
        End If

    End Sub

    Public Function getModel()
        Return model
    End Function

    Public Function getPrice()
        Return price
    End Function

    Public Function getProducer()
        Return producer
    End Function

    Public Function getCategory()
        Return category
    End Function

End Class
