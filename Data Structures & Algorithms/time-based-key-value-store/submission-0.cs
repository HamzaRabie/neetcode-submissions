public class TimeMap {
    Dictionary<string,List<string>>d;
    Dictionary<string,List<int>>stamps;
    public TimeMap() {
        d = new Dictionary<string, List<string>>();
        
        stamps = new Dictionary<string, List<int>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!d.ContainsKey(key)){
            d.Add(key,new List<string>());
            stamps.Add(key , new List<int>());
        }
        d[key].Add(value);
        stamps[key].Add(timestamp);

    }
    
    public string Get(string key, int timestamp) {
        string res="";
        if(!d.ContainsKey(key)) return "";

        int l=0 , r=stamps[key].Count-1;
        
        while(l <= r)
        {
            int mid = l + (r-l+1)/2;
            if (stamps[key][mid] > timestamp) r=mid-1;
            else {
                    res=d[key][mid];
                    l=mid+1;
                }
        }
        return res;
    }
}
