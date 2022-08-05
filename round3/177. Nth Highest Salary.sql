CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    RETURN (
        /* Write your T-SQL query statement below. */
        SELECT TOP 1 salary
        FROM (
            SELECT
                salary
                , DENSE_RANK() OVER (ORDER BY salary DESC) AS DRK
            FROM Employee
        ) a
        WHERE DRK = @N
    );
END