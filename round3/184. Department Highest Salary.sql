/* Write your T-SQL query statement below */
SELECT d.name AS Department
    , e.name AS Employee
    , e.salary AS Salary
FROM Department d
    INNER JOIN Employee e on d.id = e.departmentId
    INNER JOIN (
        SELECT d.id AS departmentId
            , MAX(e.salary) AS maxSalary
        FROM Department d
            INNER JOIN Employee e ON d.id = e.departmentId
        GROUP BY d.id
    ) m ON m.departmentId = d.id AND e.salary = m.maxSalary



    