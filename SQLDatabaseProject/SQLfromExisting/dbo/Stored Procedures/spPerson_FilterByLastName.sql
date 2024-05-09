CREATE PROCEDURE [dbo].[spPerson_FilterByLastName]
	@LastName varchar(50)
	
AS
begin
	SELECT * from Person
	WHERE LastName = @LastName;
end