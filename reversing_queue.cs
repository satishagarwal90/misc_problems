static void ReverseQueue(Queue<int> q)
{
    Stack<int> s = new Stack<int>(q.Count);
    while(q.Count > 0)
    {
        s.Push(q.Dequeue());
    }
    while(s.Count > 0)
    {
        q.Enqueue(s.Pop());
    }
}

static void ReverseQueueRecursive(Queue<int> q)
{
    if (q.Count == 0) return;
    int temp = q.Dequeue();
    ReverseQueueRecursive(q);
    q.Enqueue(temp);
}
