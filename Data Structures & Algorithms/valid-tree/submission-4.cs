public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if(edges.Length != n - 1)return false;
        Dictionary<int,List<int>> graph = new Dictionary<int, List<int>>();

        for (int i = 0; i < n; i++){graph[i] = new List<int>();}

        for(int i=0 ; i<edges.Length ; i++)
        {
            int u = edges[i][0];
            int v = edges[i][1];

            if(!graph.ContainsKey(u)) graph[u] = new List<int>();
            if(!graph.ContainsKey(v)) graph[v] = new List<int>();

            graph[u].Add(v);
            graph[v].Add(u);

        }
        
        HashSet<int> vis = new HashSet<int>();


        return DFS(0,0,graph,vis) && vis.Count  == n;
    }
    bool DFS(int node , int parent , Dictionary<int,List<int>> graph ,HashSet<int> vis )
    {
        vis.Add(node);

        foreach(var nei in graph[node])
        {
            if (!vis.Contains(nei))
        {
        if (!DFS(nei, node, graph, vis))
            return false;
    }
            else if(nei != parent)return false;
        }
        return true;
    }
}