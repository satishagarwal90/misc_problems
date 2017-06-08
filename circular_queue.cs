class CircularQueue
{
    int rear;
    int front;
    int size;
    int[] arr;

    public CircularQueue(int size)
    {
        this.size = size+1;
        arr = new int[size+1];
        rear = front = 0;
    }

    public void Enqueue(int item)
    {
        if (!QueueIsFull())
        {
            arr[rear] = item;
            rear = (rear + 1) % size;
        }
        else
        {
            Console.WriteLine("QueueFull");
        }
    }

    private bool QueueIsFull()
    {
        return ((rear + 1) % size) == front;
    }

    public int Dequeue()
    {
        int item = -1;
        if (!QueueIsEmpty())
        {
            item = arr[front];
            front = (front + 1) % size;
        }
        else
        {
            Console.WriteLine("QueueEmpty");
        }
        return item;
    }

    private bool QueueIsEmpty()
    {
        return rear == front;
    }
}
