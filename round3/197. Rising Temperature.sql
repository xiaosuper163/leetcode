/* Write your T-SQL query statement below */
SELECT 
    id
FROM (
    SELECT id
        , temperature
        , LAG(temperature) OVER (ORDER BY recordDate) AS prevTemperature
        , recordDate
        , LAG(recordDate) OVER (ORDER BY recordDate) AS prevRecordDate
    FROM Weather
) a
WHERE temperature > prevTemperature AND recordDate = DATEADD(DAY, 1, prevRecordDate)