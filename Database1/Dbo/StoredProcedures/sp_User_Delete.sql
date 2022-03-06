CREATE PROCEDURE [dbo].[sp_User_Delete]
	@Id int 
	
AS
begin
Delete from  [dbo].[tbl_User] where Id = @Id;
end

