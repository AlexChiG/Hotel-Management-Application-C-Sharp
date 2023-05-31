CREATE TABLE [dbo].[Table]
(
	[cod_angajat] INT NOT NULL PRIMARY KEY, 
    [cnp] NUMERIC(13) NOT NULL, 
    [nume] NVARCHAR(50) NOT NULL, 
    [prenume] NVARCHAR(50) NOT NULL, 
    [telefon] NUMERIC(10) NOT NULL, 
    [salariu] NUMERIC NOT NULL, 
    [data_angajare] DATE NOT NULL, 
    [cod_departament] NCHAR(10) NOT NULL
)
