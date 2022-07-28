public class Solution {
    public int Candy(int[] ratings) {
        int res = 0;
        
        int[] candies = new int[ratings.Length];
        for (int i = 0; i < ratings.Length; i++) {
            candies[i] = 1;
            if (i > 0 && ratings[i] > ratings[i-1]) {
                candies[i] = candies[i-1] + 1;
            }
                
        }
        
        for (int i = ratings.Length - 2; i >=0; i --) {
            if (ratings[i] > ratings[i+1] && candies[i] <= candies[i+1]) {
                candies[i] = candies[i+1] + 1;
            }
        }
        
        for (int i = 0; i < candies.Length; i ++) {
            res += candies[i];
        }
        
        return res;
        
    }
}