CREATE PROCEDURE [dbo].[sp_User_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
update [dbo].[tbl_User] set FirstName = @FirstName, LastName = @LastName where Id = @Id;
end
