ALTER PROCEDURE dbo.GetTopVolunteersByService(@IdService INT)
AS
BEGIN
    SELECT TOP 1 V.*
    FROM Volunteer V
    INNER JOIN ServiceForVolunteer SFV ON V.IdVolunteer = SFV.IdVolunteer
    WHERE SFV.IdService = @IdService
    ORDER BY dbo.GetRemainingMonthlyHours(V.IdVolunteer) DESC
END

EXEC dbo.GetTopVolunteersByService 1;