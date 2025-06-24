CREATE FUNCTION dbo.IsServiceHoursSufficient
(
    @ServiceId INT
)
RETURNS BIT
AS
BEGIN
    DECLARE @DonatedHours INT
    DECLARE @AvgRequestedHours DECIMAL(10,2)
    DECLARE @Result BIT

    -- סכום השעות שתרמו החודש
    SELECT @DonatedHours = ISNULL(SUM(VolunteerHours), 0)
    FROM ServiceForVolunteer
    WHERE IdService = @ServiceId
    

    -- ממוצע השעות שמתבקשות החודש
    SELECT @AvgRequestedHours = ISNULL(AVG(HoursNumber), 0)
    FROM Requests
    WHERE IdService = @ServiceId
      AND MONTH(DateRequests) = MONTH(GETDATE())
      AND YEAR(DateRequests) = YEAR(GETDATE())

    IF @DonatedHours >= @AvgRequestedHours
        SET @Result = 1
    ELSE
        SET @Result = 0

    RETURN @Result
END
