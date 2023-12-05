create table RDV 
	(
    code INT  PRIMARY KEY,
    date_heure date,
	  CONSTRAINT code, sysname, code PRIMARY KEY (code, , c1)
   
);


DECLARE @counter INT = 1;
WHILE @counter <= 100
BEGIN
    INSERT INTO RDV (code, date_heure) VALUES (@counter, 'Value' + CAST(@counter AS VARCHAR(50)));
    SET @counter = @counter + 1;
END;
)

