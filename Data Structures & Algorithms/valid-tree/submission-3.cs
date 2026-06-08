public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if(n==1 && edges.Length==0)return true;
        Dictionary<int,List<int>> graph = new Dictionary<int, List<int>>();
        for(int i=0 ; i<edges.Length ; i++)
        {
            int u = edges[i][0];
            int v = edges[i][1];

            if(!graph.ContainsKey(u))
                graph.Add(u,new List<int>());

            if(!graph.ContainsKey(v))
                graph.Add(v,new List<int>());
              
            graph[v].Add(u);
            graph[u].Add(v);
        }

        HashSet<int> vis = new HashSet<int>();

        if(!DFS(0,-1,graph,vis))
            return false;
        
        return vis.Count == n;
        
    }

    bool DFS(int node , int parent , Dictionary<int,List<int>> graph , HashSet<int> vis)
    {
        vis.Add(node);

        foreach(var nei in graph[node])
        {
            if(vis.Contains(nei) && nei != parent)return false;

            if (!vis.Contains(nei))
            {
                DFS(nei , node ,graph , vis);
            }
        }
        return true;

    }
}
