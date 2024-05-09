CREATE PROCEDURE [dbo].[spUserUpdate]
	@id int ,
	@FirstName varchar(50),
	@LastName varchar(50)
AS
begin
    update dbo.[User]
	set FirstName = @FirstName, LastName = @LastName
end
