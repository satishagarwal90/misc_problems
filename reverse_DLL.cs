class DLinkedList
{
    int data;
    DLinkedList next;
    DLinkedList prev;

    public DLinkedList Insert(DLinkedList head, int data)
    {
        DLinkedList temp = new DLinkedList();
        temp.data = data;
        if (head == null) return temp;
        temp.next = head;
        head.prev = temp;
        return temp;
    }

    public void Display(DLinkedList head)
    {
        DLinkedList temp = head;
        while(temp != null)
        {
            Console.Write(temp.data);
            temp = temp.next;
        }
        Console.WriteLine();
    }

    public DLinkedList Reverse(DLinkedList head)
    {
        DLinkedList cur = head;
        if (cur.next == null) return cur;
        DLinkedList next;
        DLinkedList prev = null;
        while(cur!= null)
        {                
            next = cur.next;
            Swap(ref cur.prev, ref cur.next);
            prev = cur;
            cur = next;
        }
        return prev;
    }

    private void Swap(ref DLinkedList prev, ref DLinkedList next)
    {
        DLinkedList temp = prev;
        prev = next;
        next = temp;
    }
}
