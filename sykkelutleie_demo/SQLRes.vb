''' <summary>
''' Klasse som holder SQL-spørringer som konstanter.
''' </summary>
''' <remarks></remarks>
Public Class SQLRes
    Public DBTestInsert As String = "INSERT INTO  ansatt(`brukernavn` ,`passord` ,`fornavn` ,`etternavn` ,`telefon` ,`epost` ,`adresse` ,`stilling` ,`postnr` ,`aktivert`)VALUES ('testbrukernavn',  'testpassord',  'Per',  'Olav',  '8888887',  'test@mail.cns',  'testveien 118',  'Lagerarbeider',  '7020',  '1')"

    Public autoIncrementAs2 As String = "ALTER TABLE ansatt AUTO_INCREMENT=2"

    Public deleteManyAnsatt As String = "delete from ansatt where ansattid > 1"

    Public cheapestBicycle As String = "SELECT sykkel.rammenr, sykkel.modell, modell.pris FROM sykkel JOIN modell ON sykkel.modell=modell.modell GROUP BY modell ORDER BY pris"

    Public costliestBicycle As String = "SELECT sykkel.rammenr, sykkel.modell, modell.pris FROM sykkel JOIN modell ON sykkel.modell=modell.modell GROUP BY modell ORDER BY pris DESC"

    Public mosteActiveSalesman As String = "SELECT COUNT(bestilling.ansattid) AS Salg, ansatt.fornavn, ansatt.etternavn, ansatt.ansattid FROM ansatt JOIN bestilling ON bestilling.ansattid=ansatt.ansattid "
    'SELECT COUNT(bestilling.ansattid) AS Salg, ansatt.fornavn, ansatt.etternavn, ansatt.ansattid FROM ansatt JOIN bestilling ON bestilling.ansattid=ansatt.ansattid WHERE datotid BETWEEN '2015/03/09' AND '2015/03/11'
End Class
