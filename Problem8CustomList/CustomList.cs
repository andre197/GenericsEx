using System;
using System.Linq;

public class CustomList<T>
    where T : IComparable<T>
{
    private const int initialLenght = 16;

    private T[] data;
    private int length;

    public CustomList()
    {
        this.data = new T[initialLenght];
    }

    public void Add(T item)
    {
        if (this.data.Length == this.length)
        {
            this.data = this.data.Concat(new T[length]).ToArray();
        }

        this.data[this.length] = item;
        this.length++;
    }

    public T Remove(int index)
    {
        if (index < 0 || index >= this.length)
        {
            throw new IndexOutOfRangeException();
        }
        var reminder = this.data[index];
        this.data = this.data.Take(index).Concat(this.data.Skip(index + 1)).ToArray();
        this.length--;
        return reminder;
    }

    public void Swap(int index1, int index2)
    {
        if (index1 < 0 || index2 < 0 || index1 >= this.length || index2 >= this.length)
        {
            throw new IndexOutOfRangeException();
        }

        var reminder = this.data[index1];
        this.data[index1] = this.data[index2];
        this.data[index2] = reminder;
    }

    public int CountGreater(T element)
    {
        int cnt = 0;
        foreach (var d in data.Where(d => d != null))
        {
            if (d.CompareTo(element) > 0)
            {
                cnt++;
            }
        }

        return cnt;
    }

    public bool Contains(T element)
    {
        bool contains = this.data.Contains(element);

        return contains;
    }

    public T Min()
    {
        return this.data.Min();
    }

    public T Max()
    {
        return this.data.Max();
    }

    public override string ToString()
    {
        string otBeReturned = string.Join(Environment.NewLine, this.data.Where(d => d != null));

        return otBeReturned;
    }
}

