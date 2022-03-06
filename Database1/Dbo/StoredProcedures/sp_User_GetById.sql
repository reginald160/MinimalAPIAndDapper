CREATE PROCEDURE [dbo].[sp_User_GetById]

@Id int
AS

begin
select * from  [dbo].[tbl_User] where Id = @Id;
end
