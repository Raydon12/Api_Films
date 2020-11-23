CREATE PROCEDURE [dbo].[GetFilmByTitle]
	@Title varchar
AS
	SELECT * From Film where Title LIKE  '%' + @Title + '%'
RETURN 0
