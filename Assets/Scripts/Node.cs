using UnityEngine;

public class Node
{
	//holds a bool w. id walkable, is the position walkable true/false
	public bool walkable;
	//holds a position in world as a vector 3
	public Vector3 worldPosition;

	//sets the x- and y position of the node in the grid
	public int gridX;
	public int gridY;

	//distance from startnode
	public int gCost;
	//distance to targetnode
	public int hCost;
	//sets the node to parent
	public Node parent;
	//set the heapindex
	private int heapIndex;

	/// <summary>
	/// Gets the total value of gcost + hcost
	/// </summary>
	public int fCost
	{
		//returns the valuefor fcost
		get { return gCost + hCost; }
	}

	/// <summary>
	/// Constructor for Node, creates a new node
	/// </summary>
	/// <param name="_walkable"> true/false </param>
	/// <param name="_worldPosition"> of this node </param>
	/// <param name="_gridX"> x value in the world </param>
	/// <param name="_gridY"> y value in the world </param>
	public Node(bool _walkable, Vector3 _worldPosition, int _gridX, int _gridY)
	{
		walkable = _walkable;
		worldPosition = _worldPosition;
		gridX = _gridX;
		gridY = _gridY;
	}
}

