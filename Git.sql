Create Table NewDotNet
(
ID int primary key,
Name Varchar(100),
Phone Varchar(12),
Address Varchar(250)
);


Alter Procedure SP_DotNet
(
@ID int = 0,
@Name Varchar(100) = null,
@Phone Varchar(12) = null,
@Address Varchar(250) = null,
@Action Varchar(100)
)
as
begin
if(@Action = 'Insert')
Insert Into NewDotNet values(@ID,@Name,@Phone,@Address)
else if(@Action = 'Update')
Update NewDotNet Set ID=@ID,Name=@Name,Phone=@Phone,Address=@Address Where ID=@ID
else if(@Action='Delete')
delete from  NewDotNet where ID=@ID 
else if(@Action='All')
Select * From NewDotNet
else if(@Action='SelectOne')
select * from NewDotNet where ID=@ID
end
