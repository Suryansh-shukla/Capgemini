
using System;

class Merger
{
    public T[] Merge<T>(T[] a, T[] b) where T:IComparable<T>
    {
        T[] r = new T[a.Length+b.Length];
        int i=0,j=0,k=0;
        while(i<a.Length && j<b.Length)
            r[k++] = a[i].CompareTo(b[j])<=0 ? a[i++] : b[j++];
        while(i<a.Length) r[k++]=a[i++];
        while(j<b.Length) r[k++]=b[j++];
        return r;
    }
}
class Program
{
    static void Main()
    {
        Merger m = new Merger();
        Console.WriteLine(string.Join(",", m.Merge(new int[]{1,3}, new int[]{2,4})));
    }
}
