/* Write your T-SQL query statement below */

select distinct(a.num) as ConsecutiveNums
from
    (
        select l1.id, l1.num
        from Logs l1
            INNER JOIN Logs l2 on l1.id = l2.id - 1 and l1.num = l2.num
    ) a
    inner join
    (
        select l1.id
        from logs l1
            INNER JOIN Logs l2 on l1.id = l2.id - 2 and l1.num = l2.num    
    ) b on a.id = b.id
    
    
