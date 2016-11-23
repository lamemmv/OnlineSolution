INSERT INTO #Description VALUES('Update/delete/create user.')
GO

IF OBJECT_ID('[Core].[UpdateUser]', 'p') IS NULL
    EXEC ('CREATE PROCEDURE [Core].[UpdateUser] AS SELECT 1 a')
GO

ALTER PROCEDURE [Core].[UpdateUser] 
	@Id [int],
	@FirstName [varchar](100),
	@LastName [varchar](20),
	@Email [varchar](100),
	@UserName [varchar](50),
	@Password [varchar](50),
	@Professor [nvarchar](max),
	@Avatar [nvarchar](max)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE Core.Users
	SET
	    Core.Users.Username = @UserName,
	    Core.Users.Password = @Password, 
	    Core.Users.FirstName = @FirstName,
	    Core.Users.LastName = @LastName,
	    Core.Users.Email = @Email,
	    Core.Users.Profession = @Professor,
	    Core.Users.Avatar = @Avatar
	WHERE Id = @Id;
END
GO