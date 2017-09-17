
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Box<T> where T : IComparable<T>
{
    private List<T> collection;

    public Box()
    {
        this.collection = new List<T>();
    }

    public void Add(T element)
    {
        this.collection.Add(element);
    }

    public void Remove(int index)
    {
        this.collection.RemoveAt(index);
    }

    public bool Contains(T element)
    {
        return this.collection.Contains(element);
    }

    public void SwapElements(int first, int second)
    {
        var temp = this.collection[first];
        this.collection[first] = this.collection[second];
        this.collection[second] = temp;
    }

    public int CountGreaterEmelements(T element)
    {
        return this.collection.Count(e => e.CompareTo(element) > 0);
    }

    public T Max()
    {
        return this.collection.Max();
    }

    public T Min()
    {
        return this.collection.Min();
    }

    public string Print()
    {
        var result = new StringBuilder();
        for (int k = 0; k < this.collection.Count; k++)
        {
            result.AppendLine(this.collection[k].ToString());
        }
        return result.ToString().Trim();
    }

    public List<T> Sort()
    {
        return new Sorter().Sort(this.collection);
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        for (int j = 0; j < this.collection.Count; j++)
        {
            result.AppendLine($"{this.collection[j].GetType().FullName}: {this.collection[j]}");
        }
        return result.ToString().Trim();
    }
}

