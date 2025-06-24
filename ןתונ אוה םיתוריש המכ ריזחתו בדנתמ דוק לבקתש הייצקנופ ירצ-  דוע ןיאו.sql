CREATE FUNCTION dbo.GetExclusiveServicesCount
(@IdVolunteer INT)
RETURNS INT
AS
BEGIN
    DECLARE @ExclusiveCount INT

    SELECT @ExclusiveCount = COUNT(*)
    FROM ServiceForVolunteer
    WHERE IdVolunteer = @IdVolunteer
      AND IdService NOT IN
      (
          SELECT IdService
          FROM ServiceForVolunteer
          WHERE IdVolunteer <> @IdVolunteer
      )

    IF @ExclusiveCount IS NULL
        SET @ExclusiveCount = 0

    RETURN @ExclusiveCount
END
