public class CircularBuffer<T>
{

    private T[] bufferArray;
    private int head;
    private int tail;
    private int total = 0;


    public CircularBuffer(int capacity)
    {
        bufferArray = new T[capacity];
    }

    public T Read()
    {
        if (total == 0)
        {
            throw new InvalidOperationException();
        }

        T value = bufferArray[head];
        head = (head + 1) % bufferArray.Length;
        total--;
        return value;
    }

    public void Write(T value)
    {
        if (total == bufferArray.Length)
        {
            throw new InvalidOperationException();
        }

        bufferArray[tail] = value;

        tail = (tail + 1) % bufferArray.Length;
        total++;
    }

    public void Overwrite(T value)
    {
        if (total == bufferArray.Length)
        {
            bufferArray[tail] = value;
            tail = (tail + 1) % bufferArray.Length;
            head = (head + 1) % bufferArray.Length;
        }
        else
        {
            Write(value);
        }
    }

    public void Clear()
    {
        head = 0;
        total = 0;
        tail = 0;
    }
}