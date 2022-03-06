CREATE PROCEDURE [dbo].[sp_User_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Date     datetime
AS
begin

insert into  [dbo].[tbl_User] (FirstName, LastName, Date)
values ( @FirstName, @LastName, @Date);
end
