CREATE PROCEDURE dbo.GetServiceStatistics
    @IdService INT,
    @VolunteerCount INT OUTPUT,
    @ApprovedRequestCount INT OUTPUT
AS
BEGIN
    -- כמה מתנדבים יש בשירות הזה
    SELECT @VolunteerCount = COUNT(*)
    FROM ServiceForVolunteer
    WHERE IdService = @IdService;

    -- כמה בקשות אושרו השנה לשירות הזה
    SELECT @ApprovedRequestCount = COUNT(*)
    FROM Requests
    WHERE IdService = @IdService
      AND StatusRequests = 'Approved'
      AND YEAR(DateRequests) = YEAR(GETDATE());
END

DECLARE @volunteers INT, @approved INT;
EXEC dbo.GetServiceStatistics
    @IdService = 1,
    @VolunteerCount = @volunteers OUTPUT,
    @ApprovedRequestCount = @approved OUTPUT;
SELECT @volunteers AS VolunteerCount, @approved AS ApprovedRequestCount;
