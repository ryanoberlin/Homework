USE TSQLV4;

CREATE TABLE dbo.Departments
(
  deptid    INT                          NOT NULL
    CONSTRAINT PK_Departments PRIMARY KEY,
  deptname  VARCHAR(25)                  NOT NULL,
  mgrid INT                              NOT NULL,
  validfrom DATETIME2(0)
    GENERATED ALWAYS AS ROW START HIDDEN NOT NULL,
  validto   DATETIME2(0)
    GENERATED ALWAYS AS ROW END   HIDDEN NOT NULL,
  PERIOD FOR SYSTEM_TIME (validfrom, validto)
)
WITH ( SYSTEM_VERSIONING = ON ( HISTORY_TABLE = dbo.DepartmentsHistory ) );

SELECT CAST(SYSUTCDATETIME() AS DATETIME2(0)) AS P1;

INSERT INTO dbo.Departments(deptid, deptname, mgrid)
  VALUES(1, 'HR'       , 7 ),
        (2, 'IT'       , 5 ),
        (3, 'Sales'    , 11),
        (4, 'marketing', 13);


SELECT CAST(SYSUTCDATETIME() AS DATETIME2(0)) AS P2;

BEGIN TRAN;

UPDATE dbo.Departments
SET deptname = 'Sales and Marketing'
WHERE deptid = 3;

DELETE FROM dbo.Departments
WHERE deptid = 4;

COMMIT TRAN;
SELECT CAST(SYSUTCDATETIME() AS DATETIME2(0)) AS P3;

UPDATE dbo.Departments
  SET mgrid = 13
WHERE deptid = 3;

SELECT *
FROM dbo.Departments;


SELECT *
FROM dbo.Departments
  FOR SYSTEM_TIME AS OF '1970-01-01 01::01';

SELECT deptid, deptname, mgrid, validfrom, validto
FROM dbo.Departments
  FOR SYSTEM_TIME BETWEEN '1970-01-01 01::01'
                      AND '2004-09-16 23:59:40';


ALTER TABLE dbo.Departments SET ( SYSTEM_VERSIONING = OFF );
DROP TABLE dbo.DepartmentsHistory, dbo.Departments;
