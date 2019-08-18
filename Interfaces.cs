// Simplified interfaces for sequences.

public interface IEnumerable<T>
{
    IEnumerator<T> GetEnumerator();
}

public interface IEnumerator<T> : IDisposable
{
    bool MoveNext();
    T Current { get; }
    void Reset();
}