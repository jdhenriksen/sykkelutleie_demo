''' <summary>
''' Klasse som holder SQL-spørringer som konstanter.
''' </summary>
''' <remarks></remarks>
Public Class SQLRes
    Public DBTestInsert As String = "INSERT INTO  ansatt(`brukernavn` ,`passord` ,`fornavn` ,`etternavn` ,`telefon` ,`epost` ,`adresse` ,`stilling` ,`postnr` ,`aktivert`)VALUES ('testbrukernavn',  'testpassord',  'Per',  'Olav',  '8888887',  'test@mail.cns',  'testveien 118',  'Lagerarbeider',  '7020',  '1')"

    Public autoIncrementAs2 As String = "ALTER TABLE ansatt AUTO_INCREMENT=2"

    Public deleteManyAnsatt As String = "delete from ansatt where ansattid > 1"

    Public cheapestBicycles As String = "SELECT sykkel.rammenr, sykkel.modell, modell.pris FROM sykkel JOIN modell ON sykkel.modell=modell.modell GROUP BY modell ORDER BY pris LIMIT "

    Public costliestBicycles As String = "SELECT sykkel.rammenr, sykkel.modell, modell.pris FROM sykkel JOIN modell ON sykkel.modell=modell.modell GROUP BY modell ORDER BY pris DESC LIMIT "

    Public mosteActiveSalesman As String = "SELECT COUNT(bestilling.ansattid) AS Salg, ansatt.fornavn, ansatt.etternavn, ansatt.ansattid FROM ansatt JOIN bestilling ON bestilling.ansattid=ansatt.ansattid "

    Public leastActiveSalesman As String = "SELECT COUNT(bestilling.ansattid) AS Salg, ansatt.fornavn, ansatt.etternavn, ansatt.ansattid FROM ansatt JOIN bestilling ON bestilling.ansattid=ansatt.ansattid "

    Public avanseBicycles As String = "SELECT SUM(modell.pris) AS 'Avanse på sykkel i perioden' FROM modell JOIN sykkel ON modell.modell=sykkel.modell JOIN sykkel_bestilling ON sykkel.rammenr=sykkel_bestilling.rammenr JOIN bestilling ON sykkel_bestilling.bestillingsid=bestilling.bestillingsid "

    Public countOrders As String = "SELECT COUNT(bestillingsid) AS 'Antall bestillinger i perioden' FROM bestilling "

    Public countMosteActiveBicycles As String = "SELECT COUNT(bestilling.bestillingsid) AS 'Ganger utleid', sykkel.rammenr AS 'Ramme nummer', sykkel.modell AS 'Modell', modell.pris AS 'Pris' FROM modell JOIN sykkel ON modell.modell=sykkel.modell JOIN sykkel_bestilling ON sykkel.rammenr=sykkel_bestilling.rammenr JOIN bestilling ON sykkel_bestilling.bestillingsid=bestilling.bestillingsid "

    Public countLeastActiveBicycles As String = "SELECT COUNT(bestilling.bestillingsid) AS 'Ganger utleid', sykkel.rammenr AS 'Ramme nummer', sykkel.modell AS 'Modell', modell.pris AS 'Pris' FROM modell JOIN sykkel ON modell.modell=sykkel.modell JOIN sykkel_bestilling ON sykkel.rammenr=sykkel_bestilling.rammenr JOIN bestilling ON sykkel_bestilling.bestillingsid=bestilling.bestillingsid "
End Class
