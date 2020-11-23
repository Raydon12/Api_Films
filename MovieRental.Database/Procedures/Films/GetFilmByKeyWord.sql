CREATE PROCEDURE [dbo].[GetFilmByKeyWord]
	@KeyWord varchar(255)
AS
	SELECT * FROM Film WHERE [Description] Like '%' + @KeyWord +'%'
RETURN 0
