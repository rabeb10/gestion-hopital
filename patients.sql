
CREATE TABLE patients
(
	(
    code INT  PRIMARY KEY,
    nom varchar(20),
    prenom VARCHAR(50),
   
);


DECLARE @counter INT = 1;
WHILE @counter <= 100
BEGIN
    INSERT INTO gestion_patient (code, nom, prenom) VALUES (@counter, 'Value' + CAST(@counter AS VARCHAR(50)));
    SET @counter = @counter + 1;
END;
)


