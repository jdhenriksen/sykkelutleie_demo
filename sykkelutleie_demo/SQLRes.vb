''' <summary>
''' Klasse som holder SQL-spørringer som konstanter.
''' </summary>
''' <remarks></remarks>
Public Class SQLRes
    Public DBTestInsert As String = "INSERT INTO  ansatt(`brukernavn` ,`passord` ,`fornavn` ,`etternavn` ,`telefon` ,`epost` ,`adresse` ,`stilling` ,`postnr` ,`aktivert`)VALUES ('testbrukernavn',  'testpassord',  'Per',  'Olav',  '8888887',  'test@mail.cns',  'testveien 118',  'Lagerarbeider',  '7020',  '1')"

    Public autoIncrementAs2 As String = "ALTER TABLE ansatt AUTO_INCREMENT=2"

    Public deleteManyAnsatt As String = "delete from ansatt where ansattid > 1"
End Class
