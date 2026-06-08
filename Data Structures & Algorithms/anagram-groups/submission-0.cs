public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<int>> d = new ();
        List<List<string>> res = new List<List<string>>();
        for(int i=0 ; i<strs.Length ; i++)
        {
            string s = new string(strs[i].OrderBy(c => c).ToArray());
            if(!d.ContainsKey(s))d.Add(s,new List<int>());
            d[s].Add(i);
        }
        foreach(var item in d)
        {
            List<string> tmp = new List<string>();
            foreach(var g in item.Value)
            {
                tmp.Add(strs[g]);
            }
            res.Add(tmp);
        }
        return res;
    }
}