
Public Class Model
    'Private listofEquipment As List(Of Equipment)
    Property model As String
    Property price As Double
    Property producer As String
    Property category As String
    Dim anySqlQuery As New DBUtility
    Dim sqlstring As String
    Dim answer As String
    Dim myData As New DataTable
    Private dao As New ModelDao
    ''' <summary>
    ''' Ny modellobject instans
    ''' </summary>
    ''' <remarks> New lager nytt objekt uti fra verdier som blir sendt til den</remarks>
    Public Sub New(ByVal modelname As String, ByVal modelprice As Double, ByVal modelproducer As String, ByVal modelcategory As String)

        model = modelname
        price = modelprice
        producer = modelproducer
        category = modelcategory

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
    Public Sub changeModel()

        dao.editModel(makeList())

    End Sub

    ''' <summary>
    ''' Modell søk
    ''' </summary>
    ''' <remarks>Fyller opp resultatliste(datagridView) med modeller</remarks>
    Public Function searchModell()

        myData = dao.searchModel(makeList())

        Return myData

    End Function
    ''' <summary>
    ''' Slette Modell
    ''' </summary>
    ''' <remarks>Sletter modeller og returnerer msgbox hvis det blir utført</remarks>

    Public Function allmodels()

        myData = dao.selectAllModels

        Return myData

    End Function

    Public Function relmodels(ByVal chosenmodel As String) As DataTable

        myData = dao.chooseModel(chosenmodel)

        Return myData

    End Function

    Public Function getModel()
        Return model
    End Function

    Public Function getPrice()
        If price = 0 Then
            Return ""
        Else
            Return price
        End If

    End Function

    Public Function getProducer()
        Return producer
    End Function

    Public Function getCategory()
        Return category
    End Function

    '  SKAL BRUKES I MODEL
    Private Function makeList() As List(Of String)
        Dim list As New List(Of String)
        list.Add(getModel())
        list.Add(getPrice())
        list.Add(getProducer())
        list.Add(getCategory())
        Return list
    End Function


End Class
