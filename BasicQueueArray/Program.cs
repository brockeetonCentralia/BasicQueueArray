ArrayQueue<int> queue = new ArrayQueue<int>(5);

// Enqueue 3 elements
queue.Enqueue(10); // Queue: 10
queue.Enqueue(20); // Queue: 10, 20
queue.Enqueue(30); // Queue: 10, 20, 30

// Peek at the front element
Console.WriteLine($"Front element is {queue.Peek()}"); // Output: Front element is 10

// Dequeue 2 elements
queue.Dequeue(); // Removes 10, Queue: 20, 30
queue.Dequeue(); // Removes 20, Queue: 30

// Check if queue is empty
Console.WriteLine($"Is queue empty? {queue.IsEmpty()}");

queue.Dequeue();

Console.WriteLine($"Front element is {queue.Peek()}");

Console.WriteLine($"Is queue empty? {queue.IsEmpty()}");

queue.Enqueue(101);
queue.Enqueue(2); 
queue.Enqueue(30);

Console.WriteLine($"Front element is {queue.Peek()}");


class ArrayQueue<T>
{
    private T[] _queue;
    private int _front;
    private int _rear;
    private int _size;

    // Constructor to initialize the queue with a given size
    public ArrayQueue(int size)
    {
        _queue = new T[size];
        _front = 0; // Front of the queue
        _rear = -1; // Rear of the queue (initially empty)
        _size = 0; // Current number of elements
    }

    // Enqueue operation to add an item to the queue
    public void Enqueue(T item)
    {
        if (_size == _queue.Length)
        {
            Console.WriteLine("Queue is full.");
            return;
        }
        _rear = (_rear + 1) % _queue.Length; // Circular increment
        _queue[_rear] = item;
        _size++;
        Console.WriteLine($"Enqueued {item} to the queue.");
    }

    // Dequeue operation to remove an item from the queue
    public T Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty.");
            return default;
        }
        T item = _queue[_front];
        _front = (_front + 1) % _queue.Length; // Circular increment
        _size--;
        Console.WriteLine($"Dequeued {item} from the queue.");
        return item;
    }

    // Peek operation to view the item at the front of the queue
    public T Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty.");
            return default;
        }
        return _queue[_front];
    }

    // Check if the queue is empty
    public bool IsEmpty() => _size == 0;
}
