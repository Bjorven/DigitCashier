CREATE TABLE [dbo].[employeeUsers] (
    [employeeID] NVARCHAR (50) NOT NULL,
    [password]   NVARCHAR (50) NULL,
    [acesslvl]   NCHAR (10)    NULL,
    [fname]      NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([employeeID] ASC)
);

