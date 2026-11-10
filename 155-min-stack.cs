public class MinStack {
    Stack<int> s;
    Stack<int> minStack;

    public MinStack() {
        s = new();
        minStack = new();
    }

    public void Push(int value) {
        s.Push(value);
        if (minStack.Count == 0 || value < minStack.Peek())
            minStack.Push(value);
        else
            minStack.Push(minStack.Peek());
    }

    public void Pop() {
        s.Pop();
        minStack.Pop();
    }

    public int Top() {
        return s.Peek();
    }

    public int GetMin() {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(value);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
