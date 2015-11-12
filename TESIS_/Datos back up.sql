--delete from dbo.TTBUS020
--delete from dbo.TTBUS014_1
--delete from dbo.TTBUS008
--delete from dbo.TTBUS002_Det
--delete from dbo.TTBUS002
--delete from dbo.TTBUS000Identificadores
--delete from dbo.TTBUS000Documentacion
--delete from dbo.TTBUS000
--delete from dbo.TTBUS005
--delete from dbo.TTBUS007Permisos
--delete from dbo.TTBUS007
--delete from dbo.T53FPOS
--delete from dbo.M124FPROV
--delete from dbo.SEG004
--delete from dbo.SEG001
--delete from dbo.BUS002
--delete from dbo.SEG002


--INSERT INTO SEG002
--SELECT * FROM MarianoTesis_BK.dbo.SEG002

--INSERT INTO BUS002
--SELECT * FROM MarianoTesis_BK.dbo.BUS002

--INSERT INTO SEG001
--SELECT * FROM MarianoTesis_BK.dbo.SEG001

--INSERT INTO SEG004
--SELECT * FROM MarianoTesis_BK.dbo.SEG004

--INSERT INTO M124FPROV
--SELECT * FROM MarianoTesis_BK.dbo.M124FPROV

--INSERT INTO T53FPOS
--SELECT * FROM MarianoTesis_BK.dbo.T53FPOS

--INSERT INTO TTBUS007
--SELECT * FROM MarianoTesis_BK.dbo.TTBUS007

--INSERT INTO TTBUS007Permisos
--SELECT * FROM MarianoTesis_BK.dbo.TTBUS007Permisos

--INSERT INTO TTBUS005
--SELECT TTBUS5_IdIdentificador FROM MarianoTesis_BK.dbo.TTBUS005

--INSERT INTO TTBUS000
--SELECT 
--TTBUS_Descripcion,TTBUS_FechaCarga,TTBUS_Estado,TTBUS_CodProveedor,TTBUS_Alquilado,
--TTBUS_CodPosicion,TTBUS_DesPosicion, TTBUS_RubroBien,TTBUS_ContDocu,TTBUS_UsuarioAlta,TTBUS_MaquinaAlta,
--TTBUS_NroSerie,TTBUS_FechaBaja,TTBUS_MotivoBaja,TTBUS_UsuarioBaja,TTBUS_MaquinaBaja
--FROM MarianoTesis_BK.dbo.TTBUS000

--INSERT INTO TTBUS000Documentacion
--SELECT * FROM MarianoTesis_BK.dbo.TTBUS000Documentacion

--INSERT INTO TTBUS000Identificadores
--SELECT * FROM MarianoTesis_BK.dbo.TTBUS000Identificadores where TTBUS_Id IN
--(SELECT TTBUS_Id FROM TTBUS000)

--INSERT INTO TTBUS002
--SELECT
--TTBUS2_MotivoCancelacion,TTBUS2_IdBien, TTBUS2_CodPosDesde, TTBUS2_RespDesde, TTBUS2_FechaEnvio,
--TTBUS2_CodPosHacia,TTBUS2_RespHacia,TTBUS2_FechaRecepcion,TTBUS2_EstadoEnvio,TTBUS2_MotivoEnvio,
--TTBUS2_Observaciones,TTBUS2_PlazoRecepcion
--FROM MarianoTesis_BK.dbo.TTBUS002 WHERE TTBUS2_IdBien IN
--(SELECT TTBUS_Id FROM TTBUS000)

--INSERT INTO TTBUS002_Det
--SELECT * FROM MarianoTesis_BK.dbo.TTBUS002_Det WHERE TTBUS2_IdMovimiento IN
--(SELECT TTBUS2_IdMovimiento FROM TTBUS002)

INSERT INTO TTBUS008
SELECT * FROM MarianoTesis_BK.dbo.TTBUS008

INSERT INTO TTBUS014_1
SELECT * FROM MarianoTesis_BK.dbo.TTBUS014_1

INSERT INTO TTBUS020
SELECT * FROM MarianoTesis_BK.dbo.TTBUS020