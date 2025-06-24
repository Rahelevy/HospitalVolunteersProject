CREATE FUNCTION dbo.GetRemainingMonthlyHours(@IdVolunteer INT)
RETURNS INT
AS
BEGIN
    DECLARE @TotalHours INT;
    DECLARE @UsedHours INT;

    SELECT @TotalHours = VolunteerHours
    FROM ServiceForVolunteer
    WHERE IdVolunteer = @IdVolunteer;

    SELECT @UsedHours = ISNULL(SUM(R.HoursNumber), 0)
    FROM Requests R
    INNER JOIN AssignedRequests AR ON R.IdRequests = AR.IdRequests
    WHERE AR.IdVolunteer = @IdVolunteer
      AND MONTH(R.DateRequests) = MONTH(GETDATE())
      AND YEAR(R.DateRequests) = YEAR(GETDATE());

    RETURN ISNULL(@TotalHours, 0) - ISNULL(@UsedHours, 0);
END



