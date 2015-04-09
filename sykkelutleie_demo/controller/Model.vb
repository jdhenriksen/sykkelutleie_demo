
Public Class Model

    Property model As String
    Property price As Double
    Property producer As String
    Property category As String
    Dim anySqlQuery As New DBUtility
    Dim sqlstring As String
    Dim answer As String
    Dim myData As New DataTable

    ''' <summary>
    ''' Ny modellobject instans
    ''' </summary>
    ''' <remarks> New lager nytt objekt uti fra verdier som blir sendt til den</remarks>
    Public Sub New(ByVal m As String, ByVal pri As Double, ByVal pro As String, ByVal c As String)

        model = m
        price = pri
        producer = pro
        category = c

    End Sub
    Public Sub New()

    End Sub

    ''' <summary>
    ''' Ny Modell
    ''' </summary>
    ''' <remarks> Lager en ny modell utifra objektet som allerede er opprettet.
    ''' Det må lages et nytt objekt før createModel blir kjørt
    ''' Den returnerer msgbox hvis en ny modell ble laget</remarks>
    Public Function createModel()

        sqlstring = "INSERT INTO modell (modell, pris, produsent, kategori) VALUES ('" & getModel() & "','" & getPrice() & "','" & getProducer() & "','" & getCategory() & "')"

        answer = anySqlQuery.updateQuery(sqlstring)

        Return answer

    End Function

    ''' <summary>
    ''' Endre modell
    ''' </summary>
    ''' <remarks>Msgbox returneres hvis endring blir utført </remarks>
    Public Function changeModel()

        sqlstring = "UPDATE modell SET pris ='" & getPrice() & "', produsent ='" & getProducer() & "', kategori ='" & getCategory() & "' WHERE modell = '" & getModel() & "'"

        answer = anySqlQuery.updateQuery(sqlstring)

        Return answer

    End Function

    ''' <summary>
    ''' Modell søk
    ''' </summary>
    ''' <remarks>Fyller opp resultatliste(datagridView) med modeller</remarks>
    Public Function searchModell()

        sqlstring = "SELECT modell, pris, produsent, kategori FROM modell WHERE (modell LIKE '%" & getModel() & "%') AND (pris LIKE '%" & getPrice() & "%') AND (produsent LIKE '%" & getProducer() & "%') AND (kategori LIKE '%" & getCategory() & "%')"

        myData = anySqlQuery.selectQuery(sqlstring)

        Return myData

    End Function
    ''' <summary>
    ''' Slette Modell
    ''' </summary>
    ''' <remarks>Sletter modeller og returnerer msgbox hvis det blir utført</remarks>
    Public Function deleteModell()
        answer = anySqlQuery.updateQuery("DELETE FROM modell WHERE modell = '" & getModel() & "'")

        Return answer

    End Function

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
