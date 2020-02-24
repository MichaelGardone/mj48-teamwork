using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Localize : MonoBehaviour
{

    public Tilemap obstacles;
    public Vector2 gridWorldSize;
    public float resolution;

    public bool showGrid = false;

    Node[,] nodes;

    private int gridX, gridY;
    private float offset;

    // Start is called before the first frame update
    void Awake()
    {
        gridX = Mathf.RoundToInt(gridWorldSize.x / resolution);
        gridY = Mathf.RoundToInt(gridWorldSize.y / resolution);
        offset = resolution / 2;
        BuildGrid();
    }

    void BuildGrid()
    {
        nodes = new Node[gridX, gridY];
        Vector3 start = transform.position - new Vector3(gridWorldSize.x / 2, gridWorldSize.y / 2);
        for(int x = 0; x < gridX; x++)
        {
            for(int y = 0; y < gridY; y++)
            {
                Vector3 checkPos = start + new Vector3(x * resolution + offset, y * resolution + offset, 0);
                bool isSolid = false;
                if (obstacles.HasTile(obstacles.WorldToCell(checkPos)))
                    isSolid = true;
                nodes[x, y] = new Node(isSolid, x, y);
            }
        }
    }

    public List<Node> GetNearbyNodes(Node n)
    {
        List<Node> nearby = new List<Node>();

        int x = n.xPos;
        int y = n.yPos;

        bool left = x != 0;
        bool right = x != gridX - 1;
        bool down = y != 0;
        bool up = y != gridY - 1;

        if (left)
            nearby.Add(nodes[x - 1, y]);
        if (right)
            nearby.Add(nodes[x + 1, y]);
        if (up)
            nearby.Add(nodes[x, y + 1]);
        if (down)
            nearby.Add(nodes[x, y - 1]);

        if (left && down && !nodes[x - 1, y].isSolid && !nodes[x, y - 1].isSolid)
            nearby.Add(nodes[x - 1, y - 1]);

        if (left && up && !nodes[x - 1, y].isSolid && !nodes[x, y + 1].isSolid)
            nearby.Add(nodes[x - 1, y + 1]);

        if (right && down && !nodes[x + 1, y].isSolid && !nodes[x, y - 1].isSolid)
            nearby.Add(nodes[x + 1, y - 1]);

        if (right && up && !nodes[x + 1, y].isSolid && !nodes[x, y + 1].isSolid)
            nearby.Add(nodes[x + 1, y + 1]);

        return nearby;
    }

    public Node NodeFromWorldPoint(Vector3 worldPos)
    {
        Vector3 centered = worldPos - transform.position;
        
        int x = Mathf.RoundToInt(Mathf.Clamp01(centered.x / gridWorldSize.x + 0.5f) * (gridX - 1));
        int y = Mathf.RoundToInt(Mathf.Clamp01(centered.y / gridWorldSize.y + 0.5f) * (gridY - 1));

        return nodes[x, y];
    }

    public Vector3 WorldPointFromNode(Node n)
    {
        Vector3 pos = transform.position;

        pos.x = pos.x - (gridWorldSize.x / 2) + ((n.xPos + 0.5f) * resolution);
        pos.y = pos.y - (gridWorldSize.y / 2) + ((n.yPos + 0.5f) * resolution);

        return pos;
    }

    private void OnDrawGizmos()
    {
        if(showGrid && nodes != null)
        {
            foreach(Node n in nodes)
            {
                if (n.isSolid)
                    Gizmos.color = Color.red;
                else
                    Gizmos.color = Color.green;

                Gizmos.DrawWireCube(WorldPointFromNode(n), new Vector3(1, 1, 1) * resolution);
            }
        }
    }
}
