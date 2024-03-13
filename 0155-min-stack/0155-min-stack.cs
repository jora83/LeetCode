public class MinStack
{
    private List<int> stack;
    public MinStack()
    {
        stack = new List<int>();
    }

    public void Push(int val)
    {
        stack.Add(val);
    }

    public void Pop()
    {
        stack.RemoveAt(stack.Count - 1);
    }

    public int Top()
    {
        return stack.Last();
    }

    public int GetMin()
    {
        return stack.Min();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */