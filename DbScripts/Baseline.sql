IF SCHEMA_ID('Core') IS NULL
	EXEC('CREATE SCHEMA Core AUTHORIZATION [dbo]');
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Core].[Users]') AND type in (N'U'))
BEGIN
	CREATE TABLE [Core].[Users](
		[Id] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
		[Username] [varchar](50) NOT NULL,
		[Password] [varchar](50) NOT NULL,
		[FirstName] [nvarchar](100) NOT NULL,
		[LastName] [nvarchar](20) NOT NULL,
		[Email] [varchar](100),
		[Mobile] [varchar] (20),
		[Activated] [bit] NOT NULL DEFAULT 0,
	 CONSTRAINT [PK_Core_Users_PK] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]
END
GO


IF OBJECT_ID('[Core].[GetUsers]', 'p') IS NULL
    EXEC ('CREATE PROCEDURE [Core].[GetUsers] AS SELECT 1')
GO
ALTER PROCEDURE [Core].[GetUsers] 
	@Keyword [nvarchar](100)
AS
BEGIN
	SET NOCOUNT ON;
    
    SELECT * FROM [Core].[Users] WHERE FirstName LIKE '%' + @Keyword + '%';
END
GO


IF OBJECT_ID('[Core].[GetUserById]', 'p') IS NULL
    EXEC ('CREATE PROCEDURE [Core].[GetUserById] AS SELECT 1')
GO
ALTER PROCEDURE [Core].[GetUserById] 
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;

    SELECT u.* FROM Core.Users u 
    WHERE u.Id = @Id;
END
GO