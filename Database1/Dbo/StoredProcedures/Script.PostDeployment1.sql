if not exists (select 1 from dbo.[tbl_User])
begin
insert into  [dbo].[tbl_User] (FirstName, LastName)
values ( 'Ozougwu','Ifeanyi');
end
