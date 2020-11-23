CREATE PROCEDURE [dbo].[GetAllActorByInitial]
	@LastL char
AS
BEGIN
	SELECT * FROM Actor 
	WHERE SUBSTRING(LastName,1,1) = @LastL
END