CREATE TABLE [dbo].[tbl_User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NCHAR(50) NOT NULL, 
    [LastName] NCHAR(50) NOT NULL, 
    [Age] INT NULL, 
    [Date] DATETIME NULL,
    [Email] NCHAR(50) NULL

)
