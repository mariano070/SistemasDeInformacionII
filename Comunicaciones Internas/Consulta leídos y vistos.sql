SELECT * FROM WEB003X
SELECT * FROM WEB002X
--QUERY LO M�S VISTO
SELECT
COMX_ID,WEB0_VIS,COUNT(*)
FROM WEB000X
WHERE WEB0_VIS = 1 AND WEB2_ID = 8
GROUP BY COMX_ID,WEB0_VIS
ORDER BY COUNT(*) DESC

--QUERY LO M�S LE�DO
SELECT
COMX_ID,WEB0_LEI,COUNT(*)
FROM WEB000X
WHERE WEB0_LEI = 1 AND WEB2_ID = 9
GROUP BY COMX_ID,WEB0_LEI
ORDER BY COUNT(*) DESC

