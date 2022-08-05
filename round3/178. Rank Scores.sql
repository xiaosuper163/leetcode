/* Write your T-SQL query statement below */
SELECT
    s.score
    , a. rank
FROM
    Scores s
    INNER JOIN (
        SELECT s1.score AS score
            , COUNT(DISTINCT s2.score) AS [rank]
        FROM
            Scores s1
            CROSS JOIN Scores s2
        WHERE s1.score <= s2.score
        GROUP BY s1.score
    ) a on s.score = a.score
ORDER BY score DESC