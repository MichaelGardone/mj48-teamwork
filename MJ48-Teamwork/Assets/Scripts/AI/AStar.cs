using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AStar : MonoBehaviour
{

    // Our heuristic, at this time, is only 0 as nodes only "cost" 1 movement action.

    public Localize grid;

    [Header("Debug")]
    public bool drawPath = false;

    private List<Node> draw = new List<Node>();

    public List<Node> FindPath(Vector3 start, Vector3 end)
    {
        Node startN = grid.NodeFromWorldPoint(start);
        Node endN = grid.NodeFromWorldPoint(end);

        List<Node> open = new List<Node>();
        HashSet<Node> closed = new HashSet<Node>();

        open.Add(startN);

        while(open.Count > 0)
        {
            Node curr = open[open.Count - 1];

            open.Remove(curr);
            closed.Add(curr);

            if(curr == endN)
            {
                return MakePath(startN, endN);
            }

            List<Node> nearby = new List<Node>();
            foreach(Node n in grid.GetNearbyNodes(curr))
            {
                if (n.isSolid || closed.Contains(n))
                    continue;
                if(!open.Contains(n))
                {
                    n.parent = curr;
                    n.gCost = curr.gCost + EuclideanDistance(n, curr);
                    n.hCost = EuclideanDistance(n, curr);
                    nearby.Add(n);
                }
            }

            nearby.Sort((x, y) => Mathf.RoundToInt(y.fCost - x.fCost));
            open = MergeLists(open, nearby);
        }

        return new List<Node>();
    }

    public List<Node> MakePath(Node s, Node e)
    {
        List<Node> path = new List<Node>();
        Node current = e;
        while(current != s)
        {
            path.Add(current);
            current = current.parent;
        }

        path.Reverse();

        // This goes away when compiled.
        if (drawPath)
            draw = new List<Node>(path);

        return path;
    }

    public List<Node> MergeLists(List<Node> l1, List<Node> l2)
    {
        List<Node> res = new List<Node>();

        int i = 0, j = 0;

        while(i < l1.Count || j < l2.Count)
        {
            if(i >= l1.Count)
            {
                res.Add(l2[j]);
                j++;
                continue;
            }
            if (j >= l2.Count)
            {
                res.Add(l2[i]);
                i++;
                continue;
            }

            if(l1[i].fCost > l2[j].fCost)
            {
                res.Add(l1[i]);
                i++;
            }
            else
            {
                res.Add(l1[j]);
                j++;
            }
        }

        return res;
    }

    float EuclideanDistance(Node n1, Node n2)
    {
        return Mathf.Sqrt(n1.xPos - n2.xPos);
    }

    float ManhattanDistance(Node n1, Node n2)
    {
        return Mathf.Abs(n1.xPos - n2.yPos) + Mathf.Abs(n1.yPos - n2.yPos);
    }

    private void OnDrawGizmos()
    {
        if(drawPath)
        {
            Gizmos.color = Color.cyan;
            if(draw.Count > 0)
            {
                foreach(Node n in draw)
                {
                    Gizmos.DrawWireCube(grid.WorldPointFromNode(n), new Vector3(1, 1, 1) * grid.resolution);
                }
            }
        }
    }

}
