public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        var res = new List<int>(rowIndex + 1);
        for (int i = 0; i <= rowIndex; i++)
        {
            if (i == 0)
            {
                res.Add(1);
                continue;
            }
            int prev=0, curr;
            for (int j = 1; j < i; j++)
            {
                curr = res[j];
                if (j == 1) res[j] += 1;
                else res[j] = prev + res[j];
                prev = curr;
                //if (i == rowIndex) Console.WriteLine($"tmp = {tmp}, j = {j}, res[j] = {res[j]}");
            }
            res.Add(1);
        }
        return res;
    }
}