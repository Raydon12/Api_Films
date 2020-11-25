﻿CREATE PROCEDURE [dbo].[CreateRental]
    @CustomerId INT,
    @FilmIds FilmIds READONLY
AS
    INSERT INTO [Rental] ([CustomerId])
    VALUES (@CustomerId);

    DECLARE @RentalId INT = SCOPE_IDENTITY();

    INSERT INTO [RentalDetail] ([RentalId], [FilmId], [RentalPrice])
    SELECT @RentalId, fi.[FilmId], f.[RentalPrice]
    FROM @FilmIds fi
    JOIN Film f ON fi.[FilmId] = f.[FilmId]
RETURN 0