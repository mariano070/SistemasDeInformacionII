--Usuario supervisor
INSERT INTO SEG002 
VALUES
('SUPERVISOR', 'SUPERVISOR SISTEMAS','cutchet','','2011-02-14 00:00:00.000', '','INT', 0, '3128-3129',
'','',0,0,'1753-01-01 00:00:00.000',0)

----------------------------------------------------------

--Sistema de seguridad
INSERT INTO SEG004
VALUES ('SUPERVISOR',1,500,'','','')


INSERT INTO SEG003 VALUES
('SUPERVISOR',1,'')

INSERT INTO SEG000
SELECT * FROM Soporte1.dbo.SEG000 WHERE SIS_COD = 1

INSERT INTO SEG008L1 VALUES (500,1,1,'Sistemas/Programas','hseg100.aspx')
INSERT INTO SEG008L1 VALUES (500,1,3,'Items Menues X','WWSEG008.aspx')
INSERT INTO SEG008L1 VALUES (500,1,2,'Usuarios','HSEG102.aspx')

-------------------------------------------------------------------------------
--Sistema de trazabilidad
INSERT INTO SEG004
VALUES ('SUPERVISOR',28,79,'','','')

INSERT INTO SEG004
VALUES ('SUPERVISOR',28,81,'','','')

INSERT INTO SEG003 VALUES
('SUPERVISOR',28,'')

INSERT INTO SEG000
SELECT * FROM Soporte1.dbo.SEG000 WHERE SIS_COD = 28

INSERT INTO SEG008L1 VALUES (79,1,1,'Adm. de Bienes de Uso','HTBUS001.aspx')
INSERT INTO SEG008L1 VALUES (79,1,2,'Administrador de Cambio de Ubicaciones','HTBUS020.aspx')
INSERT INTO SEG008L1 VALUES (79,1,3,'Adm. Bajas Bienes de Uso','HTBUS001b.aspx')
INSERT INTO SEG008L1 VALUES (79,2,2,'Bienes sin Factura','HTBUS010.aspx'	)
INSERT INTO SEG008L1 VALUES (79,2,3,'Envíos Pendientes de Recepción','HTBUS011.aspx')
INSERT INTO SEG008L1 VALUES (79,2,1,'Bienes no relacionados','HTBUS006.aspx')
INSERT INTO SEG008L1 VALUES (79,2,4,'Movimientos de Bienes de Uso','HTBUS013.aspx')
INSERT INTO SEG008L1 VALUES (79,2,5,'Bienes por Posición o por Responsable','HTBUS014.aspx')
INSERT INTO SEG008L1 VALUES (79,2,6,'Bienes e Identificadores','HTBUS016.aspx')
INSERT INTO SEG008L1 VALUES (79,2,7,'Listado de Asociaciones de Bienes de Uso','HTBUS035.aspx')
INSERT INTO SEG008L1 VALUES (79,3,1,'Identificadores','HTBUS005.aspx')
INSERT INTO SEG008L1 VALUES (81,1,2,'Permisos','HTBUS007_p.aspx')
INSERT INTO SEG008L1 VALUES (81,1,1,'Administradores','HTBUS008.aspx')
INSERT INTO SEG008L1 VALUES (81,1,3,'Posiciones y Responsables','HTBUS007.aspx')
