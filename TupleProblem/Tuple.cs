using System;
using System.Collections.Generic;

public class Tuple<T, U>
{
    private Dictionary<T, U> dic;

    public void Create(T firstItem, U secondItem)
    {
        dic.Add(firstItem, secondItem);
    }

    public override string ToString()
    {
        string s = null;
        int cnt = 0;
        foreach (var item in dic)
        {
            s += item.Key + " " + item.Value;
            if (cnt == dic.Count - 2)
            {
                break;
            }
            s += Environment.NewLine;
        }

        return s;
    }
}

