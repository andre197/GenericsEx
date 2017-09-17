
using System;
using System.Collections.Generic;

public class Sorter
{
    public List<T> Sort<T>(List<T> collection)
        where T : IComparable<T>
    {
        collection.Sort((x,y)=>x.CompareTo(y));
        return collection;
    }
}


