public class Solution {
    public int CountSubstrings(string s) {
        int count = 0;

        for (int i = 0; i < s.Length; i++) {
            count += Expand(s, i, i);     // odd length
            count += Expand(s, i, i + 1); // even length
        }

        return count;
    }

    int Expand(string s, int l, int r) {
        int count = 0;

        while (l >= 0 && r < s.Length && s[l] == s[r]) {
            count++;
            l--;
            r++;
        }

        return count;
    }
}