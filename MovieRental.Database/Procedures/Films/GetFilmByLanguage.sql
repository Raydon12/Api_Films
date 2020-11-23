CREATE PROCEDURE [dbo].[GetFilmByLanguage]
	@Language nvarchar(25)
AS
	SELECT * from Film f , [Language] l where f.LanguageId = l.LanguageId
	AND l.[Name] = @Language
RETURN 0
