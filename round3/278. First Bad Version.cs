/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        
        int start = 1, end = n;
        while (start + 1 < end) {
            int mid = (int) (end - start) / 2 + start;
            if (IsBadVersion(mid)) {
                end = mid;
            } else {
                start = mid;
            }
        }
        
        if (IsBadVersion(start)) {
            return start;
        } else {
            return end;
        }
    }
}