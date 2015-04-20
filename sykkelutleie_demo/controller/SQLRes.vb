''' <summary>
''' Klasse som holder SQL-spørringer som konstanter.
''' </summary>
''' <remarks></remarks>
Public Class SQLRes

    'STATISTICS
    Public sqlCheapestBicycles As String = "SELECT sykkel.rammenr AS 'Rammenr.', sykkel.modell AS Modell, modell.pris AS Pris FROM sykkel JOIN modell ON sykkel.modell=modell.modell GROUP BY modell ORDER BY pris LIMIT @limit;"
    Public sqlMostExpensiveBicycles As String = "SELECT sykkel.rammenr AS 'Rammenr.', sykkel.modell, modell.pris FROM sykkel JOIN modell ON sykkel.modell=modell.modell GROUP BY modell ORDER BY pris DESC LIMIT @limit;"
    Public sqlMostActiveSalesman As String = "SELECT COUNT(bestilling.ansattid) AS Salg, ansatt.fornavn, ansatt.etternavn, ansatt.ansattid FROM ansatt JOIN bestilling ON bestilling.ansattid=ansatt.ansattid WHERE datotid BETWEEN @startDate AND @endDate;"
    Public sqlLeastActiveSalesman As String = "SELECT COUNT(bestilling.ansattid) AS Salg, ansatt.fornavn, ansatt.etternavn, ansatt.ansattid FROM ansatt JOIN bestilling ON bestilling.ansattid=ansatt.ansattid WHERE datotid BETWEEN @startDate AND @endDate GROUP BY ansatt.ansattid DESC;"
    Public sqlSalesIncomeBicycles As String = "SELECT SUM(modell.pris) AS 'Avanse på sykkel i perioden' FROM modell JOIN sykkel ON modell.modell=sykkel.modell JOIN sykkel_bestilling ON sykkel.rammenr=sykkel_bestilling.rammenr JOIN bestilling ON sykkel_bestilling.bestillingsid=bestilling.bestillingsid WHERE datotid BETWEEN @startDate AND @endDate;"
    Public sqlCountOrders As String = "SELECT COUNT(bestillingsid) AS 'Antall bestillinger i perioden' FROM bestilling WHERE datotid BETWEEN @startDate AND @endDate;"
    Public sqlCountMosteActiveBicycles As String = "SELECT COUNT(bestilling.bestillingsid) AS 'Ganger utleid', sykkel.rammenr AS 'Ramme nummer', sykkel.modell AS 'Modell', modell.pris AS 'Pris' FROM modell JOIN sykkel ON modell.modell=sykkel.modell JOIN sykkel_bestilling ON sykkel.rammenr=sykkel_bestilling.rammenr JOIN bestilling ON sykkel_bestilling.bestillingsid=bestilling.bestillingsid WHERE datotid BETWEEN @startDate AND @endDate GROUP BY sykkel.rammenr LIMIT @limit;"
    Public sqlCountLeastActiveBicycles As String = "SELECT COUNT(bestilling.bestillingsid) AS 'Ganger utleid', sykkel.rammenr AS 'Ramme nummer', sykkel.modell AS 'Modell', modell.pris AS 'Pris' FROM modell JOIN sykkel ON modell.modell=sykkel.modell JOIN sykkel_bestilling ON sykkel.rammenr=sykkel_bestilling.rammenr JOIN bestilling ON sykkel_bestilling.bestillingsid=bestilling.bestillingsid WHERE datotid BETWEEN @startDate AND @endDate GROUP BY sykkel.rammenr DESC LIMIT @limit;"

    'EMPLOYEE
    Public Const sqlCreateEmployee As String = "INSERT INTO  ansatt(`brukernavn` ,`passord` ,`fornavn` ,`etternavn` ,`telefon` ,`epost` ,`adresse` ,`stilling` ,`postnr` ,`aktivert`)" _
                & "VALUES (@username, @password, @firstname, @lastname, @phone, @email, @address, @job, @zip, @active);"
    Public Const sqlEditEmployee As String = "UPDATE ansatt SET brukernavn = @username, passord = @password, fornavn = @firstname, etternavn = @lastname " _
            & ", telefon = @phone, epost = @email, adresse = @address, stilling = @job, postnr = @zip, aktivert = @active " _
            & "WHERE ansattid = @id;"
    Public Const sqlDeleteEmployee As String = "UPDATE ansatt SET aktivert = 0 WHERE ansattid = @id;"
    Public Const sqlSelectEmployeeById As String = "SELECT * FROM ansatt WHERE ansattid = @id;"
    Public Const sqlGetAllEmployees As String = "SELECT * FROM ansatt WHERE aktivert = '1';"
    Public Const sqlIsActive As String = "SELECT aktivert FROM ansatt WHERE ansattid = @id;"
    Public Const sqlGetAreaByZipCode As String = "SELECT poststed FROM poststed WHERE postnr = @zipcode;"
    Public Const sqlUsernameCheck As String = "SELECT brukernavn FROM ansatt WHERE brukernavn = @username;"
    Public Const sqlLogin As String = "SELECT stilling FROM ansatt WHERE brukernavn = @username AND passord = @password AND aktivert = '1';"
    Public Const sqlCreateZipCode As String = "INSERT INTO poststed (`postnr`, `poststed`) VALUES(@zip, @area);"
    Public Const sqlZipCodeExists As String = "SELECT * FROM poststed WHERE postnr = @zip;"
    Public Const sqlSearchEmployee As String = "SELECT * FROM ansatt WHERE brukernavn LIKE @username AND " & _
            "fornavn LIKE @firstname AND etternavn LIKE @lastname AND telefon LIKE @phone AND epost LIKE @email AND " & _
            "adresse LIKE @address AND stilling LIKE @job AND postnr LIKE @zip AND aktivert LIKE @active;"
    Public Const sqlGetPasswordHashByUsername As String = "SELECT passord FROM ansatt WHERE brukernavn = @username;"
    Public Const sqlSetUserId As String = "SELECT ansattid FROM ansatt WHERE brukernavn = @username;"

    'CUSTOMER
    Public Const sqlCreateCustomer As String = "INSERT INTO kunde (`fornavn` ,`etternavn` ,`telefon` ,`epost` ,`aktivert`) " & _
            "VALUES(@firstname, @lastname, @phone, @email, @active);"
    Public Const sqlEditCustomer As String = "UPDATE kunde SET fornavn = @firstname, etternavn = @lastname, telefon = @phone, " & _
            "epost = @email, aktivert = @active WHERE kid = @id;"
    Public Const sqlDeleteCustomer As String = "UPDATE kunde SET aktivert = 0 WHERE kid = @id;"
    Public Const sqlSelectCustomerById As String = "SELECT * FROM kunde WHERE kid = @id;"
    Public Const sqlSearchCustomer As String = "SELECT * FROM kunde WHERE fornavn LIKE @firstname AND " & _
            "etternavn LIKE @lastname AND telefon LIKE @phone AND epost LIKE @email AND aktivert LIKE @active;"
    Public Const sqlGetActiveCustomers As String = "SELECT * FROM kunde WHERE aktivert = '1';"

    'BIKE
    Public Const sqlEditBike As String = "UPDATE sykkel SET status = @status, lokasjon = @location, utleiested = @placeOfOrigin, " & _
            "bremser = @brakes, dekk = @tires, ramme = @frame, gir = @gear, modell = @model WHERE rammenr = @framenumber;"
    Public Const sqlSearchBike As String = "SELECT rammenr, modell, lokasjon, status FROM sykkel WHERE (rammenr LIKE @framenumber) AND (status LIKE @status) AND " & _
            "(lokasjon LIKE @location) AND (utleiested LIKE @placeOfOrigin) AND (bremser LIKE @brakes) AND (dekk LIKE @tires) AND " & _
            "(ramme LIKE @frame) AND (gir LIKE @gear) AND (modell LIKE @model);"
    Public Const sqlGetModelName As String = "SELECT modell FROM sykkel WHERE rammenr = @framenumber;"
    Public Const sqlSelectAllBikes As String = "SELECT * FROM sykkel;"
    Public Const sqlMissingBikes As String = "SELECT sykkel.rammenr FROM sykkel WHERE sykkel.status = 'Utleid' AND sykkel.rammenr NOT IN (SELECT s.rammenr FROM sykkel s, sykkel_bestilling sb, bestilling b WHERE s.rammenr = sb.rammenr AND sb.bestillingsid = b.bestillingsid AND b.leie_fra >= CURDATE() AND b.leie_til <= CURDATE() AND s.status = 'Utleid')"


    Public Const sqlDeleteBike As String = "UPDATE sykkel SET status = 'Deaktivert' WHERE rammenr = @framenumber;"
    Public Const sqlCreateBike As String = "INSERT INTO sykkel (`rammenr`, `status`, `lokasjon`, `utleiested`, `bremser`, `dekk`, `ramme`, `gir`, `modell`) " & _
    "VALUES (@framenumber, @status, @location, @placeOfOrigin, @brakes, @tires, @frame, @gear, @model);"
    Public Const sqlSelectBikeById As String = "SELECT modell, status, lokasjon, utleiested, dekk, ramme, gir, bremser FROM sykkel WHERE rammenr = @framenumber; "
    Public Const sqlSetAllBikesNotUnderOrder As String = "UPDATE  `sykkel` SET  sykkel.`under_bestilling` =  '0';"
    Public Const sqlSetBikeUnderOrder As String = "UPDATE  `sykkel` SET  sykkel.`under_bestilling` =  '1' WHERE  sykkel.rammenr = @framenumber;"
    Public Const sqlSearchBicycleModel As String = "SELECT rammenr, kategori, pris, produsent, sykkel.modell FROM sykkel JOIN modell ON sykkel.modell=modell.modell WHERE (rammenr LIKE @framenumber) AND (sykkel.modell LIKE @model) AND (lokasjon LIKE @location) AND (utleiested LIKE @placeofOrigin) AND (produsent LIKE @producer) AND (kategori LIKE @category) AND sykkel.under_bestilling = '0' AND status = 'På lager';"
    Public Const sqlGetBikeJoinModel As String = "SELECT kategori, sykkel.modell, pris, produsent, rammenr FROM  sykkel JOIN modell ON sykkel.modell=modell.modell  WHERE rammenr = @framenumber;"

    'MODEL
    Public Const sqlEditModel As String = "UPDATE modell SET pris = @price, produsent = @producer, kategori = @category WHERE modell = @model;"
    Public Const sqlDeleteModel As String = "DELETE FROM modell WHERE modell = @model;"
    Public Const sqlGetModelPrice As String = "SELECT pris FROM modell WHERE model = @model;"
    Public Const sqlGetModelProducer As String = "SELECT produsent FROM modell WHERE model = @model;"
    Public Const sqlGetModelCategory As String = "SELECT kategori FROM modell WHERE model = @model;"
    Public Const sqlSelectAllModels As String = "SELECT * FROM modell;"
    Public Const sqlCreateModel As String = "INSERT INTO modell (`modell`, `pris`, `produsent`, `kategori`) VALUES (@model, @price, @producer, @category);"
    Public Const sqlSearchModel As String = "SELECT modell, pris, produsent, kategori FROM modell WHERE (modell LIKE @model) AND (pris LIKE @price) AND " & _
                "(produsent LIKE @producer) AND (kategori LIKE @category);"
    Public Const sqlGetModelById As String = "SELECT modell, pris, produsent, kategori FROM modell WHERE modell = @model;"

    'EQUIPMENT
    Public Const sqlCreateEquipment As String = "INSERT INTO tilleggsutstyr (`type`, `pris`, `status`) VALUES(@type, @price, @status);"
    Public Const sqlEditEquipment As String = "UPDATE tilleggsutstyr SET type = @type, pris = @price, status = @status WHERE varenr = @id;"
    Public Const sqlDeleteEquipment As String = "UPDATE tilleggsutstyr SET status = 'Deaktivert' WHERE varenr = @id;"
    Public Const sqlSelectEquipmentById As String = "SELECT * FROM tilleggsutstyr WHERE varenr = @id;"
    Public Const sqlSelectAllEquipment As String = "SELECT * FROM tilleggsutstyr;"
    Public Const sqlSearchEquipment As String = "SELECT * FROM tilleggsutstyr WHERE varenr LIKE @id AND type LIKE @type AND " & _
            "pris LIKE @price AND status LIKE @status;"
    Public Const sqlSelectEquipmentIDOnType As String = "SELECT varenr FROM tilleggsutstyr WHERE type = @type;"
    Public Const sqlCreateCompatibility As String = "INSERT INTO kompatibel(`varenr`, `modell`) VALUES(@rowVal, @model) ON DUPLICATE KEY UPDATE modell=VALUES(modell);"
    Public Const sqlGetEquipmentByModel As String = "SELECT varenr FROM kompatibel WHERE modell = @model;"
    Public Const sqlGetEquipmentID As String = "SELECT varenr, pris FROM tilleggsutstyr WHERE type = @type AND status = 'På lager' AND under_bestilling=0;"
    Public Const sqlGetEquipmentIDDuringOrder As String = "SELECT varenr FROM tilleggsutstyr WHERE type = @type AND under_bestilling = '1';"
    Public Const sqlGetTypeFromID As String = "SELECT type FROM tilleggsutstyr WHERE varenr = @id;"
    Public Const sqlRemoveCompatibility As String = "DELETE FROM kompatibel WHERE varenr = @id AND modell = @model;"
    Public Const sqlCompatibleEquipment As String = "SELECT tilleggsutstyr.type, tilleggsutstyr.varenr FROM tilleggsutstyr JOIN kompatibel ON kompatibel.varenr=tilleggsutstyr.varenr WHERE modell = @model AND tilleggsutstyr.status = 'På lager' AND under_bestilling=0 GROUP BY type;"
    Public Const sqlSetEquipmentUnderOrder As String = "UPDATE  `tilleggsutstyr` SET  `under_bestilling` =  '1' WHERE  `tilleggsutstyr`.`varenr` = @id;"
    Public Const sqlSetEquipmentNotUnderOrder As String = "UPDATE  `tilleggsutstyr` SET  `under_bestilling` =  '0' WHERE  `tilleggsutstyr`.`varenr` = @id;"
    Public Const sqlSetAllEquipmentNotUnderOrder As String = "UPDATE  `tilleggsutstyr` SET  `under_bestilling` =  '0';"
    Public Const sqlSelectEquipmentGroupByType As String = "SELECT varenr, type, pris, status FROM tilleggsutstyr GROUP BY type;"

    'ORDER
    Public Const sqlCreateOrder As String = "INSERT INTO `bestilling` (`datotid`, `leie_fra`, `leie_til`, `ansattid`, `kid`, `sum`) " & _
            "VALUES (CURRENT_TIMESTAMP, @from, @to, @employeeID, @customerID, @sum);"
    Public Const sqlEditOrder As String = "UPDATE bestilling SET from = @from, to = @to, ansattid = @employeeID, " & _
        "kid = @customerID, sum = @sum;"
    Public Const sqlSelectOrderById As String = "SELECT * FROM bestilling WHERE bestillingsid = @id;"
    Public Const sqlSelectAllOrders As String = "SELECT * FROM bestilling;"
    Public Const sqlSearchOrder As String = "SELECT * FROM bestilling WHERE leie_fra LIKE @from AND leie_til LIKE @to AND " & _
            "ansattid LIKE @employeeID AND kid LIKE @customerID AND sum LIKE @sum;"
    Public Const sqlCreateBikeOrder As String = "INSERT INTO `sykkel_bestilling` (`bestillingsid`, `rammenr`) VALUES (@orderID, @frameNumber);"
    Public Const sqlGetLatestOrder As String = "SELECT MAX(`bestillingsid`) FROM bestilling;"
    Public Const sqlCreateEquipmentOrder As String = "INSERT INTO `utstyr_bestilling` (`bestillingsid`, `varenr`) VALUES (@orderID, @equipmentID);"
End Class
