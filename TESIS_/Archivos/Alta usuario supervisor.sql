INSERT INTO SEG002
SELECT USU_COD,USU_DES,USU_CLA,USU_INT,USU_MAIW FROM Soporte1.soporte1.SEG002 WHERE USU_COD = 'SUPERVISOR'

INSERT INTO SEG004 (USU_COD_,SIS_COD,PRG_COD) VALUES ('SUPERVISOR',28,79)