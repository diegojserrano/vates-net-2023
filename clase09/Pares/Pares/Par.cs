
public class Par<T> where T: IComparable {

    public T C1 { get; set; }
    public T C2 { get; set; }

    public Par(T c1, T c2) {
        C1 = c1;
        C2 = c2;
    }

    public bool Ascendente {
        get {
            return C1.CompareTo(C2) <= 0;
        }
    }

    public override string ToString()
    {
        return $"({C1};{C2})";
    }


}


