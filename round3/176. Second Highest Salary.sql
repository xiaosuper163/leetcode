/* Write your T-SQL query statement below */
SELECT ISNULL (
    (
        SELECT TOP 1 salary 
        FROM Employee
        WHERE salary NOT IN 
            (
                SELECT TOP 1 salary
                FROM Employee
                ORDER BY salary DESC
            )
        ORDER BY salary DESC
    ), NULL
) AS SecondHighestSalary
