CREATE PROCEDURE SP_VIS_BUSINNES_UNIT()
AS
BEGIN

SELECT "PrcCode","PrcName" 
FROM OPRC 
WHERE "DimCode"='1' AND "Active"='Y';

END;