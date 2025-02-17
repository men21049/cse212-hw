public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value == Data)
        {
            return;
        }
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        if (value < Data)
        {
            if (Left is null)
                return false;

            return Left.Contains(value);
        }
        else
        {
            if (Right is null)
                return false;

            return Right.Contains(value);
        }

    }

    public int GetHeight()
    {
        int lHeight = 0;
        int rHeight = 0;
        // TODO Start Problem 4
        if (Left is not null)
        {
            lHeight = Left.GetHeight();
        }
        else
        {
            lHeight = 0;
        }

        if (Right is not null)
        {
            rHeight = Right.GetHeight();
        }
        else
        {
            rHeight = 0;
        }

        if (lHeight > rHeight)
        {
            return 1 + lHeight;
        }
        else
        {
            return 1 + rHeight;
        }
    }
}