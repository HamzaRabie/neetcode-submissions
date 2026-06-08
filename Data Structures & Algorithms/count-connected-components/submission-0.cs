public class Solution {
    public int CountComponents(int n, int[][] edges) {
        Dictionary<int,List<int>> graph = new ();
        for(int i=0 ; i<n ; i++)
        {
            graph.Add(i,new List<int>());
        }

        for(int i=0 ; i<edges.Length ; i++)
        {
            int u = edges[i][0];
            int v =  edges[i][1];

            graph[u].Add(v);
            graph[v].Add(u);
        }

        HashSet<int> vis = new HashSet<int>();
        int res=0;
        for(int i=0 ; i<n ; i++)
        {
            if(!vis.Contains(i)){
                    DFS(i,graph,vis);
                    res++;
                }
        }
        return res;
    }
    void DFS(int node ,Dictionary<int,List<int>> graph ,HashSet<int> vis)
    {
        vis.Add(node);

        foreach(var nei in graph[node])
        {
            if(!vis.Contains(nei))DFS(nei,graph,vis);
        }
    }
}
