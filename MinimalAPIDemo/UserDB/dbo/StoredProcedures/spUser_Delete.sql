CREATE PROCEDURE [dbo].[spUser_Delete]
	@Id int
AS
begin
    DELETE
	from dbo.[User]
	where Id = @Id;
end
