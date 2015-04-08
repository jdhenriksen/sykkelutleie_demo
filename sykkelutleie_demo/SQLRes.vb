''' <summary>
''' Klasse som holder SQL-spørringer som konstanter.
''' </summary>
''' <remarks></remarks>
Public Class SQLRes
    'TEST
    Public DBTestInsert As String = "INSERT INTO  ansatt(`brukernavn` ,`passord` ,`fornavn` ,`etternavn` ,`telefon` ,`epost` ,`adresse` ,`stilling` ,`postnr` ,`aktivert`)VALUES ('testbrukernavn',  'testpassord',  'Per',  'Olav',  '8888887',  'test@mail.cns',  'testveien 118',  'Lagerarbeider',  '7020',  '1')"
    Public autoIncrementAs2 As String = "ALTER TABLE ansatt AUTO_INCREMENT=2"
    Public deleteManyAnsatt As String = "delete from ansatt where ansattid > 1"

    'STATISTICS
    Public cheapestBicycles As String = "SELECT sykkel.rammenr AS 'Rammenr.', sykkel.modell AS Modell, modell.pris AS Pris FROM sykkel JOIN modell ON sykkel.modell=modell.modell GROUP BY modell ORDER BY pris LIMIT @limit;"
    Public mostExpensiveBicycles As String = "SELECT sykkel.rammenr AS 'Rammenr.', sykkel.modell, modell.pris FROM sykkel JOIN modell ON sykkel.modell=modell.modell GROUP BY modell ORDER BY pris DESC LIMIT @limit;"
    Public mostActiveSalesman As String = "SELECT COUNT(bestilling.ansattid) AS Salg, ansatt.fornavn, ansatt.etternavn, ansatt.ansattid FROM ansatt JOIN bestilling ON bestilling.ansattid=ansatt.ansattid WHERE datotid BETWEEN @startDate AND @endDate;"
    Public leastActiveSalesman As String = "SELECT COUNT(bestilling.ansattid) AS Salg, ansatt.fornavn, ansatt.etternavn, ansatt.ansattid FROM ansatt JOIN bestilling ON bestilling.ansattid=ansatt.ansattid WHERE datotid BETWEEN @startDate AND @endDate GROUP BY ansatt.ansattid DESC;"
    Public avanseBicycles As String = "SELECT SUM(modell.pris) AS 'Avanse på sykkel i perioden' FROM modell JOIN sykkel ON modell.modell=sykkel.modell JOIN sykkel_bestilling ON sykkel.rammenr=sykkel_bestilling.rammenr JOIN bestilling ON sykkel_bestilling.bestillingsid=bestilling.bestillingsid WHERE datotid BETWEEN @startDate AND @endDate;"
    Public countOrders As String = "SELECT COUNT(bestillingsid) AS 'Antall bestillinger i perioden' FROM bestilling WHERE datotid BETWEEN @startDate AND @endDate;"
    Public countMosteActiveBicycles As String = "SELECT COUNT(bestilling.bestillingsid) AS 'Ganger utleid', sykkel.rammenr AS 'Ramme nummer', sykkel.modell AS 'Modell', modell.pris AS 'Pris' FROM modell JOIN sykkel ON modell.modell=sykkel.modell JOIN sykkel_bestilling ON sykkel.rammenr=sykkel_bestilling.rammenr JOIN bestilling ON sykkel_bestilling.bestillingsid=bestilling.bestillingsid WHERE datotid BETWEEN @startDate AND @endDate GROUP BY sykkel.rammenr LIMIT @limit;"
    Public countLeastActiveBicycles As String = "SELECT COUNT(bestilling.bestillingsid) AS 'Ganger utleid', sykkel.rammenr AS 'Ramme nummer', sykkel.modell AS 'Modell', modell.pris AS 'Pris' FROM modell JOIN sykkel ON modell.modell=sykkel.modell JOIN sykkel_bestilling ON sykkel.rammenr=sykkel_bestilling.rammenr JOIN bestilling ON sykkel_bestilling.bestillingsid=bestilling.bestillingsid WHERE datotid BETWEEN @startDate AND @endDate GROUP BY sykkel.rammenr DESC LIMIT @limit;"

    'EMPLOYEE
    Public Const sqlCreateEmployee As String = "INSERT INTO  ansatt(`brukernavn` ,`passord` ,`fornavn` ,`etternavn` ,`telefon` ,`epost` ,`adresse` ,`stilling` ,`postnr` ,`aktivert`)" _
                & "VALUES (@username, @password, @firstname, @lastname, @phone, @email, @address, @job, @zip, @active);"
    Public Const sqlEditEmployee As String = "UPDATE ansatt SET brukernavn = @username, passord = @password, fornavn = @firstname, etternavn = @lastname " _
            & ", telefon = @phone, epost = @email, adresse = @address, stilling = @job, postnr = @zip, aktivert = @active " _
            & "WHERE ansattid = @id;"
    Public Const sqlDeleteEmployee As String = "UPDATE ansatt SET aktivert = 0 WHERE ansattid = @id;"
    Public Const sqlSelectEmployeeById As String = "SELECT * FROM ansatt WHERE ansattid = @id;"
    Public Const sqlGetAllEmployees As String = "SELECT * FROM ansatt;"
    Public Const sqlIsActive As String = "SELECT aktivert FROM ansatt WHERE ansattid = @id;"
    Public Const sqlGetAreaByZipCode As String = "SELECT poststed FROM poststed WHERE postnr = @zipcode;"
    Public Const sqlUsernameCheck As String = "SELECT brukernavn FROM ansatt WHERE brukernavn = @username;"
    Public Const sqlLogin As String = "SELECT stilling FROM ansatt WHERE brukernavn = @username AND passord = @password;"

    'CUSTOMER
    Public Const sqlCreateCustomer As String = "INSERT INTO kunde (`fornavn` ,`etternavn` ,`telefon` ,`epost` ,`aktivert`) " & _
            "VALUES(@firstname, @lastname, @phone, @email, @active);"
    Public Const sqlEditCustomer As String = "UPDATE kunde SET fornavn = @firstname, etternavn = @lastname, telefon = @phone, " & _
            "epost = @email, aktivert = @active WHERE kid = @id;"
    Public Const sqlDeleteCustomer As String = "DELETE FROM kunde WHERE kid = @id;"
    Public Const sqlSelectCustomerById As String = "SELECT * FROM kunde WHERE id = @id;"
    Public Const sqlSelectAllCustomers As String = "SELECT * FROM kunde;"

    'BIKE
    Public Const sqlCreateBike As String = "INSERT INTO sykkel (rammenr, status, lokasjon, utleiested, bremser, dekk, ramme, gir, modell) " & _
            "VALUES (@framenumber, @status, @location, @placeOfOrigin, @brakes, @tires, @frame, @gear, @model);"
    Public Const sqlEditBike As String = "UPDATE sykkel SET status = @status, lokasjon = @location, utleiested = @placeOfOrigin, " & _
            "bremser = @brakes, dekk = @tires, ramme = @frame, gir = @gear, modell = @model WHERE rammenr = @framenumber;"
    Public Const sqlDeleteBike As String = "DELETE FROM sykkel WHERE rammenr = @framenumber;"
    Public Const sqlGetModelName As String = "SELECT modell FROM sykkel WHERE rammenr = @framenumber;"
    Public Const sqlSelectAllBikes As String = "SELECT * FROM sykkel;"

    'MODEL
    Public Const sqlCreateModel As String = "INSERT INTO modell (modell, pris, produsent, kategori) VALUES (@model, @price, @producer, @category);"
    Public Const sqlEditModel As String = "UPDATE modell SET pris = @price, produsent = @producer, kategori = @category WHERE modell = @model;"
    Public Const sqlDeleteModel As String = "DELETE FROM modell WHERE modell = @model;"
    Public Const sqlGetModelPrice As String = "SELECT pris FROM modell WHERE model = @model;"
    Public Const sqlGetModelProducer As String = "SELECT produsent FROM modell WHERE model = @model;"
    Public Const sqlGetModelCategory As String = "SELECT kategori FROM modell WHERE model = @model;"
    Public Const sqlSelectAllModels As String = "SELECT * FROM modell;"

    'EQUIPMENT
    Public Const sqlCreateEquipment As String = "INSERT INTO tilleggsutstyr `type`, `pris`, `status` VALUES(@type, @price, @status);"
    Public Const sqlEditEquipment As String = "UPDATE tilleggsutstyr SET type = @type, pris = @price, status = @status WHERE varenr = @id;"
    Public Const sqlDeleteEquipment As String = "DELETE FROM tilleggsutstyr WHERE varenr = @id;"
    Public Const sqlSelectEquipmentById As String = "SELECT * FROM tilleggsutstyr WHERE varenr = @id;"
    Public Const sqlSelectAllEquipment As String = "SELECT * FROM tilleggsutstyr;"

    'ORDER
    Public Const sqlCreateOrder As String = "INSERT INTO bestilling (`leie_fra`, `leie_til`, `ansattid`, `kid`, `sum`) " & _
            "VALUES(@from, @to, @employeeID, @customerID, @sum);"
    Public Const sqlEditOrder As String = "UPDATE bestilling SET from = @from, to = @to, ansattid = @employeeID, " & _
        "kid = @customerID, sum = @sum;"
    Public Const sqlSelectOrderById As String = "SELECT * FROM bestilling WHERE bestillingsid = @id;"
    Public Const sqlSelectAllOrders As String = "SELECT * FROM bestilling;"

End Class
