CREATE PROCEDURE dbo.GetVolunteerMonthlyHours
    @IdVolunteer INT,
    @CurrentMonthHours INT OUTPUT,
    @PreviousMonthHours INT OUTPUT
AS
BEGIN

    --  כל השעות שתרם החודש
    SELECT @CurrentMonthHours = ISNULL(SUM(R.HoursNumber), 0)
    FROM AssignedRequests AR
    INNER JOIN Requests R ON AR.IdRequests = R.IdRequests
    WHERE AR.IdVolunteer = @IdVolunteer
      AND MONTH(R.DateRequests) = MONTH(GETDATE())
      AND YEAR(R.DateRequests) = YEAR(GETDATE());

    --  כל השעות שתרם בחודש הקודם
    SELECT @PreviousMonthHours = ISNULL(SUM(R.HoursNumber), 0)
    FROM AssignedRequests AR
    INNER JOIN Requests R ON AR.IdRequests = R.IdRequests
    WHERE AR.IdVolunteer = @IdVolunteer
      AND MONTH(R.DateRequests) = MONTH(DATEADD(MONTH, -1, GETDATE()))
      AND YEAR(R.DateRequests) = YEAR(DATEADD(MONTH, -1, GETDATE()));
END
