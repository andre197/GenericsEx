using System;
using System.Collections.Generic;
using System.Linq;

public class Box<T>
    where T : IComparable
{
    private List<T> list;

    public Box()
    {
        this.list = new List<T>();
    }
    

    public void Add(T item)
    {
        this.list.Add(item);
    }

    public T Remove(int index)
    {
        var reminder = this.list[index];
        this.list.RemoveAt(index);

        return reminder;
    }

    public void Swap(int index1, int index2)
    {
        var reminder = this.list[index1];
        this.list[index1] = this.list[index2];
        this.list[index2] = reminder;
    }

    public int CountGreater<T>(T element)
        where T : IComparable
    {
        int cnt = this.list.Count(b=>b.CompareTo(element)>0);
        
        return cnt;
    }

    public bool Contains(T element)
    {
        bool contains = this.list.Contains(element);
        
        return contains;
    }

    public T Min()
    {
        return this.list.Min();
    }

    public T Max()
    {
        return this.list.Max();
    }

    public override string ToString()
    {
        string otBeReturned = string.Join(Environment.NewLine, this.list);

        return otBeReturned;
    }
}

