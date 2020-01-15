using System;
class Node
{
	public Node left, right;
	public int data;
	public Node(int data)
	{
		this.data = data;
		left = right = null;
	}
}
class Solution
{

	static int getHeight(Node root)
	{

		Node trav = root;

		int leftHeight = 0;
		int rightHeight = 0;

		int highestHeight = 0;



		while (trav.left != null)
		{
			leftHeight++;
			trav = trav.left;
		}

		if (trav.left == null)
		{
			if (highestHeight < leftHeight)
			{
				highestHeight = leftHeight;
			}
			trav = root;
		}

		while (trav.right != null)
		{
			rightHeight++;
			trav = trav.right;
		}

		if (trav.right == null)
		{
			if (highestHeight < rightHeight)
			{
				highestHeight = rightHeight;
			}
			trav = root;
		}


		return highestHeight;
	}

	static Node insert(Node root, int data)
	{
		if (root == null)
		{
			return new Node(data);
		}
		else
		{
			Node cur;
			if (data <= root.data)
			{
				cur = insert(root.left, data);
				root.left = cur;
			}
			else
			{
				cur = insert(root.right, data);
				root.right = cur;
			}
			return root;
		}
	}
	static void Main(String[] args)
	{
		Node root = null;
		int T = Int32.Parse(Console.ReadLine());
		while (T-- > 0)
		{
			int data = Int32.Parse(Console.ReadLine());
			root = insert(root, data);
		}
		int height = getHeight(root);
		Console.WriteLine(height);

	}
}