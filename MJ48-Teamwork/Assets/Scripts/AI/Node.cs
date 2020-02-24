using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{

    public bool isSolid = false;
    public int xPos, yPos;

    public float gCost, hCost;
    public float fCost { get { return gCost + hCost; } }

    public Node parent;
    
    public Node(bool isSolid, int xPos, int yPos)
    {
        this.isSolid = isSolid;
        this.xPos = xPos;
        this.yPos = yPos;
    }

}
