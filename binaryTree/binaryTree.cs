namespace Generic;

public class BinaryTree
{
    public Node root;

    public BinaryTree()
    {
        this.root = null;
    }

    public void Inserttree(int data)
    {
        Node newNode = new Node(data);
        if (root == null)
        {
            root = newNode;
            return;
        }

        Node current = root;
        while (true)
        {
            if (data < current.data)
            {
                if (current.left == null)
                {
                    current.left = newNode;
                    return;
                }
                current = current.left;
            }
            else
            {
                if (current.right == null)
                {
                    current.right = newNode;
                    return;
                }
                current = current.right;
            }
        }
    }

    public void InOrderTraversal(Node current)
    {
        if (current == null)
        {
            return;
        }

        InOrderTraversal(current.left);
        Console.Write(current.data + " ");
        InOrderTraversal(current.right);
    }
}